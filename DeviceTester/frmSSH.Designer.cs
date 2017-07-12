namespace TCPDeviceTester
{
    partial class frmSSH
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
            this.lblRebootExplanation = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btbReboot = new System.Windows.Forms.Button();
            this.btnStartPointsat = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRemoteHost = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblRebootExplanation
            // 
            this.lblRebootExplanation.AutoSize = true;
            this.lblRebootExplanation.Location = new System.Drawing.Point(154, 101);
            this.lblRebootExplanation.Name = "lblRebootExplanation";
            this.lblRebootExplanation.Size = new System.Drawing.Size(128, 13);
            this.lblRebootExplanation.TabIndex = 17;
            this.lblRebootExplanation.Text = "no need to click connect.";
            // 
            // txtConsole
            // 
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtConsole.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtConsole.Location = new System.Drawing.Point(0, 191);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(720, 256);
            this.txtConsole.TabIndex = 16;
            // 
            // btbReboot
            // 
            this.btbReboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbReboot.Location = new System.Drawing.Point(10, 96);
            this.btbReboot.Name = "btbReboot";
            this.btbReboot.Size = new System.Drawing.Size(138, 23);
            this.btbReboot.TabIndex = 12;
            this.btbReboot.Text = "Reboot Pointsat";
            this.btbReboot.UseVisualStyleBackColor = true;
            this.btbReboot.Click += new System.EventHandler(this.btbReboot_Click);
            // 
            // btnStartPointsat
            // 
            this.btnStartPointsat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPointsat.Location = new System.Drawing.Point(10, 66);
            this.btnStartPointsat.Name = "btnStartPointsat";
            this.btnStartPointsat.Size = new System.Drawing.Size(138, 23);
            this.btnStartPointsat.TabIndex = 13;
            this.btnStartPointsat.Text = "Start Pointsat";
            this.btnStartPointsat.UseVisualStyleBackColor = true;
            this.btnStartPointsat.Click += new System.EventHandler(this.btnStartPointsat_Click);
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(382, 143);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(328, 22);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 15;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(219, 4);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.Location = new System.Drawing.Point(113, 4);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 10;
            this.lblUsername.Text = "Username";
            // 
            // lblRemoteHost
            // 
            this.lblRemoteHost.AutoSize = true;
            this.lblRemoteHost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRemoteHost.Location = new System.Drawing.Point(7, 4);
            this.lblRemoteHost.Name = "lblRemoteHost";
            this.lblRemoteHost.Size = new System.Drawing.Size(82, 13);
            this.lblRemoteHost.TabIndex = 11;
            this.lblRemoteHost.Text = "Remote Host IP";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(222, 22);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "1";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.Location = new System.Drawing.Point(116, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 21);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Text = "root";
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCommand.Location = new System.Drawing.Point(1, 144);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(377, 21);
            this.txtCommand.TabIndex = 7;
            this.txtCommand.Text = "ls";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIP.Location = new System.Drawing.Point(10, 22);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 21);
            this.txtIP.TabIndex = 8;
            this.txtIP.Text = "192.168.1.125";
            // 
            // lnkClear
            // 
            this.lnkClear.AutoSize = true;
            this.lnkClear.Location = new System.Drawing.Point(678, 166);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(30, 13);
            this.lnkClear.TabIndex = 18;
            this.lnkClear.TabStop = true;
            this.lnkClear.Text = "clear";
            this.lnkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClear_LinkClicked);
            // 
            // frmSSH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 447);
            this.Controls.Add(this.lnkClear);
            this.Controls.Add(this.lblRebootExplanation);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btbReboot);
            this.Controls.Add(this.btnStartPointsat);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblRemoteHost);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.txtIP);
            this.Name = "frmSSH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSH Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRebootExplanation;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btbReboot;
        private System.Windows.Forms.Button btnStartPointsat;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRemoteHost;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtIP;
        private ShellTextBox shellTextBox1;
        private System.Windows.Forms.LinkLabel lnkClear;
    }
}