namespace TCPDeviceTester
{
    partial class frmNetworkTools
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
            this.btnListIPs = new System.Windows.Forms.Button();
            this.btnGetIP = new System.Windows.Forms.Button();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.txtIP1 = new System.Windows.Forms.TextBox();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.txtIP1LastOctet = new System.Windows.Forms.TextBox();
            this.txtIP2LastOctet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.btnGetAllDevicesOnLAN = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnListIPs
            // 
            this.btnListIPs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListIPs.Location = new System.Drawing.Point(634, 176);
            this.btnListIPs.Name = "btnListIPs";
            this.btnListIPs.Size = new System.Drawing.Size(132, 23);
            this.btnListIPs.TabIndex = 1;
            this.btnListIPs.Text = "List Available IPs";
            this.btnListIPs.UseVisualStyleBackColor = true;
            this.btnListIPs.Click += new System.EventHandler(this.btnListIPs_Click);
            // 
            // btnGetIP
            // 
            this.btnGetIP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetIP.Location = new System.Drawing.Point(565, 38);
            this.btnGetIP.Name = "btnGetIP";
            this.btnGetIP.Size = new System.Drawing.Size(169, 23);
            this.btnGetIP.TabIndex = 2;
            this.btnGetIP.Text = "Get IP";
            this.btnGetIP.UseVisualStyleBackColor = true;
            this.btnGetIP.Click += new System.EventHandler(this.btnGetIP_Click);
            // 
            // txtHostname
            // 
            this.txtHostname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHostname.Location = new System.Drawing.Point(565, 12);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(169, 21);
            this.txtHostname.TabIndex = 3;
            this.txtHostname.Text = "www.unizayn.com";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(562, 74);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(19, 13);
            this.lblIP.TabIndex = 4;
            this.lblIP.Text = "...";
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 12);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(515, 347);
            this.txtConsole.TabIndex = 3;
            // 
            // txtIP1
            // 
            this.txtIP1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP1.Location = new System.Drawing.Point(634, 124);
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Size = new System.Drawing.Size(100, 21);
            this.txtIP1.TabIndex = 5;
            this.txtIP1.Text = "192.168.1.";
            // 
            // txtIP2
            // 
            this.txtIP2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP2.Location = new System.Drawing.Point(634, 150);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(100, 21);
            this.txtIP2.TabIndex = 5;
            this.txtIP2.Text = "192.168.0.";
            this.txtIP2.Visible = false;
            // 
            // txtIP1LastOctet
            // 
            this.txtIP1LastOctet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP1LastOctet.Location = new System.Drawing.Point(740, 124);
            this.txtIP1LastOctet.Name = "txtIP1LastOctet";
            this.txtIP1LastOctet.Size = new System.Drawing.Size(26, 21);
            this.txtIP1LastOctet.TabIndex = 5;
            this.txtIP1LastOctet.Text = "0";
            // 
            // txtIP2LastOctet
            // 
            this.txtIP2LastOctet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP2LastOctet.Location = new System.Drawing.Point(740, 150);
            this.txtIP2LastOctet.Name = "txtIP2LastOctet";
            this.txtIP2LastOctet.Size = new System.Drawing.Size(26, 21);
            this.txtIP2LastOctet.TabIndex = 5;
            this.txtIP2LastOctet.Text = "255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Range Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(564, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Range End";
            // 
            // lnkClear
            // 
            this.lnkClear.AutoSize = true;
            this.lnkClear.Location = new System.Drawing.Point(12, 363);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(31, 13);
            this.lnkClear.TabIndex = 7;
            this.lnkClear.TabStop = true;
            this.lnkClear.Text = "Clear";
            this.lnkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClear_LinkClicked);
            // 
            // btnGetAllDevicesOnLAN
            // 
            this.btnGetAllDevicesOnLAN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAllDevicesOnLAN.Location = new System.Drawing.Point(633, 300);
            this.btnGetAllDevicesOnLAN.Name = "btnGetAllDevicesOnLAN";
            this.btnGetAllDevicesOnLAN.Size = new System.Drawing.Size(132, 23);
            this.btnGetAllDevicesOnLAN.TabIndex = 1;
            this.btnGetAllDevicesOnLAN.Text = "GetAllDevicesOnLAN";
            this.btnGetAllDevicesOnLAN.UseVisualStyleBackColor = true;
            this.btnGetAllDevicesOnLAN.Click += new System.EventHandler(this.btnGetAllDevicesOnLAN_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(565, 205);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 23);
            this.progressBar1.Step = 5;
            this.progressBar1.TabIndex = 8;
            // 
            // frmNetworkTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 385);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lnkClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP2);
            this.Controls.Add(this.txtIP2LastOctet);
            this.Controls.Add(this.txtIP1LastOctet);
            this.Controls.Add(this.txtIP1);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.txtHostname);
            this.Controls.Add(this.btnGetIP);
            this.Controls.Add(this.btnGetAllDevicesOnLAN);
            this.Controls.Add(this.btnListIPs);
            this.Name = "frmNetworkTools";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListIPs;
        private System.Windows.Forms.Button btnGetIP;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.TextBox txtIP1;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.TextBox txtIP1LastOctet;
        private System.Windows.Forms.TextBox txtIP2LastOctet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkClear;
        private System.Windows.Forms.Button btnGetAllDevicesOnLAN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}