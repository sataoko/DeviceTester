namespace DeviceTester
{
    partial class frmCharMap
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
            this.dgvChars = new System.Windows.Forms.DataGridView();
            this.Decimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HEX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASCII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unicode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTF7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTF8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowChars = new System.Windows.Forms.Button();
            this.txtCharMap = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChars)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChars
            // 
            this.dgvChars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Decimal,
            this.HEX,
            this.ASCII,
            this.Unicode,
            this.UTF7,
            this.UTF8});
            this.dgvChars.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvChars.Location = new System.Drawing.Point(0, 0);
            this.dgvChars.Name = "dgvChars";
            this.dgvChars.Size = new System.Drawing.Size(646, 603);
            this.dgvChars.TabIndex = 0;
            // 
            // Decimal
            // 
            this.Decimal.HeaderText = "Decimal";
            this.Decimal.Name = "Decimal";
            // 
            // HEX
            // 
            this.HEX.HeaderText = "HEX";
            this.HEX.Name = "HEX";
            // 
            // ASCII
            // 
            this.ASCII.HeaderText = "ASCII";
            this.ASCII.Name = "ASCII";
            // 
            // Unicode
            // 
            this.Unicode.HeaderText = "Unicode";
            this.Unicode.Name = "Unicode";
            // 
            // UTF7
            // 
            this.UTF7.HeaderText = "UTF7";
            this.UTF7.Name = "UTF7";
            // 
            // UTF8
            // 
            this.UTF8.HeaderText = "UTF8";
            this.UTF8.Name = "UTF8";
            // 
            // btnShowChars
            // 
            this.btnShowChars.Location = new System.Drawing.Point(707, 35);
            this.btnShowChars.Name = "btnShowChars";
            this.btnShowChars.Size = new System.Drawing.Size(136, 23);
            this.btnShowChars.TabIndex = 1;
            this.btnShowChars.Text = "Show Char 1 to 255";
            this.btnShowChars.UseVisualStyleBackColor = true;
            this.btnShowChars.Click += new System.EventHandler(this.BtnShowChars_Click);
            // 
            // txtCharMap
            // 
            this.txtCharMap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCharMap.Location = new System.Drawing.Point(646, 138);
            this.txtCharMap.Multiline = true;
            this.txtCharMap.Name = "txtCharMap";
            this.txtCharMap.Size = new System.Drawing.Size(591, 465);
            this.txtCharMap.TabIndex = 2;
            // 
            // frmCharMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 603);
            this.Controls.Add(this.txtCharMap);
            this.Controls.Add(this.btnShowChars);
            this.Controls.Add(this.dgvChars);
            this.Name = "frmCharMap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Char Map";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn HEX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASCII;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unicode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTF7;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTF8;
        private System.Windows.Forms.Button btnShowChars;
        private System.Windows.Forms.TextBox txtCharMap;
    }
}