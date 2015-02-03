namespace TCPDeviceTester
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentXML = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblConnectionType = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblComPortInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCommandExecutionTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenXMLLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenXMLFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateNewDeviceFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNetworkTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miPrepareCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.miGenerateCommandList = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.tbcDevice = new System.Windows.Forms.TabControl();
            this.tpDeviceCommands = new System.Windows.Forms.TabPage();
            this.chkUseCheckSum = new System.Windows.Forms.CheckBox();
            this.dgvInstructions = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiSendBytesToDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmiSendToTools = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiSendToBytesGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiSendBytesToConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmiCloneCurrentRow = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiCalculateCheckSum = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDeviceInfo = new System.Windows.Forms.Panel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbSendToTools = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNewRow = new System.Windows.Forms.ToolStripButton();
            this.tsbCloneRow = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCalculateCheckSum = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConvertToHex = new System.Windows.Forms.ToolStripButton();
            this.pnlInstructionsBottom = new System.Windows.Forms.Panel();
            this.chkConditionalReading = new System.Windows.Forms.CheckBox();
            this.chkCommandIsASCII = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReadBufferSize = new System.Windows.Forms.TextBox();
            this.txtTCPClientCommunicationTimeOut = new System.Windows.Forms.TextBox();
            this.txtDelayTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndByte = new System.Windows.Forms.TextBox();
            this.txtTimerInterval = new System.Windows.Forms.TextBox();
            this.lnkSetTimerInterval = new System.Windows.Forms.LinkLabel();
            this.chkTimerActive = new System.Windows.Forms.CheckBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSendBytesToDevice = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSNMPSend = new System.Windows.Forms.ToolStripButton();
            this.tsbSNMPSet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSendToComPort = new System.Windows.Forms.ToolStripButton();
            this.tsbStopTimer = new System.Windows.Forms.ToolStripButton();
            this.tpDeviceInfo = new System.Windows.Forms.TabPage();
            this.lblBuildDate = new System.Windows.Forms.Label();
            this.lnkUpdateDeviceInfo = new System.Windows.Forms.LinkLabel();
            this.pnlDeviceInformation = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.txtInstructionStructure = new System.Windows.Forms.TextBox();
            this.txtCheckSumType = new System.Windows.Forms.TextBox();
            this.txtDeviceExplanation = new System.Windows.Forms.TextBox();
            this.tpConsole = new System.Windows.Forms.TabPage();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.pnlConsoleBottom = new System.Windows.Forms.Panel();
            this.lnkSelectDOSCommand = new System.Windows.Forms.LinkLabel();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.tsbClearConsole = new System.Windows.Forms.ToolStripButton();
            this.tsbCalculateConsoleCheckSum = new System.Windows.Forms.ToolStripButton();
            this.tsbChangeConsoleStyle = new System.Windows.Forms.ToolStripButton();
            this.lblCaretPosition = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbDosMode = new System.Windows.Forms.RadioButton();
            this.rbDeviceMode = new System.Windows.Forms.RadioButton();
            this.tpCommandWorkbench = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolStrip7 = new System.Windows.Forms.ToolStrip();
            this.tsbSendFromWorkbench = new System.Windows.Forms.ToolStripButton();
            this.txtWorkbench = new System.Windows.Forms.TextBox();
            this.toolStrip6 = new System.Windows.Forms.ToolStrip();
            this.tsbSaveWorkbenchText = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCalculateWorkbenchChk = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSendToGrid = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripIPPort = new System.Windows.Forms.ToolStrip();
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
            this.tbcTools = new System.Windows.Forms.TabControl();
            this.tpIncomingBytes = new System.Windows.Forms.TabPage();
            this.tbcIncomingBytes = new System.Windows.Forms.TabControl();
            this.tpTextView = new System.Windows.Forms.TabPage();
            this.txtReceivedBytes = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkSaveLog = new System.Windows.Forms.CheckBox();
            this.txtReceivedBytesHex = new System.Windows.Forms.TextBox();
            this.lblHEX = new System.Windows.Forms.Label();
            this.txtReceivedBytesASCII = new System.Windows.Forms.TextBox();
            this.lblASCII = new System.Windows.Forms.Label();
            this.tpGridView = new System.Windows.Forms.TabPage();
            this.dgvIncomingBytes = new System.Windows.Forms.DataGridView();
            this.ByteNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASCII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBits = new System.Windows.Forms.Panel();
            this.dgvBits = new System.Windows.Forms.DataGridView();
            this.Bit7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bit0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBits = new System.Windows.Forms.Label();
            this.txtBits = new System.Windows.Forms.TextBox();
            this.tpStatusBits = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClearIncomingBytes = new System.Windows.Forms.ToolStripButton();
            this.tsbChangeMainConsoleStyle = new System.Windows.Forms.ToolStripButton();
            this.tsbClearBeforeSend = new System.Windows.Forms.ToolStripButton();
            this.tpTools = new System.Windows.Forms.TabPage();
            this.rbCRC16Kermit = new System.Windows.Forms.RadioButton();
            this.rbCRC16 = new System.Windows.Forms.RadioButton();
            this.rbSendToGridHex = new System.Windows.Forms.RadioButton();
            this.rbMod95 = new System.Windows.Forms.RadioButton();
            this.rbSendToGridDecimal = new System.Windows.Forms.RadioButton();
            this.rbXOR = new System.Windows.Forms.RadioButton();
            this.lblActiveTCPConnections = new System.Windows.Forms.ListBox();
            this.btnActiveTCPConnections = new System.Windows.Forms.Button();
            this.btnSendToConsole = new System.Windows.Forms.Button();
            this.btnSendToGrid = new System.Windows.Forms.Button();
            this.btnCalculateCRC = new System.Windows.Forms.Button();
            this.cbCheckSumTypes2 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtASCIIBytes = new System.Windows.Forms.TextBox();
            this.txtHEXBytes = new System.Windows.Forms.TextBox();
            this.txtDecimalBytes = new System.Windows.Forms.TextBox();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cbCheckSumTypes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbComPortSettings = new System.Windows.Forms.ToolStripButton();
            this.tsbConnectToComPort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.cbCommunicationType = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tmrRequest = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlInstructions.SuspendLayout();
            this.tbcDevice.SuspendLayout();
            this.tpDeviceCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructions)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlDeviceInfo.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.pnlInstructionsBottom.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tpDeviceInfo.SuspendLayout();
            this.pnlDeviceInformation.SuspendLayout();
            this.tpConsole.SuspendLayout();
            this.pnlConsoleBottom.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tpCommandWorkbench.SuspendLayout();
            this.panel5.SuspendLayout();
            this.toolStrip7.SuspendLayout();
            this.toolStrip6.SuspendLayout();
            this.toolStripIPPort.SuspendLayout();
            this.tbcTools.SuspendLayout();
            this.tpIncomingBytes.SuspendLayout();
            this.tbcIncomingBytes.SuspendLayout();
            this.tpTextView.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingBytes)).BeginInit();
            this.pnlBits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBits)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tpTools.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblCurrentXML,
            this.lblConnectionType,
            this.lblComPortInfo,
            this.lblCommandExecutionTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 644);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1049, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.btnOpenXMLLocation,
            this.btnOpenXMLFile,
            this.btnCreateNewDeviceFile,
            this.btnNetworkTools});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnOpenXMLLocation
            // 
            this.btnOpenXMLLocation.Name = "btnOpenXMLLocation";
            this.btnOpenXMLLocation.Size = new System.Drawing.Size(194, 22);
            this.btnOpenXMLLocation.Text = "Open XML Location";
            this.btnOpenXMLLocation.Click += new System.EventHandler(this.btnOpenXMLLocation_Click);
            // 
            // btnOpenXMLFile
            // 
            this.btnOpenXMLFile.Name = "btnOpenXMLFile";
            this.btnOpenXMLFile.Size = new System.Drawing.Size(194, 22);
            this.btnOpenXMLFile.Text = "Open XML File";
            this.btnOpenXMLFile.Click += new System.EventHandler(this.btnOpenXMLFile_Click);
            // 
            // btnCreateNewDeviceFile
            // 
            this.btnCreateNewDeviceFile.Name = "btnCreateNewDeviceFile";
            this.btnCreateNewDeviceFile.Size = new System.Drawing.Size(194, 22);
            this.btnCreateNewDeviceFile.Text = "Create New Device File";
            this.btnCreateNewDeviceFile.Click += new System.EventHandler(this.btnCreateNewDeviceFile_Click);
            // 
            // btnNetworkTools
            // 
            this.btnNetworkTools.Name = "btnNetworkTools";
            this.btnNetworkTools.Size = new System.Drawing.Size(194, 22);
            this.btnNetworkTools.Text = "Network Tools";
            this.btnNetworkTools.Click += new System.EventHandler(this.btnNetworkTools_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPrepareCommand,
            this.miGenerateCommandList});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // miPrepareCommand
            // 
            this.miPrepareCommand.Name = "miPrepareCommand";
            this.miPrepareCommand.Size = new System.Drawing.Size(202, 22);
            this.miPrepareCommand.Text = "Prepare Command";
            this.miPrepareCommand.Click += new System.EventHandler(this.miPrepareCommand_Click);
            // 
            // miGenerateCommandList
            // 
            this.miGenerateCommandList.Name = "miGenerateCommandList";
            this.miGenerateCommandList.Size = new System.Drawing.Size(202, 22);
            this.miGenerateCommandList.Text = "Generate Command List";
            this.miGenerateCommandList.Click += new System.EventHandler(this.miGenerateCommandList_Click);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlInstructions);
            this.splitContainer1.Panel1.Controls.Add(this.toolStripIPPort);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbcTools);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip4);
            this.splitContainer1.Size = new System.Drawing.Size(1049, 620);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 2;
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.Controls.Add(this.tbcDevice);
            this.pnlInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInstructions.Location = new System.Drawing.Point(0, 25);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(500, 595);
            this.pnlInstructions.TabIndex = 2;
            // 
            // tbcDevice
            // 
            this.tbcDevice.Controls.Add(this.tpDeviceCommands);
            this.tbcDevice.Controls.Add(this.tpDeviceInfo);
            this.tbcDevice.Controls.Add(this.tpConsole);
            this.tbcDevice.Controls.Add(this.tpCommandWorkbench);
            this.tbcDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcDevice.HotTrack = true;
            this.tbcDevice.ItemSize = new System.Drawing.Size(101, 25);
            this.tbcDevice.Location = new System.Drawing.Point(0, 0);
            this.tbcDevice.Name = "tbcDevice";
            this.tbcDevice.SelectedIndex = 0;
            this.tbcDevice.Size = new System.Drawing.Size(500, 595);
            this.tbcDevice.TabIndex = 0;
            this.tbcDevice.SelectedIndexChanged += new System.EventHandler(this.tbcDevice_SelectedIndexChanged);
            // 
            // tpDeviceCommands
            // 
            this.tpDeviceCommands.Controls.Add(this.chkUseCheckSum);
            this.tpDeviceCommands.Controls.Add(this.dgvInstructions);
            this.tpDeviceCommands.Controls.Add(this.pnlDeviceInfo);
            this.tpDeviceCommands.Controls.Add(this.pnlInstructionsBottom);
            this.tpDeviceCommands.Controls.Add(this.toolStrip2);
            this.tpDeviceCommands.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDeviceCommands.Location = new System.Drawing.Point(4, 29);
            this.tpDeviceCommands.Name = "tpDeviceCommands";
            this.tpDeviceCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeviceCommands.Size = new System.Drawing.Size(492, 562);
            this.tpDeviceCommands.TabIndex = 0;
            this.tpDeviceCommands.Text = "Device Commands";
            this.tpDeviceCommands.UseVisualStyleBackColor = true;
            // 
            // chkUseCheckSum
            // 
            this.chkUseCheckSum.AutoSize = true;
            this.chkUseCheckSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkUseCheckSum.Location = new System.Drawing.Point(387, 415);
            this.chkUseCheckSum.Name = "chkUseCheckSum";
            this.chkUseCheckSum.Size = new System.Drawing.Size(99, 17);
            this.chkUseCheckSum.TabIndex = 2;
            this.chkUseCheckSum.Text = "Add checkSum";
            this.chkUseCheckSum.UseVisualStyleBackColor = true;
            this.chkUseCheckSum.Visible = false;
            // 
            // dgvInstructions
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvInstructions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInstructions.BackgroundColor = System.Drawing.Color.White;
            this.dgvInstructions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInstructions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInstructions.ColumnHeadersHeight = 30;
            this.dgvInstructions.ContextMenuStrip = this.contextMenuStrip1;
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
            this.dgvInstructions.Size = new System.Drawing.Size(486, 406);
            this.dgvInstructions.TabIndex = 3;
            this.dgvInstructions.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInstructions_CellBeginEdit);
            this.dgvInstructions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstructions_CellContentClick);
            this.dgvInstructions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInstructions_CellEndEdit);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiSendBytesToDevice,
            this.toolStripSeparator2,
            this.cmiSendToTools,
            this.cmiSendToBytesGrid,
            this.cmiSendBytesToConsole,
            this.toolStripSeparator3,
            this.cmiCloneCurrentRow,
            this.cmiCalculateCheckSum});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 148);
            // 
            // cmiSendBytesToDevice
            // 
            this.cmiSendBytesToDevice.Name = "cmiSendBytesToDevice";
            this.cmiSendBytesToDevice.Size = new System.Drawing.Size(194, 22);
            this.cmiSendBytesToDevice.Text = "Send Bytes To Device";
            this.cmiSendBytesToDevice.Click += new System.EventHandler(this.cmiSendBytesToDevice_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // cmiSendToTools
            // 
            this.cmiSendToTools.Name = "cmiSendToTools";
            this.cmiSendToTools.Size = new System.Drawing.Size(194, 22);
            this.cmiSendToTools.Text = "Send To Tools";
            this.cmiSendToTools.Click += new System.EventHandler(this.cmiSendToTools_Click);
            // 
            // cmiSendToBytesGrid
            // 
            this.cmiSendToBytesGrid.Name = "cmiSendToBytesGrid";
            this.cmiSendToBytesGrid.Size = new System.Drawing.Size(194, 22);
            this.cmiSendToBytesGrid.Text = "Send To Bytes Grid";
            this.cmiSendToBytesGrid.Click += new System.EventHandler(this.cmiSendToBytesGrid_Click);
            // 
            // cmiSendBytesToConsole
            // 
            this.cmiSendBytesToConsole.Name = "cmiSendBytesToConsole";
            this.cmiSendBytesToConsole.Size = new System.Drawing.Size(194, 22);
            this.cmiSendBytesToConsole.Text = "Send Bytes To Console";
            this.cmiSendBytesToConsole.Click += new System.EventHandler(this.cmiSendBytesToConsole_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
            // 
            // cmiCloneCurrentRow
            // 
            this.cmiCloneCurrentRow.Name = "cmiCloneCurrentRow";
            this.cmiCloneCurrentRow.Size = new System.Drawing.Size(194, 22);
            this.cmiCloneCurrentRow.Text = "Clone Current Row";
            this.cmiCloneCurrentRow.Click += new System.EventHandler(this.cmiCloneCurrentRow_Click);
            // 
            // cmiCalculateCheckSum
            // 
            this.cmiCalculateCheckSum.Name = "cmiCalculateCheckSum";
            this.cmiCalculateCheckSum.Size = new System.Drawing.Size(194, 22);
            this.cmiCalculateCheckSum.Text = "Calculate Check Sum";
            this.cmiCalculateCheckSum.Click += new System.EventHandler(this.cmiCalculateCheckSum_Click);
            // 
            // pnlDeviceInfo
            // 
            this.pnlDeviceInfo.Controls.Add(this.toolStrip3);
            this.pnlDeviceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeviceInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlDeviceInfo.Name = "pnlDeviceInfo";
            this.pnlDeviceInfo.Size = new System.Drawing.Size(486, 29);
            this.pnlDeviceInfo.TabIndex = 5;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSendToTools,
            this.toolStripSeparator8,
            this.tsbNewRow,
            this.tsbCloneRow,
            this.toolStripSeparator1,
            this.tsbCalculateCheckSum,
            this.toolStripSeparator11,
            this.tsbConvertToHex});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(486, 25);
            this.toolStrip3.TabIndex = 15;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsbSendToTools
            // 
            this.tsbSendToTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSendToTools.Image = ((System.Drawing.Image)(resources.GetObject("tsbSendToTools.Image")));
            this.tsbSendToTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendToTools.Name = "tsbSendToTools";
            this.tsbSendToTools.Size = new System.Drawing.Size(86, 22);
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
            // tsbConvertToHex
            // 
            this.tsbConvertToHex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbConvertToHex.Image = ((System.Drawing.Image)(resources.GetObject("tsbConvertToHex.Image")));
            this.tsbConvertToHex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConvertToHex.Name = "tsbConvertToHex";
            this.tsbConvertToHex.Size = new System.Drawing.Size(93, 22);
            this.tsbConvertToHex.Text = "Convert To Hex";
            this.tsbConvertToHex.Click += new System.EventHandler(this.tsbConvertToHex_Click);
            // 
            // pnlInstructionsBottom
            // 
            this.pnlInstructionsBottom.BackColor = System.Drawing.Color.LightGray;
            this.pnlInstructionsBottom.Controls.Add(this.chkConditionalReading);
            this.pnlInstructionsBottom.Controls.Add(this.chkCommandIsASCII);
            this.pnlInstructionsBottom.Controls.Add(this.label10);
            this.pnlInstructionsBottom.Controls.Add(this.label8);
            this.pnlInstructionsBottom.Controls.Add(this.label1);
            this.pnlInstructionsBottom.Controls.Add(this.txtReadBufferSize);
            this.pnlInstructionsBottom.Controls.Add(this.txtTCPClientCommunicationTimeOut);
            this.pnlInstructionsBottom.Controls.Add(this.txtDelayTime);
            this.pnlInstructionsBottom.Controls.Add(this.label9);
            this.pnlInstructionsBottom.Controls.Add(this.label2);
            this.pnlInstructionsBottom.Controls.Add(this.txtEndByte);
            this.pnlInstructionsBottom.Controls.Add(this.txtTimerInterval);
            this.pnlInstructionsBottom.Controls.Add(this.lnkSetTimerInterval);
            this.pnlInstructionsBottom.Controls.Add(this.chkTimerActive);
            this.pnlInstructionsBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInstructionsBottom.Location = new System.Drawing.Point(3, 438);
            this.pnlInstructionsBottom.Name = "pnlInstructionsBottom";
            this.pnlInstructionsBottom.Size = new System.Drawing.Size(486, 96);
            this.pnlInstructionsBottom.TabIndex = 6;
            // 
            // chkConditionalReading
            // 
            this.chkConditionalReading.AutoSize = true;
            this.chkConditionalReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConditionalReading.ForeColor = System.Drawing.Color.Black;
            this.chkConditionalReading.Location = new System.Drawing.Point(283, 50);
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
            this.chkCommandIsASCII.Location = new System.Drawing.Point(283, 30);
            this.chkCommandIsASCII.Name = "chkCommandIsASCII";
            this.chkCommandIsASCII.Size = new System.Drawing.Size(113, 17);
            this.chkCommandIsASCII.TabIndex = 33;
            this.chkCommandIsASCII.Text = "Command is ASCII";
            this.chkCommandIsASCII.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(14, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 11);
            this.label10.TabIndex = 32;
            this.label10.Text = "Read Buffer Size";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 11);
            this.label8.TabIndex = 32;
            this.label8.Text = "TCPClientCommunicationTimeOut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 11);
            this.label1.TabIndex = 31;
            this.label1.Text = "Send Delay Time";
            // 
            // txtReadBufferSize
            // 
            this.txtReadBufferSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReadBufferSize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReadBufferSize.Location = new System.Drawing.Point(181, 58);
            this.txtReadBufferSize.Name = "txtReadBufferSize";
            this.txtReadBufferSize.Size = new System.Drawing.Size(50, 14);
            this.txtReadBufferSize.TabIndex = 29;
            this.txtReadBufferSize.Text = "100";
            // 
            // txtTCPClientCommunicationTimeOut
            // 
            this.txtTCPClientCommunicationTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTCPClientCommunicationTimeOut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCPClientCommunicationTimeOut.Location = new System.Drawing.Point(181, 42);
            this.txtTCPClientCommunicationTimeOut.Name = "txtTCPClientCommunicationTimeOut";
            this.txtTCPClientCommunicationTimeOut.Size = new System.Drawing.Size(50, 14);
            this.txtTCPClientCommunicationTimeOut.TabIndex = 29;
            this.txtTCPClientCommunicationTimeOut.Text = "500";
            // 
            // txtDelayTime
            // 
            this.txtDelayTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDelayTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDelayTime.Location = new System.Drawing.Point(181, 26);
            this.txtDelayTime.Name = "txtDelayTime";
            this.txtDelayTime.Size = new System.Drawing.Size(50, 14);
            this.txtDelayTime.TabIndex = 30;
            this.txtDelayTime.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "End Byte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 11);
            this.label2.TabIndex = 28;
            this.label2.Text = "Timer Interval";
            // 
            // txtEndByte
            // 
            this.txtEndByte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndByte.Location = new System.Drawing.Point(333, 71);
            this.txtEndByte.Name = "txtEndByte";
            this.txtEndByte.Size = new System.Drawing.Size(28, 13);
            this.txtEndByte.TabIndex = 27;
            this.txtEndByte.Text = "3";
            // 
            // txtTimerInterval
            // 
            this.txtTimerInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimerInterval.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTimerInterval.Location = new System.Drawing.Point(181, 10);
            this.txtTimerInterval.Name = "txtTimerInterval";
            this.txtTimerInterval.Size = new System.Drawing.Size(50, 14);
            this.txtTimerInterval.TabIndex = 27;
            this.txtTimerInterval.Text = "1000";
            // 
            // lnkSetTimerInterval
            // 
            this.lnkSetTimerInterval.AutoSize = true;
            this.lnkSetTimerInterval.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSetTimerInterval.Location = new System.Drawing.Point(237, 10);
            this.lnkSetTimerInterval.Name = "lnkSetTimerInterval";
            this.lnkSetTimerInterval.Size = new System.Drawing.Size(28, 13);
            this.lnkSetTimerInterval.TabIndex = 26;
            this.lnkSetTimerInterval.TabStop = true;
            this.lnkSetTimerInterval.Text = "Set";
            this.lnkSetTimerInterval.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSetTimerInterval_LinkClicked);
            // 
            // chkTimerActive
            // 
            this.chkTimerActive.AutoSize = true;
            this.chkTimerActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkTimerActive.ForeColor = System.Drawing.Color.Black;
            this.chkTimerActive.Location = new System.Drawing.Point(283, 9);
            this.chkTimerActive.Name = "chkTimerActive";
            this.chkTimerActive.Size = new System.Drawing.Size(85, 17);
            this.chkTimerActive.TabIndex = 16;
            this.chkTimerActive.Text = "Timer Active";
            this.chkTimerActive.UseVisualStyleBackColor = true;
            this.chkTimerActive.CheckedChanged += new System.EventHandler(this.chkTimerActive_CheckedChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSendBytesToDevice,
            this.toolStripSeparator13,
            this.btnSNMPSend,
            this.tsbSNMPSet,
            this.toolStripSeparator12,
            this.tsbSendToComPort,
            this.tsbStopTimer});
            this.toolStrip2.Location = new System.Drawing.Point(3, 534);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(486, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbSendBytesToDevice
            // 
            this.tsbSendBytesToDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbSendBytesToDevice.Image = ((System.Drawing.Image)(resources.GetObject("tsbSendBytesToDevice.Image")));
            this.tsbSendBytesToDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendBytesToDevice.Name = "tsbSendBytesToDevice";
            this.tsbSendBytesToDevice.Size = new System.Drawing.Size(108, 22);
            this.tsbSendBytesToDevice.Text = "Send To Device";
            this.tsbSendBytesToDevice.Click += new System.EventHandler(this.tsbSendBytesToDevice_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSNMPSend
            // 
            this.btnSNMPSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSNMPSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSNMPSend.Image")));
            this.btnSNMPSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSNMPSend.Name = "btnSNMPSend";
            this.btnSNMPSend.Size = new System.Drawing.Size(65, 22);
            this.btnSNMPSend.Text = "SNMP Get";
            this.btnSNMPSend.Click += new System.EventHandler(this.btnSNMPSend_Click);
            // 
            // tsbSNMPSet
            // 
            this.tsbSNMPSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSNMPSet.Image = ((System.Drawing.Image)(resources.GetObject("tsbSNMPSet.Image")));
            this.tsbSNMPSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSNMPSet.Name = "tsbSNMPSet";
            this.tsbSNMPSet.Size = new System.Drawing.Size(63, 22);
            this.tsbSNMPSet.Text = "SNMP Set";
            this.tsbSNMPSet.Click += new System.EventHandler(this.tsbSNMPSet_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSendToComPort
            // 
            this.tsbSendToComPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSendToComPort.Image = ((System.Drawing.Image)(resources.GetObject("tsbSendToComPort.Image")));
            this.tsbSendToComPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendToComPort.Name = "tsbSendToComPort";
            this.tsbSendToComPort.Size = new System.Drawing.Size(105, 22);
            this.tsbSendToComPort.Text = "Send to Com Port";
            this.tsbSendToComPort.Visible = false;
            this.tsbSendToComPort.Click += new System.EventHandler(this.tsbSendToComPort_Click);
            // 
            // tsbStopTimer
            // 
            this.tsbStopTimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStopTimer.Image = ((System.Drawing.Image)(resources.GetObject("tsbStopTimer.Image")));
            this.tsbStopTimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStopTimer.Name = "tsbStopTimer";
            this.tsbStopTimer.Size = new System.Drawing.Size(69, 22);
            this.tsbStopTimer.Text = "Stop Timer";
            this.tsbStopTimer.Click += new System.EventHandler(this.tsbStopTimer_Click);
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
            this.tpDeviceInfo.Size = new System.Drawing.Size(492, 562);
            this.tpDeviceInfo.TabIndex = 1;
            this.tpDeviceInfo.Text = "Device Info";
            this.tpDeviceInfo.UseVisualStyleBackColor = true;
            // 
            // lblBuildDate
            // 
            this.lblBuildDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBuildDate.AutoSize = true;
            this.lblBuildDate.Location = new System.Drawing.Point(8, 534);
            this.lblBuildDate.Name = "lblBuildDate";
            this.lblBuildDate.Size = new System.Drawing.Size(85, 13);
            this.lblBuildDate.TabIndex = 24;
            this.lblBuildDate.Text = "Build Date : ";
            this.lblBuildDate.UseMnemonic = false;
            // 
            // lnkUpdateDeviceInfo
            // 
            this.lnkUpdateDeviceInfo.AutoSize = true;
            this.lnkUpdateDeviceInfo.Location = new System.Drawing.Point(121, 206);
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
            this.pnlDeviceInformation.Controls.Add(this.label3);
            this.pnlDeviceInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDeviceInformation.Location = new System.Drawing.Point(3, 3);
            this.pnlDeviceInformation.Name = "pnlDeviceInformation";
            this.pnlDeviceInformation.Size = new System.Drawing.Size(486, 24);
            this.pnlDeviceInformation.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Device Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Command Structure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Check Sum Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Device Explanation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Device Name";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeviceName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceName.Location = new System.Drawing.Point(124, 41);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(145, 21);
            this.txtDeviceName.TabIndex = 14;
            // 
            // txtInstructionStructure
            // 
            this.txtInstructionStructure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstructionStructure.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstructionStructure.Location = new System.Drawing.Point(124, 119);
            this.txtInstructionStructure.Multiline = true;
            this.txtInstructionStructure.Name = "txtInstructionStructure";
            this.txtInstructionStructure.Size = new System.Drawing.Size(348, 84);
            this.txtInstructionStructure.TabIndex = 16;
            // 
            // txtCheckSumType
            // 
            this.txtCheckSumType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCheckSumType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckSumType.Location = new System.Drawing.Point(124, 93);
            this.txtCheckSumType.Name = "txtCheckSumType";
            this.txtCheckSumType.Size = new System.Drawing.Size(145, 21);
            this.txtCheckSumType.TabIndex = 17;
            // 
            // txtDeviceExplanation
            // 
            this.txtDeviceExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeviceExplanation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceExplanation.Location = new System.Drawing.Point(124, 67);
            this.txtDeviceExplanation.Name = "txtDeviceExplanation";
            this.txtDeviceExplanation.Size = new System.Drawing.Size(145, 21);
            this.txtDeviceExplanation.TabIndex = 15;
            // 
            // tpConsole
            // 
            this.tpConsole.Controls.Add(this.txtConsole);
            this.tpConsole.Controls.Add(this.pnlConsoleBottom);
            this.tpConsole.Controls.Add(this.panel4);
            this.tpConsole.Location = new System.Drawing.Point(4, 29);
            this.tpConsole.Name = "tpConsole";
            this.tpConsole.Size = new System.Drawing.Size(492, 562);
            this.tpConsole.TabIndex = 3;
            this.tpConsole.Text = "Console";
            this.tpConsole.UseVisualStyleBackColor = true;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsole.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.White;
            this.txtConsole.Location = new System.Drawing.Point(0, 24);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(492, 483);
            this.txtConsole.TabIndex = 24;
            this.txtConsole.Text = ">";
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            this.txtConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsole_KeyDown);
            this.txtConsole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsole_KeyPress);
            // 
            // pnlConsoleBottom
            // 
            this.pnlConsoleBottom.Controls.Add(this.lnkSelectDOSCommand);
            this.pnlConsoleBottom.Controls.Add(this.toolStrip5);
            this.pnlConsoleBottom.Controls.Add(this.lblCaretPosition);
            this.pnlConsoleBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConsoleBottom.Location = new System.Drawing.Point(0, 507);
            this.pnlConsoleBottom.Name = "pnlConsoleBottom";
            this.pnlConsoleBottom.Size = new System.Drawing.Size(492, 55);
            this.pnlConsoleBottom.TabIndex = 25;
            // 
            // lnkSelectDOSCommand
            // 
            this.lnkSelectDOSCommand.AutoSize = true;
            this.lnkSelectDOSCommand.Location = new System.Drawing.Point(358, 7);
            this.lnkSelectDOSCommand.Name = "lnkSelectDOSCommand";
            this.lnkSelectDOSCommand.Size = new System.Drawing.Size(113, 13);
            this.lnkSelectDOSCommand.TabIndex = 5;
            this.lnkSelectDOSCommand.TabStop = true;
            this.lnkSelectDOSCommand.Text = "Select DOS Command";
            this.lnkSelectDOSCommand.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectDOSCommand_LinkClicked);
            // 
            // toolStrip5
            // 
            this.toolStrip5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClearConsole,
            this.tsbCalculateConsoleCheckSum,
            this.tsbChangeConsoleStyle});
            this.toolStrip5.Location = new System.Drawing.Point(0, 30);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(492, 25);
            this.toolStrip5.TabIndex = 4;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // tsbClearConsole
            // 
            this.tsbClearConsole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClearConsole.Image = ((System.Drawing.Image)(resources.GetObject("tsbClearConsole.Image")));
            this.tsbClearConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearConsole.Name = "tsbClearConsole";
            this.tsbClearConsole.Size = new System.Drawing.Size(38, 22);
            this.tsbClearConsole.Text = "Clear";
            this.tsbClearConsole.Click += new System.EventHandler(this.tsbClearConsole_Click);
            // 
            // tsbCalculateConsoleCheckSum
            // 
            this.tsbCalculateConsoleCheckSum.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCalculateConsoleCheckSum.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalculateConsoleCheckSum.Image")));
            this.tsbCalculateConsoleCheckSum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalculateConsoleCheckSum.Name = "tsbCalculateConsoleCheckSum";
            this.tsbCalculateConsoleCheckSum.Size = new System.Drawing.Size(123, 22);
            this.tsbCalculateConsoleCheckSum.Text = "Calculate Check Sum";
            this.tsbCalculateConsoleCheckSum.Click += new System.EventHandler(this.tsbCalculateConsoleCheckSum_Click);
            // 
            // tsbChangeConsoleStyle
            // 
            this.tsbChangeConsoleStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChangeConsoleStyle.Image = ((System.Drawing.Image)(resources.GetObject("tsbChangeConsoleStyle.Image")));
            this.tsbChangeConsoleStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChangeConsoleStyle.Name = "tsbChangeConsoleStyle";
            this.tsbChangeConsoleStyle.Size = new System.Drawing.Size(80, 22);
            this.tsbChangeConsoleStyle.Text = "Change Style";
            this.tsbChangeConsoleStyle.Click += new System.EventHandler(this.tsbChangeConsoleStyle_Click);
            // 
            // lblCaretPosition
            // 
            this.lblCaretPosition.AutoSize = true;
            this.lblCaretPosition.Location = new System.Drawing.Point(8, 10);
            this.lblCaretPosition.Name = "lblCaretPosition";
            this.lblCaretPosition.Size = new System.Drawing.Size(16, 13);
            this.lblCaretPosition.TabIndex = 3;
            this.lblCaretPosition.Text = "...";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.rbDosMode);
            this.panel4.Controls.Add(this.rbDeviceMode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 24);
            this.panel4.TabIndex = 23;
            // 
            // rbDosMode
            // 
            this.rbDosMode.AutoSize = true;
            this.rbDosMode.Location = new System.Drawing.Point(128, 4);
            this.rbDosMode.Name = "rbDosMode";
            this.rbDosMode.Size = new System.Drawing.Size(103, 17);
            this.rbDosMode.TabIndex = 17;
            this.rbDosMode.Text = "DOS Commands";
            this.rbDosMode.UseVisualStyleBackColor = true;
            this.rbDosMode.CheckedChanged += new System.EventHandler(this.rbDosMode_CheckedChanged);
            // 
            // rbDeviceMode
            // 
            this.rbDeviceMode.AutoSize = true;
            this.rbDeviceMode.Checked = true;
            this.rbDeviceMode.Location = new System.Drawing.Point(8, 4);
            this.rbDeviceMode.Name = "rbDeviceMode";
            this.rbDeviceMode.Size = new System.Drawing.Size(114, 17);
            this.rbDeviceMode.TabIndex = 16;
            this.rbDeviceMode.TabStop = true;
            this.rbDeviceMode.Text = "Device Commands";
            this.rbDeviceMode.UseVisualStyleBackColor = true;
            this.rbDeviceMode.CheckedChanged += new System.EventHandler(this.rbDeviceMode_CheckedChanged);
            // 
            // tpCommandWorkbench
            // 
            this.tpCommandWorkbench.Controls.Add(this.panel5);
            this.tpCommandWorkbench.Controls.Add(this.txtWorkbench);
            this.tpCommandWorkbench.Controls.Add(this.toolStrip6);
            this.tpCommandWorkbench.Location = new System.Drawing.Point(4, 29);
            this.tpCommandWorkbench.Name = "tpCommandWorkbench";
            this.tpCommandWorkbench.Size = new System.Drawing.Size(492, 562);
            this.tpCommandWorkbench.TabIndex = 4;
            this.tpCommandWorkbench.Text = "Command Workbench";
            this.tpCommandWorkbench.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.toolStrip7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 513);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(492, 49);
            this.panel5.TabIndex = 17;
            // 
            // toolStrip7
            // 
            this.toolStrip7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSendFromWorkbench});
            this.toolStrip7.Location = new System.Drawing.Point(0, 24);
            this.toolStrip7.Name = "toolStrip7";
            this.toolStrip7.Size = new System.Drawing.Size(492, 25);
            this.toolStrip7.TabIndex = 5;
            this.toolStrip7.Text = "toolStrip7";
            // 
            // tsbSendFromWorkbench
            // 
            this.tsbSendFromWorkbench.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbSendFromWorkbench.Image = ((System.Drawing.Image)(resources.GetObject("tsbSendFromWorkbench.Image")));
            this.tsbSendFromWorkbench.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSendFromWorkbench.Name = "tsbSendFromWorkbench";
            this.tsbSendFromWorkbench.Size = new System.Drawing.Size(108, 22);
            this.tsbSendFromWorkbench.Text = "Send To Device";
            this.tsbSendFromWorkbench.Click += new System.EventHandler(this.tsbSendFromWorkbench_Click);
            // 
            // txtWorkbench
            // 
            this.txtWorkbench.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWorkbench.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkbench.Location = new System.Drawing.Point(0, 25);
            this.txtWorkbench.Multiline = true;
            this.txtWorkbench.Name = "txtWorkbench";
            this.txtWorkbench.Size = new System.Drawing.Size(492, 537);
            this.txtWorkbench.TabIndex = 18;
            // 
            // toolStrip6
            // 
            this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSaveWorkbenchText,
            this.toolStripButton1,
            this.toolStripSeparator9,
            this.tsbCalculateWorkbenchChk,
            this.toolStripSeparator10,
            this.tsbSendToGrid,
            this.toolStripSeparator7});
            this.toolStrip6.Location = new System.Drawing.Point(0, 0);
            this.toolStrip6.Name = "toolStrip6";
            this.toolStrip6.Size = new System.Drawing.Size(492, 25);
            this.toolStrip6.TabIndex = 16;
            this.toolStrip6.Text = "toolStrip6";
            // 
            // tsbSaveWorkbenchText
            // 
            this.tsbSaveWorkbenchText.Image = global::TCPDeviceTester.Properties.Resources.save;
            this.tsbSaveWorkbenchText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveWorkbenchText.Name = "tsbSaveWorkbenchText";
            this.tsbSaveWorkbenchText.Size = new System.Drawing.Size(115, 22);
            this.tsbSaveWorkbenchText.Text = "Save Workbench";
            this.tsbSaveWorkbenchText.Click += new System.EventHandler(this.tsbSaveWorkbenchText_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton1.Text = "Send To Tools";
            this.toolStripButton1.ToolTipText = "Sends current row to Tools section to edit them";
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
            this.tsbSendToGrid.Size = new System.Drawing.Size(79, 22);
            this.tsbSendToGrid.Text = "Send To Grid";
            this.tsbSendToGrid.Click += new System.EventHandler(this.tsbSendToGrid_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripIPPort
            // 
            this.toolStripIPPort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadDeviceXML,
            this.toolStripSeparator4,
            this.toolStripLabel4,
            this.txtCurrentIP,
            this.toolStripLabel5,
            this.txtCurrentPort,
            this.tsbSaveIPPort,
            this.tsbConnectToIP,
            this.tsbPing,
            this.tsbPingPort});
            this.toolStripIPPort.Location = new System.Drawing.Point(0, 0);
            this.toolStripIPPort.Name = "toolStripIPPort";
            this.toolStripIPPort.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripIPPort.Size = new System.Drawing.Size(500, 25);
            this.toolStripIPPort.TabIndex = 7;
            this.toolStripIPPort.Text = "toolStripIPPort";
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
            this.tsbSaveIPPort.Image = global::TCPDeviceTester.Properties.Resources.save;
            this.tsbSaveIPPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveIPPort.Name = "tsbSaveIPPort";
            this.tsbSaveIPPort.Size = new System.Drawing.Size(51, 22);
            this.tsbSaveIPPort.Text = "Save";
            this.tsbSaveIPPort.Click += new System.EventHandler(this.tsbSaveIPPort_Click);
            // 
            // tsbConnectToIP
            // 
            this.tsbConnectToIP.Image = global::TCPDeviceTester.Properties.Resources.red_light;
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
            this.tsbPingPort.Size = new System.Drawing.Size(60, 19);
            this.tsbPingPort.Text = "Ping Port";
            this.tsbPingPort.Click += new System.EventHandler(this.tsbPingPort_Click);
            // 
            // tbcTools
            // 
            this.tbcTools.Controls.Add(this.tpIncomingBytes);
            this.tbcTools.Controls.Add(this.tpTools);
            this.tbcTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcTools.Location = new System.Drawing.Point(0, 25);
            this.tbcTools.Name = "tbcTools";
            this.tbcTools.SelectedIndex = 0;
            this.tbcTools.Size = new System.Drawing.Size(545, 595);
            this.tbcTools.TabIndex = 16;
            // 
            // tpIncomingBytes
            // 
            this.tpIncomingBytes.Controls.Add(this.tbcIncomingBytes);
            this.tpIncomingBytes.Controls.Add(this.toolStrip1);
            this.tpIncomingBytes.Location = new System.Drawing.Point(4, 22);
            this.tpIncomingBytes.Name = "tpIncomingBytes";
            this.tpIncomingBytes.Padding = new System.Windows.Forms.Padding(3);
            this.tpIncomingBytes.Size = new System.Drawing.Size(537, 569);
            this.tpIncomingBytes.TabIndex = 0;
            this.tpIncomingBytes.Text = "Incoming Bytes";
            this.tpIncomingBytes.UseVisualStyleBackColor = true;
            // 
            // tbcIncomingBytes
            // 
            this.tbcIncomingBytes.Controls.Add(this.tpTextView);
            this.tbcIncomingBytes.Controls.Add(this.tpGridView);
            this.tbcIncomingBytes.Controls.Add(this.tpStatusBits);
            this.tbcIncomingBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcIncomingBytes.Location = new System.Drawing.Point(3, 3);
            this.tbcIncomingBytes.Name = "tbcIncomingBytes";
            this.tbcIncomingBytes.SelectedIndex = 0;
            this.tbcIncomingBytes.Size = new System.Drawing.Size(531, 538);
            this.tbcIncomingBytes.TabIndex = 0;
            // 
            // tpTextView
            // 
            this.tpTextView.Controls.Add(this.txtReceivedBytes);
            this.tpTextView.Controls.Add(this.panel3);
            this.tpTextView.Location = new System.Drawing.Point(4, 22);
            this.tpTextView.Name = "tpTextView";
            this.tpTextView.Padding = new System.Windows.Forms.Padding(3);
            this.tpTextView.Size = new System.Drawing.Size(523, 512);
            this.tpTextView.TabIndex = 0;
            this.tpTextView.Text = "Text View";
            this.tpTextView.UseVisualStyleBackColor = true;
            // 
            // txtReceivedBytes
            // 
            this.txtReceivedBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceivedBytes.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceivedBytes.Location = new System.Drawing.Point(3, 3);
            this.txtReceivedBytes.Multiline = true;
            this.txtReceivedBytes.Name = "txtReceivedBytes";
            this.txtReceivedBytes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceivedBytes.Size = new System.Drawing.Size(517, 250);
            this.txtReceivedBytes.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkSaveLog);
            this.panel3.Controls.Add(this.txtReceivedBytesHex);
            this.panel3.Controls.Add(this.lblHEX);
            this.panel3.Controls.Add(this.txtReceivedBytesASCII);
            this.panel3.Controls.Add(this.lblASCII);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 256);
            this.panel3.TabIndex = 30;
            // 
            // chkSaveLog
            // 
            this.chkSaveLog.AutoSize = true;
            this.chkSaveLog.Location = new System.Drawing.Point(3, 238);
            this.chkSaveLog.Name = "chkSaveLog";
            this.chkSaveLog.Size = new System.Drawing.Size(131, 17);
            this.chkSaveLog.TabIndex = 33;
            this.chkSaveLog.Text = "Save Log To Text File";
            this.chkSaveLog.UseVisualStyleBackColor = true;
            // 
            // txtReceivedBytesHex
            // 
            this.txtReceivedBytesHex.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReceivedBytesHex.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceivedBytesHex.Location = new System.Drawing.Point(0, 124);
            this.txtReceivedBytesHex.Multiline = true;
            this.txtReceivedBytesHex.Name = "txtReceivedBytesHex";
            this.txtReceivedBytesHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceivedBytesHex.Size = new System.Drawing.Size(517, 110);
            this.txtReceivedBytesHex.TabIndex = 30;
            // 
            // lblHEX
            // 
            this.lblHEX.AutoSize = true;
            this.lblHEX.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHEX.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHEX.Location = new System.Drawing.Point(0, 111);
            this.lblHEX.Name = "lblHEX";
            this.lblHEX.Size = new System.Drawing.Size(26, 13);
            this.lblHEX.TabIndex = 31;
            this.lblHEX.Text = "HEX";
            // 
            // txtReceivedBytesASCII
            // 
            this.txtReceivedBytesASCII.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReceivedBytesASCII.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceivedBytesASCII.Location = new System.Drawing.Point(0, 13);
            this.txtReceivedBytesASCII.Multiline = true;
            this.txtReceivedBytesASCII.Name = "txtReceivedBytesASCII";
            this.txtReceivedBytesASCII.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceivedBytesASCII.Size = new System.Drawing.Size(517, 98);
            this.txtReceivedBytesASCII.TabIndex = 29;
            // 
            // lblASCII
            // 
            this.lblASCII.AutoSize = true;
            this.lblASCII.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblASCII.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASCII.Location = new System.Drawing.Point(0, 0);
            this.lblASCII.Name = "lblASCII";
            this.lblASCII.Size = new System.Drawing.Size(35, 13);
            this.lblASCII.TabIndex = 32;
            this.lblASCII.Text = "ASCII";
            // 
            // tpGridView
            // 
            this.tpGridView.Controls.Add(this.dgvIncomingBytes);
            this.tpGridView.Controls.Add(this.pnlBits);
            this.tpGridView.Location = new System.Drawing.Point(4, 22);
            this.tpGridView.Name = "tpGridView";
            this.tpGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tpGridView.Size = new System.Drawing.Size(523, 512);
            this.tpGridView.TabIndex = 1;
            this.tpGridView.Text = "Grid View";
            this.tpGridView.UseVisualStyleBackColor = true;
            // 
            // dgvIncomingBytes
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvIncomingBytes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIncomingBytes.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvIncomingBytes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIncomingBytes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvIncomingBytes.ColumnHeadersHeight = 30;
            this.dgvIncomingBytes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ByteNo,
            this.Decimal,
            this.ASCII,
            this.HEX});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIncomingBytes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvIncomingBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncomingBytes.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvIncomingBytes.Location = new System.Drawing.Point(3, 3);
            this.dgvIncomingBytes.Name = "dgvIncomingBytes";
            this.dgvIncomingBytes.RowHeadersVisible = false;
            this.dgvIncomingBytes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncomingBytes.Size = new System.Drawing.Size(517, 366);
            this.dgvIncomingBytes.TabIndex = 0;
            this.dgvIncomingBytes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncomingBytes_CellContentClick);
            // 
            // ByteNo
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ByteNo.DefaultCellStyle = dataGridViewCellStyle4;
            this.ByteNo.HeaderText = "Byte No";
            this.ByteNo.Name = "ByteNo";
            this.ByteNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ByteNo.Width = 70;
            // 
            // Decimal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Decimal.DefaultCellStyle = dataGridViewCellStyle5;
            this.Decimal.HeaderText = "Decimal";
            this.Decimal.Name = "Decimal";
            this.Decimal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ASCII
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ASCII.DefaultCellStyle = dataGridViewCellStyle6;
            this.ASCII.HeaderText = "ASCII";
            this.ASCII.Name = "ASCII";
            this.ASCII.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HEX
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HEX.DefaultCellStyle = dataGridViewCellStyle7;
            this.HEX.HeaderText = "HEX";
            this.HEX.Name = "HEX";
            this.HEX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlBits
            // 
            this.pnlBits.Controls.Add(this.dgvBits);
            this.pnlBits.Controls.Add(this.lblBits);
            this.pnlBits.Controls.Add(this.txtBits);
            this.pnlBits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBits.Location = new System.Drawing.Point(3, 369);
            this.pnlBits.Name = "pnlBits";
            this.pnlBits.Size = new System.Drawing.Size(517, 140);
            this.pnlBits.TabIndex = 1;
            // 
            // dgvBits
            // 
            this.dgvBits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bit7,
            this.Bit6,
            this.Bit5,
            this.Bit4,
            this.Bit3,
            this.Bit2,
            this.Bit1,
            this.Bit0});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBits.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBits.Location = new System.Drawing.Point(15, 27);
            this.dgvBits.Name = "dgvBits";
            this.dgvBits.RowHeadersVisible = false;
            this.dgvBits.Size = new System.Drawing.Size(243, 42);
            this.dgvBits.TabIndex = 2;
            // 
            // Bit7
            // 
            this.Bit7.HeaderText = "Bit7";
            this.Bit7.Name = "Bit7";
            this.Bit7.Width = 30;
            // 
            // Bit6
            // 
            this.Bit6.HeaderText = "Bit6";
            this.Bit6.Name = "Bit6";
            this.Bit6.Width = 30;
            // 
            // Bit5
            // 
            this.Bit5.HeaderText = "Bit5";
            this.Bit5.Name = "Bit5";
            this.Bit5.Width = 30;
            // 
            // Bit4
            // 
            this.Bit4.HeaderText = "Bit4";
            this.Bit4.Name = "Bit4";
            this.Bit4.Width = 30;
            // 
            // Bit3
            // 
            this.Bit3.HeaderText = "Bit3";
            this.Bit3.Name = "Bit3";
            this.Bit3.Width = 30;
            // 
            // Bit2
            // 
            this.Bit2.HeaderText = "Bit2";
            this.Bit2.Name = "Bit2";
            this.Bit2.Width = 30;
            // 
            // Bit1
            // 
            this.Bit1.HeaderText = "Bit1";
            this.Bit1.Name = "Bit1";
            this.Bit1.Width = 30;
            // 
            // Bit0
            // 
            this.Bit0.HeaderText = "Bit0";
            this.Bit0.Name = "Bit0";
            this.Bit0.Width = 30;
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
            // txtBits
            // 
            this.txtBits.Location = new System.Drawing.Point(15, 88);
            this.txtBits.Name = "txtBits";
            this.txtBits.Size = new System.Drawing.Size(243, 20);
            this.txtBits.TabIndex = 0;
            // 
            // tpStatusBits
            // 
            this.tpStatusBits.Location = new System.Drawing.Point(4, 22);
            this.tpStatusBits.Name = "tpStatusBits";
            this.tpStatusBits.Padding = new System.Windows.Forms.Padding(3);
            this.tpStatusBits.Size = new System.Drawing.Size(523, 512);
            this.tpStatusBits.TabIndex = 2;
            this.tpStatusBits.Text = "Status Bits Explanations";
            this.tpStatusBits.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClearIncomingBytes,
            this.tsbChangeMainConsoleStyle,
            this.tsbClearBeforeSend});
            this.toolStrip1.Location = new System.Drawing.Point(3, 541);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(531, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // tpTools
            // 
            this.tpTools.Controls.Add(this.rbCRC16Kermit);
            this.tpTools.Controls.Add(this.rbCRC16);
            this.tpTools.Controls.Add(this.rbSendToGridHex);
            this.tpTools.Controls.Add(this.rbMod95);
            this.tpTools.Controls.Add(this.rbSendToGridDecimal);
            this.tpTools.Controls.Add(this.rbXOR);
            this.tpTools.Controls.Add(this.lblActiveTCPConnections);
            this.tpTools.Controls.Add(this.btnActiveTCPConnections);
            this.tpTools.Controls.Add(this.btnSendToConsole);
            this.tpTools.Controls.Add(this.btnSendToGrid);
            this.tpTools.Controls.Add(this.btnCalculateCRC);
            this.tpTools.Controls.Add(this.cbCheckSumTypes2);
            this.tpTools.Controls.Add(this.label21);
            this.tpTools.Controls.Add(this.label14);
            this.tpTools.Controls.Add(this.label15);
            this.tpTools.Controls.Add(this.label16);
            this.tpTools.Controls.Add(this.label20);
            this.tpTools.Controls.Add(this.txtASCIIBytes);
            this.tpTools.Controls.Add(this.txtHEXBytes);
            this.tpTools.Controls.Add(this.txtDecimalBytes);
            this.tpTools.Location = new System.Drawing.Point(4, 22);
            this.tpTools.Name = "tpTools";
            this.tpTools.Padding = new System.Windows.Forms.Padding(3);
            this.tpTools.Size = new System.Drawing.Size(537, 569);
            this.tpTools.TabIndex = 1;
            this.tpTools.Text = "Checksum Calculator";
            this.tpTools.UseVisualStyleBackColor = true;
            // 
            // rbCRC16Kermit
            // 
            this.rbCRC16Kermit.AutoSize = true;
            this.rbCRC16Kermit.Location = new System.Drawing.Point(274, 466);
            this.rbCRC16Kermit.Name = "rbCRC16Kermit";
            this.rbCRC16Kermit.Size = new System.Drawing.Size(88, 17);
            this.rbCRC16Kermit.TabIndex = 49;
            this.rbCRC16Kermit.Text = "CRC16Kermit";
            this.rbCRC16Kermit.UseVisualStyleBackColor = true;
            this.rbCRC16Kermit.Visible = false;
            // 
            // rbCRC16
            // 
            this.rbCRC16.AutoSize = true;
            this.rbCRC16.Location = new System.Drawing.Point(209, 466);
            this.rbCRC16.Name = "rbCRC16";
            this.rbCRC16.Size = new System.Drawing.Size(59, 17);
            this.rbCRC16.TabIndex = 49;
            this.rbCRC16.Text = "CRC16";
            this.rbCRC16.UseVisualStyleBackColor = true;
            this.rbCRC16.Visible = false;
            // 
            // rbSendToGridHex
            // 
            this.rbSendToGridHex.AutoSize = true;
            this.rbSendToGridHex.Checked = true;
            this.rbSendToGridHex.Location = new System.Drawing.Point(233, 296);
            this.rbSendToGridHex.Name = "rbSendToGridHex";
            this.rbSendToGridHex.Size = new System.Drawing.Size(44, 17);
            this.rbSendToGridHex.TabIndex = 49;
            this.rbSendToGridHex.TabStop = true;
            this.rbSendToGridHex.Text = "Hex";
            this.rbSendToGridHex.UseVisualStyleBackColor = true;
            this.rbSendToGridHex.Visible = false;
            // 
            // rbMod95
            // 
            this.rbMod95.AutoSize = true;
            this.rbMod95.Location = new System.Drawing.Point(141, 466);
            this.rbMod95.Name = "rbMod95";
            this.rbMod95.Size = new System.Drawing.Size(62, 17);
            this.rbMod95.TabIndex = 49;
            this.rbMod95.Text = "MOD95";
            this.rbMod95.UseVisualStyleBackColor = true;
            this.rbMod95.Visible = false;
            // 
            // rbSendToGridDecimal
            // 
            this.rbSendToGridDecimal.AutoSize = true;
            this.rbSendToGridDecimal.Location = new System.Drawing.Point(283, 297);
            this.rbSendToGridDecimal.Name = "rbSendToGridDecimal";
            this.rbSendToGridDecimal.Size = new System.Drawing.Size(63, 17);
            this.rbSendToGridDecimal.TabIndex = 49;
            this.rbSendToGridDecimal.Text = "Decimal";
            this.rbSendToGridDecimal.UseVisualStyleBackColor = true;
            this.rbSendToGridDecimal.Visible = false;
            // 
            // rbXOR
            // 
            this.rbXOR.AutoSize = true;
            this.rbXOR.Location = new System.Drawing.Point(87, 466);
            this.rbXOR.Name = "rbXOR";
            this.rbXOR.Size = new System.Drawing.Size(48, 17);
            this.rbXOR.TabIndex = 49;
            this.rbXOR.Text = "XOR";
            this.rbXOR.UseVisualStyleBackColor = true;
            this.rbXOR.Visible = false;
            // 
            // lblActiveTCPConnections
            // 
            this.lblActiveTCPConnections.FormattingEnabled = true;
            this.lblActiveTCPConnections.Location = new System.Drawing.Point(11, 495);
            this.lblActiveTCPConnections.Name = "lblActiveTCPConnections";
            this.lblActiveTCPConnections.Size = new System.Drawing.Size(255, 30);
            this.lblActiveTCPConnections.TabIndex = 48;
            this.lblActiveTCPConnections.Visible = false;
            // 
            // btnActiveTCPConnections
            // 
            this.btnActiveTCPConnections.Location = new System.Drawing.Point(11, 531);
            this.btnActiveTCPConnections.Name = "btnActiveTCPConnections";
            this.btnActiveTCPConnections.Size = new System.Drawing.Size(255, 23);
            this.btnActiveTCPConnections.TabIndex = 47;
            this.btnActiveTCPConnections.Text = "Active TCP Connections";
            this.btnActiveTCPConnections.UseVisualStyleBackColor = true;
            this.btnActiveTCPConnections.Visible = false;
            this.btnActiveTCPConnections.Click += new System.EventHandler(this.btnActiveTCPConnections_Click);
            // 
            // btnSendToConsole
            // 
            this.btnSendToConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToConsole.Location = new System.Drawing.Point(283, 531);
            this.btnSendToConsole.Name = "btnSendToConsole";
            this.btnSendToConsole.Size = new System.Drawing.Size(150, 23);
            this.btnSendToConsole.TabIndex = 46;
            this.btnSendToConsole.Text = "<< Send to Console";
            this.btnSendToConsole.UseVisualStyleBackColor = true;
            this.btnSendToConsole.Visible = false;
            this.btnSendToConsole.Click += new System.EventHandler(this.btnSendToConsole_Click);
            // 
            // btnSendToGrid
            // 
            this.btnSendToGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendToGrid.Location = new System.Drawing.Point(74, 292);
            this.btnSendToGrid.Name = "btnSendToGrid";
            this.btnSendToGrid.Size = new System.Drawing.Size(150, 23);
            this.btnSendToGrid.TabIndex = 46;
            this.btnSendToGrid.Text = "<< Send to Grid";
            this.btnSendToGrid.UseVisualStyleBackColor = true;
            this.btnSendToGrid.Click += new System.EventHandler(this.btnSendToGrid_Click);
            // 
            // btnCalculateCRC
            // 
            this.btnCalculateCRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateCRC.Location = new System.Drawing.Point(383, 292);
            this.btnCalculateCRC.Name = "btnCalculateCRC";
            this.btnCalculateCRC.Size = new System.Drawing.Size(98, 23);
            this.btnCalculateCRC.TabIndex = 46;
            this.btnCalculateCRC.Text = "Calculate CRC";
            this.btnCalculateCRC.UseVisualStyleBackColor = true;
            this.btnCalculateCRC.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCheckSumTypes2
            // 
            this.cbCheckSumTypes2.FormattingEnabled = true;
            this.cbCheckSumTypes2.Items.AddRange(new object[] {
            "MOD95",
            "XOR",
            "CRC16",
            "CRC32"});
            this.cbCheckSumTypes2.Location = new System.Drawing.Point(272, 494);
            this.cbCheckSumTypes2.Name = "cbCheckSumTypes2";
            this.cbCheckSumTypes2.Size = new System.Drawing.Size(121, 21);
            this.cbCheckSumTypes2.TabIndex = 45;
            this.cbCheckSumTypes2.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(19, 468);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "CRC TYPE";
            this.label21.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 16);
            this.label14.TabIndex = 39;
            this.label14.Text = "HEX";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(15, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 16);
            this.label15.TabIndex = 40;
            this.label15.Text = "Decimal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 44);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 41;
            this.label16.Text = "ASCII";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(70, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(357, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Byte Array (Use BLANK between each character. exp: 2 1 10 3)";
            // 
            // txtASCIIBytes
            // 
            this.txtASCIIBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtASCIIBytes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtASCIIBytes.Location = new System.Drawing.Point(74, 42);
            this.txtASCIIBytes.Multiline = true;
            this.txtASCIIBytes.Name = "txtASCIIBytes";
            this.txtASCIIBytes.Size = new System.Drawing.Size(407, 80);
            this.txtASCIIBytes.TabIndex = 21;
            this.txtASCIIBytes.TextChanged += new System.EventHandler(this.txtASCIIBytes_TextChanged);
            // 
            // txtHEXBytes
            // 
            this.txtHEXBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHEXBytes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHEXBytes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHEXBytes.Location = new System.Drawing.Point(74, 206);
            this.txtHEXBytes.Multiline = true;
            this.txtHEXBytes.Name = "txtHEXBytes";
            this.txtHEXBytes.Size = new System.Drawing.Size(407, 80);
            this.txtHEXBytes.TabIndex = 22;
            this.txtHEXBytes.TextChanged += new System.EventHandler(this.txtHEXBytes_TextChanged);
            // 
            // txtDecimalBytes
            // 
            this.txtDecimalBytes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDecimalBytes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimalBytes.Location = new System.Drawing.Point(74, 124);
            this.txtDecimalBytes.Multiline = true;
            this.txtDecimalBytes.Name = "txtDecimalBytes";
            this.txtDecimalBytes.Size = new System.Drawing.Size(407, 80);
            this.txtDecimalBytes.TabIndex = 23;
            this.txtDecimalBytes.TextChanged += new System.EventHandler(this.txtDecimalBytes_TextChanged);
            this.txtDecimalBytes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDecimalBytes_KeyDown);
            this.txtDecimalBytes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimalBytes_KeyPress);
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.toolStripLabel3,
            this.cbCheckSumTypes,
            this.toolStripSeparator6,
            this.tsbComPortSettings,
            this.tsbConnectToComPort,
            this.toolStripSeparator14,
            this.cbCommunicationType});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(545, 25);
            this.toolStrip4.TabIndex = 3;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(96, 22);
            this.toolStripLabel3.Text = "Check Sum Type";
            // 
            // cbCheckSumTypes
            // 
            this.cbCheckSumTypes.Items.AddRange(new object[] {
            "MOD95",
            "XOR",
            "CRC16",
            "CRC16Kermit",
            "CRC32",
            "SUM"});
            this.cbCheckSumTypes.Name = "cbCheckSumTypes";
            this.cbCheckSumTypes.Size = new System.Drawing.Size(80, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbComPortSettings
            // 
            this.tsbComPortSettings.Image = global::TCPDeviceTester.Properties.Resources.port_icon;
            this.tsbComPortSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbComPortSettings.Name = "tsbComPortSettings";
            this.tsbComPortSettings.Size = new System.Drawing.Size(123, 22);
            this.tsbComPortSettings.Text = "Com Port Settings";
            this.tsbComPortSettings.Click += new System.EventHandler(this.tsbComPortSettings_Click);
            // 
            // tsbConnectToComPort
            // 
            this.tsbConnectToComPort.Image = global::TCPDeviceTester.Properties.Resources.red_light;
            this.tsbConnectToComPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnectToComPort.Name = "tsbConnectToComPort";
            this.tsbConnectToComPort.Size = new System.Drawing.Size(72, 22);
            this.tsbConnectToComPort.Text = "Connect";
            this.tsbConnectToComPort.Click += new System.EventHandler(this.tsbConnectToComPort_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // cbCommunicationType
            // 
            this.cbCommunicationType.Items.AddRange(new object[] {
            "TCPIPStandard",
            "TCPIPConnected",
            "UDP",
            "ComPort"});
            this.cbCommunicationType.Name = "cbCommunicationType";
            this.cbCommunicationType.Size = new System.Drawing.Size(100, 25);
            this.cbCommunicationType.SelectedIndexChanged += new System.EventHandler(this.cbCommunicationType_SelectedIndexChanged);
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
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 666);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Tester";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.pnlInstructions.ResumeLayout(false);
            this.tbcDevice.ResumeLayout(false);
            this.tpDeviceCommands.ResumeLayout(false);
            this.tpDeviceCommands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructions)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlDeviceInfo.ResumeLayout(false);
            this.pnlDeviceInfo.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.pnlInstructionsBottom.ResumeLayout(false);
            this.pnlInstructionsBottom.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tpDeviceInfo.ResumeLayout(false);
            this.tpDeviceInfo.PerformLayout();
            this.pnlDeviceInformation.ResumeLayout(false);
            this.pnlDeviceInformation.PerformLayout();
            this.tpConsole.ResumeLayout(false);
            this.tpConsole.PerformLayout();
            this.pnlConsoleBottom.ResumeLayout(false);
            this.pnlConsoleBottom.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tpCommandWorkbench.ResumeLayout(false);
            this.tpCommandWorkbench.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.toolStrip7.ResumeLayout(false);
            this.toolStrip7.PerformLayout();
            this.toolStrip6.ResumeLayout(false);
            this.toolStrip6.PerformLayout();
            this.toolStripIPPort.ResumeLayout(false);
            this.toolStripIPPort.PerformLayout();
            this.tbcTools.ResumeLayout(false);
            this.tpIncomingBytes.ResumeLayout(false);
            this.tpIncomingBytes.PerformLayout();
            this.tbcIncomingBytes.ResumeLayout(false);
            this.tpTextView.ResumeLayout(false);
            this.tpTextView.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingBytes)).EndInit();
            this.pnlBits.ResumeLayout(false);
            this.pnlBits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBits)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tpTools.ResumeLayout(false);
            this.tpTools.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPrepareCommand;
        private System.Windows.Forms.ToolStripMenuItem miGenerateCommandList;
        private System.Windows.Forms.Timer tmrRequest;
        private System.Windows.Forms.TabControl tbcTools;
        private System.Windows.Forms.TabPage tpIncomingBytes;
        private System.Windows.Forms.TabPage tpTools;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtASCIIBytes;
        private System.Windows.Forms.TextBox txtHEXBytes;
        private System.Windows.Forms.TextBox txtDecimalBytes;
        private System.Windows.Forms.Button btnCalculateCRC;
        private System.Windows.Forms.ComboBox cbCheckSumTypes2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSendToGrid;
        private System.Windows.Forms.TabControl tbcDevice;
        private System.Windows.Forms.TabPage tpDeviceCommands;
        private System.Windows.Forms.DataGridView dgvInstructions;
        private System.Windows.Forms.Panel pnlDeviceInfo;
        private System.Windows.Forms.Panel pnlInstructionsBottom;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSendBytesToDevice;
        private System.Windows.Forms.TabPage tpDeviceInfo;
        private System.Windows.Forms.Panel pnlDeviceInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.TextBox txtInstructionStructure;
        private System.Windows.Forms.TextBox txtCheckSumType;
        private System.Windows.Forms.TextBox txtDeviceExplanation;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbSendToTools;
        private System.Windows.Forms.ToolStripButton tsbCloneRow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage tpConsole;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Panel pnlConsoleBottom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripButton btnSNMPSend;
        private System.Windows.Forms.ListBox lblActiveTCPConnections;
        private System.Windows.Forms.Button btnActiveTCPConnections;
        private System.Windows.Forms.TabControl tbcIncomingBytes;
        private System.Windows.Forms.TabPage tpTextView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtReceivedBytes;
        private System.Windows.Forms.TabPage tpGridView;
        private System.Windows.Forms.DataGridView dgvIncomingBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ByteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASCII;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEX;
        private System.Windows.Forms.Panel pnlBits;
        private System.Windows.Forms.TextBox txtBits;
        private System.Windows.Forms.DataGridView dgvBits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bit7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bit6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bit5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bit4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bit3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bit2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bit0;
        private System.Windows.Forms.Label lblBits;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmiSendBytesToDevice;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cmiSendToTools;
        private System.Windows.Forms.ToolStripMenuItem cmiSendToBytesGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cmiCloneCurrentRow;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.LinkLabel lnkUpdateDeviceInfo;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.RadioButton rbCRC16Kermit;
        private System.Windows.Forms.RadioButton rbCRC16;
        private System.Windows.Forms.RadioButton rbMod95;
        private System.Windows.Forms.RadioButton rbXOR;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentXML;
        private System.Windows.Forms.ToolStripButton tsbComPortSettings;
        private System.Windows.Forms.ToolStripMenuItem cmiCalculateCheckSum;
        private System.Windows.Forms.CheckBox chkUseCheckSum;
        private System.Windows.Forms.ToolStripStatusLabel lblConnectionType;
        private System.Windows.Forms.ToolStripButton tsbCalculateCheckSum;
        private System.Windows.Forms.ToolStripComboBox cbCheckSumTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbSendToComPort;
        private System.Windows.Forms.ToolStripButton tsbConnectToComPort;
        private System.Windows.Forms.ToolStripStatusLabel lblComPortInfo;
        private System.Windows.Forms.Label lblCaretPosition;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClearIncomingBytes;
        private System.Windows.Forms.RadioButton rbDosMode;
        private System.Windows.Forms.RadioButton rbDeviceMode;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton tsbClearConsole;
        private System.Windows.Forms.ToolStripButton tsbCalculateConsoleCheckSum;
        private System.Windows.Forms.ToolStripButton tsbChangeConsoleStyle;
        private System.Windows.Forms.Button btnSendToConsole;
        private System.Windows.Forms.ToolStripMenuItem cmiSendBytesToConsole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbNewRow;
        private System.Windows.Forms.RadioButton rbSendToGridHex;
        private System.Windows.Forms.RadioButton rbSendToGridDecimal;
        private System.Windows.Forms.TabPage tpCommandWorkbench;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStrip toolStrip6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tsbSaveWorkbenchText;
        private System.Windows.Forms.ToolStripButton tsbCalculateWorkbenchChk;
        private System.Windows.Forms.TextBox txtWorkbench;
        private System.Windows.Forms.ToolStrip toolStrip7;
        private System.Windows.Forms.ToolStripButton tsbSendFromWorkbench;
        private System.Windows.Forms.CheckBox chkTimerActive;
        private System.Windows.Forms.ToolStripButton tsbStopTimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton tsbSendToGrid;
        private System.Windows.Forms.ToolStripMenuItem btnOpenXMLLocation;
        private System.Windows.Forms.ToolStripMenuItem btnOpenXMLFile;
        private System.Windows.Forms.ToolStrip toolStripIPPort;
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
        private System.Windows.Forms.TextBox txtReceivedBytesHex;
        private System.Windows.Forms.Label lblHEX;
        private System.Windows.Forms.TextBox txtReceivedBytesASCII;
        private System.Windows.Forms.Label lblASCII;
        private System.Windows.Forms.ToolStripButton tsbChangeMainConsoleStyle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton tsbSNMPSet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripStatusLabel lblCommandExecutionTime;
        private System.Windows.Forms.ToolStripButton tsbConnectToIP;
        private System.Windows.Forms.ToolStripButton tsbPing;
        private System.Windows.Forms.ToolStripButton tsbPingPort;
        private System.Windows.Forms.CheckBox chkCommandIsASCII;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCPClientCommunicationTimeOut;
        private System.Windows.Forms.TextBox txtDelayTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimerInterval;
        private System.Windows.Forms.LinkLabel lnkSetTimerInterval;
        private System.Windows.Forms.ToolStripMenuItem btnNetworkTools;
        private System.Windows.Forms.Label lblBuildDate;
        private System.Windows.Forms.TabPage tpStatusBits;
        private System.Windows.Forms.CheckBox chkConditionalReading;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndByte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReadBufferSize;
        private System.Windows.Forms.ToolStripButton tsbClearBeforeSend;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripComboBox cbCommunicationType;
        private System.Windows.Forms.CheckBox chkSaveLog;
    }
}

