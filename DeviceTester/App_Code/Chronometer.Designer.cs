namespace DeviceTester
{
    partial class Chronometer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sevenSegmentArray1 = new DeviceTester.SevenSegmentArray();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sevenSegmentArray1
            // 
            this.sevenSegmentArray1.ArrayCount = 10;
            this.sevenSegmentArray1.ColorBackground = System.Drawing.Color.Black;
            this.sevenSegmentArray1.ColorDark = System.Drawing.Color.Black;
            this.sevenSegmentArray1.ColorLight = System.Drawing.Color.Lime;
            this.sevenSegmentArray1.DecimalShow = true;
            this.sevenSegmentArray1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenSegmentArray1.ElementPadding = new System.Windows.Forms.Padding(4);
            this.sevenSegmentArray1.ElementWidth = 10;
            this.sevenSegmentArray1.ItalicFactor = 0F;
            this.sevenSegmentArray1.Location = new System.Drawing.Point(0, 0);
            this.sevenSegmentArray1.Name = "sevenSegmentArray1";
            this.sevenSegmentArray1.Size = new System.Drawing.Size(294, 64);
            this.sevenSegmentArray1.TabIndex = 0;
            this.sevenSegmentArray1.TabStop = false;
            this.sevenSegmentArray1.Value = null;
            this.sevenSegmentArray1.Load += new System.EventHandler(this.sevenSegmentArray1_Load);
            // 
            // Chronometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sevenSegmentArray1);
            this.Name = "Chronometer";
            this.Size = new System.Drawing.Size(294, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private SevenSegmentArray sevenSegmentArray1;
        private System.Windows.Forms.Timer timer1;

    }
}
