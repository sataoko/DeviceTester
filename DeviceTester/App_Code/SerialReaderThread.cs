using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeviceTester
{
    class SerialReaderThread
    {
        private Thread t;

        public SerialReaderThread()
        {
            t = new Thread(RunMethod);
        }

        public void Start() { t.Start(); }
        public void Stop() { t.Abort(); }

        // note: this event is fired in the background thread
        public event EventHandler<DataEventArgs> DataReceived;

        private bool closed = false;
        public void Close() { closed = true; }

        private void RunMethod()
        {
            // I'll just believe that this is correct
            SerialPort mySerialPort = new SerialPort();
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.Open();

            while (!closed)
            {
                string line = mySerialPort.ReadLine();
                if (DataReceived != null) DataReceived(this, new DataEventArgs(line));
            }
        }
    }

    public class DataEventArgs : EventArgs
    {
        public string Data { get; private set; }

        public DataEventArgs(string data) { Data = data; }
    }

}


