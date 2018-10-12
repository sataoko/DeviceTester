using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceTester
{
    public partial class frmShowLogs : Form
    {
        public frmShowLogs()
        {
            InitializeComponent();
        }

        string GetFileName(string szPath)
        {
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"\w+[.]\w+$+");
            return r.Match(szPath).Value;
        }

        private void LoadLogFiles()
        {
            string[] dosyalar = Directory.GetFiles(Application.StartupPath + "\\Logs");
            List<FileInfo> dosyaBilgileri = new List<FileInfo>();

            foreach (string dosya in dosyalar)
            {
                lbLogFiles.Items.Add(System.IO.Path.GetFileName(dosya));
                //dosyaBilgileri.Add(new FileInfo(dosya));
            }

            //lbDeviceXMLFiles.DataSource = dosyaBilgileri;
        }

        private void frmShowLogs_Load(object sender, EventArgs e)
        {
            LoadLogFiles();
        }

        private void tsbShowLogs_Click(object sender, EventArgs e)
        {
            string logText = File.ReadAllText(Application.StartupPath + "\\Logs\\"+lbLogFiles.Text);

            //string log= "<?xml version=\"1.0\" encoding=\"UTF-8\"?><?xml-stylesheet type = \"text/xsl\" href = \"logs.xsl\" ?>";
            //log += "<logs>"+logText+ "</logs>";
            //webBrowser1.DocumentText= log;

            string tempLogFile = Application.StartupPath + "\\temp_logs.xml";
            System.IO.StreamWriter file = new System.IO.StreamWriter(tempLogFile);
            file.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?><?xml-stylesheet type = \"text/xsl\" href = \"logs.xsl\" ?> ");
            file.WriteLine("<logs>");
            file.WriteLine(logText);
            file.WriteLine("</logs>");
            file.Close();
            webBrowser1.Navigate(tempLogFile);
        }
    }
}
