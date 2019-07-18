using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceTester
{
    public partial class frmSerialPortTerminal : Form
    {

        bool reading = true;
        SerialReaderThread thread = null;

        void StartClick(object s, EventArgs e)
        {
            if (thread == null)
            {
                thread = new SerialReaderThread();
                thread.DataReceived += ThreadDataReceived;
                thread.Start();
            }
            reading = true;
        }

        void StopClick(object s, EventArgs e) { reading = false; }

        void ThreadDataReceived(object s, EventArgs e)
        {
            // Note: this method is called in the thread context, thus we must
            // use Invoke to talk to UI controls. So invoke a method on our
            // thread.
            if (reading) Invoke(new EventHandler<DataEventArgs>(ThreadDataReceivedSync), new object[] { s, e });
        }

        void ThreadDataReceivedSync(object s, DataEventArgs e)
        {
            txtConsole.Text += e.Data + "\n";
        }

        public frmSerialPortTerminal()
        {
            InitializeComponent();
        }
    }
}
