using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DeviceTester
{
    public partial class Chronometer : UserControl
    {
        Stopwatch stopwatch = new Stopwatch();

        int _counter = 0;
        int _second = 0;

        public Chronometer()
        {
            InitializeComponent();
        }

        public void Start()
        {
            timer1.Enabled = true;
            _counter = 0;
            _second = 0;
            stopwatch.Start();
        }

        public void Reset()
        {
            _counter = 0;
            _second = 0;
            DisplayTime();
            stopwatch.Reset();
            stopwatch.Start();
        }

        public void Stop()
        {
            timer1.Enabled = false;
            _counter = 0;
            _second = 0;
            stopwatch.Stop();
        }

        public void Pause()
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _counter++; if (_counter == 100)
            {
                _counter = 0;
                _second++;
            }
            DisplayTime();
        }

        private void DisplayTime()
        {
            //int splitsecond = _counter % 100;
            //int second = _counter / 100;
            string s =stopwatch.Elapsed.ToString().Replace(":",".");
            string splitSecond = s.Substring(s.LastIndexOf("."), 2);
            sevenSegmentArray1.Value =s.Substring(0,s.LastIndexOf("."));  //_second.ToString() + "." + (stopwatch.ElapsedMilliseconds/10).ToString("##");
        }

        private void sevenSegmentArray1_Load(object sender, EventArgs e)
        {
            sevenSegmentArray1.ColorDark = Color.FromArgb(3, 23, 3);
        }

    }
}
