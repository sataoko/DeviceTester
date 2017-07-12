namespace DeviceTester
{
    partial class frmSuperConsole
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.shellControl1 = new DeviceTester.ShellControl();
            this.pnlConsoleSettings = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lnkSelectDosCommand = new System.Windows.Forms.LinkLabel();
            this.rbASCII = new System.Windows.Forms.RadioButton();
            this.rbDos = new System.Windows.Forms.RadioButton();
            this.rbHEX = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtLastOutput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlConsoleSettings.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.shellControl1);
            this.splitContainer1.Panel1.Controls.Add(this.pnlConsoleSettings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtLastOutput);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(890, 583);
            this.splitContainer1.SplitterDistance = 476;
            this.splitContainer1.TabIndex = 0;
            // 
            // shellControl1
            // 
            this.shellControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shellControl1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellControl1.Location = new System.Drawing.Point(0, 96);
            this.shellControl1.Name = "shellControl1";
            this.shellControl1.Prompt = ">";
            this.shellControl1.ShellTextBackColor = System.Drawing.Color.Black;
            this.shellControl1.ShellTextFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shellControl1.ShellTextForeColor = System.Drawing.Color.FloralWhite;
            this.shellControl1.Size = new System.Drawing.Size(476, 487);
            this.shellControl1.TabIndex = 0;
            this.shellControl1.CommandEntered += new DeviceTester.EventCommandEntered(this.shellControl1_CommandEntered);
            // 
            // pnlConsoleSettings
            // 
            this.pnlConsoleSettings.Controls.Add(this.tabControl1);
            this.pnlConsoleSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConsoleSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlConsoleSettings.Name = "pnlConsoleSettings";
            this.pnlConsoleSettings.Size = new System.Drawing.Size(476, 96);
            this.pnlConsoleSettings.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 96);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lnkSelectDosCommand);
            this.tabPage1.Controls.Add(this.rbASCII);
            this.tabPage1.Controls.Add(this.rbDos);
            this.tabPage1.Controls.Add(this.rbHEX);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 70);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Console";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lnkSelectDosCommand
            // 
            this.lnkSelectDosCommand.AutoSize = true;
            this.lnkSelectDosCommand.Location = new System.Drawing.Point(316, 29);
            this.lnkSelectDosCommand.Name = "lnkSelectDosCommand";
            this.lnkSelectDosCommand.Size = new System.Drawing.Size(113, 13);
            this.lnkSelectDosCommand.TabIndex = 20;
            this.lnkSelectDosCommand.TabStop = true;
            this.lnkSelectDosCommand.Text = "Select DOS Command";
            this.lnkSelectDosCommand.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectDosCommand_LinkClicked);
            // 
            // rbASCII
            // 
            this.rbASCII.AutoSize = true;
            this.rbASCII.Location = new System.Drawing.Point(80, 27);
            this.rbASCII.Name = "rbASCII";
            this.rbASCII.Size = new System.Drawing.Size(52, 17);
            this.rbASCII.TabIndex = 18;
            this.rbASCII.Text = "ASCII";
            this.rbASCII.UseVisualStyleBackColor = true;
            // 
            // rbDos
            // 
            this.rbDos.AutoSize = true;
            this.rbDos.Location = new System.Drawing.Point(138, 27);
            this.rbDos.Name = "rbDos";
            this.rbDos.Size = new System.Drawing.Size(103, 17);
            this.rbDos.TabIndex = 19;
            this.rbDos.Text = "DOS Commands";
            this.rbDos.UseVisualStyleBackColor = true;
            // 
            // rbHEX
            // 
            this.rbHEX.AutoSize = true;
            this.rbHEX.Checked = true;
            this.rbHEX.Location = new System.Drawing.Point(27, 27);
            this.rbHEX.Name = "rbHEX";
            this.rbHEX.Size = new System.Drawing.Size(47, 17);
            this.rbHEX.TabIndex = 18;
            this.rbHEX.TabStop = true;
            this.rbHEX.Text = "HEX";
            this.rbHEX.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtPort);
            this.tabPage2.Controls.Add(this.txtIP);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 70);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IP - Port";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(53, 39);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "5933";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(53, 13);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "192.168.1.100";
            // 
            // txtLastOutput
            // 
            this.txtLastOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastOutput.Location = new System.Drawing.Point(0, 96);
            this.txtLastOutput.Multiline = true;
            this.txtLastOutput.Name = "txtLastOutput";
            this.txtLastOutput.Size = new System.Drawing.Size(410, 487);
            this.txtLastOutput.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 96);
            this.panel1.TabIndex = 2;
            // 
            // frmSuperConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 583);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmSuperConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super Console";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlConsoleSettings.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ShellControl shellControl1;
        private System.Windows.Forms.Panel pnlConsoleSettings;
        private System.Windows.Forms.TextBox txtLastOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rbASCII;
        private System.Windows.Forms.RadioButton rbDos;
        private System.Windows.Forms.RadioButton rbHEX;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.LinkLabel lnkSelectDosCommand;
    }
}