﻿namespace DeviceTester
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentXML = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConnectionType = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblComPortInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCommandExecutionTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenXMLLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenXMLFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateNewDeviceFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHTTPTester = new System.Windows.Forms.ToolStripMenuItem();
            this.miNetworkTools = new System.Windows.Forms.ToolStripMenuItem();
            this.miSSHTester = new System.Windows.Forms.ToolStripMenuItem();
            this.miSuperConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.miPythonConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.miCharMap = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsInstructionsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiSendBytesToDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmiSendToTools = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiSendToBytesGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiSendBytesToConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmiCloneCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiCalculateCheckSum = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tmrRequest = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lnkApplyBCIP = new System.Windows.Forms.LinkLabel();
            this.lnkGetComplement = new System.Windows.Forms.LinkLabel();
            this.lnkDelOneHexByte = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.tlsMain = new System.Windows.Forms.ToolStrip();
            this.tsbLoadDeviceXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.txtCurrentIP = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.txtCurrentPort = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSaveIPPort = new System.Windows.Forms.ToolStripButton();
            this.tsbConnectToIP = new System.Windows.Forms.ToolStripButton();
            this.tsbPing = new System.Windows.Forms.ToolStripButton();
            this.tsbPingPort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCurrentChecksumType = new System.Windows.Forms.ToolStripLabel();
            this.cbCheckSumTypes = new System.Windows.Forms.ToolStripComboBox();
            this.tlsSend = new System.Windows.Forms.ToolStrip();
            this.tsbSendBytesToDevice = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSendViaPython = new System.Windows.Forms.ToolStripButton();
            this.cbPythonSenders = new System.Windows.Forms.ToolStripComboBox();
            this.tsbRunPythonInCommandPrompt = new System.Windows.Forms.ToolStripButton();
            this.tsbGetPythonCommandLineText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSNMPSend = new System.Windows.Forms.ToolStripButton();
            this.tsbSNMPSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tslConnectionType = new System.Windows.Forms.ToolStripLabel();
            this.cbConnectionType = new System.Windows.Forms.ToolStripComboBox();
            this.tsbErrorMessageClear = new System.Windows.Forms.ToolStripButton();
            this.tsbTest = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.tbcDevice = new System.Windows.Forms.TabControl();
            this.tpDeviceCommands = new System.Windows.Forms.TabPage();
            this.dgvInstructions = new System.Windows.Forms.DataGridView();
            this.pnlDeviceInfo = new System.Windows.Forms.Panel();
            this.tlsInstructionsGrid = new System.Windows.Forms.ToolStrip();
            this.tsbSendToTools = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNewRow = new System.Windows.Forms.ToolStripButton();
            this.tsbCloneRow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCalculateCheckSum = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddToTimerList = new System.Windows.Forms.ToolStripButton();
            this.tsbConvertToHex = new System.Windows.Forms.ToolStripButton();
            this.pnlInstructionsBottom = new System.Windows.Forms.Panel();
            this.chkUseCheckSum = new System.Windows.Forms.CheckBox();
            this.chkConditionalReading = new System.Windows.Forms.CheckBox();
            this.chkCommandIsASCII = new System.Windows.Forms.CheckBox();
            this.lblReadBufferSize = new System.Windows.Forms.Label();
            this.lblTCPClientCommunicationTimeOut = new System.Windows.Forms.Label();
            this.lblSendDelayTime = new System.Windows.Forms.Label();
            this.txtReadBufferSize = new System.Windows.Forms.TextBox();
            this.txtTCPClientCommunicationTimeOut = new System.Windows.Forms.TextBox();
            this.txtDelayTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEndByte = new System.Windows.Forms.TextBox();
            this.tpDeviceInfo = new System.Windows.Forms.TabPage();
            this.lblBuildDate = new System.Windows.Forms.Label();
            this.lnkUpdateDeviceInfo = new System.Windows.Forms.LinkLabel();
            this.pnlDeviceInformation = new System.Windows.Forms.Panel();
            this.lblDeviceInformationTitle = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.txtInstructionStructure = new System.Windows.Forms.TextBox();
            this.txtCheckSumType = new System.Windows.Forms.TextBox();
            this.txtDeviceExplanation = new System.Windows.Forms.TextBox();
            this.tpCommandWorkbench = new System.Windows.Forms.TabPage();
            this.txtWorkbench = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtWorkbenchCurrentCommand = new System.Windows.Forms.TextBox();
            this.tlsCommandWorkbenchSend = new System.Windows.Forms.ToolStrip();
            this.tsbSendFromWorkbench = new System.Windows.Forms.ToolStripButton();
            this.tlsCommandWorkbench = new System.Windows.Forms.ToolStrip();
            this.tsbSaveWorkbenchText = new System.Windows.Forms.ToolStripButton();
            this.tsbSendFromWorkbenchToTools = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCalculateWorkbenchChk = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSendToGrid = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tpTimerCommandList = new System.Windows.Forms.TabPage();
            this.dgvTimerInstructions = new System.Windows.Forms.DataGridView();
            this.InstructionBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Explanation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlsTimerCommandList = new System.Windows.Forms.ToolStrip();
            this.tsbRemoveTimerCommand = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveTimerRowUp = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveTimerRowDown = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chronometer1 = new DeviceTester.Chronometer();
            this.sevenSegmentArray2 = new DeviceTester.SevenSegmentArray();
            this.tlsTimerCommandsControl = new System.Windows.Forms.ToolStrip();
            this.tsbStartTimer = new System.Windows.Forms.ToolStripButton();
            this.tsbStopTimer2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtTimerInterval = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSetTimerInterval = new System.Windows.Forms.ToolStripButton();
            this.tsbToogleCounterTimerInterval = new System.Windows.Forms.ToolStripButton();
            this.tpConsole = new System.Windows.Forms.TabPage();
            this.shellControl1 = new DeviceTester.ShellControl();
            this.pnlConsoleBottom = new System.Windows.Forms.Panel();
            this.lnkSelectDOSCommand = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbConsoleIsInASCIIMode = new System.Windows.Forms.RadioButton();
            this.rbConsoleIsInPythonMode = new System.Windows.Forms.RadioButton();
            this.rbConsoleIsInDosMode = new System.Windows.Forms.RadioButton();
            this.rbConsoleIsInDeviceMode = new System.Windows.Forms.RadioButton();
            this.pnlInstructionsTop = new System.Windows.Forms.Panel();
            this.tbcTools = new System.Windows.Forms.TabControl();
            this.tpIncomingBytes = new System.Windows.Forms.TabPage();
            this.chkSaveLog = new System.Windows.Forms.CheckBox();
            this.tbcIncomingBytes = new System.Windows.Forms.TabControl();
            this.tpTextView = new System.Windows.Forms.TabPage();
            this.hexReceivedBytes = new Be.Windows.Forms.HexBox();
            this.ctxHexBoxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCopyHexBoxToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBitsHolder = new System.Windows.Forms.Panel();
            this.bitDisplay1 = new DeviceTester.BitDisplay();
            this.lblByteNo = new System.Windows.Forms.Label();
            this.txtSentCommand = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtReceivedBytesASCII = new System.Windows.Forms.TextBox();
            this.tpGridView = new System.Windows.Forms.TabPage();
            this.dgvIncomingBytes = new System.Windows.Forms.DataGridView();
            this.ByteNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASCII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBits = new System.Windows.Forms.Panel();
            this.bitDisplay2 = new DeviceTester.BitDisplay();
            this.lblBits = new System.Windows.Forms.Label();
            this.tlsIncomingBytes = new System.Windows.Forms.ToolStrip();
            this.tsbClearIncomingBytes = new System.Windows.Forms.ToolStripButton();
            this.tsbChangeMainConsoleStyle = new System.Windows.Forms.ToolStripButton();
            this.tsbClearBeforeSend = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbShowLogs = new System.Windows.Forms.ToolStripButton();
            this.tpTools = new System.Windows.Forms.TabPage();
            this.pnlPythonTools = new System.Windows.Forms.Panel();
            this.btnApplyPythonCode = new System.Windows.Forms.Button();
            this.lbPyFiles = new System.Windows.Forms.ListBox();
            this.lmkEditPythonCode = new System.Windows.Forms.LinkLabel();
            this.lnkReloadPythonFiles = new System.Windows.Forms.LinkLabel();
            this.lnkClearHexBytes = new System.Windows.Forms.LinkLabel();
            this.lnkSendToGrid = new System.Windows.Forms.LinkLabel();
            this.lnkCalculateCRC = new System.Windows.Forms.LinkLabel();
            this.dgvCheckSums = new System.Windows.Forms.DataGridView();
            this.CheckSumType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChecksumValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalculateCRCInHex = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtASCIIBytesInCHKCalculator = new System.Windows.Forms.TextBox();
            this.txtHEXBytesInCHKCalculator = new System.Windows.Forms.TextBox();
            this.txtDecimalBytesInCHKCalculator = new System.Windows.Forms.TextBox();
            this.tpConvertor = new System.Windows.Forms.TabPage();
            this.rbDouble = new System.Windows.Forms.RadioButton();
            this.rbInt32 = new System.Windows.Forms.RadioButton();
            this.rbInt16 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConvertedBytes = new System.Windows.Forms.TextBox();
            this.txtIntNumberToConvert = new System.Windows.Forms.TextBox();
            this.rbCRC16Kermit = new System.Windows.Forms.RadioButton();
            this.rbCRC16 = new System.Windows.Forms.RadioButton();
            this.rbMod95 = new System.Windows.Forms.RadioButton();
            this.rbXOR = new System.Windows.Forms.RadioButton();
            this.lblActiveTCPConnections = new System.Windows.Forms.ListBox();
            this.btnSendToConsole = new System.Windows.Forms.Button();
            this.cbCheckSumTypes2 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tpErrorMessages = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.toolStripErrorMessages = new System.Windows.Forms.ToolStrip();
            this.tsbClearErrorMessages = new System.Windows.Forms.ToolStripButton();
            this.tlsMain2 = new System.Windows.Forms.ToolStrip();
            this.tsbComPortSettings = new System.Windows.Forms.ToolStripButton();
            this.tsbConnectToComPort = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.cmsInstructionsGrid.SuspendLayout();
            this.tlsMain.SuspendLayout();
            this.tlsSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.pnlInstructions.SuspendLayout();
            this.tbcDevice.SuspendLayout();
            this.tpDeviceCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructions)).BeginInit();
            this.pnlDeviceInfo.SuspendLayout();
            this.tlsInstructionsGrid.SuspendLayout();
            this.pnlInstructionsBottom.SuspendLayout();
            this.tpDeviceInfo.SuspendLayout();
            this.pnlDeviceInformation.SuspendLayout();
            this.tpCommandWorkbench.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tlsCommandWorkbenchSend.SuspendLayout();
            this.tlsCommandWorkbench.SuspendLayout();
            this.tpTimerCommandList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimerInstructions)).BeginInit();
            this.tlsTimerCommandList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlsTimerCommandsControl.SuspendLayout();
            this.tpConsole.SuspendLayout();
            this.pnlConsoleBottom.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tbcTools.SuspendLayout();
            this.tpIncomingBytes.SuspendLayout();
            this.tbcIncomingBytes.SuspendLayout();
            this.tpTextView.SuspendLayout();
            this.ctxHexBoxMenu.SuspendLayout();
            this.pnlBitsHolder.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingBytes)).BeginInit();
            this.pnlBits.SuspendLayout();
            this.tlsIncomingBytes.SuspendLayout();
            this.tpTools.SuspendLayout();
            this.pnlPythonTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckSums)).BeginInit();
            this.tpConvertor.SuspendLayout();
            this.tpErrorMessages.SuspendLayout();
            this.toolStripErrorMessages.SuspendLayout();
            this.tlsMain2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblCurrentXML,
            this.lblConnectionType,
            this.lblComPortInfo,
            this.lblCommandExecutionTime});
            this.statusStripMain.Location = new System.Drawing.Point(0, 697);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1084, 22);
            this.statusStripMain.TabIndex = 0;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 17);
            this.lblStatus.Text = "...";
            // 
            // lblCurrentXML
            // 
            this.lblCurrentXML.Name = "lblCurrentXML";
            this.lblCurrentXML.Size = new System.Drawing.Size(74, 17);
            this.lblCurrentXML.Text = "Current XML";
            // 
            // lblConnectionType
            // 
            this.lblConnectionType.Name = "lblConnectionType";
            this.lblConnectionType.Size = new System.Drawing.Size(16, 17);
            this.lblConnectionType.Text = "...";
            // 
            // lblComPortInfo
            // 
            this.lblComPortInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblComPortInfo.Name = "lblComPortInfo";
            this.lblComPortInfo.Size = new System.Drawing.Size(16, 17);
            this.lblComPortInfo.Text = "...";
            // 
            // lblCommandExecutionTime
            // 
            this.lblCommandExecutionTime.Name = "lblCommandExecutionTime";
            this.lblCommandExecutionTime.Size = new System.Drawing.Size(16, 17);
            this.lblCommandExecutionTime.Text = "...";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1084, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenXMLLocation,
            this.btnOpenXMLFile,
            this.btnCreateNewDeviceFile,
            this.toolStripSeparator15,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnOpenXMLLocation
            // 
            this.btnOpenXMLLocation.Name = "btnOpenXMLLocation";
            this.btnOpenXMLLocation.Size = new System.Drawing.Size(222, 22);
            this.btnOpenXMLLocation.Text = "Open Device XMLs Location";
            this.btnOpenXMLLocation.Click += new System.EventHandler(this.btnOpenXMLLocation_Click);
            // 
            // btnOpenXMLFile
            // 
            this.btnOpenXMLFile.Name = "btnOpenXMLFile";
            this.btnOpenXMLFile.Size = new System.Drawing.Size(222, 22);
            this.btnOpenXMLFile.Text = "Open Device XML File";
            this.btnOpenXMLFile.Click += new System.EventHandler(this.btnOpenXMLFile_Click);
            // 
            // btnCreateNewDeviceFile
            // 
            this.btnCreateNewDeviceFile.Name = "btnCreateNewDeviceFile";
            this.btnCreateNewDeviceFile.Size = new System.Drawing.Size(222, 22);
            this.btnCreateNewDeviceFile.Text = "Create New Device XML File";
            this.btnCreateNewDeviceFile.Click += new System.EventHandler(this.btnCreateNewDeviceFile_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(219, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHTTPTester,
            this.miNetworkTools,
            this.miSSHTester,
            this.miSuperConsole,
            this.miPythonConsole,
            this.miCharMap});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // miHTTPTester
            // 
            this.miHTTPTester.Name = "miHTTPTester";
            this.miHTTPTester.Size = new System.Drawing.Size(158, 22);
            this.miHTTPTester.Text = "HTTP Tester";
            this.miHTTPTester.Click += new System.EventHandler(this.miHTTPTester_Click);
            // 
            // miNetworkTools
            // 
            this.miNetworkTools.Name = "miNetworkTools";
            this.miNetworkTools.Size = new System.Drawing.Size(158, 22);
            this.miNetworkTools.Text = "Network Tools";
            this.miNetworkTools.Click += new System.EventHandler(this.miNetworkTools_Click);
            // 
            // miSSHTester
            // 
            this.miSSHTester.Name = "miSSHTester";
            this.miSSHTester.Size = new System.Drawing.Size(158, 22);
            this.miSSHTester.Text = "SSH Tester";
            this.miSSHTester.Click += new System.EventHandler(this.miSSHTester_Click);
            // 
            // miSuperConsole
            // 
            this.miSuperConsole.Name = "miSuperConsole";
            this.miSuperConsole.Size = new System.Drawing.Size(158, 22);
            this.miSuperConsole.Text = "Super Console";
            this.miSuperConsole.Click += new System.EventHandler(this.miSuperConsole_Click);
            // 
            // miPythonConsole
            // 
            this.miPythonConsole.Name = "miPythonConsole";
            this.miPythonConsole.Size = new System.Drawing.Size(158, 22);
            this.miPythonConsole.Text = "Python Console";
            this.miPythonConsole.Click += new System.EventHandler(this.miPythonConsole_Click);
            // 
            // miCharMap
            // 
            this.miCharMap.Name = "miCharMap";
            this.miCharMap.Size = new System.Drawing.Size(158, 22);
            this.miCharMap.Text = "Char Map";
            this.miCharMap.Click += new System.EventHandler(this.MiCharMap_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelp,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(107, 22);
            this.miHelp.Text = "Help";
            this.miHelp.Click += new System.EventHandler(this.miHelp_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // cmsInstructionsGrid
            // 
            this.cmsInstructionsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiSendBytesToDevice,
            this.toolStripSeparator2,
            this.cmiSendToTools,
            this.cmiSendToBytesGrid,
            this.cmiSendBytesToConsole,
            this.toolStripSeparator3,
            this.cmiCloneCurrentRow,
            this.cmiCalculateCheckSum});
            this.cmsInstructionsGrid.Name = "contextMenuStrip1";
            this.cmsInstructionsGrid.Size = new System.Drawing.Size(194, 148);
            // 
            // cmiSendBytesToDevice
            // 
            this.cmiSendBytesToDevice.Name = "cmiSendBytesToDevice";
            this.cmiSendBytesToDevice.Size = new System.Drawing.Size(193, 22);
            this.cmiSendBytesToDevice.Text = "Send Bytes To Device";
            this.cmiSendBytesToDevice.Click += new System.EventHandler(this.cmiSendBytesToDevice_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // cmiSendToTools
            // 
            this.cmiSendToTools.Name = "cmiSendToTools";
            this.cmiSendToTools.Size = new System.Drawing.Size(193, 22);
            this.cmiSendToTools.Text = "Send To Tools";
            this.cmiSendToTools.Click += new System.EventHandler(this.cmiSendToTools_Click);
            // 
            // cmiSendToBytesGrid
            // 
            this.cmiSendToBytesGrid.Name = "cmiSendToBytesGrid";
            this.cmiSendToBytesGrid.Size = new System.Drawing.Size(193, 22);
            this.cmiSendToBytesGrid.Text = "Send To Bytes Grid";
            this.cmiSendToBytesGrid.Click += new System.EventHandler(this.cmiSendToBytesGrid_Click);
            // 
            // cmiSendBytesToConsole
            // 
            this.cmiSendBytesToConsole.Name = "cmiSendBytesToConsole";
            this.cmiSendBytesToConsole.Size = new System.Drawing.Size(193, 22);
            this.cmiSendBytesToConsole.Text = "Send Bytes To Console";
            this.cmiSendBytesToConsole.Click += new System.EventHandler(this.cmiSendBytesToConsole_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(190, 6);
            // 
            // cmiCloneCurrentRow
            // 
            this.cmiCloneCurrentRow.Name = "cmiCloneCurrentRow";
            this.cmiCloneCurrentRow.Size = new System.Drawing.Size(193, 22);
            this.cmiCloneCurrentRow.Text = "Clone Current Row";
            this.cmiCloneCurrentRow.Click += new System.EventHandler(this.cmiCloneCurrentRow_Click);
            // 
            // cmiCalculateCheckSum
            // 
            this.cmiCalculateCheckSum.Name = "cmiCalculateCheckSum";
            this.cmiCalculateCheckSum.Size = new System.Drawing.Size(193, 22);
            this.cmiCalculateCheckSum.Text = "Calculate Check Sum";
            this.cmiCalculateCheckSum.Click += new System.EventHandler(this.cmiCalculateCheckSum_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tmrRequest
            // 
            this.tmrRequest.Interval = 600000;
            this.tmrRequest.Tick += new System.EventHandler(this.tmrRequest_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cmd_icon.jpg");
            this.imageList1.Images.SetKeyName(1, "green_light.png");
            this.imageList1.Images.SetKeyName(2, "red_light.png");
            this.imageList1.Images.SetKeyName(3, "grey_dot.png");
            // 
            // tmrCounter
            // 
            this.tmrCounter.Interval = 1000;
            this.tmrCounter.Tick += new System.EventHandler(this.tmrCounter_Tick);
            // 
            // lnkApplyBCIP
            // 
            this.lnkApplyBCIP.AutoSize = true;
            this.lnkApplyBCIP.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkApplyBCIP.Location = new System.Drawing.Point(417, 412);
            this.lnkApplyBCIP.Name = "lnkApplyBCIP";
            this.lnkApplyBCIP.Size = new System.Drawing.Size(60, 13);
            this.lnkApplyBCIP.TabIndex = 53;
            this.lnkApplyBCIP.TabStop = true;
            this.lnkApplyBCIP.Text = "Apply BCIP";
            this.toolTip1.SetToolTip(this.lnkApplyBCIP, "1- Converts 10 to 10 EF, 02 to 10 FD, 03 to 10 FC.\r\nThose are special characters " +
        "in BCIP protocol. \r\n2- Adds XOR check sum.\r\n3- Wraps array with 02 and 03.");
            this.lnkApplyBCIP.Visible = false;
            this.lnkApplyBCIP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkApplyBCIP_LinkClicked);
            // 
            // lnkGetComplement
            // 
            this.lnkGetComplement.AutoSize = true;
            this.lnkGetComplement.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkGetComplement.Location = new System.Drawing.Point(417, 395);
            this.lnkGetComplement.Name = "lnkGetComplement";
            this.lnkGetComplement.Size = new System.Drawing.Size(91, 13);
            this.lnkGetComplement.TabIndex = 53;
            this.lnkGetComplement.TabStop = true;
            this.lnkGetComplement.Text = "Complement of All";
            this.toolTip1.SetToolTip(this.lnkGetComplement, "It subtracts all bytes from FF.");
            this.lnkGetComplement.Visible = false;
            this.lnkGetComplement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGetComplement_LinkClicked);
            // 
            // lnkDelOneHexByte
            // 
            this.lnkDelOneHexByte.AutoSize = true;
            this.lnkDelOneHexByte.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkDelOneHexByte.Location = new System.Drawing.Point(406, 98);
            this.lnkDelOneHexByte.Name = "lnkDelOneHexByte";
            this.lnkDelOneHexByte.Size = new System.Drawing.Size(62, 13);
            this.lnkDelOneHexByte.TabIndex = 53;
            this.lnkDelOneHexByte.TabStop = true;
            this.lnkDelOneHexByte.Text = "Delete Byte";
            this.toolTip1.SetToolTip(this.lnkDelOneHexByte, "Deletes the last byte in the byte array.");
            this.lnkDelOneHexByte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelOneHexByte_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(57, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "HEX Value (Little Endianness)";
            this.toolTip1.SetToolTip(this.label11, "Some Notes:\r\n1- x86 CPU uses little endianness.\r\n2- Here, Int32 is used. (We can " +
        "make it optional later)\r\n3- So, 4 bytes are used in the form of 00 00 00 00.");
            // 
            // tlsMain
            // 
            this.tlsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadDeviceXML,
            this.toolStripSeparator4,
            this.toolStripLabel4,
            this.txtCurrentIP,
            this.toolStripLabel5,
            this.txtCurrentPort,
            this.tsbSaveIPPort,
            this.tsbConnectToIP,
            this.tsbPing,
            this.tsbPingPort,
            this.toolStripSeparator5,
            this.lblCurrentChecksumType,
            this.cbCheckSumTypes});
            this.tlsMain.Location = new System.Drawing.Point(0, 24);
            this.tlsMain.Name = "tlsMain";
            this.tlsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tlsMain.Size = new System.Drawing.Size(1084, 25);
            this.tlsMain.TabIndex = 7;
            this.tlsMain.Text = "toolStripIPPort";
            // 
            // tsbLoadDeviceXML
            // 
            this.tsbLoadDeviceXML.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadDeviceXML.Image")));
            this.tsbLoadDeviceXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadDeviceXML.Name = "tsbLoadDeviceXML";
            this.tsbLoadDeviceXML.Size = new System.Drawing.Size(112, 22);
            this.tsbLoadDeviceXML.Text = "Load Device File";
            this.tsbLoadDeviceXML.Click += new System.EventHandler(this.tsbLoadDeviceXML_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(17, 22);
            this.toolStripLabel4.Text = "IP";
            // 
            // txtCurrentIP
            // 
            this.txtCurrentIP.Name = "txtCurrentIP";
            this.txtCurrentIP.Size = new System.Drawing.Size(90, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel5.Text = "Port";
            // 
            // txtCurrentPort
            // 
            this.txtCurrentPort.Name = "txtCurrentPort";
            this.txtCurrentPort.Size = new System.Drawing.Size(40, 25);
            // 
            // tsbSaveIPPort
            // 
            this.tsbSaveIPPort.Image = global::DeviceTester.Properties.Resources.save;
            this.tsbSaveIPPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveIPPort.Name = "tsbSaveIPPort";
            this.tsbSaveIPPort.Size = new System.Drawing.Size(51, 22);
            this.tsbSaveIPPort.Text = "Save";
            this.tsbSaveIPPort.Click += new System.EventHandler(this.tsbSaveIPPort_Click);
            // 
            // tsbConnectToIP
            // 
            this.tsbConnectToIP.Image = global::DeviceTester.Properties.Resources.red_light;
            this.tsbConnectToIP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnectToIP.Name = "tsbConnectToIP";
            this.tsbConnectToIP.Size = new System.Drawing.Size(72, 22);
            this.tsbConnectToIP.Text = "Connect";
            this.tsbConnectToIP.Click += new System.EventHandler(this.tsbConnectToIP_Click);
            // 
            // tsbPing
            // 
            this.tsbPing.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPing.Image = ((System.Drawing.Image)(resources.GetObject("tsbPing.Image")));
            this.tsbPing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPing.Name = "tsbPing";
            this.tsbPing.Size = new System.Drawing.Size(35, 22);
            this.tsbPing.Text = "Ping";
            this.tsbPing.Click += new System.EventHandler(this.tsbPing_Click);
            // 
            // tsbPingPort
            // 
            this.tsbPingPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPingPort.Image = ((System.Drawing.Image)(resources.GetObject("tsbPingPort.Image")));
            this.tsbPingPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPingPort.Name = "tsbPingPort";
            this.tsbPingPort.Size = new System.Drawing.Size(60, 22);
            this.tsbPingPort.Text = "Ping Port";
            this.tsbPingPort.Click += new System.EventHandler(this.tsbPingPort_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // lblCurrentChecksumType
            // 
            this.lblCurrentChecksumType.Name = "lblCurrentChecksumType";
            this.lblCurrentChecksumType.Size = new System.Drawing.Size(134, 22);
            this.lblCurrentChecksumType.Text = "Current Checksum Type";
            // 
            // cbCheckSumTypes
            // 
            this.cbCheckSumTypes.Items.AddRange(new object[] {
            "SUM",
            "XOR",
            "MOD95",
            "CRC16",
            "CRC16Kermit",
            "CRC16XModem",
            "CRC32",
            "MODBUS"});
            this.cbCheckSumTypes.Name = "cbCheckSumTypes";
            this.cbCheckSumTypes.Size = new System.Drawing.Size(80, 25);
            // 
            // tlsSend
            // 
            this.tlsSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsSend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSendBytesToDevice,
            this.toolStripSeparator13,
            this.tsbSendViaPython,
            this.cbPythonSenders,
            this.tsbRunPythonInCommandPrompt,
            this.tsbGetPythonCommandLineText,
            this.toolStripSeparator6,
            this.btnSNMPSend,
            this.tsbSNMPSet,
            this.toolStripSeparator12,
            this.tslConnectionType,
            this.cbConnectionType,
            this.tsbErrorMessageClear,
            this.tsbTest});
            this.tlsSend.Location = new System.Drawing.Point(0, 659);
            this.tlsSend.Name = "tlsSend";
            this.tlsSend.Size = new System.Drawing.Size(1084, 38);
            this.tlsSend.TabIndex = 4;
            this.tlsSend.Text = "toolStrip2";
            // 
            // tsbSendBytesToDevice
            // 
            this.tsbSendBytesToDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbSendBytesToDevice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsbSendBytesToDevice.Image = global::DeviceTester.Properties.Resources.rightArrow;
            this.tsbSendBytesToDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendBytesToDevice.Name = "tsbSendBytesToDevice";
            this.tsbSendBytesToDevice.Size = new System.Drawing.Size(99, 35);
            this.tsbSendBytesToDevice.Text = "SEND TO DEVICE";
            this.tsbSendBytesToDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSendBytesToDevice.ToolTipText = "Send selected packet to target";
            this.tsbSendBytesToDevice.Click += new System.EventHandler(this.tsbSendBytesToDevice_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbSendViaPython
            // 
            this.tsbSendViaPython.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbSendViaPython.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsbSendViaPython.Image = global::DeviceTester.Properties.Resources.python_icon;
            this.tsbSendViaPython.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendViaPython.Name = "tsbSendViaPython";
            this.tsbSendViaPython.Size = new System.Drawing.Size(109, 35);
            this.tsbSendViaPython.Text = "SEND VIA PYTHON";
            this.tsbSendViaPython.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSendViaPython.ToolTipText = "Send selected packet to target";
            this.tsbSendViaPython.Click += new System.EventHandler(this.tsbSendViaPython_Click);
            // 
            // cbPythonSenders
            // 
            this.cbPythonSenders.Items.AddRange(new object[] {
            "python_socket.py",
            "python_visa.py",
            "python_serial.py",
            "python_snmp.py"});
            this.cbPythonSenders.Name = "cbPythonSenders";
            this.cbPythonSenders.Size = new System.Drawing.Size(121, 38);
            this.cbPythonSenders.Text = "python_socket.py";
            this.cbPythonSenders.SelectedIndexChanged += new System.EventHandler(this.cbPythonSenders_SelectedIndexChanged);
            // 
            // tsbRunPythonInCommandPrompt
            // 
            this.tsbRunPythonInCommandPrompt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRunPythonInCommandPrompt.Image = ((System.Drawing.Image)(resources.GetObject("tsbRunPythonInCommandPrompt.Image")));
            this.tsbRunPythonInCommandPrompt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRunPythonInCommandPrompt.Name = "tsbRunPythonInCommandPrompt";
            this.tsbRunPythonInCommandPrompt.Size = new System.Drawing.Size(23, 35);
            this.tsbRunPythonInCommandPrompt.Text = "Run Python In Command Prompt";
            this.tsbRunPythonInCommandPrompt.ToolTipText = "Run python in command prompt";
            this.tsbRunPythonInCommandPrompt.Click += new System.EventHandler(this.TsbRunPythonInCommandPrompt_Click);
            // 
            // tsbGetPythonCommandLineText
            // 
            this.tsbGetPythonCommandLineText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGetPythonCommandLineText.Image = ((System.Drawing.Image)(resources.GetObject("tsbGetPythonCommandLineText.Image")));
            this.tsbGetPythonCommandLineText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGetPythonCommandLineText.Name = "tsbGetPythonCommandLineText";
            this.tsbGetPythonCommandLineText.Size = new System.Drawing.Size(23, 35);
            this.tsbGetPythonCommandLineText.Text = "Copy Command To Clipboard";
            this.tsbGetPythonCommandLineText.Click += new System.EventHandler(this.TsbGetPythonCommandLineText_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
            // 
            // btnSNMPSend
            // 
            this.btnSNMPSend.Image = global::DeviceTester.Properties.Resources.snmp_icon;
            this.btnSNMPSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSNMPSend.Name = "btnSNMPSend";
            this.btnSNMPSend.Size = new System.Drawing.Size(65, 35);
            this.btnSNMPSend.Text = "SNMP Get";
            this.btnSNMPSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSNMPSend.Click += new System.EventHandler(this.btnSNMPSend_Click);
            // 
            // tsbSNMPSet
            // 
            this.tsbSNMPSet.Image = ((System.Drawing.Image)(resources.GetObject("tsbSNMPSet.Image")));
            this.tsbSNMPSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSNMPSet.Name = "tsbSNMPSet";
            this.tsbSNMPSet.Size = new System.Drawing.Size(63, 35);
            this.tsbSNMPSet.Text = "SNMP Set";
            this.tsbSNMPSet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSNMPSet.Click += new System.EventHandler(this.tsbSNMPSet_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 38);
            // 
            // tslConnectionType
            // 
            this.tslConnectionType.Name = "tslConnectionType";
            this.tslConnectionType.Size = new System.Drawing.Size(97, 35);
            this.tslConnectionType.Text = "Connection Type";
            // 
            // cbConnectionType
            // 
            this.cbConnectionType.Items.AddRange(new object[] {
            "TCPIPStandard",
            "TCPIPConnected",
            "UDP",
            "ComPort"});
            this.cbConnectionType.Name = "cbConnectionType";
            this.cbConnectionType.Size = new System.Drawing.Size(100, 38);
            this.cbConnectionType.SelectedIndexChanged += new System.EventHandler(this.cbConnectionType_SelectedIndexChanged);
            // 
            // tsbErrorMessageClear
            // 
            this.tsbErrorMessageClear.Image = global::DeviceTester.Properties.Resources.grey_dot;
            this.tsbErrorMessageClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbErrorMessageClear.Name = "tsbErrorMessageClear";
            this.tsbErrorMessageClear.Size = new System.Drawing.Size(101, 35);
            this.tsbErrorMessageClear.Text = "Error Message";
            this.tsbErrorMessageClear.Click += new System.EventHandler(this.tsbErrorMessageClear_Click);
            // 
            // tsbTest
            // 
            this.tsbTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTest.Image = ((System.Drawing.Image)(resources.GetObject("tsbTest.Image")));
            this.tsbTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTest.Name = "tsbTest";
            this.tsbTest.Size = new System.Drawing.Size(32, 35);
            this.tsbTest.Text = "Test";
            this.tsbTest.Click += new System.EventHandler(this.tsbTest_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 49);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.pnlInstructions);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tbcTools);
            this.splitContainerMain.Panel2.Controls.Add(this.tlsMain2);
            this.splitContainerMain.Size = new System.Drawing.Size(1084, 610);
            this.splitContainerMain.SplitterDistance = 499;
            this.splitContainerMain.TabIndex = 2;
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.Controls.Add(this.tbcDevice);
            this.pnlInstructions.Controls.Add(this.pnlInstructionsTop);
            this.pnlInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInstructions.Location = new System.Drawing.Point(0, 0);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(499, 610);
            this.pnlInstructions.TabIndex = 2;
            // 
            // tbcDevice
            // 
            this.tbcDevice.Controls.Add(this.tpDeviceCommands);
            this.tbcDevice.Controls.Add(this.tpDeviceInfo);
            this.tbcDevice.Controls.Add(this.tpCommandWorkbench);
            this.tbcDevice.Controls.Add(this.tpTimerCommandList);
            this.tbcDevice.Controls.Add(this.tpConsole);
            this.tbcDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcDevice.HotTrack = true;
            this.tbcDevice.ItemSize = new System.Drawing.Size(101, 25);
            this.tbcDevice.Location = new System.Drawing.Point(0, 5);
            this.tbcDevice.Name = "tbcDevice";
            this.tbcDevice.SelectedIndex = 0;
            this.tbcDevice.Size = new System.Drawing.Size(499, 605);
            this.tbcDevice.TabIndex = 0;
            // 
            // tpDeviceCommands
            // 
            this.tpDeviceCommands.Controls.Add(this.dgvInstructions);
            this.tpDeviceCommands.Controls.Add(this.pnlDeviceInfo);
            this.tpDeviceCommands.Controls.Add(this.pnlInstructionsBottom);
            this.tpDeviceCommands.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDeviceCommands.Location = new System.Drawing.Point(4, 29);
            this.tpDeviceCommands.Name = "tpDeviceCommands";
            this.tpDeviceCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeviceCommands.Size = new System.Drawing.Size(491, 572);
            this.tpDeviceCommands.TabIndex = 0;
            this.tpDeviceCommands.Text = "Device Commands";
            this.tpDeviceCommands.UseVisualStyleBackColor = true;
            // 
            // dgvInstructions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvInstructions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInstructions.BackgroundColor = System.Drawing.Color.White;
            this.dgvInstructions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInstructions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInstructions.ColumnHeadersHeight = 30;
            this.dgvInstructions.ContextMenuStrip = this.cmsInstructionsGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInstructions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInstructions.Location = new System.Drawing.Point(3, 32);
            this.dgvInstructions.Name = "dgvInstructions";
            this.dgvInstructions.RowHeadersVisible = false;
            this.dgvInstructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInstructions.Size = new System.Drawing.Size(485, 462);
            this.dgvInstructions.TabIndex = 3;
            this.dgvInstructions.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInstructions_CellBeginEdit);
            this.dgvInstructions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstructions_CellEndEdit);
            this.dgvInstructions.SelectionChanged += new System.EventHandler(this.dgvInstructions_SelectionChanged);
            // 
            // pnlDeviceInfo
            // 
            this.pnlDeviceInfo.Controls.Add(this.tlsInstructionsGrid);
            this.pnlDeviceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeviceInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlDeviceInfo.Name = "pnlDeviceInfo";
            this.pnlDeviceInfo.Size = new System.Drawing.Size(485, 29);
            this.pnlDeviceInfo.TabIndex = 5;
            // 
            // tlsInstructionsGrid
            // 
            this.tlsInstructionsGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsInstructionsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSendToTools,
            this.toolStripSeparator8,
            this.tsbNewRow,
            this.tsbCloneRow,
            this.toolStripSeparator1,
            this.tsbCalculateCheckSum,
            this.toolStripSeparator11,
            this.tsbAddToTimerList,
            this.tsbConvertToHex});
            this.tlsInstructionsGrid.Location = new System.Drawing.Point(0, 4);
            this.tlsInstructionsGrid.Name = "tlsInstructionsGrid";
            this.tlsInstructionsGrid.Size = new System.Drawing.Size(485, 25);
            this.tlsInstructionsGrid.TabIndex = 15;
            this.tlsInstructionsGrid.Text = "toolStrip3";
            // 
            // tsbSendToTools
            // 
            this.tsbSendToTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSendToTools.Image = ((System.Drawing.Image)(resources.GetObject("tsbSendToTools.Image")));
            this.tsbSendToTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendToTools.Name = "tsbSendToTools";
            this.tsbSendToTools.Size = new System.Drawing.Size(84, 22);
            this.tsbSendToTools.Text = "Send To Tools";
            this.tsbSendToTools.ToolTipText = "Sends current row to Tools section to edit them";
            this.tsbSendToTools.Click += new System.EventHandler(this.tsbSendToTools_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbNewRow
            // 
            this.tsbNewRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewRow.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewRow.Image")));
            this.tsbNewRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewRow.Name = "tsbNewRow";
            this.tsbNewRow.Size = new System.Drawing.Size(86, 22);
            this.tsbNewRow.Text = "Add New Row";
            this.tsbNewRow.Click += new System.EventHandler(this.tsbNewRow_Click);
            // 
            // tsbCloneRow
            // 
            this.tsbCloneRow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCloneRow.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloneRow.Image")));
            this.tsbCloneRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloneRow.Name = "tsbCloneRow";
            this.tsbCloneRow.Size = new System.Drawing.Size(68, 22);
            this.tsbCloneRow.Text = "Clone Row";
            this.tsbCloneRow.ToolTipText = "Generates a new row identical to current one";
            this.tsbCloneRow.Click += new System.EventHandler(this.tsbCloneRow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCalculateCheckSum
            // 
            this.tsbCalculateCheckSum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCalculateCheckSum.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalculateCheckSum.Image")));
            this.tsbCalculateCheckSum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalculateCheckSum.Name = "tsbCalculateCheckSum";
            this.tsbCalculateCheckSum.Size = new System.Drawing.Size(74, 22);
            this.tsbCalculateCheckSum.Text = "Check  Sum";
            this.tsbCalculateCheckSum.ToolTipText = "Calculate Check  Sum";
            this.tsbCalculateCheckSum.Click += new System.EventHandler(this.tsbCalculateCheckSum_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAddToTimerList
            // 
            this.tsbAddToTimerList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddToTimerList.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddToTimerList.Image")));
            this.tsbAddToTimerList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddToTimerList.Name = "tsbAddToTimerList";
            this.tsbAddToTimerList.Size = new System.Drawing.Size(58, 22);
            this.tsbAddToTimerList.Text = "To Timer";
            this.tsbAddToTimerList.Click += new System.EventHandler(this.tsbAddToTimerList_Click);
            // 
            // tsbConvertToHex
            // 
            this.tsbConvertToHex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbConvertToHex.Image = ((System.Drawing.Image)(resources.GetObject("tsbConvertToHex.Image")));
            this.tsbConvertToHex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConvertToHex.Name = "tsbConvertToHex";
            this.tsbConvertToHex.Size = new System.Drawing.Size(92, 19);
            this.tsbConvertToHex.Text = "Convert To Hex";
            this.tsbConvertToHex.Click += new System.EventHandler(this.tsbConvertToHex_Click);
            // 
            // pnlInstructionsBottom
            // 
            this.pnlInstructionsBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInstructionsBottom.Controls.Add(this.chkUseCheckSum);
            this.pnlInstructionsBottom.Controls.Add(this.chkConditionalReading);
            this.pnlInstructionsBottom.Controls.Add(this.chkCommandIsASCII);
            this.pnlInstructionsBottom.Controls.Add(this.lblReadBufferSize);
            this.pnlInstructionsBottom.Controls.Add(this.lblTCPClientCommunicationTimeOut);
            this.pnlInstructionsBottom.Controls.Add(this.lblSendDelayTime);
            this.pnlInstructionsBottom.Controls.Add(this.txtReadBufferSize);
            this.pnlInstructionsBottom.Controls.Add(this.txtTCPClientCommunicationTimeOut);
            this.pnlInstructionsBottom.Controls.Add(this.txtDelayTime);
            this.pnlInstructionsBottom.Controls.Add(this.label9);
            this.pnlInstructionsBottom.Controls.Add(this.txtEndByte);
            this.pnlInstructionsBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInstructionsBottom.Location = new System.Drawing.Point(3, 494);
            this.pnlInstructionsBottom.Name = "pnlInstructionsBottom";
            this.pnlInstructionsBottom.Size = new System.Drawing.Size(485, 75);
            this.pnlInstructionsBottom.TabIndex = 6;
            // 
            // chkUseCheckSum
            // 
            this.chkUseCheckSum.AutoSize = true;
            this.chkUseCheckSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkUseCheckSum.Location = new System.Drawing.Point(384, 13);
            this.chkUseCheckSum.Name = "chkUseCheckSum";
            this.chkUseCheckSum.Size = new System.Drawing.Size(99, 17);
            this.chkUseCheckSum.TabIndex = 2;
            this.chkUseCheckSum.Text = "Add checkSum";
            this.chkUseCheckSum.UseVisualStyleBackColor = true;
            this.chkUseCheckSum.Visible = false;
            // 
            // chkConditionalReading
            // 
            this.chkConditionalReading.AutoSize = true;
            this.chkConditionalReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConditionalReading.ForeColor = System.Drawing.Color.Black;
            this.chkConditionalReading.Location = new System.Drawing.Point(252, 33);
            this.chkConditionalReading.Name = "chkConditionalReading";
            this.chkConditionalReading.Size = new System.Drawing.Size(121, 17);
            this.chkConditionalReading.TabIndex = 33;
            this.chkConditionalReading.Text = "Conditional Reading";
            this.chkConditionalReading.UseVisualStyleBackColor = true;
            // 
            // chkCommandIsASCII
            // 
            this.chkCommandIsASCII.AutoSize = true;
            this.chkCommandIsASCII.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkCommandIsASCII.ForeColor = System.Drawing.Color.Black;
            this.chkCommandIsASCII.Location = new System.Drawing.Point(252, 13);
            this.chkCommandIsASCII.Name = "chkCommandIsASCII";
            this.chkCommandIsASCII.Size = new System.Drawing.Size(113, 17);
            this.chkCommandIsASCII.TabIndex = 33;
            this.chkCommandIsASCII.Text = "Command is ASCII";
            this.chkCommandIsASCII.UseVisualStyleBackColor = true;
            // 
            // lblReadBufferSize
            // 
            this.lblReadBufferSize.AutoSize = true;
            this.lblReadBufferSize.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReadBufferSize.Location = new System.Drawing.Point(18, 48);
            this.lblReadBufferSize.Name = "lblReadBufferSize";
            this.lblReadBufferSize.Size = new System.Drawing.Size(74, 11);
            this.lblReadBufferSize.TabIndex = 32;
            this.lblReadBufferSize.Text = "Read Buffer Size";
            // 
            // lblTCPClientCommunicationTimeOut
            // 
            this.lblTCPClientCommunicationTimeOut.AutoSize = true;
            this.lblTCPClientCommunicationTimeOut.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCPClientCommunicationTimeOut.Location = new System.Drawing.Point(18, 32);
            this.lblTCPClientCommunicationTimeOut.Name = "lblTCPClientCommunicationTimeOut";
            this.lblTCPClientCommunicationTimeOut.Size = new System.Drawing.Size(149, 11);
            this.lblTCPClientCommunicationTimeOut.TabIndex = 32;
            this.lblTCPClientCommunicationTimeOut.Text = "TCPClientCommunicationTimeOut";
            // 
            // lblSendDelayTime
            // 
            this.lblSendDelayTime.AutoSize = true;
            this.lblSendDelayTime.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSendDelayTime.Location = new System.Drawing.Point(18, 16);
            this.lblSendDelayTime.Name = "lblSendDelayTime";
            this.lblSendDelayTime.Size = new System.Drawing.Size(78, 11);
            this.lblSendDelayTime.TabIndex = 31;
            this.lblSendDelayTime.Text = "Send Delay Time";
            // 
            // txtReadBufferSize
            // 
            this.txtReadBufferSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReadBufferSize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReadBufferSize.Location = new System.Drawing.Point(185, 44);
            this.txtReadBufferSize.Name = "txtReadBufferSize";
            this.txtReadBufferSize.Size = new System.Drawing.Size(50, 14);
            this.txtReadBufferSize.TabIndex = 29;
            this.txtReadBufferSize.Text = "64";
            // 
            // txtTCPClientCommunicationTimeOut
            // 
            this.txtTCPClientCommunicationTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTCPClientCommunicationTimeOut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCPClientCommunicationTimeOut.Location = new System.Drawing.Point(185, 28);
            this.txtTCPClientCommunicationTimeOut.Name = "txtTCPClientCommunicationTimeOut";
            this.txtTCPClientCommunicationTimeOut.Size = new System.Drawing.Size(50, 14);
            this.txtTCPClientCommunicationTimeOut.TabIndex = 29;
            this.txtTCPClientCommunicationTimeOut.Text = "500";
            // 
            // txtDelayTime
            // 
            this.txtDelayTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelayTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDelayTime.Location = new System.Drawing.Point(185, 12);
            this.txtDelayTime.Name = "txtDelayTime";
            this.txtDelayTime.Size = new System.Drawing.Size(50, 14);
            this.txtDelayTime.TabIndex = 30;
            this.txtDelayTime.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(381, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "End Byte";
            // 
            // txtEndByte
            // 
            this.txtEndByte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndByte.Location = new System.Drawing.Point(437, 35);
            this.txtEndByte.Name = "txtEndByte";
            this.txtEndByte.Size = new System.Drawing.Size(28, 13);
            this.txtEndByte.TabIndex = 27;
            this.txtEndByte.Text = "3";
            // 
            // tpDeviceInfo
            // 
            this.tpDeviceInfo.Controls.Add(this.lblBuildDate);
            this.tpDeviceInfo.Controls.Add(this.lnkUpdateDeviceInfo);
            this.tpDeviceInfo.Controls.Add(this.pnlDeviceInformation);
            this.tpDeviceInfo.Controls.Add(this.label7);
            this.tpDeviceInfo.Controls.Add(this.label6);
            this.tpDeviceInfo.Controls.Add(this.label5);
            this.tpDeviceInfo.Controls.Add(this.label4);
            this.tpDeviceInfo.Controls.Add(this.txtDeviceName);
            this.tpDeviceInfo.Controls.Add(this.txtInstructionStructure);
            this.tpDeviceInfo.Controls.Add(this.txtCheckSumType);
            this.tpDeviceInfo.Controls.Add(this.txtDeviceExplanation);
            this.tpDeviceInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDeviceInfo.Location = new System.Drawing.Point(4, 29);
            this.tpDeviceInfo.Name = "tpDeviceInfo";
            this.tpDeviceInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeviceInfo.Size = new System.Drawing.Size(491, 572);
            this.tpDeviceInfo.TabIndex = 1;
            this.tpDeviceInfo.Text = "Device Info";
            this.tpDeviceInfo.UseVisualStyleBackColor = true;
            // 
            // lblBuildDate
            // 
            this.lblBuildDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBuildDate.AutoSize = true;
            this.lblBuildDate.Location = new System.Drawing.Point(8, 544);
            this.lblBuildDate.Name = "lblBuildDate";
            this.lblBuildDate.Size = new System.Drawing.Size(85, 13);
            this.lblBuildDate.TabIndex = 24;
            this.lblBuildDate.Text = "Build Date : ";
            this.lblBuildDate.UseMnemonic = false;
            // 
            // lnkUpdateDeviceInfo
            // 
            this.lnkUpdateDeviceInfo.AutoSize = true;
            this.lnkUpdateDeviceInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkUpdateDeviceInfo.Location = new System.Drawing.Point(129, 206);
            this.lnkUpdateDeviceInfo.Name = "lnkUpdateDeviceInfo";
            this.lnkUpdateDeviceInfo.Size = new System.Drawing.Size(53, 13);
            this.lnkUpdateDeviceInfo.TabIndex = 23;
            this.lnkUpdateDeviceInfo.TabStop = true;
            this.lnkUpdateDeviceInfo.Text = "Update";
            this.lnkUpdateDeviceInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdateDeviceInfo_LinkClicked);
            // 
            // pnlDeviceInformation
            // 
            this.pnlDeviceInformation.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeviceInformation.Controls.Add(this.lblDeviceInformationTitle);
            this.pnlDeviceInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeviceInformation.Location = new System.Drawing.Point(3, 3);
            this.pnlDeviceInformation.Name = "pnlDeviceInformation";
            this.pnlDeviceInformation.Size = new System.Drawing.Size(485, 24);
            this.pnlDeviceInformation.TabIndex = 22;
            // 
            // lblDeviceInformationTitle
            // 
            this.lblDeviceInformationTitle.AutoSize = true;
            this.lblDeviceInformationTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviceInformationTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeviceInformationTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceInformationTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblDeviceInformationTitle.Location = new System.Drawing.Point(0, 0);
            this.lblDeviceInformationTitle.Name = "lblDeviceInformationTitle";
            this.lblDeviceInformationTitle.Size = new System.Drawing.Size(194, 23);
            this.lblDeviceInformationTitle.TabIndex = 14;
            this.lblDeviceInformationTitle.Text = "Device Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Command Structure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Check Sum Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Device Explanation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Device Name";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeviceName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceName.Location = new System.Drawing.Point(132, 41);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(145, 21);
            this.txtDeviceName.TabIndex = 14;
            // 
            // txtInstructionStructure
            // 
            this.txtInstructionStructure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstructionStructure.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructionStructure.Location = new System.Drawing.Point(132, 119);
            this.txtInstructionStructure.Multiline = true;
            this.txtInstructionStructure.Name = "txtInstructionStructure";
            this.txtInstructionStructure.Size = new System.Drawing.Size(348, 84);
            this.txtInstructionStructure.TabIndex = 16;
            // 
            // txtCheckSumType
            // 
            this.txtCheckSumType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckSumType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckSumType.Location = new System.Drawing.Point(132, 93);
            this.txtCheckSumType.Name = "txtCheckSumType";
            this.txtCheckSumType.Size = new System.Drawing.Size(145, 21);
            this.txtCheckSumType.TabIndex = 17;
            // 
            // txtDeviceExplanation
            // 
            this.txtDeviceExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeviceExplanation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceExplanation.Location = new System.Drawing.Point(132, 67);
            this.txtDeviceExplanation.Name = "txtDeviceExplanation";
            this.txtDeviceExplanation.Size = new System.Drawing.Size(145, 21);
            this.txtDeviceExplanation.TabIndex = 15;
            // 
            // tpCommandWorkbench
            // 
            this.tpCommandWorkbench.Controls.Add(this.txtWorkbench);
            this.tpCommandWorkbench.Controls.Add(this.panel5);
            this.tpCommandWorkbench.Controls.Add(this.tlsCommandWorkbench);
            this.tpCommandWorkbench.Location = new System.Drawing.Point(4, 29);
            this.tpCommandWorkbench.Name = "tpCommandWorkbench";
            this.tpCommandWorkbench.Size = new System.Drawing.Size(491, 572);
            this.tpCommandWorkbench.TabIndex = 4;
            this.tpCommandWorkbench.Text = "Command Workbench";
            this.tpCommandWorkbench.UseVisualStyleBackColor = true;
            // 
            // txtWorkbench
            // 
            this.txtWorkbench.BackColor = System.Drawing.Color.White;
            this.txtWorkbench.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWorkbench.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWorkbench.ForeColor = System.Drawing.Color.Blue;
            this.txtWorkbench.Location = new System.Drawing.Point(0, 92);
            this.txtWorkbench.Multiline = true;
            this.txtWorkbench.Name = "txtWorkbench";
            this.txtWorkbench.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWorkbench.Size = new System.Drawing.Size(491, 480);
            this.txtWorkbench.TabIndex = 18;
            this.txtWorkbench.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtWorkbench_MouseClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtWorkbenchCurrentCommand);
            this.panel5.Controls.Add(this.tlsCommandWorkbenchSend);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(491, 67);
            this.panel5.TabIndex = 17;
            // 
            // txtWorkbenchCurrentCommand
            // 
            this.txtWorkbenchCurrentCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWorkbenchCurrentCommand.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtWorkbenchCurrentCommand.Location = new System.Drawing.Point(8, 10);
            this.txtWorkbenchCurrentCommand.Name = "txtWorkbenchCurrentCommand";
            this.txtWorkbenchCurrentCommand.Size = new System.Drawing.Size(471, 23);
            this.txtWorkbenchCurrentCommand.TabIndex = 6;
            // 
            // tlsCommandWorkbenchSend
            // 
            this.tlsCommandWorkbenchSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsCommandWorkbenchSend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSendFromWorkbench});
            this.tlsCommandWorkbenchSend.Location = new System.Drawing.Point(0, 42);
            this.tlsCommandWorkbenchSend.Name = "tlsCommandWorkbenchSend";
            this.tlsCommandWorkbenchSend.Size = new System.Drawing.Size(491, 25);
            this.tlsCommandWorkbenchSend.TabIndex = 5;
            this.tlsCommandWorkbenchSend.Text = "toolStrip7";
            // 
            // tsbSendFromWorkbench
            // 
            this.tsbSendFromWorkbench.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbSendFromWorkbench.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsbSendFromWorkbench.Image = global::DeviceTester.Properties.Resources.rightArrow;
            this.tsbSendFromWorkbench.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbSendFromWorkbench.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendFromWorkbench.Name = "tsbSendFromWorkbench";
            this.tsbSendFromWorkbench.Size = new System.Drawing.Size(115, 22);
            this.tsbSendFromWorkbench.Text = "SEND TO DEVICE";
            this.tsbSendFromWorkbench.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbSendFromWorkbench.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbSendFromWorkbench.Click += new System.EventHandler(this.tsbSendFromWorkbench_Click);
            // 
            // tlsCommandWorkbench
            // 
            this.tlsCommandWorkbench.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSaveWorkbenchText,
            this.tsbSendFromWorkbenchToTools,
            this.toolStripSeparator9,
            this.tsbCalculateWorkbenchChk,
            this.toolStripSeparator10,
            this.tsbSendToGrid,
            this.toolStripSeparator7});
            this.tlsCommandWorkbench.Location = new System.Drawing.Point(0, 0);
            this.tlsCommandWorkbench.Name = "tlsCommandWorkbench";
            this.tlsCommandWorkbench.Size = new System.Drawing.Size(491, 25);
            this.tlsCommandWorkbench.TabIndex = 16;
            this.tlsCommandWorkbench.Text = "toolStrip6";
            // 
            // tsbSaveWorkbenchText
            // 
            this.tsbSaveWorkbenchText.Image = global::DeviceTester.Properties.Resources.save;
            this.tsbSaveWorkbenchText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveWorkbenchText.Name = "tsbSaveWorkbenchText";
            this.tsbSaveWorkbenchText.Size = new System.Drawing.Size(115, 22);
            this.tsbSaveWorkbenchText.Text = "Save Workbench";
            this.tsbSaveWorkbenchText.Click += new System.EventHandler(this.tsbSaveWorkbenchText_Click);
            // 
            // tsbSendFromWorkbenchToTools
            // 
            this.tsbSendFromWorkbenchToTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSendFromWorkbenchToTools.Image = ((System.Drawing.Image)(resources.GetObject("tsbSendFromWorkbenchToTools.Image")));
            this.tsbSendFromWorkbenchToTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendFromWorkbenchToTools.Name = "tsbSendFromWorkbenchToTools";
            this.tsbSendFromWorkbenchToTools.Size = new System.Drawing.Size(84, 22);
            this.tsbSendFromWorkbenchToTools.Text = "Send To Tools";
            this.tsbSendFromWorkbenchToTools.ToolTipText = "Sends current row to Tools section to edit them";
            this.tsbSendFromWorkbenchToTools.Click += new System.EventHandler(this.tsbSendFromWorkbenchToTools_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCalculateWorkbenchChk
            // 
            this.tsbCalculateWorkbenchChk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCalculateWorkbenchChk.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalculateWorkbenchChk.Image")));
            this.tsbCalculateWorkbenchChk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalculateWorkbenchChk.Name = "tsbCalculateWorkbenchChk";
            this.tsbCalculateWorkbenchChk.Size = new System.Drawing.Size(74, 22);
            this.tsbCalculateWorkbenchChk.Text = "Check  Sum";
            this.tsbCalculateWorkbenchChk.ToolTipText = "Calculate Check  Sum";
            this.tsbCalculateWorkbenchChk.Click += new System.EventHandler(this.tsbCalculateWorkbenchChk_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSendToGrid
            // 
            this.tsbSendToGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSendToGrid.Image = ((System.Drawing.Image)(resources.GetObject("tsbSendToGrid.Image")));
            this.tsbSendToGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendToGrid.Name = "tsbSendToGrid";
            this.tsbSendToGrid.Size = new System.Drawing.Size(78, 22);
            this.tsbSendToGrid.Text = "Send To Grid";
            this.tsbSendToGrid.Click += new System.EventHandler(this.tsbSendToGrid_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tpTimerCommandList
            // 
            this.tpTimerCommandList.Controls.Add(this.dgvTimerInstructions);
            this.tpTimerCommandList.Controls.Add(this.tlsTimerCommandList);
            this.tpTimerCommandList.Controls.Add(this.panel1);
            this.tpTimerCommandList.Location = new System.Drawing.Point(4, 29);
            this.tpTimerCommandList.Name = "tpTimerCommandList";
            this.tpTimerCommandList.Padding = new System.Windows.Forms.Padding(3);
            this.tpTimerCommandList.Size = new System.Drawing.Size(491, 572);
            this.tpTimerCommandList.TabIndex = 5;
            this.tpTimerCommandList.Text = "Timer Command List";
            this.tpTimerCommandList.UseVisualStyleBackColor = true;
            // 
            // dgvTimerInstructions
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTimerInstructions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTimerInstructions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimerInstructions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTimerInstructions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTimerInstructions.ColumnHeadersHeight = 30;
            this.dgvTimerInstructions.ColumnHeadersVisible = false;
            this.dgvTimerInstructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InstructionBytes,
            this.Explanation});
            this.dgvTimerInstructions.ContextMenuStrip = this.cmsInstructionsGrid;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTimerInstructions.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTimerInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimerInstructions.Location = new System.Drawing.Point(3, 28);
            this.dgvTimerInstructions.Name = "dgvTimerInstructions";
            this.dgvTimerInstructions.RowHeadersVisible = false;
            this.dgvTimerInstructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimerInstructions.Size = new System.Drawing.Size(485, 441);
            this.dgvTimerInstructions.TabIndex = 9;
            // 
            // InstructionBytes
            // 
            this.InstructionBytes.HeaderText = "Instruction Bytes";
            this.InstructionBytes.Name = "InstructionBytes";
            this.InstructionBytes.Width = 300;
            // 
            // Explanation
            // 
            this.Explanation.HeaderText = "Explanation";
            this.Explanation.Name = "Explanation";
            this.Explanation.Width = 170;
            // 
            // tlsTimerCommandList
            // 
            this.tlsTimerCommandList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRemoveTimerCommand,
            this.tsbMoveTimerRowUp,
            this.tsbMoveTimerRowDown});
            this.tlsTimerCommandList.Location = new System.Drawing.Point(3, 3);
            this.tlsTimerCommandList.Name = "tlsTimerCommandList";
            this.tlsTimerCommandList.Size = new System.Drawing.Size(485, 25);
            this.tlsTimerCommandList.TabIndex = 8;
            this.tlsTimerCommandList.Text = "toolStrip8";
            // 
            // tsbRemoveTimerCommand
            // 
            this.tsbRemoveTimerCommand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRemoveTimerCommand.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveTimerCommand.Image")));
            this.tsbRemoveTimerCommand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveTimerCommand.Name = "tsbRemoveTimerCommand";
            this.tsbRemoveTimerCommand.Size = new System.Drawing.Size(70, 22);
            this.tsbRemoveTimerCommand.Text = "Delete Row";
            this.tsbRemoveTimerCommand.Click += new System.EventHandler(this.tsbRemoveTimerCommand_Click);
            // 
            // tsbMoveTimerRowUp
            // 
            this.tsbMoveTimerRowUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMoveTimerRowUp.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoveTimerRowUp.Image")));
            this.tsbMoveTimerRowUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveTimerRowUp.Name = "tsbMoveTimerRowUp";
            this.tsbMoveTimerRowUp.Size = new System.Drawing.Size(59, 22);
            this.tsbMoveTimerRowUp.Text = "Move Up";
            this.tsbMoveTimerRowUp.Click += new System.EventHandler(this.tsbMoveTimerRowUp_Click);
            // 
            // tsbMoveTimerRowDown
            // 
            this.tsbMoveTimerRowDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMoveTimerRowDown.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoveTimerRowDown.Image")));
            this.tsbMoveTimerRowDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveTimerRowDown.Name = "tsbMoveTimerRowDown";
            this.tsbMoveTimerRowDown.Size = new System.Drawing.Size(75, 22);
            this.tsbMoveTimerRowDown.Text = "Move Down";
            this.tsbMoveTimerRowDown.Click += new System.EventHandler(this.tsbMoveTimerRowDown_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.chronometer1);
            this.panel1.Controls.Add(this.sevenSegmentArray2);
            this.panel1.Controls.Add(this.tlsTimerCommandsControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 100);
            this.panel1.TabIndex = 7;
            // 
            // chronometer1
            // 
            this.chronometer1.Location = new System.Drawing.Point(164, 27);
            this.chronometer1.Name = "chronometer1";
            this.chronometer1.Size = new System.Drawing.Size(294, 64);
            this.chronometer1.TabIndex = 30;
            // 
            // sevenSegmentArray2
            // 
            this.sevenSegmentArray2.ArrayCount = 2;
            this.sevenSegmentArray2.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray2.ColorDark = System.Drawing.Color.Black;
            this.sevenSegmentArray2.ColorLight = System.Drawing.Color.Crimson;
            this.sevenSegmentArray2.DecimalShow = false;
            this.sevenSegmentArray2.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray2.ElementWidth = 10;
            this.sevenSegmentArray2.ItalicFactor = 0F;
            this.sevenSegmentArray2.Location = new System.Drawing.Point(27, 31);
            this.sevenSegmentArray2.Name = "sevenSegmentArray2";
            this.sevenSegmentArray2.Size = new System.Drawing.Size(71, 60);
            this.sevenSegmentArray2.TabIndex = 29;
            this.sevenSegmentArray2.TabStop = false;
            this.sevenSegmentArray2.Value = null;
            // 
            // tlsTimerCommandsControl
            // 
            this.tlsTimerCommandsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStartTimer,
            this.tsbStopTimer2,
            this.toolStripLabel1,
            this.txtTimerInterval,
            this.tsbSetTimerInterval,
            this.tsbToogleCounterTimerInterval});
            this.tlsTimerCommandsControl.Location = new System.Drawing.Point(0, 0);
            this.tlsTimerCommandsControl.Name = "tlsTimerCommandsControl";
            this.tlsTimerCommandsControl.Size = new System.Drawing.Size(485, 25);
            this.tlsTimerCommandsControl.TabIndex = 4;
            this.tlsTimerCommandsControl.Text = "toolStrip8";
            // 
            // tsbStartTimer
            // 
            this.tsbStartTimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStartTimer.Image = ((System.Drawing.Image)(resources.GetObject("tsbStartTimer.Image")));
            this.tsbStartTimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStartTimer.Name = "tsbStartTimer";
            this.tsbStartTimer.Size = new System.Drawing.Size(69, 22);
            this.tsbStartTimer.Text = "Start Timer";
            this.tsbStartTimer.Click += new System.EventHandler(this.tsbStartTimer_Click);
            // 
            // tsbStopTimer2
            // 
            this.tsbStopTimer2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStopTimer2.Image = ((System.Drawing.Image)(resources.GetObject("tsbStopTimer2.Image")));
            this.tsbStopTimer2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStopTimer2.Name = "tsbStopTimer2";
            this.tsbStopTimer2.Size = new System.Drawing.Size(69, 22);
            this.tsbStopTimer2.Text = "Stop Timer";
            this.tsbStopTimer2.Click += new System.EventHandler(this.tsbStopTimer2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(104, 22);
            this.toolStripLabel1.Text = "Timer Interval(ms)";
            // 
            // txtTimerInterval
            // 
            this.txtTimerInterval.Name = "txtTimerInterval";
            this.txtTimerInterval.Size = new System.Drawing.Size(70, 25);
            this.txtTimerInterval.Text = "1000";
            // 
            // tsbSetTimerInterval
            // 
            this.tsbSetTimerInterval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSetTimerInterval.Image = ((System.Drawing.Image)(resources.GetObject("tsbSetTimerInterval.Image")));
            this.tsbSetTimerInterval.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSetTimerInterval.Name = "tsbSetTimerInterval";
            this.tsbSetTimerInterval.Size = new System.Drawing.Size(69, 22);
            this.tsbSetTimerInterval.Text = "Set Interval";
            this.tsbSetTimerInterval.Click += new System.EventHandler(this.tsbSetTimerInterval_Click);
            // 
            // tsbToogleCounterTimerInterval
            // 
            this.tsbToogleCounterTimerInterval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbToogleCounterTimerInterval.Image = ((System.Drawing.Image)(resources.GetObject("tsbToogleCounterTimerInterval.Image")));
            this.tsbToogleCounterTimerInterval.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbToogleCounterTimerInterval.Name = "tsbToogleCounterTimerInterval";
            this.tsbToogleCounterTimerInterval.Size = new System.Drawing.Size(23, 22);
            this.tsbToogleCounterTimerInterval.Text = "toolStripButton1";
            this.tsbToogleCounterTimerInterval.Click += new System.EventHandler(this.tsbToogleCounterTimerInterval_Click);
            // 
            // tpConsole
            // 
            this.tpConsole.Controls.Add(this.shellControl1);
            this.tpConsole.Controls.Add(this.pnlConsoleBottom);
            this.tpConsole.Controls.Add(this.panel4);
            this.tpConsole.Location = new System.Drawing.Point(4, 29);
            this.tpConsole.Name = "tpConsole";
            this.tpConsole.Size = new System.Drawing.Size(491, 572);
            this.tpConsole.TabIndex = 3;
            this.tpConsole.Text = "Console";
            this.tpConsole.UseVisualStyleBackColor = true;
            // 
            // shellControl1
            // 
            this.shellControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellControl1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellControl1.Location = new System.Drawing.Point(0, 24);
            this.shellControl1.Name = "shellControl1";
            this.shellControl1.Prompt = ">";
            this.shellControl1.ShellTextBackColor = System.Drawing.Color.Black;
            this.shellControl1.ShellTextFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellControl1.ShellTextForeColor = System.Drawing.Color.FloralWhite;
            this.shellControl1.Size = new System.Drawing.Size(491, 520);
            this.shellControl1.TabIndex = 26;
            this.shellControl1.CommandEntered += new DeviceTester.EventCommandEntered(this.shellControl1_CommandEntered);
            // 
            // pnlConsoleBottom
            // 
            this.pnlConsoleBottom.Controls.Add(this.lnkSelectDOSCommand);
            this.pnlConsoleBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConsoleBottom.Location = new System.Drawing.Point(0, 544);
            this.pnlConsoleBottom.Name = "pnlConsoleBottom";
            this.pnlConsoleBottom.Size = new System.Drawing.Size(491, 28);
            this.pnlConsoleBottom.TabIndex = 25;
            // 
            // lnkSelectDOSCommand
            // 
            this.lnkSelectDOSCommand.AutoSize = true;
            this.lnkSelectDOSCommand.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSelectDOSCommand.Location = new System.Drawing.Point(8, 6);
            this.lnkSelectDOSCommand.Name = "lnkSelectDOSCommand";
            this.lnkSelectDOSCommand.Size = new System.Drawing.Size(113, 13);
            this.lnkSelectDOSCommand.TabIndex = 5;
            this.lnkSelectDOSCommand.TabStop = true;
            this.lnkSelectDOSCommand.Text = "Select DOS Command";
            this.lnkSelectDOSCommand.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectDOSCommand_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.rbConsoleIsInASCIIMode);
            this.panel4.Controls.Add(this.rbConsoleIsInPythonMode);
            this.panel4.Controls.Add(this.rbConsoleIsInDosMode);
            this.panel4.Controls.Add(this.rbConsoleIsInDeviceMode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(491, 24);
            this.panel4.TabIndex = 23;
            // 
            // rbConsoleIsInASCIIMode
            // 
            this.rbConsoleIsInASCIIMode.AutoSize = true;
            this.rbConsoleIsInASCIIMode.Location = new System.Drawing.Point(67, 4);
            this.rbConsoleIsInASCIIMode.Name = "rbConsoleIsInASCIIMode";
            this.rbConsoleIsInASCIIMode.Size = new System.Drawing.Size(52, 17);
            this.rbConsoleIsInASCIIMode.TabIndex = 17;
            this.rbConsoleIsInASCIIMode.Text = "ASCII";
            this.rbConsoleIsInASCIIMode.UseVisualStyleBackColor = true;
            this.rbConsoleIsInASCIIMode.CheckedChanged += new System.EventHandler(this.rbDosMode_CheckedChanged);
            // 
            // rbConsoleIsInPythonMode
            // 
            this.rbConsoleIsInPythonMode.AutoSize = true;
            this.rbConsoleIsInPythonMode.Location = new System.Drawing.Point(237, 4);
            this.rbConsoleIsInPythonMode.Name = "rbConsoleIsInPythonMode";
            this.rbConsoleIsInPythonMode.Size = new System.Drawing.Size(58, 17);
            this.rbConsoleIsInPythonMode.TabIndex = 17;
            this.rbConsoleIsInPythonMode.Text = "Python";
            this.rbConsoleIsInPythonMode.UseVisualStyleBackColor = true;
            this.rbConsoleIsInPythonMode.CheckedChanged += new System.EventHandler(this.rbDosMode_CheckedChanged);
            // 
            // rbConsoleIsInDosMode
            // 
            this.rbConsoleIsInDosMode.AutoSize = true;
            this.rbConsoleIsInDosMode.Checked = true;
            this.rbConsoleIsInDosMode.Location = new System.Drawing.Point(128, 4);
            this.rbConsoleIsInDosMode.Name = "rbConsoleIsInDosMode";
            this.rbConsoleIsInDosMode.Size = new System.Drawing.Size(103, 17);
            this.rbConsoleIsInDosMode.TabIndex = 17;
            this.rbConsoleIsInDosMode.TabStop = true;
            this.rbConsoleIsInDosMode.Text = "DOS Commands";
            this.rbConsoleIsInDosMode.UseVisualStyleBackColor = true;
            this.rbConsoleIsInDosMode.CheckedChanged += new System.EventHandler(this.rbDosMode_CheckedChanged);
            // 
            // rbConsoleIsInDeviceMode
            // 
            this.rbConsoleIsInDeviceMode.AutoSize = true;
            this.rbConsoleIsInDeviceMode.Location = new System.Drawing.Point(8, 4);
            this.rbConsoleIsInDeviceMode.Name = "rbConsoleIsInDeviceMode";
            this.rbConsoleIsInDeviceMode.Size = new System.Drawing.Size(47, 17);
            this.rbConsoleIsInDeviceMode.TabIndex = 16;
            this.rbConsoleIsInDeviceMode.Text = "HEX";
            this.rbConsoleIsInDeviceMode.UseVisualStyleBackColor = true;
            this.rbConsoleIsInDeviceMode.CheckedChanged += new System.EventHandler(this.rbDeviceMode_CheckedChanged);
            // 
            // pnlInstructionsTop
            // 
            this.pnlInstructionsTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlInstructionsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInstructionsTop.Location = new System.Drawing.Point(0, 0);
            this.pnlInstructionsTop.Name = "pnlInstructionsTop";
            this.pnlInstructionsTop.Size = new System.Drawing.Size(499, 5);
            this.pnlInstructionsTop.TabIndex = 1;
            // 
            // tbcTools
            // 
            this.tbcTools.Controls.Add(this.tpIncomingBytes);
            this.tbcTools.Controls.Add(this.tpTools);
            this.tbcTools.Controls.Add(this.tpConvertor);
            this.tbcTools.Controls.Add(this.tpErrorMessages);
            this.tbcTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcTools.Location = new System.Drawing.Point(0, 25);
            this.tbcTools.Name = "tbcTools";
            this.tbcTools.SelectedIndex = 0;
            this.tbcTools.Size = new System.Drawing.Size(581, 585);
            this.tbcTools.TabIndex = 16;
            // 
            // tpIncomingBytes
            // 
            this.tpIncomingBytes.Controls.Add(this.chkSaveLog);
            this.tpIncomingBytes.Controls.Add(this.tbcIncomingBytes);
            this.tpIncomingBytes.Controls.Add(this.tlsIncomingBytes);
            this.tpIncomingBytes.Location = new System.Drawing.Point(4, 22);
            this.tpIncomingBytes.Name = "tpIncomingBytes";
            this.tpIncomingBytes.Padding = new System.Windows.Forms.Padding(3);
            this.tpIncomingBytes.Size = new System.Drawing.Size(573, 559);
            this.tpIncomingBytes.TabIndex = 0;
            this.tpIncomingBytes.Text = "Incoming Bytes";
            this.tpIncomingBytes.UseVisualStyleBackColor = true;
            // 
            // chkSaveLog
            // 
            this.chkSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSaveLog.AutoSize = true;
            this.chkSaveLog.Checked = true;
            this.chkSaveLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveLog.Location = new System.Drawing.Point(491, 536);
            this.chkSaveLog.Name = "chkSaveLog";
            this.chkSaveLog.Size = new System.Drawing.Size(72, 17);
            this.chkSaveLog.TabIndex = 33;
            this.chkSaveLog.Text = "Save Log";
            this.chkSaveLog.UseVisualStyleBackColor = true;
            // 
            // tbcIncomingBytes
            // 
            this.tbcIncomingBytes.Controls.Add(this.tpTextView);
            this.tbcIncomingBytes.Controls.Add(this.tpGridView);
            this.tbcIncomingBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcIncomingBytes.Location = new System.Drawing.Point(3, 3);
            this.tbcIncomingBytes.Name = "tbcIncomingBytes";
            this.tbcIncomingBytes.SelectedIndex = 0;
            this.tbcIncomingBytes.Size = new System.Drawing.Size(567, 528);
            this.tbcIncomingBytes.TabIndex = 0;
            // 
            // tpTextView
            // 
            this.tpTextView.Controls.Add(this.hexReceivedBytes);
            this.tpTextView.Controls.Add(this.pnlBitsHolder);
            this.tpTextView.Controls.Add(this.txtSentCommand);
            this.tpTextView.Controls.Add(this.panel3);
            this.tpTextView.Location = new System.Drawing.Point(4, 22);
            this.tpTextView.Name = "tpTextView";
            this.tpTextView.Padding = new System.Windows.Forms.Padding(3);
            this.tpTextView.Size = new System.Drawing.Size(559, 502);
            this.tpTextView.TabIndex = 0;
            this.tpTextView.Text = "Text View";
            this.tpTextView.UseVisualStyleBackColor = true;
            // 
            // hexReceivedBytes
            // 
            this.hexReceivedBytes.AllowDrop = true;
            this.hexReceivedBytes.BackColor = System.Drawing.Color.SeaShell;
            this.hexReceivedBytes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // 
            // 
            this.hexReceivedBytes.BuiltInContextMenu.CopyMenuItemText = "Copy ";
            this.hexReceivedBytes.BuiltInContextMenu.CutMenuItemText = "Cut ";
            this.hexReceivedBytes.BuiltInContextMenu.PasteMenuItemText = "Paste ";
            this.hexReceivedBytes.BuiltInContextMenu.SelectAllMenuItemText = "Select All ";
            this.hexReceivedBytes.ColumnInfoVisible = true;
            this.hexReceivedBytes.ContextMenuStrip = this.ctxHexBoxMenu;
            this.hexReceivedBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexReceivedBytes.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hexReceivedBytes.GroupSeparatorVisible = true;
            this.hexReceivedBytes.InfoForeColor = System.Drawing.Color.Silver;
            this.hexReceivedBytes.Location = new System.Drawing.Point(3, 28);
            this.hexReceivedBytes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hexReceivedBytes.Name = "hexReceivedBytes";
            this.hexReceivedBytes.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.hexReceivedBytes.Size = new System.Drawing.Size(553, 151);
            this.hexReceivedBytes.StringViewVisible = true;
            this.hexReceivedBytes.TabIndex = 33;
            this.hexReceivedBytes.UseFixedBytesPerLine = true;
            this.hexReceivedBytes.VScrollBarVisible = true;
            this.hexReceivedBytes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hexBox_MouseClick);
            // 
            // ctxHexBoxMenu
            // 
            this.ctxHexBoxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCopyHexBoxToClipboard});
            this.ctxHexBoxMenu.Name = "ctxHexBoxMenu";
            this.ctxHexBoxMenu.Size = new System.Drawing.Size(225, 26);
            // 
            // miCopyHexBoxToClipboard
            // 
            this.miCopyHexBoxToClipboard.Name = "miCopyHexBoxToClipboard";
            this.miCopyHexBoxToClipboard.Size = new System.Drawing.Size(224, 22);
            this.miCopyHexBoxToClipboard.Text = "Copy Selection To Clipboard";
            this.miCopyHexBoxToClipboard.Click += new System.EventHandler(this.miCopyHexBoxToClipboard_Click);
            // 
            // pnlBitsHolder
            // 
            this.pnlBitsHolder.Controls.Add(this.bitDisplay1);
            this.pnlBitsHolder.Controls.Add(this.lblByteNo);
            this.pnlBitsHolder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBitsHolder.Location = new System.Drawing.Point(3, 179);
            this.pnlBitsHolder.Name = "pnlBitsHolder";
            this.pnlBitsHolder.Size = new System.Drawing.Size(553, 64);
            this.pnlBitsHolder.TabIndex = 34;
            // 
            // bitDisplay1
            // 
            this.bitDisplay1.Location = new System.Drawing.Point(110, 4);
            this.bitDisplay1.Name = "bitDisplay1";
            this.bitDisplay1.Size = new System.Drawing.Size(423, 54);
            this.bitDisplay1.TabIndex = 7;
            // 
            // lblByteNo
            // 
            this.lblByteNo.AutoSize = true;
            this.lblByteNo.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblByteNo.Location = new System.Drawing.Point(3, 3);
            this.lblByteNo.Name = "lblByteNo";
            this.lblByteNo.Size = new System.Drawing.Size(19, 15);
            this.lblByteNo.TabIndex = 4;
            this.lblByteNo.Text = "...";
            // 
            // txtSentCommand
            // 
            this.txtSentCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSentCommand.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSentCommand.Location = new System.Drawing.Point(3, 3);
            this.txtSentCommand.Name = "txtSentCommand";
            this.txtSentCommand.Size = new System.Drawing.Size(553, 25);
            this.txtSentCommand.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtReceivedBytesASCII);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 256);
            this.panel3.TabIndex = 30;
            // 
            // txtReceivedBytesASCII
            // 
            this.txtReceivedBytesASCII.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtReceivedBytesASCII.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceivedBytesASCII.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceivedBytesASCII.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceivedBytesASCII.Location = new System.Drawing.Point(0, 0);
            this.txtReceivedBytesASCII.Multiline = true;
            this.txtReceivedBytesASCII.Name = "txtReceivedBytesASCII";
            this.txtReceivedBytesASCII.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceivedBytesASCII.Size = new System.Drawing.Size(553, 256);
            this.txtReceivedBytesASCII.TabIndex = 29;
            // 
            // tpGridView
            // 
            this.tpGridView.Controls.Add(this.dgvIncomingBytes);
            this.tpGridView.Controls.Add(this.pnlBits);
            this.tpGridView.Location = new System.Drawing.Point(4, 22);
            this.tpGridView.Name = "tpGridView";
            this.tpGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tpGridView.Size = new System.Drawing.Size(559, 502);
            this.tpGridView.TabIndex = 1;
            this.tpGridView.Text = "Grid View";
            this.tpGridView.UseVisualStyleBackColor = true;
            // 
            // dgvIncomingBytes
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvIncomingBytes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvIncomingBytes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvIncomingBytes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIncomingBytes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvIncomingBytes.ColumnHeadersHeight = 30;
            this.dgvIncomingBytes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ByteNo,
            this.Decimal,
            this.ASCII,
            this.HEX});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncomingBytes.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvIncomingBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncomingBytes.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvIncomingBytes.Location = new System.Drawing.Point(3, 3);
            this.dgvIncomingBytes.Name = "dgvIncomingBytes";
            this.dgvIncomingBytes.RowHeadersVisible = false;
            this.dgvIncomingBytes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncomingBytes.Size = new System.Drawing.Size(553, 414);
            this.dgvIncomingBytes.TabIndex = 0;
            this.dgvIncomingBytes.SelectionChanged += new System.EventHandler(this.dgvIncomingBytes_SelectionChanged);
            // 
            // ByteNo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ByteNo.DefaultCellStyle = dataGridViewCellStyle6;
            this.ByteNo.HeaderText = "Byte No";
            this.ByteNo.Name = "ByteNo";
            this.ByteNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ByteNo.Width = 70;
            // 
            // Decimal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Decimal.DefaultCellStyle = dataGridViewCellStyle7;
            this.Decimal.HeaderText = "Decimal";
            this.Decimal.Name = "Decimal";
            this.Decimal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ASCII
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ASCII.DefaultCellStyle = dataGridViewCellStyle8;
            this.ASCII.HeaderText = "ASCII";
            this.ASCII.Name = "ASCII";
            this.ASCII.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HEX
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HEX.DefaultCellStyle = dataGridViewCellStyle9;
            this.HEX.HeaderText = "HEX";
            this.HEX.Name = "HEX";
            this.HEX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlBits
            // 
            this.pnlBits.Controls.Add(this.bitDisplay2);
            this.pnlBits.Controls.Add(this.lblBits);
            this.pnlBits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBits.Location = new System.Drawing.Point(3, 417);
            this.pnlBits.Name = "pnlBits";
            this.pnlBits.Size = new System.Drawing.Size(553, 82);
            this.pnlBits.TabIndex = 1;
            // 
            // bitDisplay2
            // 
            this.bitDisplay2.Location = new System.Drawing.Point(96, 6);
            this.bitDisplay2.Name = "bitDisplay2";
            this.bitDisplay2.Size = new System.Drawing.Size(389, 60);
            this.bitDisplay2.TabIndex = 3;
            // 
            // lblBits
            // 
            this.lblBits.AutoSize = true;
            this.lblBits.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBits.Location = new System.Drawing.Point(0, 0);
            this.lblBits.Name = "lblBits";
            this.lblBits.Size = new System.Drawing.Size(24, 13);
            this.lblBits.TabIndex = 1;
            this.lblBits.Text = "Bits";
            // 
            // tlsIncomingBytes
            // 
            this.tlsIncomingBytes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlsIncomingBytes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClearIncomingBytes,
            this.tsbChangeMainConsoleStyle,
            this.tsbClearBeforeSend,
            this.toolStripSeparator14,
            this.tsbShowLogs});
            this.tlsIncomingBytes.Location = new System.Drawing.Point(3, 531);
            this.tlsIncomingBytes.Name = "tlsIncomingBytes";
            this.tlsIncomingBytes.Size = new System.Drawing.Size(567, 25);
            this.tlsIncomingBytes.TabIndex = 0;
            this.tlsIncomingBytes.Text = "toolStrip1";
            // 
            // tsbClearIncomingBytes
            // 
            this.tsbClearIncomingBytes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClearIncomingBytes.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearIncomingBytes.Image")));
            this.tsbClearIncomingBytes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearIncomingBytes.Name = "tsbClearIncomingBytes";
            this.tsbClearIncomingBytes.Size = new System.Drawing.Size(38, 22);
            this.tsbClearIncomingBytes.Text = "Clear";
            this.tsbClearIncomingBytes.Click += new System.EventHandler(this.tsbClearIncomingBytes_Click);
            // 
            // tsbChangeMainConsoleStyle
            // 
            this.tsbChangeMainConsoleStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChangeMainConsoleStyle.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangeMainConsoleStyle.Image")));
            this.tsbChangeMainConsoleStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangeMainConsoleStyle.Name = "tsbChangeMainConsoleStyle";
            this.tsbChangeMainConsoleStyle.Size = new System.Drawing.Size(80, 22);
            this.tsbChangeMainConsoleStyle.Text = "Change Style";
            this.tsbChangeMainConsoleStyle.Click += new System.EventHandler(this.tsbChangeMainConsoleStyle_Click);
            // 
            // tsbClearBeforeSend
            // 
            this.tsbClearBeforeSend.Checked = true;
            this.tsbClearBeforeSend.CheckOnClick = true;
            this.tsbClearBeforeSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbClearBeforeSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClearBeforeSend.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearBeforeSend.Image")));
            this.tsbClearBeforeSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearBeforeSend.Name = "tsbClearBeforeSend";
            this.tsbClearBeforeSend.Size = new System.Drawing.Size(104, 22);
            this.tsbClearBeforeSend.Text = "Clear Before Send";
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbShowLogs
            // 
            this.tsbShowLogs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbShowLogs.Image = ((System.Drawing.Image)(resources.GetObject("tsbShowLogs.Image")));
            this.tsbShowLogs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowLogs.Name = "tsbShowLogs";
            this.tsbShowLogs.Size = new System.Drawing.Size(68, 22);
            this.tsbShowLogs.Text = "Show Logs";
            this.tsbShowLogs.Click += new System.EventHandler(this.tsbShowLogs_Click);
            // 
            // tpTools
            // 
            this.tpTools.Controls.Add(this.pnlPythonTools);
            this.tpTools.Controls.Add(this.lnkClearHexBytes);
            this.tpTools.Controls.Add(this.lnkSendToGrid);
            this.tpTools.Controls.Add(this.lnkApplyBCIP);
            this.tpTools.Controls.Add(this.lnkCalculateCRC);
            this.tpTools.Controls.Add(this.lnkGetComplement);
            this.tpTools.Controls.Add(this.lnkDelOneHexByte);
            this.tpTools.Controls.Add(this.dgvCheckSums);
            this.tpTools.Controls.Add(this.btnCalculateCRCInHex);
            this.tpTools.Controls.Add(this.label14);
            this.tpTools.Controls.Add(this.label15);
            this.tpTools.Controls.Add(this.label16);
            this.tpTools.Controls.Add(this.txtASCIIBytesInCHKCalculator);
            this.tpTools.Controls.Add(this.txtHEXBytesInCHKCalculator);
            this.tpTools.Controls.Add(this.txtDecimalBytesInCHKCalculator);
            this.tpTools.Location = new System.Drawing.Point(4, 22);
            this.tpTools.Name = "tpTools";
            this.tpTools.Padding = new System.Windows.Forms.Padding(3);
            this.tpTools.Size = new System.Drawing.Size(573, 559);
            this.tpTools.TabIndex = 1;
            this.tpTools.Text = "Checksum Calculator";
            this.tpTools.UseVisualStyleBackColor = true;
            // 
            // pnlPythonTools
            // 
            this.pnlPythonTools.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlPythonTools.Controls.Add(this.btnApplyPythonCode);
            this.pnlPythonTools.Controls.Add(this.lbPyFiles);
            this.pnlPythonTools.Controls.Add(this.lmkEditPythonCode);
            this.pnlPythonTools.Controls.Add(this.lnkReloadPythonFiles);
            this.pnlPythonTools.Location = new System.Drawing.Point(246, 141);
            this.pnlPythonTools.Name = "pnlPythonTools";
            this.pnlPythonTools.Size = new System.Drawing.Size(282, 251);
            this.pnlPythonTools.TabIndex = 55;
            // 
            // btnApplyPythonCode
            // 
            this.btnApplyPythonCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApplyPythonCode.Location = new System.Drawing.Point(12, 15);
            this.btnApplyPythonCode.Name = "btnApplyPythonCode";
            this.btnApplyPythonCode.Size = new System.Drawing.Size(191, 23);
            this.btnApplyPythonCode.TabIndex = 55;
            this.btnApplyPythonCode.Text = "Apply Python Code";
            this.btnApplyPythonCode.UseVisualStyleBackColor = true;
            this.btnApplyPythonCode.Click += new System.EventHandler(this.btnApplyPythonCode_Click);
            // 
            // lbPyFiles
            // 
            this.lbPyFiles.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPyFiles.FormattingEnabled = true;
            this.lbPyFiles.Location = new System.Drawing.Point(12, 44);
            this.lbPyFiles.Name = "lbPyFiles";
            this.lbPyFiles.Size = new System.Drawing.Size(191, 199);
            this.lbPyFiles.TabIndex = 54;
            // 
            // lmkEditPythonCode
            // 
            this.lmkEditPythonCode.AutoSize = true;
            this.lmkEditPythonCode.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lmkEditPythonCode.Location = new System.Drawing.Point(209, 44);
            this.lmkEditPythonCode.Name = "lmkEditPythonCode";
            this.lmkEditPythonCode.Size = new System.Drawing.Size(53, 13);
            this.lmkEditPythonCode.TabIndex = 53;
            this.lmkEditPythonCode.TabStop = true;
            this.lmkEditPythonCode.Text = "Edit Code";
            this.lmkEditPythonCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lmkEditPythonCode_LinkClicked);
            // 
            // lnkReloadPythonFiles
            // 
            this.lnkReloadPythonFiles.AutoSize = true;
            this.lnkReloadPythonFiles.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkReloadPythonFiles.Location = new System.Drawing.Point(209, 67);
            this.lnkReloadPythonFiles.Name = "lnkReloadPythonFiles";
            this.lnkReloadPythonFiles.Size = new System.Drawing.Size(65, 13);
            this.lnkReloadPythonFiles.TabIndex = 53;
            this.lnkReloadPythonFiles.TabStop = true;
            this.lnkReloadPythonFiles.Text = "Reload Files";
            this.lnkReloadPythonFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReloadPythonFiles_LinkClicked);
            // 
            // lnkClearHexBytes
            // 
            this.lnkClearHexBytes.AutoSize = true;
            this.lnkClearHexBytes.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkClearHexBytes.Location = new System.Drawing.Point(483, 98);
            this.lnkClearHexBytes.Name = "lnkClearHexBytes";
            this.lnkClearHexBytes.Size = new System.Drawing.Size(45, 13);
            this.lnkClearHexBytes.TabIndex = 53;
            this.lnkClearHexBytes.TabStop = true;
            this.lnkClearHexBytes.Text = "Clear All";
            this.lnkClearHexBytes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearHexBytes_LinkClicked);
            // 
            // lnkSendToGrid
            // 
            this.lnkSendToGrid.AutoSize = true;
            this.lnkSendToGrid.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSendToGrid.Location = new System.Drawing.Point(6, 98);
            this.lnkSendToGrid.Name = "lnkSendToGrid";
            this.lnkSendToGrid.Size = new System.Drawing.Size(85, 13);
            this.lnkSendToGrid.TabIndex = 53;
            this.lnkSendToGrid.TabStop = true;
            this.lnkSendToGrid.Text = "<< Send To Grid";
            this.lnkSendToGrid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSendToGrid_LinkClicked);
            // 
            // lnkCalculateCRC
            // 
            this.lnkCalculateCRC.AutoSize = true;
            this.lnkCalculateCRC.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkCalculateCRC.Location = new System.Drawing.Point(340, 98);
            this.lnkCalculateCRC.Name = "lnkCalculateCRC";
            this.lnkCalculateCRC.Size = new System.Drawing.Size(51, 13);
            this.lnkCalculateCRC.TabIndex = 53;
            this.lnkCalculateCRC.TabStop = true;
            this.lnkCalculateCRC.Text = "Add CHK";
            this.lnkCalculateCRC.Visible = false;
            this.lnkCalculateCRC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCalculateCRC_LinkClicked);
            // 
            // dgvCheckSums
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCheckSums.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCheckSums.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCheckSums.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCheckSums.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCheckSums.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCheckSums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckSums.ColumnHeadersVisible = false;
            this.dgvCheckSums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSumType,
            this.ChecksumValue});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckSums.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCheckSums.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCheckSums.Location = new System.Drawing.Point(9, 118);
            this.dgvCheckSums.Name = "dgvCheckSums";
            this.dgvCheckSums.ReadOnly = true;
            this.dgvCheckSums.RowHeadersVisible = false;
            this.dgvCheckSums.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckSums.Size = new System.Drawing.Size(230, 292);
            this.dgvCheckSums.TabIndex = 52;
            this.dgvCheckSums.DoubleClick += new System.EventHandler(this.dgvCheckSums_DoubleClick);
            // 
            // CheckSumType
            // 
            this.CheckSumType.HeaderText = "CHKType";
            this.CheckSumType.Name = "CheckSumType";
            this.CheckSumType.ReadOnly = true;
            this.CheckSumType.Width = 150;
            // 
            // ChecksumValue
            // 
            this.ChecksumValue.HeaderText = "CHKValue";
            this.ChecksumValue.Name = "ChecksumValue";
            this.ChecksumValue.ReadOnly = true;
            this.ChecksumValue.Width = 80;
            // 
            // btnCalculateCRCInHex
            // 
            this.btnCalculateCRCInHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateCRCInHex.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculateCRCInHex.Location = new System.Drawing.Point(246, 395);
            this.btnCalculateCRCInHex.Name = "btnCalculateCRCInHex";
            this.btnCalculateCRCInHex.Size = new System.Drawing.Size(125, 30);
            this.btnCalculateCRCInHex.TabIndex = 46;
            this.btnCalculateCRCInHex.Text = "Calculate Checksum";
            this.btnCalculateCRCInHex.UseVisualStyleBackColor = true;
            this.btnCalculateCRCInHex.Click += new System.EventHandler(this.btnCalculateCRCInHex_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "HEX BYTE ARRAY";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 488);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 40;
            this.label15.Text = "Decimal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 419);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "ASCII";
            // 
            // txtASCIIBytesInCHKCalculator
            // 
            this.txtASCIIBytesInCHKCalculator.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtASCIIBytesInCHKCalculator.Location = new System.Drawing.Point(9, 435);
            this.txtASCIIBytesInCHKCalculator.Multiline = true;
            this.txtASCIIBytesInCHKCalculator.Name = "txtASCIIBytesInCHKCalculator";
            this.txtASCIIBytesInCHKCalculator.Size = new System.Drawing.Size(520, 50);
            this.txtASCIIBytesInCHKCalculator.TabIndex = 21;
            this.txtASCIIBytesInCHKCalculator.TextChanged += new System.EventHandler(this.txtASCIIBytes_TextChanged);
            // 
            // txtHEXBytesInCHKCalculator
            // 
            this.txtHEXBytesInCHKCalculator.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHEXBytesInCHKCalculator.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHEXBytesInCHKCalculator.Location = new System.Drawing.Point(9, 26);
            this.txtHEXBytesInCHKCalculator.Multiline = true;
            this.txtHEXBytesInCHKCalculator.Name = "txtHEXBytesInCHKCalculator";
            this.txtHEXBytesInCHKCalculator.Size = new System.Drawing.Size(520, 64);
            this.txtHEXBytesInCHKCalculator.TabIndex = 22;
            this.txtHEXBytesInCHKCalculator.TextChanged += new System.EventHandler(this.txtHEXBytes_TextChanged);
            // 
            // txtDecimalBytesInCHKCalculator
            // 
            this.txtDecimalBytesInCHKCalculator.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimalBytesInCHKCalculator.Location = new System.Drawing.Point(9, 506);
            this.txtDecimalBytesInCHKCalculator.Multiline = true;
            this.txtDecimalBytesInCHKCalculator.Name = "txtDecimalBytesInCHKCalculator";
            this.txtDecimalBytesInCHKCalculator.Size = new System.Drawing.Size(519, 50);
            this.txtDecimalBytesInCHKCalculator.TabIndex = 23;
            this.txtDecimalBytesInCHKCalculator.TextChanged += new System.EventHandler(this.txtDecimalBytes_TextChanged);
            this.txtDecimalBytesInCHKCalculator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimalBytes_KeyPress);
            // 
            // tpConvertor
            // 
            this.tpConvertor.Controls.Add(this.rbDouble);
            this.tpConvertor.Controls.Add(this.rbInt32);
            this.tpConvertor.Controls.Add(this.rbInt16);
            this.tpConvertor.Controls.Add(this.label11);
            this.tpConvertor.Controls.Add(this.label2);
            this.tpConvertor.Controls.Add(this.txtConvertedBytes);
            this.tpConvertor.Controls.Add(this.txtIntNumberToConvert);
            this.tpConvertor.Controls.Add(this.rbCRC16Kermit);
            this.tpConvertor.Controls.Add(this.rbCRC16);
            this.tpConvertor.Controls.Add(this.rbMod95);
            this.tpConvertor.Controls.Add(this.rbXOR);
            this.tpConvertor.Controls.Add(this.lblActiveTCPConnections);
            this.tpConvertor.Controls.Add(this.btnSendToConsole);
            this.tpConvertor.Controls.Add(this.cbCheckSumTypes2);
            this.tpConvertor.Controls.Add(this.label21);
            this.tpConvertor.Location = new System.Drawing.Point(4, 22);
            this.tpConvertor.Name = "tpConvertor";
            this.tpConvertor.Padding = new System.Windows.Forms.Padding(3);
            this.tpConvertor.Size = new System.Drawing.Size(573, 559);
            this.tpConvertor.TabIndex = 2;
            this.tpConvertor.Text = "Convertor";
            this.tpConvertor.UseVisualStyleBackColor = true;
            // 
            // rbDouble
            // 
            this.rbDouble.AutoSize = true;
            this.rbDouble.Location = new System.Drawing.Point(311, 103);
            this.rbDouble.Name = "rbDouble";
            this.rbDouble.Size = new System.Drawing.Size(48, 17);
            this.rbDouble.TabIndex = 62;
            this.rbDouble.Text = "Float";
            this.rbDouble.UseVisualStyleBackColor = true;
            // 
            // rbInt32
            // 
            this.rbInt32.AutoSize = true;
            this.rbInt32.Location = new System.Drawing.Point(245, 103);
            this.rbInt32.Name = "rbInt32";
            this.rbInt32.Size = new System.Drawing.Size(49, 17);
            this.rbInt32.TabIndex = 62;
            this.rbInt32.Text = "Int32";
            this.rbInt32.UseVisualStyleBackColor = true;
            // 
            // rbInt16
            // 
            this.rbInt16.AutoSize = true;
            this.rbInt16.Checked = true;
            this.rbInt16.Location = new System.Drawing.Point(178, 103);
            this.rbInt16.Name = "rbInt16";
            this.rbInt16.Size = new System.Drawing.Size(49, 17);
            this.rbInt16.TabIndex = 62;
            this.rbInt16.TabStop = true;
            this.rbInt16.Text = "Int16";
            this.rbInt16.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Integer Value";
            // 
            // txtConvertedBytes
            // 
            this.txtConvertedBytes.Location = new System.Drawing.Point(209, 56);
            this.txtConvertedBytes.Name = "txtConvertedBytes";
            this.txtConvertedBytes.Size = new System.Drawing.Size(150, 20);
            this.txtConvertedBytes.TabIndex = 59;
            this.txtConvertedBytes.TextChanged += new System.EventHandler(this.txtConvertedBytes_TextChanged);
            // 
            // txtIntNumberToConvert
            // 
            this.txtIntNumberToConvert.Location = new System.Drawing.Point(209, 32);
            this.txtIntNumberToConvert.Name = "txtIntNumberToConvert";
            this.txtIntNumberToConvert.Size = new System.Drawing.Size(150, 20);
            this.txtIntNumberToConvert.TabIndex = 59;
            this.txtIntNumberToConvert.TextChanged += new System.EventHandler(this.txtIntNumberToConvert_TextChanged);
            // 
            // rbCRC16Kermit
            // 
            this.rbCRC16Kermit.AutoSize = true;
            this.rbCRC16Kermit.Location = new System.Drawing.Point(343, 385);
            this.rbCRC16Kermit.Name = "rbCRC16Kermit";
            this.rbCRC16Kermit.Size = new System.Drawing.Size(88, 17);
            this.rbCRC16Kermit.TabIndex = 55;
            this.rbCRC16Kermit.Text = "CRC16Kermit";
            this.rbCRC16Kermit.UseVisualStyleBackColor = true;
            this.rbCRC16Kermit.Visible = false;
            // 
            // rbCRC16
            // 
            this.rbCRC16.AutoSize = true;
            this.rbCRC16.Location = new System.Drawing.Point(343, 408);
            this.rbCRC16.Name = "rbCRC16";
            this.rbCRC16.Size = new System.Drawing.Size(59, 17);
            this.rbCRC16.TabIndex = 56;
            this.rbCRC16.Text = "CRC16";
            this.rbCRC16.UseVisualStyleBackColor = true;
            this.rbCRC16.Visible = false;
            // 
            // rbMod95
            // 
            this.rbMod95.AutoSize = true;
            this.rbMod95.Location = new System.Drawing.Point(343, 431);
            this.rbMod95.Name = "rbMod95";
            this.rbMod95.Size = new System.Drawing.Size(62, 17);
            this.rbMod95.TabIndex = 57;
            this.rbMod95.Text = "MOD95";
            this.rbMod95.UseVisualStyleBackColor = true;
            this.rbMod95.Visible = false;
            // 
            // rbXOR
            // 
            this.rbXOR.AutoSize = true;
            this.rbXOR.Location = new System.Drawing.Point(343, 362);
            this.rbXOR.Name = "rbXOR";
            this.rbXOR.Size = new System.Drawing.Size(48, 17);
            this.rbXOR.TabIndex = 58;
            this.rbXOR.Text = "XOR";
            this.rbXOR.UseVisualStyleBackColor = true;
            this.rbXOR.Visible = false;
            // 
            // lblActiveTCPConnections
            // 
            this.lblActiveTCPConnections.FormattingEnabled = true;
            this.lblActiveTCPConnections.Location = new System.Drawing.Point(55, 447);
            this.lblActiveTCPConnections.Name = "lblActiveTCPConnections";
            this.lblActiveTCPConnections.Size = new System.Drawing.Size(255, 30);
            this.lblActiveTCPConnections.TabIndex = 54;
            this.lblActiveTCPConnections.Visible = false;
            // 
            // btnSendToConsole
            // 
            this.btnSendToConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToConsole.Location = new System.Drawing.Point(55, 391);
            this.btnSendToConsole.Name = "btnSendToConsole";
            this.btnSendToConsole.Size = new System.Drawing.Size(255, 23);
            this.btnSendToConsole.TabIndex = 52;
            this.btnSendToConsole.Text = "<< Send to Console";
            this.btnSendToConsole.UseVisualStyleBackColor = true;
            this.btnSendToConsole.Visible = false;
            // 
            // cbCheckSumTypes2
            // 
            this.cbCheckSumTypes2.FormattingEnabled = true;
            this.cbCheckSumTypes2.Items.AddRange(new object[] {
            "MOD95",
            "XOR",
            "CRC16",
            "CRC32"});
            this.cbCheckSumTypes2.Location = new System.Drawing.Point(55, 420);
            this.cbCheckSumTypes2.Name = "cbCheckSumTypes2";
            this.cbCheckSumTypes2.Size = new System.Drawing.Size(121, 21);
            this.cbCheckSumTypes2.TabIndex = 51;
            this.cbCheckSumTypes2.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(340, 333);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "CRC TYPE";
            this.label21.Visible = false;
            // 
            // tpErrorMessages
            // 
            this.tpErrorMessages.Controls.Add(this.txtConsole);
            this.tpErrorMessages.Controls.Add(this.toolStripErrorMessages);
            this.tpErrorMessages.Location = new System.Drawing.Point(4, 22);
            this.tpErrorMessages.Name = "tpErrorMessages";
            this.tpErrorMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tpErrorMessages.Size = new System.Drawing.Size(573, 559);
            this.tpErrorMessages.TabIndex = 3;
            this.tpErrorMessages.Text = "Error Messages";
            this.tpErrorMessages.UseVisualStyleBackColor = true;
            // 
            // txtConsole
            // 
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtConsole.Location = new System.Drawing.Point(3, 28);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(567, 528);
            this.txtConsole.TabIndex = 0;
            // 
            // toolStripErrorMessages
            // 
            this.toolStripErrorMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClearErrorMessages});
            this.toolStripErrorMessages.Location = new System.Drawing.Point(3, 3);
            this.toolStripErrorMessages.Name = "toolStripErrorMessages";
            this.toolStripErrorMessages.Size = new System.Drawing.Size(567, 25);
            this.toolStripErrorMessages.TabIndex = 1;
            this.toolStripErrorMessages.Text = "toolStrip1";
            // 
            // tsbClearErrorMessages
            // 
            this.tsbClearErrorMessages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClearErrorMessages.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearErrorMessages.Image")));
            this.tsbClearErrorMessages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearErrorMessages.Name = "tsbClearErrorMessages";
            this.tsbClearErrorMessages.Size = new System.Drawing.Size(38, 22);
            this.tsbClearErrorMessages.Text = "Clear";
            this.tsbClearErrorMessages.Click += new System.EventHandler(this.tsbClearErrorMessages_Click);
            // 
            // tlsMain2
            // 
            this.tlsMain2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbComPortSettings,
            this.tsbConnectToComPort});
            this.tlsMain2.Location = new System.Drawing.Point(0, 0);
            this.tlsMain2.Name = "tlsMain2";
            this.tlsMain2.Size = new System.Drawing.Size(581, 25);
            this.tlsMain2.TabIndex = 3;
            this.tlsMain2.Text = "toolStrip4";
            // 
            // tsbComPortSettings
            // 
            this.tsbComPortSettings.Image = global::DeviceTester.Properties.Resources.port_icon;
            this.tsbComPortSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbComPortSettings.Name = "tsbComPortSettings";
            this.tsbComPortSettings.Size = new System.Drawing.Size(123, 22);
            this.tsbComPortSettings.Text = "Com Port Settings";
            this.tsbComPortSettings.Click += new System.EventHandler(this.tsbComPortSettings_Click);
            // 
            // tsbConnectToComPort
            // 
            this.tsbConnectToComPort.Image = global::DeviceTester.Properties.Resources.red_light;
            this.tsbConnectToComPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnectToComPort.Name = "tsbConnectToComPort";
            this.tsbConnectToComPort.Size = new System.Drawing.Size(72, 22);
            this.tsbConnectToComPort.Text = "Connect";
            this.tsbConnectToComPort.Click += new System.EventHandler(this.tsbConnectToComPort_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 719);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.tlsMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.tlsSend);
            this.Controls.Add(this.statusStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Tester";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.cmsInstructionsGrid.ResumeLayout(false);
            this.tlsMain.ResumeLayout(false);
            this.tlsMain.PerformLayout();
            this.tlsSend.ResumeLayout(false);
            this.tlsSend.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.pnlInstructions.ResumeLayout(false);
            this.tbcDevice.ResumeLayout(false);
            this.tpDeviceCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructions)).EndInit();
            this.pnlDeviceInfo.ResumeLayout(false);
            this.pnlDeviceInfo.PerformLayout();
            this.tlsInstructionsGrid.ResumeLayout(false);
            this.tlsInstructionsGrid.PerformLayout();
            this.pnlInstructionsBottom.ResumeLayout(false);
            this.pnlInstructionsBottom.PerformLayout();
            this.tpDeviceInfo.ResumeLayout(false);
            this.tpDeviceInfo.PerformLayout();
            this.pnlDeviceInformation.ResumeLayout(false);
            this.pnlDeviceInformation.PerformLayout();
            this.tpCommandWorkbench.ResumeLayout(false);
            this.tpCommandWorkbench.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tlsCommandWorkbenchSend.ResumeLayout(false);
            this.tlsCommandWorkbenchSend.PerformLayout();
            this.tlsCommandWorkbench.ResumeLayout(false);
            this.tlsCommandWorkbench.PerformLayout();
            this.tpTimerCommandList.ResumeLayout(false);
            this.tpTimerCommandList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimerInstructions)).EndInit();
            this.tlsTimerCommandList.ResumeLayout(false);
            this.tlsTimerCommandList.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlsTimerCommandsControl.ResumeLayout(false);
            this.tlsTimerCommandsControl.PerformLayout();
            this.tpConsole.ResumeLayout(false);
            this.pnlConsoleBottom.ResumeLayout(false);
            this.pnlConsoleBottom.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tbcTools.ResumeLayout(false);
            this.tpIncomingBytes.ResumeLayout(false);
            this.tpIncomingBytes.PerformLayout();
            this.tbcIncomingBytes.ResumeLayout(false);
            this.tpTextView.ResumeLayout(false);
            this.tpTextView.PerformLayout();
            this.ctxHexBoxMenu.ResumeLayout(false);
            this.pnlBitsHolder.ResumeLayout(false);
            this.pnlBitsHolder.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingBytes)).EndInit();
            this.pnlBits.ResumeLayout(false);
            this.pnlBits.PerformLayout();
            this.tlsIncomingBytes.ResumeLayout(false);
            this.tlsIncomingBytes.PerformLayout();
            this.tpTools.ResumeLayout(false);
            this.tpTools.PerformLayout();
            this.pnlPythonTools.ResumeLayout(false);
            this.pnlPythonTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckSums)).EndInit();
            this.tpConvertor.ResumeLayout(false);
            this.tpConvertor.PerformLayout();
            this.tpErrorMessages.ResumeLayout(false);
            this.tpErrorMessages.PerformLayout();
            this.toolStripErrorMessages.ResumeLayout(false);
            this.toolStripErrorMessages.PerformLayout();
            this.tlsMain2.ResumeLayout(false);
            this.tlsMain2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.Timer tmrRequest;
        private System.Windows.Forms.TabControl tbcTools;
        private System.Windows.Forms.TabPage tpIncomingBytes;
        private System.Windows.Forms.TabPage tpTools;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtASCIIBytesInCHKCalculator;
        private System.Windows.Forms.TextBox txtHEXBytesInCHKCalculator;
        private System.Windows.Forms.TextBox txtDecimalBytesInCHKCalculator;
        private System.Windows.Forms.TabControl tbcDevice;
        private System.Windows.Forms.TabPage tpDeviceCommands;
        private System.Windows.Forms.DataGridView dgvInstructions;
        private System.Windows.Forms.Panel pnlDeviceInfo;
        private System.Windows.Forms.Panel pnlInstructionsBottom;
        private System.Windows.Forms.ToolStrip tlsSend;
        private System.Windows.Forms.ToolStripButton tsbSendBytesToDevice;
        private System.Windows.Forms.TabPage tpDeviceInfo;
        private System.Windows.Forms.Panel pnlDeviceInformation;
        private System.Windows.Forms.Label lblDeviceInformationTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtInstructionStructure;
        private System.Windows.Forms.TextBox txtCheckSumType;
        private System.Windows.Forms.TextBox txtDeviceExplanation;
        private System.Windows.Forms.ToolStrip tlsInstructionsGrid;
        private System.Windows.Forms.ToolStripButton tsbSendToTools;
        private System.Windows.Forms.ToolStripButton tsbCloneRow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage tpConsole;
        private System.Windows.Forms.Panel pnlConsoleBottom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripButton btnSNMPSend;
        private System.Windows.Forms.TabControl tbcIncomingBytes;
        private System.Windows.Forms.TabPage tpTextView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tpGridView;
        private System.Windows.Forms.DataGridView dgvIncomingBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ByteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASCII;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEX;
        private System.Windows.Forms.Panel pnlBits;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.ContextMenuStrip cmsInstructionsGrid;
        private System.Windows.Forms.ToolStripMenuItem cmiSendBytesToDevice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmiSendToTools;
        private System.Windows.Forms.ToolStripMenuItem cmiSendToBytesGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmiCloneCurrentRow;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.LinkLabel lnkUpdateDeviceInfo;
        private System.Windows.Forms.ToolStrip tlsMain2;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentXML;
        private System.Windows.Forms.ToolStripButton tsbComPortSettings;
        private System.Windows.Forms.ToolStripMenuItem cmiCalculateCheckSum;
        private System.Windows.Forms.CheckBox chkUseCheckSum;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectionType;
        private System.Windows.Forms.ToolStripButton tsbCalculateCheckSum;
        private System.Windows.Forms.ToolStripButton tsbTest;
        private System.Windows.Forms.ToolStripButton tsbConnectToComPort;
        private System.Windows.Forms.ToolStripStatusLabel lblComPortInfo;
        private System.Windows.Forms.ToolStrip tlsIncomingBytes;
        private System.Windows.Forms.ToolStripButton tsbClearIncomingBytes;
        private System.Windows.Forms.RadioButton rbConsoleIsInDosMode;
        private System.Windows.Forms.RadioButton rbConsoleIsInDeviceMode;
        private System.Windows.Forms.ToolStripMenuItem cmiSendBytesToConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbNewRow;
        private System.Windows.Forms.TabPage tpCommandWorkbench;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStrip tlsCommandWorkbench;
        private System.Windows.Forms.ToolStripButton tsbSendFromWorkbenchToTools;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tsbSaveWorkbenchText;
        private System.Windows.Forms.ToolStripButton tsbCalculateWorkbenchChk;
        private System.Windows.Forms.TextBox txtWorkbench;
        private System.Windows.Forms.ToolStrip tlsCommandWorkbenchSend;
        private System.Windows.Forms.ToolStripButton tsbSendFromWorkbench;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsbSendToGrid;
        private System.Windows.Forms.ToolStripMenuItem btnOpenXMLLocation;
        private System.Windows.Forms.ToolStripMenuItem btnOpenXMLFile;
        private System.Windows.Forms.ToolStrip tlsMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox txtCurrentIP;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox txtCurrentPort;
        private System.Windows.Forms.ToolStripButton tsbSaveIPPort;
        private System.Windows.Forms.ToolStripButton tsbLoadDeviceXML;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbConvertToHex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem btnCreateNewDeviceFile;
        private System.Windows.Forms.LinkLabel lnkSelectDOSCommand;
        private System.Windows.Forms.TextBox txtReceivedBytesASCII;
        private System.Windows.Forms.ToolStripButton tsbChangeMainConsoleStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton tsbSNMPSet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripStatusLabel lblCommandExecutionTime;
        private System.Windows.Forms.ToolStripButton tsbConnectToIP;
        private System.Windows.Forms.ToolStripButton tsbPing;
        private System.Windows.Forms.ToolStripButton tsbPingPort;
        private System.Windows.Forms.CheckBox chkCommandIsASCII;
        private System.Windows.Forms.Label lblTCPClientCommunicationTimeOut;
        private System.Windows.Forms.Label lblSendDelayTime;
        private System.Windows.Forms.TextBox txtTCPClientCommunicationTimeOut;
        private System.Windows.Forms.TextBox txtDelayTime;
        private System.Windows.Forms.Label lblBuildDate;
        private System.Windows.Forms.CheckBox chkConditionalReading;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndByte;
        private System.Windows.Forms.Label lblReadBufferSize;
        private System.Windows.Forms.TextBox txtReadBufferSize;
        private System.Windows.Forms.ToolStripButton tsbClearBeforeSend;
        private System.Windows.Forms.CheckBox chkSaveLog;
        private System.Windows.Forms.TextBox txtWorkbenchCurrentCommand;
        private System.Windows.Forms.Button btnCalculateCRCInHex;
        private System.Windows.Forms.DataGridView dgvCheckSums;
        private System.Windows.Forms.TabPage tpConvertor;
        private System.Windows.Forms.RadioButton rbCRC16Kermit;
        private System.Windows.Forms.RadioButton rbCRC16;
        private System.Windows.Forms.RadioButton rbMod95;
        private System.Windows.Forms.RadioButton rbXOR;
        private System.Windows.Forms.ListBox lblActiveTCPConnections;
        private System.Windows.Forms.Button btnSendToConsole;
        private System.Windows.Forms.ComboBox cbCheckSumTypes2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.LinkLabel lnkDelOneHexByte;
        private System.Windows.Forms.LinkLabel lnkClearHexBytes;
        private System.Windows.Forms.LinkLabel lnkSendToGrid;
        private System.Windows.Forms.TextBox txtConvertedBytes;
        private System.Windows.Forms.TextBox txtIntNumberToConvert;
        private System.Windows.Forms.TextBox txtSentCommand;
        private System.Windows.Forms.TabPage tpTimerCommandList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tlsTimerCommandsControl;
        private System.Windows.Forms.ToolStripButton tsbStartTimer;
        private System.Windows.Forms.ToolStripButton tsbStopTimer2;
        private System.Windows.Forms.DataGridView dgvTimerInstructions;
        private System.Windows.Forms.ToolStrip tlsTimerCommandList;
        private System.Windows.Forms.ToolStripButton tsbAddToTimerList;
        private System.Windows.Forms.ToolStripButton tsbRemoveTimerCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstructionBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Explanation;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtTimerInterval;
        private System.Windows.Forms.ToolStripButton tsbSetTimerInterval;
        private System.Windows.Forms.Timer tmrCounter;
        private SevenSegmentArray sevenSegmentArray2;
        private System.Windows.Forms.ToolStripButton tsbToogleCounterTimerInterval;
        private Be.Windows.Forms.HexBox hexReceivedBytes;
        private Chronometer chronometer1;
        private System.Windows.Forms.Panel pnlBitsHolder;
        private System.Windows.Forms.Label lblByteNo;
        private System.Windows.Forms.ToolStripMenuItem miHTTPTester;
        private System.Windows.Forms.ToolStripMenuItem miNetworkTools;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem miSSHTester;
        private System.Windows.Forms.ToolStripMenuItem miSuperConsole;
        private System.Windows.Forms.LinkLabel lnkGetComplement;
        private System.Windows.Forms.LinkLabel lnkCalculateCRC;
        private System.Windows.Forms.LinkLabel lnkApplyBCIP;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private ShellControl shellControl1;
        private System.Windows.Forms.RadioButton rbConsoleIsInASCIIMode;
        private System.Windows.Forms.ToolStripComboBox cbConnectionType;
        private System.Windows.Forms.ToolStripLabel tslConnectionType;
        private System.Windows.Forms.Panel pnlInstructionsTop;
        private BitDisplay bitDisplay1;
        private BitDisplay bitDisplay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckSumType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChecksumValue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel lblCurrentChecksumType;
        private System.Windows.Forms.ToolStripComboBox cbCheckSumTypes;
        private System.Windows.Forms.RadioButton rbConsoleIsInPythonMode;
        private System.Windows.Forms.ToolStripMenuItem miPythonConsole;
        private System.Windows.Forms.ListBox lbPyFiles;
        private System.Windows.Forms.RadioButton rbDouble;
        private System.Windows.Forms.RadioButton rbInt16;
        private System.Windows.Forms.RadioButton rbInt32;
        private System.Windows.Forms.TabPage tpErrorMessages;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.ToolStrip toolStripErrorMessages;
        private System.Windows.Forms.LinkLabel lmkEditPythonCode;
        private System.Windows.Forms.ToolStripButton tsbSendViaPython;
        private System.Windows.Forms.LinkLabel lnkReloadPythonFiles;
        private System.Windows.Forms.Panel pnlPythonTools;
        private System.Windows.Forms.Button btnApplyPythonCode;
        private System.Windows.Forms.ToolStripComboBox cbPythonSenders;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbErrorMessageClear;
        private System.Windows.Forms.ToolStripButton tsbClearErrorMessages;
        private System.Windows.Forms.ToolStripButton tsbMoveTimerRowUp;
        private System.Windows.Forms.ToolStripButton tsbMoveTimerRowDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton tsbShowLogs;
        private System.Windows.Forms.ContextMenuStrip ctxHexBoxMenu;
        private System.Windows.Forms.ToolStripMenuItem miCopyHexBoxToClipboard;
        private System.Windows.Forms.ToolStripButton tsbRunPythonInCommandPrompt;
        private System.Windows.Forms.ToolStripButton tsbGetPythonCommandLineText;
        private System.Windows.Forms.ToolStripMenuItem miCharMap;
    }
}

