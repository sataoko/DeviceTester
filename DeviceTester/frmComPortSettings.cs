using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeviceTester
{
    public partial class frmComPortSettings : Form
    {
        public string ComPort { get; set; }
        public Int32 BaudRate { get; set; }
        public string Parity { get; set; }
        public byte DataBits { get; set; }
        public string StopBits { get; set; }

        public frmComPortSettings()
        {
            InitializeComponent();
        }

        private void frmComPortSettings_Load(object sender, EventArgs e)
        {
            cbComPorts.DataSource = System.IO.Ports.SerialPort.GetPortNames();

            Ini.IniFile ini = new Ini.IniFile();
            cbComPorts.Text = ini.IniReadValue("ComportSettings", "COMPort");
            cbBaudRates.Text = ini.IniReadValue("ComportSettings", "BaudRate");
            cbParities.Text = ini.IniReadValue("ComportSettings", "Parity");
            cbDataBits.Text = ini.IniReadValue("ComportSettings", "DataBits");
            cbStopBits.Text = ini.IniReadValue("ComportSettings", "StopBits");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.ComPort = cbComPorts.Text;
            this.BaudRate = Convert.ToInt32(cbBaudRates.Text);
            this.Parity = cbParities.Text;
            this.DataBits = Convert.ToByte(cbDataBits.Text);
            this.StopBits = cbStopBits.Text;

            Ini.IniFile ini = new Ini.IniFile();
            ini.IniWriteValue("ComportSettings", "COMPort", this.ComPort);
            ini.IniWriteValue("ComportSettings", "BaudRate", this.BaudRate.ToString());
            ini.IniWriteValue("ComportSettings", "Parity", this.Parity);
            ini.IniWriteValue("ComportSettings", "DataBits", this.DataBits.ToString());
            ini.IniWriteValue("ComportSettings", "StopBits", this.StopBits.ToString());

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
