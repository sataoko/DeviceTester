﻿namespace DeviceTester
{
    partial class frmHTTPTester
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
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSend = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtIP = new System.Windows.Forms.ToolStripTextBox();
            this.txtPort = new System.Windows.Forms.ToolStripTextBox();
            this.tsbConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtURL = new System.Windows.Forms.ToolStripTextBox();
            this.tsbGetIP = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbClearConsole = new System.Windows.Forms.ToolStripButton();
            this.tbcHtml = new System.Windows.Forms.TabControl();
            this.tpHTML = new System.Windows.Forms.TabPage();
            this.tpWebBrowser = new System.Windows.Forms.TabPage();
            this.txtReceivedBytesASCII = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.tbcHtml.SuspendLayout();
            this.tpHTML.SuspendLayout();
            this.tpWebBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommand.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.Location = new System.Drawing.Point(3, 28);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommand.Size = new System.Drawing.Size(817, 173);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.Text = "GET / HTTP/1.1\r\nhost: www.google.it\r\n\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 445);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 255);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCommand);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TCP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSend});
            this.toolStrip2.Location = new System.Drawing.Point(3, 201);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(817, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbSend
            // 
            this.tsbSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSend.Name = "tsbSend";
            this.tsbSend.Size = new System.Drawing.Size(37, 22);
            this.tsbSend.Text = "Send";
            this.tsbSend.Click += new System.EventHandler(this.tsbSend_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtIP,
            this.txtPort,
            this.tsbConnect,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtURL,
            this.tsbGetIP});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtIP
            // 
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 25);
            this.txtIP.Text = "216.58.209.195";
            // 
            // txtPort
            // 
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(50, 25);
            this.txtPort.Text = "80";
            // 
            // tsbConnect
            // 
            this.tsbConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnect.Name = "tsbConnect";
            this.tsbConnect.Size = new System.Drawing.Size(56, 22);
            this.tsbConnect.Text = "Connect";
            this.tsbConnect.Click += new System.EventHandler(this.tsbConnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel1.Text = "Target URL";
            // 
            // txtURL
            // 
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(100, 25);
            // 
            // tsbGetIP
            // 
            this.tsbGetIP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbGetIP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGetIP.Name = "tsbGetIP";
            this.tsbGetIP.Size = new System.Drawing.Size(42, 22);
            this.tsbGetIP.Text = "Get IP";
            this.tsbGetIP.Click += new System.EventHandler(this.tsbGetIP_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClearConsole});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(831, 25);
            this.toolStrip3.TabIndex = 4;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsbClearConsole
            // 
            this.tsbClearConsole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClearConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearConsole.Name = "tsbClearConsole";
            this.tsbClearConsole.Size = new System.Drawing.Size(38, 22);
            this.tsbClearConsole.Text = "Clear";
            this.tsbClearConsole.Click += new System.EventHandler(this.tsbClearConsole_Click);
            // 
            // tbcHtml
            // 
            this.tbcHtml.Controls.Add(this.tpHTML);
            this.tbcHtml.Controls.Add(this.tpWebBrowser);
            this.tbcHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcHtml.Location = new System.Drawing.Point(0, 25);
            this.tbcHtml.Name = "tbcHtml";
            this.tbcHtml.SelectedIndex = 0;
            this.tbcHtml.Size = new System.Drawing.Size(831, 420);
            this.tbcHtml.TabIndex = 5;
            this.tbcHtml.SelectedIndexChanged += new System.EventHandler(this.tbcHtml_SelectedIndexChanged);
            // 
            // tpHTML
            // 
            this.tpHTML.Controls.Add(this.txtReceivedBytesASCII);
            this.tpHTML.Location = new System.Drawing.Point(4, 22);
            this.tpHTML.Name = "tpHTML";
            this.tpHTML.Padding = new System.Windows.Forms.Padding(3);
            this.tpHTML.Size = new System.Drawing.Size(823, 394);
            this.tpHTML.TabIndex = 0;
            this.tpHTML.Text = "HTML";
            this.tpHTML.UseVisualStyleBackColor = true;
            // 
            // tpWebBrowser
            // 
            this.tpWebBrowser.Controls.Add(this.webBrowser1);
            this.tpWebBrowser.Location = new System.Drawing.Point(4, 22);
            this.tpWebBrowser.Name = "tpWebBrowser";
            this.tpWebBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tpWebBrowser.Size = new System.Drawing.Size(823, 394);
            this.tpWebBrowser.TabIndex = 1;
            this.tpWebBrowser.Text = "VIEW";
            this.tpWebBrowser.UseVisualStyleBackColor = true;
            // 
            // txtReceivedBytesASCII
            // 
            this.txtReceivedBytesASCII.BackColor = System.Drawing.Color.Black;
            this.txtReceivedBytesASCII.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceivedBytesASCII.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedBytesASCII.ForeColor = System.Drawing.Color.Lime;
            this.txtReceivedBytesASCII.Location = new System.Drawing.Point(3, 3);
            this.txtReceivedBytesASCII.Multiline = true;
            this.txtReceivedBytesASCII.Name = "txtReceivedBytesASCII";
            this.txtReceivedBytesASCII.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceivedBytesASCII.Size = new System.Drawing.Size(817, 388);
            this.txtReceivedBytesASCII.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(817, 388);
            this.webBrowser1.TabIndex = 0;
            // 
            // frmHTTPTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 700);
            this.Controls.Add(this.tbcHtml);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip3);
            this.Name = "frmHTTPTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTTP Tester";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tbcHtml.ResumeLayout(false);
            this.tpHTML.ResumeLayout(false);
            this.tpHTML.PerformLayout();
            this.tpWebBrowser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtIP;
        private System.Windows.Forms.ToolStripTextBox txtPort;
        private System.Windows.Forms.ToolStripButton tsbConnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbGetIP;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbSend;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbClearConsole;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtURL;
        private System.Windows.Forms.TabControl tbcHtml;
        private System.Windows.Forms.TabPage tpHTML;
        private System.Windows.Forms.TextBox txtReceivedBytesASCII;
        private System.Windows.Forms.TabPage tpWebBrowser;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

