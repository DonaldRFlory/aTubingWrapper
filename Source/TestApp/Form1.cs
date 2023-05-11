using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_STAT = System.UInt32;
using API_DEVICE_HANDLE = System.IntPtr;
using U32 = System.UInt32;
using U16 = System.UInt16;
using U8 = System.Byte;

namespace TestApp
{

    public partial class Form1 : Form
    {
        public const U8 EXT_SERVO_BASE_INDEX = 16;
        public const U8 EXT_SERVO_BASE_BK2_INDEX = 32;
        public const U16 MAX_CONNECTIONS = 10;
        private int StatusMessageTimer;
        string UpgradeStatusStr;
        private bool Started, StartedUp;
        private U32 m_MemAddress;
        private StreamWriter LogFile;
        string LogPath;

        public Form1()
        {
            DateTime localDate = DateTime.Now;
            InitializeComponent();
            m_MemAddress = 0;
            //Delegates = new MD[100];
            InitMenu();
            API.SetBoardAddress((byte)nudBoardAddress.Value);
            LogPath = @".\TestLog" + ".txt";
            try
            {
                LogFile = File.AppendText(LogPath);
            }
            catch
            {
                StringBuilder SB = new StringBuilder();
                SB.AppendFormat("Cannot open log file {0}\r\n", LogPath);
                MessageBox.Show(SB.ToString());
                this.Close();
            }

            LogFile.Write("TestApp Started Up at: {0}\r\n", localDate.ToString());
            LogFile.Flush();
            SetupCallbackFunctions();
            if (!LoadMenu("TestMenu.txt"))
            {
                return;
            }
            CheckMenu();
            DrawMenu("MainMenu");
            InitConnection();
            rbSelectSerial.Checked = true;
            //MenuListBox.Focus();
            if (MenuListBox.Items.Count != 0)
            {
                MenuListBox.SetSelected(0, true);
            }
            tabControl1.SelectedIndex = 1;
            Started = true;
        }

        //So when user wants to open a connection, they open
        //it here. Connection manager makes the connection if possible
        //and returns an index. User may specify an index. For comm
        //ports, this is the connection index. For HID it is the discovery
        //index. They may have called the HIDCount API function to
        //determine how many are available. We will not let them connect
        //to an already open comm port or HID index.
        //Values stored are in order of connection index and only
        //as far as NumConnections.
        //The error detection and restart stuff I put in for single connection
        //over USB no longer makes much sense. Need to detect and show
        //errors in status box but forget the automatic reconnect
        //So how to test it all. Need a way to connect to a particular type
        //and index. Need a disconnect button. Good enough to disconnect the
        //current channel. Need a way to select a channel using numeric up/down
        //control. Maybe a checkbox to indicate the type of connection for current index.
        //Also need a connection box with desired type checkbox, Index, and
        private Connection CMgr;
        public class Connection
        {
            public Connection()
            {
                DevHandles = new API_DEVICE_HANDLE[MAX_CONNECTIONS];
                IsHID = new bool[MAX_CONNECTIONS];
                IsConnected = new bool[MAX_CONNECTIONS];
                ConIndices = new byte[MAX_CONNECTIONS];
                CurIndex = 0;
                _NumConnections = 0;
            }
            private U8 _NumConnections;
            public bool Select(U8 Channel, out bool IsUSB)
            {
                IsUSB = false;
                if ((Channel < MAX_CONNECTIONS) && IsConnected[Channel])
                {
                    IsUSB = IsHID[Channel];
                    CurIndex = Channel;
                    return true;
                }
                return false;
            }
            public U8 NumConnections
            {
                get
                {
                    return _NumConnections;
                }
            }
            private API_DEVICE_HANDLE[] DevHandles;
            private byte[] ConIndices;
            private bool[] IsHID;
            private bool[] IsConnected;
            private U8 CurIndex;

            public API_DEVICE_HANDLE CurHandle()
            {
                if (_NumConnections != 0)
                {
                    return DevHandles[CurIndex];
                }
                else
                {
                    return (System.IntPtr)0;
                }
            }

            public bool Disconnect()
            {
                if ((_NumConnections == 0) || !IsConnected[CurIndex])
                {
                    return false;
                }
                if (APIWrap.Disconnect(DevHandles[CurIndex]))
                {
                    IsConnected[CurIndex] = false;
                    --_NumConnections;
                    return true;
                }
                return false;
            }

            //Returns -1 on failure, positive ChannelID on success
            //New connection becomes selected channel.
            public int Connect(bool HIDFlag, U8 Index)
            {
                if (_NumConnections >= MAX_CONNECTIONS)
                {
                    return -1;
                }
                for (int i = 0; i < _NumConnections; ++i)
                {
                    if (IsConnected[i] && (IsHID[i] == HIDFlag) && (ConIndices[i] == Index))
                    {
                        return -1;
                    }
                }
                //So.. we have room for a new connection and have no
                //connection to the specified target
                for (U8 i = 0; i < MAX_CONNECTIONS; ++i)
                {   //find the first empty slot in connection array
                    if (!IsConnected[i])
                    {
                        if (HIDFlag)
                        {
                            API_DEVICE_HANDLE Handle = (System.IntPtr)0;
                            if (API.HIDConnect(ref Handle, OUR_VID, OUR_PID, Index))
                            {
                                DevHandles[i] = Handle;
                                ++_NumConnections;
                                IsConnected[i] = true;
                                IsHID[i] = true;
                                ConIndices[i] = Index;
                                CurIndex = i;
                                return i;
                            }
                        }
                        else
                        {
                            if (API.SerialConnect(ref DevHandles[i], Index))
                            {
                                ++_NumConnections;
                                IsConnected[i] = true;
                                IsHID[i] = false;
                                ConIndices[i] = Index;
                                CurIndex = i;
                                return i;
                            }
                        }
                        break;
                    }
                }
                return -1;
            }
        }


        //API call wrapper function
        public bool GetVelAcc(U8 Channel, out float Velocity, out float Acceleration)
        {
            Velocity = Acceleration = 0;
            return false;
        }

        //API call wrapper function
        public U16 GetMaxLinkSendSize()
        {
            return (U16)API.GetMaxLinkSendSize(CMgr.CurHandle());
        }

        //API call wrapper function
        public U16 GetMaxLinkReturnSize()
        {
            return (U16)API.GetMaxLinkReturnSize(CMgr.CurHandle());
        }

        private void InitConnection()
        {
            CMgr = new Connection();
        }
        //        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //		public delegate bool UpgradeCB(
        //			[MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)]
        //			U16 []String,
        //			U32 StrLen,
        //			U8 Status,
        //			U32 PBPos,
        //			 U32 PBRange);
        static class API  //These are manually generated DLL exports
        {
            [DllImport(@".\PPBAPI.dll")]
            public static extern void RegisterLoggingCallback(LoggingCB CallbackPointer);
            [DllImport(@".\PPBAPI.dll")]
            public static extern void RegisterLinkStatusCallback(LinkStatusCB CallbackPointer);
            [DllImport(@".\PPBAPI.dll")]
            public static extern bool Disconnect(API_DEVICE_HANDLE Handle);
            [DllImport(@".\PPBAPI.dll")]
            public static extern bool SerialConnect(ref API_DEVICE_HANDLE Handle, int Index);
            [DllImport(@".\PPBAPI.dll")]
            public static extern U8 HIDCount(U16 VID, U16 PID);
            [DllImport(@".\PPBAPI.dll")]
            public static extern bool HIDConnect(ref API_DEVICE_HANDLE Handle, U16 VID, U16 PID, U8 Index);
            [DllImport(@".\PPBAPI.dll")]
            public static extern U32 GetMaxLinkSendSize(API_DEVICE_HANDLE APIHandle);
            [DllImport(@".\PPBAPI.dll")]
            public static extern U32 GetMaxLinkReturnSize(API_DEVICE_HANDLE APIHandle);
            [DllImport(@".\PPBAPI.dll")]
            public static extern void SetBoardAddress(U8 Address);
        }
        static class APIWrap  //These are wrappers for API calls above
        {
            //return true if status is OK
            public static bool StatusOK(API_STAT Status)
            {
                return ((int)(Status & 0XFFFF) == (int)API_RSLT.OK);
            }

            public static bool Disconnect(API_DEVICE_HANDLE Handle)
            {
                return API.Disconnect(Handle);
            }

            //This will connect to the Index'th HID device matching our
            //OUR_VID and OUR_PID, assuming there
            //is room in the DLL's channel info table
            //It will fail if all ten channels are in use.
            public static bool ConnectToUSB(ref API_DEVICE_HANDLE Handle, U8 Index)
            {
                return API.HIDConnect(ref Handle, OUR_VID, OUR_PID, Index);
            }

            public static bool SerialConnect(ref API_DEVICE_HANDLE Handle, U8 Index)
            {
                return API.SerialConnect(ref Handle, Index);
            }
        }

        private void MessageServe()
        {
            if (ConnectStatusOK)
            {
                U16 TraceBuffCount = 0;
                U16 Count, MaxChunk, ChunkSize;
                MaxChunk = (U16)(GetMaxLinkReturnSize() - 1);//account for return value byte
                while (TraceBuffCount != 0)
                {
                    ChunkSize = (TraceBuffCount > MaxChunk) ? MaxChunk : TraceBuffCount;
                    if (ChunkSize == 0)
                    {
                        return;
                    }
                    TraceBuffCount -= ChunkSize;
                    U8[] Buff = new U8[ChunkSize];
                    Count = ReadTraceBuffer(Buff, (U8)ChunkSize);
                    for (U16 i = 0; i < Count; ++i)
                    {
                        if ((Buff[i] < 1) || (Buff[i] >= 127))//check for printable ASCII or control chars except null
                        {//No
                            Buff[i] = 42; //replace with '*'
                        }
                    }
                    string String = System.Text.Encoding.ASCII.GetString(Buff);//make it a string
                    rtbMessageBuff.AppendText(String);
                    if (cbMessBuffAutoScroll.Checked)
                    {
                        rtbMessageBuff.SelectionStart = rtbMessageBuff.Text.Length;
                        rtbMessageBuff.ScrollToCaret();
                    }
                }
            }
        }

        private bool GetInputString(string Prompt, out string Input)
        {
            EntryDialog EDInstance = new EntryDialog(Prompt);
            DialogResult dialogResult = EDInstance.ShowDialog(this);
            Input = EDInstance.Input;
            return (dialogResult == DialogResult.OK);
        }

        private bool ConnectStatusOK;
        //Check status and report in status window, return true/false
        private bool APIStatusOK(API_STAT Status)
        {
            StringBuilder SB = new StringBuilder();
            if ((int)(Status & 0XFFFF) == (int)API_RSLT.OK)
            {
                LabAPI.BackColor = System.Drawing.Color.Green;
                ConnectStatusOK = true;
                TBConnectStatus.Text = "";
                return true;
            }
            else
            {
                LabAPI.BackColor = System.Drawing.Color.Red;
                ConnectStatusOK = false;
                //report the error here TODO:
                SB.AppendFormat(" {0,5}{1,11}{2, 15}", Status >> 24, (Status >> 16) & 0XFF, Status & 0xFF);
                if ((Status & 0XFF) == (int)API_RSLT.COMM_BAD_SEND)
                {

                }
                TBConnectStatus.Text = SB.ToString();
                return false;
            }
        }

        private void MemBlockTest()
        {
            //Encoding enc = new ASCIIEncoding();
            //string S2 = "This is a fairly lengthy string which I want to download to the link buffer on the slave and retrieve in several parts. We want to see some text that we can easily recognize when we read it back up";
            //byte [] Bytes = enc.GetBytes(S2);
            //MasterBlockDown(ref Bytes, (ushort)Bytes.Length, 0X1FFF1000);
            //MasterBlockUp(0X1FFF1020, ref Bytes, (ushort)Bytes.Length);
            //string decodedString = enc.GetString(Bytes);
            //MasterBlockUp(0X1FFF1030, ref Bytes, (ushort)Bytes.Length);
            //decodedString = enc.GetString(Bytes);
        }

        private void UpdateConnectionStatus(bool NewState)
        {

        }

        private void CBUSBConnection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBCycleS0_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Name = tabControl1.TabPages[tabControl1.SelectedIndex].Name;
            if (Name == "tabMenuPage")
            {
                MenuListBox.Focus();
                //MessageBox.Show("Hello");
            }
            else if (Name == "tabMemoryPage")
            {
                DisplayMemPage(m_MemAddress);
            }
        }

        private int TenMsecDivide;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (++TenMsecDivide < 5)
            {
                return;
            }

            //-------------------------Stuff below this point happens every 50 msec--------------------------------
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


            TenMsecDivide = 0;

            if (StatusMessageTimer > 0)
            {
                --StatusMessageTimer;
                if (StatusMessageTimer == 0)
                {
                    ProgBarLabel.Text = "";
                }
            }
            if (Started & !StartedUp)
            {
                StartedUp = true;
                tabControl1.SelectedIndex = 0;
            }

            //tbMilliseconds.Text = GetSlaveParameter(1, 0).ToString();
        }

        private void MenuListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int Index = this.MenuListBox.IndexFromPoint(e.Location);
            if (Index != System.Windows.Forms.ListBox.NoMatches)
            {
                ExecuteMenuSelection();
            }
        }

        private void MenuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void BTestEntry_Click(object sender, EventArgs e)
        {
            string Input;
            GetInputString("Enter a Value:", out Input);
            MessageBox.Show(Input, "The input was:");
        }


        private void MyAcceptButton_Click(object sender, EventArgs e)
        {
            string Name = tabControl1.TabPages[tabControl1.SelectedIndex].Name;
            if (Name == "tabMenuPage")
            {
                ExecuteMenuSelection();
                MenuListBox.Focus();
            }
            else if (Name == "tabMemoryPage")
            {
                UpdateMemPage();
            }
        }

        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Down:
                case Keys.Up:
                case Keys.PageUp:
                case Keys.PageDown:
                    return true;
            }
            return base.IsInputKey(keyData);
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            PopMenu();
            MenuListBox.Focus();
        }

        private void MenuListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char C = e.KeyChar;
            int Index = MenuListBox.SelectedIndex;
            for (int i = 0; i < TheMenu.CurrentPage.Items.Count; ++i)
            {
                if (TheMenu.CurrentPage.Items[i].Activator == C)
                {
                    MenuListBox.SelectedIndex = i;
                    ExecuteMenuSelection();
                    break;
                }
            }
        }

        //public delegate bool UpgradeCB(U8 Status, char []String, U32 StrLen, U32 PBPos, U32 PBRange);
        public bool UGCallbackFunction(U16[] U16Array, U32 StrLen, U8 Status, U32 PBPos, U32 PBRange)
        {
            char[] ChrArray = new char[StrLen];

            for (int i = 0; i < StrLen; ++i)
            {
                ChrArray[i] = (char)U16Array[i];
            }
            progressBar1.Step = 1;
            progressBar1.Show();
            UpgradeStatusStr = new string(ChrArray, 0, (int)StrLen);
            progressBar1.Maximum = (int)PBRange;
            //Note on strange setting of progressBar1.Value below
            //Apparently there is an animation done by Windows Aero
            //theme which produces the delay. The workaround is to
            //set to one more than the position you want then back
            //off to the position you want. The animation only
            //happens for increases in position!
            if (PBPos < PBRange)
            {
                progressBar1.Value = (int)PBPos + 1;
                progressBar1.Value = (int)PBPos;
            }
            else
            {
                progressBar1.Value = (int)PBPos;
            }
            ProgBarLabel.Text = UpgradeStatusStr;
            progressBar1.Refresh();
            ProgBarLabel.Refresh();
            return false;
        }

        private void rbSelectUSB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSelectSerial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            int Channel;
            byte Index;
            API_DEVICE_HANDLE Handle = (System.IntPtr)0;
            try
            {
                Index = (byte)Convert.ToInt32(nudIndex.Value);
                if (rbSelectUSB.Checked)
                {
                    Channel = CMgr.Connect(true, Index);//make a USB connection
                    if (Channel >= 0)
                    {
                        rbUSB.Checked = true;
                        nudCurrentChannel.Value = Channel;
                        return;
                    }
                }
                else
                {
                    Channel = CMgr.Connect(false, Index);//make a serial connection
                    if (Channel >= 0)
                    {
                        rbSerial.Checked = true;
                        nudCurrentChannel.Value = Channel;
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Exception during connect attempt");
                return;
            }
            MessageBox.Show("Connection failed");
        }

        private void rbSerial_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSerial.Checked)
            {
                rbUSB.Checked = false;
            }
        }

        private void rbUSB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUSB.Checked)
            {
                rbSerial.Checked = false;
            }
        }

        private void SelectNewChannel()
        {
            bool IsUSB;
            U8 NewChannel = (U8)Convert.ToInt32(nudCurrentChannel.Value);
            if (CMgr.Select(NewChannel, out IsUSB))
            {
                if (IsUSB)
                {
                    rbSerial.Checked = false;
                    rbUSB.Checked = true;
                }
                else
                {
                    rbSerial.Checked = true;
                    rbUSB.Checked = false;
                }
            }
            else
            {
                rbSerial.Checked = false;
                rbUSB.Checked = false;
            }
        }

        private void nudCurrentChannel_ValueChanged(object sender, EventArgs e)
        {
            SelectNewChannel();
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            if (!CMgr.Disconnect())
            {
                MessageBox.Show("Disconnect failed!!");
                return;
            }
            SelectNewChannel();
        }



        private void bGoPosA0_Click(object sender, EventArgs e)
        {
            //MovePosA(0);
        }

        private void bGoPosB0_Click(object sender, EventArgs e)
        {
            //MovePosB(0);
        }
        private void bReset0_Click(object sender, EventArgs e)
        {
            //ResetServo(0);
        }


        private void bReset1_Click(object sender, EventArgs e)
        {
            //ResetServo(1);
        }

        private void bReset2_Click(object sender, EventArgs e)
        {
            //ResetServo(2);


        }

        private void bReset3_Click(object sender, EventArgs e)
        {
            //ResetServo(3);
        }

        private void bDisableAll_Click(object sender, EventArgs e)
        {

        }

        public void LogToMessageBuffer(string LogString)
        {
            rtbMessageBuff.Invoke(new MethodInvoker(delegate
            {
                rtbMessageBuff.AppendText(LogString);
                if (cbMessBuffAutoScroll.Checked)
                {
                    rtbMessageBuff.SelectionStart = rtbMessageBuff.Text.Length;
                    rtbMessageBuff.ScrollToCaret();
                }
            }));
        }

        private void bMessageBufferClear_Click(object sender, EventArgs e)
        {
            rtbMessageBuff.Clear();
        }


        private void trbServ0_Scroll(object sender, EventArgs e)
        {
            //tbServ0Pos.Text = trbServ0.Value.ToString();
        }


        private void trbServ0_ValueChanged(object sender, EventArgs e)
        {
            //          tbServ0Pos.Text = trbServ0.Value.ToString();
        }



        private void nudTRB0Max_ValueChanged(object sender, EventArgs e)
        {
            //  trbServ0.Maximum = (int)nudTRB0Max.Value;
            //  tbServ0Pos.Text = trbServ0.Value.ToString();
        }

        private void nudTRB0Min_ValueChanged(object sender, EventArgs e)
        {
            //  trbServ0.Minimum = (int)nudTRB0Min.Value;
            //   tbServ0Pos.Text = trbServ0.Value.ToString();
        }


        private void nudBoardAddress_ValueChanged(object sender, EventArgs e)
        {
            API.SetBoardAddress((byte)nudBoardAddress.Value);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetSlaveParameter(30, 0, 0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetSlaveParameter(31, 0, 0);//SegStep()
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            GetSlaveParameter(0, 0);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
