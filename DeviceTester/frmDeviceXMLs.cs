using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DeviceTester
{
    public partial class frmDeviceXMLs : Form
    {
        public string DeviceXMLFilePath = string.Empty;
        private FileExplorer fe = new FileExplorer();

        public frmDeviceXMLs()
        {
            InitializeComponent();
        }
        
        string GetFileName(string szPath)
        {
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"\w+[.]\w+$+");
            return r.Match(szPath).Value;
        }

        private void frmDeviceXMLs_Load(object sender, EventArgs e)
        {
            string[] dosyalar = Directory.GetFiles(Application.StartupPath+"\\DeviceXMLs");
            List<FileInfo> dosyaBilgileri = new List<FileInfo>();

            //foreach (string dosya in dosyalar)
            //{
            //    lbDeviceXMLFiles.Items.Add(GetFileName(dosya.ToString()));
            //    //dosyaBilgileri.Add(new FileInfo(dosya));
            //}

            //lbDeviceXMLFiles.DataSource = dosyaBilgileri;

            fe.CreateTree(this.trvFiles, Application.StartupPath + "\\DeviceXMLs");
            TreeNode node = fe.EnumerateDirectory(trvFiles.Nodes[0]);
            node.Expand();
        }

        private void LoadDeviceXML()
        {
            if (string.IsNullOrEmpty(lblSelectedFile.Text)) MessageBox.Show("Select a file");
            else
            {
                DeviceXMLFilePath = lblSelectedFile.Tag.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadDeviceXML();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        

        private void trvFiles_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "")
            {
                TreeNode node = fe.EnumerateDirectory(e.Node);
            }
        }

        private string GetParentNodeTexts(TreeNode clickedNode, string currentFolder)
        {
            TreeNode node = clickedNode.Parent;
            if (node == null) return currentFolder;
            else
            {
                currentFolder = node.Text + "\\" + currentFolder;
                return GetParentNodeTexts(node, currentFolder);
            }
        }

        private void trvFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = trvFiles.SelectedNode;
            string fileName = GetParentNodeTexts(node, node.Text);
            lblSelectedFile.Text = GetFileName(fileName);
            lblSelectedFile.Tag = fileName;

            //DeviceXMLFilePath = node.Text;
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void trvFiles_DoubleClick(object sender, EventArgs e)
        {
            LoadDeviceXML();
        }

    }
}
