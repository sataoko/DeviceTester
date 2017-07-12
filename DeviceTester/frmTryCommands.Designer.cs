namespace TCPDeviceTester
{
    partial class frmTryCommands
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
            this.lbGeneratedCommands = new System.Windows.Forms.ListBox();
            this.txtAddressStart = new System.Windows.Forms.TextBox();
            this.txtAddressEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbASCII = new System.Windows.Forms.RadioButton();
            this.rbSTXETX = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lmkGenerateCommands = new System.Windows.Forms.LinkLabel();
            this.txtCommandInDecimal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkSendCommand = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lnkStartSending = new System.Windows.Forms.LinkLabel();
            this.lnkStopSending = new System.Windows.Forms.LinkLabel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lnkClearCommandsListBox = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLogInfo = new System.Windows.Forms.TextBox();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.LogNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReceivedBytesASCII = new System.Windows.Forms.TextBox();
            this.txtReceivedBytes = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbGeneratedCommands
            // 
            this.lbGeneratedCommands.FormattingEnabled = true;
            this.lbGeneratedCommands.Location = new System.Drawing.Point(20, 162);
            this.lbGeneratedCommands.Name = "lbGeneratedCommands";
            this.lbGeneratedCommands.Size = new System.Drawing.Size(198, 316);
            this.lbGeneratedCommands.TabIndex = 21;
            // 
            // txtAddressStart
            // 
            this.txtAddressStart.Location = new System.Drawing.Point(22, 52);
            this.txtAddressStart.Name = "txtAddressStart";
            this.txtAddressStart.Size = new System.Drawing.Size(57, 20);
            this.txtAddressStart.TabIndex = 22;
            this.txtAddressStart.Text = "48";
            // 
            // txtAddressEnd
            // 
            this.txtAddressEnd.Location = new System.Drawing.Point(85, 52);
            this.txtAddressEnd.Name = "txtAddressEnd";
            this.txtAddressEnd.Size = new System.Drawing.Size(57, 20);
            this.txtAddressEnd.TabIndex = 22;
            this.txtAddressEnd.Text = "111";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Address Range";
            // 
            // rbASCII
            // 
            this.rbASCII.AutoSize = true;
            this.rbASCII.Checked = true;
            this.rbASCII.Location = new System.Drawing.Point(20, 12);
            this.rbASCII.Name = "rbASCII";
            this.rbASCII.Size = new System.Drawing.Size(52, 17);
            this.rbASCII.TabIndex = 24;
            this.rbASCII.TabStop = true;
            this.rbASCII.Text = "ASCII";
            this.rbASCII.UseVisualStyleBackColor = true;
            // 
            // rbSTXETX
            // 
            this.rbSTXETX.AutoSize = true;
            this.rbSTXETX.Location = new System.Drawing.Point(78, 12);
            this.rbSTXETX.Name = "rbSTXETX";
            this.rbSTXETX.Size = new System.Drawing.Size(72, 17);
            this.rbSTXETX.TabIndex = 24;
            this.rbSTXETX.Text = "STX/ETX";
            this.rbSTXETX.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(275, 111);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.Text = "Mod 95";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lmkGenerateCommands
            // 
            this.lmkGenerateCommands.AutoSize = true;
            this.lmkGenerateCommands.Location = new System.Drawing.Point(19, 143);
            this.lmkGenerateCommands.Name = "lmkGenerateCommands";
            this.lmkGenerateCommands.Size = new System.Drawing.Size(106, 13);
            this.lmkGenerateCommands.TabIndex = 25;
            this.lmkGenerateCommands.TabStop = true;
            this.lmkGenerateCommands.Text = "Generate Commands";
            this.lmkGenerateCommands.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lmkGenerateCommands_LinkClicked);
            // 
            // txtCommandInDecimal
            // 
            this.txtCommandInDecimal.Location = new System.Drawing.Point(22, 110);
            this.txtCommandInDecimal.Name = "txtCommandInDecimal";
            this.txtCommandInDecimal.Size = new System.Drawing.Size(196, 20);
            this.txtCommandInDecimal.TabIndex = 26;
            this.txtCommandInDecimal.Text = "120";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Command In Decimal";
            // 
            // lnkSendCommand
            // 
            this.lnkSendCommand.AutoSize = true;
            this.lnkSendCommand.Location = new System.Drawing.Point(225, 162);
            this.lnkSendCommand.Name = "lnkSendCommand";
            this.lnkSendCommand.Size = new System.Drawing.Size(82, 13);
            this.lnkSendCommand.TabIndex = 27;
            this.lnkSendCommand.TabStop = true;
            this.lnkSendCommand.Text = "Send Command";
            this.lnkSendCommand.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSendCommand_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(291, 10);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(108, 21);
            this.txtIP.TabIndex = 28;
            this.txtIP.Text = "10.0.0.214";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(291, 36);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(45, 21);
            this.txtPort.TabIndex = 29;
            this.txtPort.Text = "50000";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lnkStartSending
            // 
            this.lnkStartSending.AutoSize = true;
            this.lnkStartSending.Location = new System.Drawing.Point(224, 229);
            this.lnkStartSending.Name = "lnkStartSending";
            this.lnkStartSending.Size = new System.Drawing.Size(71, 13);
            this.lnkStartSending.TabIndex = 32;
            this.lnkStartSending.TabStop = true;
            this.lnkStartSending.Text = "Start Sending";
            this.lnkStartSending.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStartSending_LinkClicked);
            // 
            // lnkStopSending
            // 
            this.lnkStopSending.AutoSize = true;
            this.lnkStopSending.Location = new System.Drawing.Point(225, 252);
            this.lnkStopSending.Name = "lnkStopSending";
            this.lnkStopSending.Size = new System.Drawing.Size(71, 13);
            this.lnkStopSending.TabIndex = 32;
            this.lnkStopSending.TabStop = true;
            this.lnkStopSending.Text = "Stop Sending";
            this.lnkStopSending.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStopSending_LinkClicked);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(341, 36);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(58, 21);
            this.btnConnect.TabIndex = 33;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lnkClearCommandsListBox
            // 
            this.lnkClearCommandsListBox.AutoSize = true;
            this.lnkClearCommandsListBox.Location = new System.Drawing.Point(20, 483);
            this.lnkClearCommandsListBox.Name = "lnkClearCommandsListBox";
            this.lnkClearCommandsListBox.Size = new System.Drawing.Size(31, 13);
            this.lnkClearCommandsListBox.TabIndex = 25;
            this.lnkClearCommandsListBox.TabStop = true;
            this.lnkClearCommandsListBox.Text = "Clear";
            this.lnkClearCommandsListBox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearCommandsListBox_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(445, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 597);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLogInfo);
            this.panel2.Controls.Add(this.dgvLogs);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 378);
            this.panel2.TabIndex = 0;
            // 
            // txtLogInfo
            // 
            this.txtLogInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogInfo.Location = new System.Drawing.Point(0, 196);
            this.txtLogInfo.Multiline = true;
            this.txtLogInfo.Name = "txtLogInfo";
            this.txtLogInfo.Size = new System.Drawing.Size(455, 182);
            this.txtLogInfo.TabIndex = 44;
            // 
            // dgvLogs
            // 
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogNo,
            this.LogTime,
            this.LogInfo});
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLogs.Location = new System.Drawing.Point(0, 23);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.Size = new System.Drawing.Size(455, 173);
            this.dgvLogs.TabIndex = 42;
            this.dgvLogs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogs_CellClick);
            // 
            // LogNo
            // 
            this.LogNo.HeaderText = "LogNo";
            this.LogNo.Name = "LogNo";
            // 
            // LogTime
            // 
            this.LogTime.HeaderText = "LogTime";
            this.LogTime.Name = "LogTime";
            this.LogTime.Width = 150;
            // 
            // LogInfo
            // 
            this.LogInfo.HeaderText = "LogInfo";
            this.LogInfo.Name = "LogInfo";
            this.LogInfo.Width = 300;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 23);
            this.panel4.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Logs";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtReceivedBytesASCII);
            this.panel3.Controls.Add(this.txtReceivedBytes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 219);
            this.panel3.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "ASCII";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Decimal";
            // 
            // txtReceivedBytesASCII
            // 
            this.txtReceivedBytesASCII.Location = new System.Drawing.Point(25, 121);
            this.txtReceivedBytesASCII.Multiline = true;
            this.txtReceivedBytesASCII.Name = "txtReceivedBytesASCII";
            this.txtReceivedBytesASCII.Size = new System.Drawing.Size(407, 71);
            this.txtReceivedBytesASCII.TabIndex = 35;
            // 
            // txtReceivedBytes
            // 
            this.txtReceivedBytes.Location = new System.Drawing.Point(25, 33);
            this.txtReceivedBytes.Multiline = true;
            this.txtReceivedBytes.Name = "txtReceivedBytes";
            this.txtReceivedBytes.Size = new System.Drawing.Size(404, 64);
            this.txtReceivedBytes.TabIndex = 36;
            // 
            // frmTryCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lnkStopSending);
            this.Controls.Add(this.lnkStartSending);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lnkSendCommand);
            this.Controls.Add(this.txtCommandInDecimal);
            this.Controls.Add(this.lnkClearCommandsListBox);
            this.Controls.Add(this.lmkGenerateCommands);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbSTXETX);
            this.Controls.Add(this.rbASCII);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddressEnd);
            this.Controls.Add(this.txtAddressStart);
            this.Controls.Add(this.lbGeneratedCommands);
            this.Name = "frmTryCommands";
            this.Text = "frmTryCommands";
            this.Load += new System.EventHandler(this.frmTryCommands_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGeneratedCommands;
        private System.Windows.Forms.TextBox txtAddressStart;
        private System.Windows.Forms.TextBox txtAddressEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbASCII;
        private System.Windows.Forms.RadioButton rbSTXETX;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.LinkLabel lmkGenerateCommands;
        private System.Windows.Forms.TextBox txtCommandInDecimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkSendCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel lnkStartSending;
        private System.Windows.Forms.LinkLabel lnkStopSending;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.LinkLabel lnkClearCommandsListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReceivedBytesASCII;
        private System.Windows.Forms.TextBox txtReceivedBytes;
        private System.Windows.Forms.TextBox txtLogInfo;
    }
}