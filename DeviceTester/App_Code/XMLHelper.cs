using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace TCPDeviceTester
{
    class XMLHelper
    {
        private string _xmlFile = string.Empty;
        public string XMLFile
        {
            get { return _xmlFile; }
            set { _xmlFile = value; }
        }
        private string _startNode = "/DeviceInstructions/Instruction"; 
        public string StartNode
        {
            get { return _startNode; }
            set { _startNode = value; }
        }

        public XMLHelper(string shortcutsFile)
        {
            XMLFile = shortcutsFile;
        }

        public void UpdateNode(string nodeName, string currentNodeValue, string newNodeValue)
        {
            string xmlPath = _xmlFile;

            XmlDocument XMLDom = new XmlDocument();
            //load your xml file
            XMLDom.Load(xmlPath);

            XmlNodeList newXMLNodes = XMLDom.SelectNodes(_startNode);
            foreach (XmlNode newXMLNode in newXMLNodes)
                if (newXMLNode[nodeName].InnerText == currentNodeValue)
                    newXMLNode[nodeName].InnerText = newNodeValue;
            XMLDom.Save(xmlPath);
            XMLDom = null;
        }

        public void UpdateNodeByRefField(string refFieldName, string refFieldValue, string targetFieldName, string targetFieldValue)
        {
            string xmlPath = _xmlFile;

            if (string.IsNullOrEmpty(xmlPath)) return;

            XmlDocument XMLDom = new XmlDocument();
            //load your xml file
            XMLDom.Load(xmlPath);

            XmlNodeList newXMLNodes = XMLDom.SelectNodes(_startNode);
            foreach (XmlNode newXMLNode in newXMLNodes)
                if (newXMLNode[refFieldName].InnerText == refFieldValue)
                    newXMLNode[targetFieldName].InnerText = targetFieldValue;
            XMLDom.Save(xmlPath);
            XMLDom = null;
        }

        public void UpdateNodeByID(string nodeID, string nodeName, string newNodeValue)
        {
            string xmlPath = _xmlFile;

            XmlDocument XMLDom = new XmlDocument();
            //load your xml file
            XMLDom.Load(xmlPath);

            XmlNodeList newXMLNodes = XMLDom.SelectNodes(_startNode);
            foreach (XmlNode newXMLNode in newXMLNodes)
                if (newXMLNode["ID"].InnerText ==nodeID)
                    newXMLNode[nodeName].InnerText = newNodeValue;
            XMLDom.Save(xmlPath);
            XMLDom = null;
        }

        public void UpdateNodePathByID(string nodeID, string newPath)
        {
            string xmlPath = _xmlFile;

            XmlDocument XMLDom = new XmlDocument();
            //load your xml file
            XMLDom.Load(xmlPath);

            XmlNodeList newXMLNodes = XMLDom.SelectNodes(_startNode);
            foreach (XmlNode newXMLNode in newXMLNodes)
                //Updating data where "Node1" is "sree" with "kambham"
                if (newXMLNode["ID"].InnerText == nodeID)
                    newXMLNode["FilePath"].InnerText = newPath;
            XMLDom.Save(xmlPath);
            XMLDom = null;
        }

        public  void UpdateNodeOrderNoByID(string nodeID, string newOrderNo)
        {
            string xmlPath = _xmlFile;

            XmlDocument XMLDom = new XmlDocument();
            //load your xml file
            XMLDom.Load(xmlPath);

            XmlNodeList newXMLNodes = XMLDom.SelectNodes(_startNode);

            foreach (XmlNode newXMLNode in newXMLNodes)
                if (newXMLNode["ID"].InnerText == nodeID)
                    newXMLNode["Order"].InnerText = newOrderNo;
            XMLDom.Save(xmlPath);
            XMLDom = null;
        }

        public void DeleteNodeByID(string nodeID)
        {
            string xmlPath = _xmlFile;

            XmlDocument XMLDom = new XmlDocument();
            //load your xml file
            XMLDom.Load(xmlPath);

            XmlNodeList newXMLNodes = XMLDom.SelectNodes(_startNode);
            foreach (XmlNode newXMLNode in newXMLNodes)
                //Updating data where "Node1" is "sree" with "kambham"
                if (newXMLNode["ID"].InnerText == nodeID)
                    newXMLNode.ParentNode.RemoveChild(newXMLNode);
            XMLDom.Save(xmlPath);
            XMLDom = null;
        }

        public string GetOrderNo(XmlDocument xmlDoc)
        {
            XmlNodeList newXMLNodes = xmlDoc.SelectNodes(_startNode);

            int biggestOrderNo = Convert.ToInt16((newXMLNodes.Item(0) as XmlNode)["Order"].InnerText);
            foreach (XmlNode newXMLNode in newXMLNodes)
            {
                int currentOrderNo = Convert.ToInt16(newXMLNode["Order"].InnerText);
                if (currentOrderNo>biggestOrderNo) biggestOrderNo = currentOrderNo;
            }
            biggestOrderNo++;
            return biggestOrderNo.ToString();
        }

        public string ShowBiggestOrderNo()
        {
            string strFilename = _xmlFile;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(strFilename);
            XmlNodeList newXMLNodes = xmlDoc.SelectNodes(_startNode);

            int biggestOrderNo = Convert.ToInt16((newXMLNodes.Item(0) as XmlNode)["Order"].InnerText);
            foreach (XmlNode newXMLNode in newXMLNodes)
            {
                //int i = string.Compare(, orderNo,);
                int currentOrderNo = Convert.ToInt16(newXMLNode["Order"].InnerText);
                if (currentOrderNo>biggestOrderNo) biggestOrderNo = currentOrderNo;
            }
            
            return biggestOrderNo.ToString();
        }

        public void AddNewNode(string nodeValue)
        {
            string strFilename = _xmlFile;
            XmlDocument xmlDoc = new XmlDocument();
            if (System.IO.File.Exists(strFilename))
            {
                xmlDoc.Load(strFilename);

                XmlElement elmRoot = xmlDoc.DocumentElement;
                XmlElement shortCut = xmlDoc.CreateElement("Instruction");

                //FIELDS
                XmlElement idNode = xmlDoc.CreateElement("ID");
                idNode.InnerText = DateTime.Now.ToBinary().ToString();

                XmlElement filePathNode = xmlDoc.CreateElement("Explanation");
                filePathNode.InnerText = "";

                XmlElement aliasNode = xmlDoc.CreateElement("InstructionBytes");
                aliasNode.InnerText = nodeValue;

                XmlElement orderNo = xmlDoc.CreateElement("Order");
                orderNo.InnerText = GetOrderNo(xmlDoc);

                shortCut.AppendChild(idNode);
                shortCut.AppendChild(filePathNode);
                shortCut.AppendChild(aliasNode);
                shortCut.AppendChild(orderNo);

                elmRoot.AppendChild(shortCut);
                xmlDoc.Save(strFilename);
            }

        }

        //public void ReadXMLShortcuts(System.Windows.Forms.TreeView targetTreeView )
        //{
        //    System.Data.DataSet ds = new System.Data.DataSet();
        //    string strFilename = _xmlFile;
        //    ds.ReadXml(strFilename);

        //    ds.Tables[0].DefaultView.Sort = "OrderNo";

        //    System.Data.DataView dv = ds.Tables[0].DefaultView;

        //    targetTreeView.Nodes.Clear();
        //    foreach (System.Data.DataRowView dvr in dv)
        //    {
        //        Shortcut s = new Shortcut(dvr["FilePath"].ToString().Trim(), dvr["Alias"].ToString().Trim());
        //        s.ID = dvr["ID"].ToString();
        //        s.OrderNo = dvr["OrderNo"].ToString();
        //        DataTreeNode d = new DataTreeNode(s);
        //        targetTreeView.Nodes.Add(d);
        //    }

        //}
    }
}
