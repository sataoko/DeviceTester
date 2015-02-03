namespace TCPDeviceTester
{
    partial class frmPrepareCommand
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
            this.lnkCRC32 = new System.Windows.Forms.LinkLabel();
            this.lnkGenerateCheckSum = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDecimalBytes = new System.Windows.Forms.TextBox();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.txtDecimalByteValue = new System.Windows.Forms.TextBox();
            this.txtHEXByteValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lnkCIFCheckSum = new System.Windows.Forms.LinkLabel();
            this.lnkMiteqCheckSum = new System.Windows.Forms.LinkLabel();
            this.txtASCIIBytes = new System.Windows.Forms.TextBox();
            this.txtHEXBytes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbDecimal = new System.Windows.Forms.RadioButton();
            this.rbHEX = new System.Windows.Forms.RadioButton();
            this.rbASCII = new System.Windows.Forms.RadioButton();
            this.lnkCRC16 = new System.Windows.Forms.LinkLabel();
            this.lnkMod256 = new System.Windows.Forms.LinkLabel();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkCRC32
            // 
            this.lnkCRC32.AutoSize = true;
            this.lnkCRC32.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCRC32.Location = new System.Drawing.Point(59, 140);
            this.lnkCRC32.Name = "lnkCRC32";
            this.lnkCRC32.Size = new System.Drawing.Size(95, 13);
            this.lnkCRC32.TabIndex = 14;
            this.lnkCRC32.TabStop = true;
            this.lnkCRC32.Text = "CRC32 (SWC 100)";
            this.lnkCRC32.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCRC32_LinkClicked);
            // 
            // lnkGenerateCheckSum
            // 
            this.lnkGenerateCheckSum.AutoSize = true;
            this.lnkGenerateCheckSum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkGenerateCheckSum.Location = new System.Drawing.Point(58, 110);
            this.lnkGenerateCheckSum.Name = "lnkGenerateCheckSum";
            this.lnkGenerateCheckSum.Size = new System.Drawing.Size(142, 13);
            this.lnkGenerateCheckSum.TabIndex = 15;
            this.lnkGenerateCheckSum.TabStop = true;
            this.lnkGenerateCheckSum.Text = "Create Check Sum (Newtec)";
            this.lnkGenerateCheckSum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGenerateCheckSum_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Byte Array (Use comma between each character. exp: 2,1,10,3)";
            // 
            // txtDecimalBytes
            // 
            this.txtDecimalBytes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimalBytes.Location = new System.Drawing.Point(62, 54);
            this.txtDecimalBytes.Name = "txtDecimalBytes";
            this.txtDecimalBytes.Size = new System.Drawing.Size(280, 21);
            this.txtDecimalBytes.TabIndex = 12;
            this.txtDecimalBytes.TextChanged += new System.EventHandler(this.txtDecimalBytes_TextChanged);
            this.txtDecimalBytes.Enter += new System.EventHandler(this.txtDecimalBytes_Enter);
            // 
            // txtASCII
            // 
            this.txtASCII.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtASCII.Location = new System.Drawing.Point(540, 28);
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.Size = new System.Drawing.Size(58, 21);
            this.txtASCII.TabIndex = 16;
            this.txtASCII.TextChanged += new System.EventHandler(this.txtASCII_TextChanged);
            // 
            // txtDecimalByteValue
            // 
            this.txtDecimalByteValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimalByteValue.Location = new System.Drawing.Point(540, 54);
            this.txtDecimalByteValue.Name = "txtDecimalByteValue";
            this.txtDecimalByteValue.Size = new System.Drawing.Size(58, 21);
            this.txtDecimalByteValue.TabIndex = 16;
            this.txtDecimalByteValue.TextChanged += new System.EventHandler(this.txtDecimalByteValue_TextChanged);
            // 
            // txtHEXByteValue
            // 
            this.txtHEXByteValue.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHEXByteValue.Location = new System.Drawing.Point(540, 80);
            this.txtHEXByteValue.Name = "txtHEXByteValue";
            this.txtHEXByteValue.Size = new System.Drawing.Size(58, 21);
            this.txtHEXByteValue.TabIndex = 16;
            this.txtHEXByteValue.TextChanged += new System.EventHandler(this.txtHEXByteValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "HEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Decimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ASCII";
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(548, 154);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(50, 21);
            this.txtSize.TabIndex = 18;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(59, 173);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create Check Sum (CPI HPA)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkCIFCheckSum
            // 
            this.lnkCIFCheckSum.AutoSize = true;
            this.lnkCIFCheckSum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCIFCheckSum.Location = new System.Drawing.Point(215, 173);
            this.lnkCIFCheckSum.Name = "lnkCIFCheckSum";
            this.lnkCIFCheckSum.Size = new System.Drawing.Size(118, 13);
            this.lnkCIFCheckSum.TabIndex = 15;
            this.lnkCIFCheckSum.TabStop = true;
            this.lnkCIFCheckSum.Text = "CIF Protocol CheckSum";
            this.lnkCIFCheckSum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCIFCheckSum_LinkClicked);
            // 
            // lnkMiteqCheckSum
            // 
            this.lnkMiteqCheckSum.AutoSize = true;
            this.lnkMiteqCheckSum.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMiteqCheckSum.Location = new System.Drawing.Point(59, 207);
            this.lnkMiteqCheckSum.Name = "lnkMiteqCheckSum";
            this.lnkMiteqCheckSum.Size = new System.Drawing.Size(85, 13);
            this.lnkMiteqCheckSum.TabIndex = 15;
            this.lnkMiteqCheckSum.TabStop = true;
            this.lnkMiteqCheckSum.Text = "Miteq CheckSum";
            this.lnkMiteqCheckSum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMiteqCheckSum_LinkClicked);
            // 
            // txtASCIIBytes
            // 
            this.txtASCIIBytes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtASCIIBytes.Location = new System.Drawing.Point(62, 30);
            this.txtASCIIBytes.Name = "txtASCIIBytes";
            this.txtASCIIBytes.Size = new System.Drawing.Size(280, 21);
            this.txtASCIIBytes.TabIndex = 12;
            this.txtASCIIBytes.TextChanged += new System.EventHandler(this.txtASCIIBytes_TextChanged);
            this.txtASCIIBytes.Enter += new System.EventHandler(this.txtASCIIBytes_Enter);
            // 
            // txtHEXBytes
            // 
            this.txtHEXBytes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHEXBytes.Location = new System.Drawing.Point(62, 78);
            this.txtHEXBytes.Name = "txtHEXBytes";
            this.txtHEXBytes.Size = new System.Drawing.Size(280, 21);
            this.txtHEXBytes.TabIndex = 12;
            this.txtHEXBytes.TextChanged += new System.EventHandler(this.txtHEXBytes_TextChanged);
            this.txtHEXBytes.Enter += new System.EventHandler(this.txtHEXBytes_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "ASCII";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Decimal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "HEX";
            // 
            // rbDecimal
            // 
            this.rbDecimal.AutoSize = true;
            this.rbDecimal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDecimal.Location = new System.Drawing.Point(348, 59);
            this.rbDecimal.Name = "rbDecimal";
            this.rbDecimal.Size = new System.Drawing.Size(14, 13);
            this.rbDecimal.TabIndex = 20;
            this.rbDecimal.TabStop = true;
            this.rbDecimal.UseVisualStyleBackColor = true;
            // 
            // rbHEX
            // 
            this.rbHEX.AutoSize = true;
            this.rbHEX.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHEX.Location = new System.Drawing.Point(348, 82);
            this.rbHEX.Name = "rbHEX";
            this.rbHEX.Size = new System.Drawing.Size(14, 13);
            this.rbHEX.TabIndex = 20;
            this.rbHEX.TabStop = true;
            this.rbHEX.UseVisualStyleBackColor = true;
            // 
            // rbASCII
            // 
            this.rbASCII.AutoSize = true;
            this.rbASCII.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbASCII.Location = new System.Drawing.Point(348, 33);
            this.rbASCII.Name = "rbASCII";
            this.rbASCII.Size = new System.Drawing.Size(14, 13);
            this.rbASCII.TabIndex = 20;
            this.rbASCII.TabStop = true;
            this.rbASCII.UseVisualStyleBackColor = true;
            // 
            // lnkCRC16
            // 
            this.lnkCRC16.AutoSize = true;
            this.lnkCRC16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCRC16.Location = new System.Drawing.Point(178, 140);
            this.lnkCRC16.Name = "lnkCRC16";
            this.lnkCRC16.Size = new System.Drawing.Size(71, 13);
            this.lnkCRC16.TabIndex = 14;
            this.lnkCRC16.TabStop = true;
            this.lnkCRC16.Text = "CRC16 (MCL)";
            this.lnkCRC16.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCRC16_LinkClicked);
            // 
            // lnkMod256
            // 
            this.lnkMod256.AutoSize = true;
            this.lnkMod256.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMod256.Location = new System.Drawing.Point(59, 238);
            this.lnkMod256.Name = "lnkMod256";
            this.lnkMod256.Size = new System.Drawing.Size(48, 13);
            this.lnkMod256.TabIndex = 15;
            this.lnkMod256.TabStop = true;
            this.lnkMod256.Text = "Mod 256";
            this.lnkMod256.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMod256_LinkClicked);
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtH.Location = new System.Drawing.Point(497, 309);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(58, 21);
            this.txtH.TabIndex = 16;
            this.txtH.TextChanged += new System.EventHandler(this.txtASCII_TextChanged);
            // 
            // txtL
            // 
            this.txtL.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtL.Location = new System.Drawing.Point(497, 335);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(58, 21);
            this.txtL.TabIndex = 16;
            this.txtL.TextChanged += new System.EventHandler(this.txtDecimalByteValue_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(451, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "L";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(451, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "H";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(580, 338);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(49, 13);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "calculate";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(499, 370);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(12, 13);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "L";
            // 
            // frmPrepareCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 421);
            this.Controls.Add(this.rbHEX);
            this.Controls.Add(this.rbASCII);
            this.Controls.Add(this.rbDecimal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHEXByteValue);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtDecimalByteValue);
            this.Controls.Add(this.txtASCII);
            this.Controls.Add(this.lnkCRC16);
            this.Controls.Add(this.lnkCRC32);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lnkMod256);
            this.Controls.Add(this.lnkMiteqCheckSum);
            this.Controls.Add(this.lnkCIFCheckSum);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lnkGenerateCheckSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtASCIIBytes);
            this.Controls.Add(this.txtHEXBytes);
            this.Controls.Add(this.txtDecimalBytes);
            this.Name = "frmPrepareCommand";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepare Command";
            this.Load += new System.EventHandler(this.frmPrepareCommand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkCRC32;
        private System.Windows.Forms.LinkLabel lnkGenerateCheckSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDecimalBytes;
        private System.Windows.Forms.TextBox txtASCII;
        private System.Windows.Forms.TextBox txtDecimalByteValue;
        private System.Windows.Forms.TextBox txtHEXByteValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lnkCIFCheckSum;
        private System.Windows.Forms.LinkLabel lnkMiteqCheckSum;
        private System.Windows.Forms.TextBox txtASCIIBytes;
        private System.Windows.Forms.TextBox txtHEXBytes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbDecimal;
        private System.Windows.Forms.RadioButton rbHEX;
        private System.Windows.Forms.RadioButton rbASCII;
        private System.Windows.Forms.LinkLabel lnkCRC16;
        private System.Windows.Forms.LinkLabel lnkMod256;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label lblResult;
    }
}