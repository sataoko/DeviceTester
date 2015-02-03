using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace TCPDeviceTester
{
    class XMLOperations
    {
        private string _XMLFilePath = string.Empty;
        public string XMLFilePath
        {
            get { return XMLFilePath; }
            set { XMLFilePath = value; }
        }


        private string _startNode = "/Shortcuts/ShortCut";
        public string StartNode
        {
            get { return _startNode; }
            set { _startNode = value; }
        }



        public XMLOperations(string XMLFilePath)
        {
            _XMLFilePath = XMLFilePath;
        }


        public void ReadXMLInstructions(System.Windows.Forms.TreeView targetTreeView)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            string strFilename = _XMLFilePath;
            ds.ReadXml(strFilename);

            ds.Tables[0].DefaultView.Sort = "OrderNo";

            System.Data.DataView dv = ds.Tables[0].DefaultView;

            targetTreeView.Nodes.Clear();
            foreach (System.Data.DataRowView dvr in dv)
            {
                Instruction s = new Instruction(dvr["FilePath"].ToString().Trim(), dvr["Alias"].ToString().Trim());
                s.ID = dvr["ID"].ToString();
                s.OrderNo = dvr["Order"].ToString();
                DataTreeNode d = new DataTreeNode(s);
                targetTreeView.Nodes.Add(d);
            }
        }

        public List<Instruction> GetXMLNodes(string startNode)
        {
            string strFilename = _XMLFilePath;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(strFilename);
            XmlNodeList newXMLNodes = xmlDoc.SelectNodes(startNode);

            List<Instruction> instructions =new List<Instruction>();

            foreach (XmlNode newXMLNode in newXMLNodes)
            {
                Instruction i = new Instruction(newXMLNode["InstructionBytes"].InnerText, newXMLNode["Explanation"].InnerText);
                i.ID= newXMLNode["ID"].InnerText;
                i.OrderNo = newXMLNode["Order"].InnerText;
                if (newXMLNode["CheckSum"] == null) i.CheckSum = "0";else
                i.CheckSum = newXMLNode["CheckSum"].InnerText;
                
                instructions.Add(i);
            }

            return instructions;
        }

        public DeviceInfo GetDeviceInfo()
        {
            string strFilename = _XMLFilePath;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(strFilename);
            XmlNodeList newXMLNodes = xmlDoc.SelectNodes("DeviceInstructions/DeviceInfo");

            DeviceInfo di = new DeviceInfo(); 

            foreach (XmlNode newXMLNode in newXMLNodes)
            {
                di.DeviceName = newXMLNode["DeviceName"].InnerText;
                di.DeviceExplanation = newXMLNode["Explanation"].InnerText;
                di.DeviceIP = newXMLNode["IP"].InnerText;
                di.DevicePort = newXMLNode["Port"].InnerText;
                di.CheckSumType = newXMLNode["CheckSumType"].InnerText;
                di.InstructionStructure = newXMLNode["InstructionStructure"].InnerText;
            }

            return di;
        }

        public WorkbenchData GetWorkbenchData()
        {
            string strFilename = _XMLFilePath;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(strFilename);
            XmlNodeList newXMLNodes = xmlDoc.SelectNodes("DeviceInstructions/WorkbenchData");

            WorkbenchData wbd = new WorkbenchData();

            foreach (XmlNode newXMLNode in newXMLNodes)
            {
                wbd.ID = newXMLNode["ID"].InnerText;
                wbd.Instructions = newXMLNode["Instructions"].InnerText;
            }

            return wbd;
        }
    }
}
