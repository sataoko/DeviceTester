using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TCPDeviceTester
{
    /* Class  :FileExplorer
     * Author : Chandana Subasinghe
     * Date   : 10/03/2006
     * Discription : This class use to create the tree view and load 
     *               directories and files in to the tree
     *          
     */
    class FileExplorer
    {
        public FileExplorer()
        {

        }

        /* Method :CreateTree
         * Author : Chandana Subasinghe
         * Date   : 10/03/2006
         * Discription : This is use to creat and build the tree
         *          
         */

        public bool CreateTree(TreeView treeView)
        {
            bool returnValue = false;

            try
            {
                // Create Desktop
                TreeNode desktop = new TreeNode();
                desktop.Text = "Desktop";
                desktop.Tag = "Desktop";
                desktop.Nodes.Add("");
                treeView.Nodes.Add(desktop);
                // Get driveInfo
                foreach (DriveInfo drv in DriveInfo.GetDrives())
                {

                    TreeNode fChild = new TreeNode();
                    if (drv.DriveType == DriveType.CDRom)
                    {
                        fChild.ImageIndex = 1;
                        fChild.SelectedImageIndex = 1;
                    }
                    else if (drv.DriveType == DriveType.Fixed)
                    {
                        fChild.ImageIndex = 0;
                        fChild.SelectedImageIndex = 0;
                    }
                    fChild.Text = drv.Name;
                    fChild.Nodes.Add("");
                    treeView.Nodes.Add(fChild);
                    returnValue = true;
                }

            }
            catch (Exception ex)
            {
                returnValue = false;
            }
            return returnValue;

        }

        public bool CreateTree(TreeView treeView, string startPath)
        {
            bool returnValue = false;

            try
            {
                // Create Desktop
                TreeNode desktop = new TreeNode();
                desktop.Text = "DeviceXMLs";// startPath;
                desktop.Tag = startPath;
                desktop.Nodes.Add("");
                treeView.Nodes.Add(desktop);
                returnValue = true;
            }
            catch (Exception ex)
            {
                returnValue = false;
            }
            return returnValue;
        }


        /* Method :EnumerateDirectory
         * Author : Chandana Subasinghe
         * Date   : 10/03/2006
         * Description : This is use to Enumerate directories and files
         *          
         */
        public TreeNode EnumerateDirectory(TreeNode parentNode)
        {
            try
            {
                DirectoryInfo rootDir;
                // To fill Desktop
                Char[] arr = { '\\' };
                string[] nameList = parentNode.FullPath.Split(arr);
                string path = "";
                
             //   if (nameList.GetValue(0).ToString() == "Desktop")
             //   {
             //       // path =  System.Environment.SpecialFolder.Desktop+"\\";
             //       path = "E:\\";
             //       for (int i = 1; i < nameList.Length; i++)
             //       {
             //           path = path + nameList[i] + "\\";
             //       }

             //       rootDir = new DirectoryInfo(path);
             //   }
             //   else if (nameList.GetValue(0).ToString() == "DeviceXMLs")
             //   {
             //       // path =  System.Environment.SpecialFolder.Desktop+"\\";
             //       path = Application.StartupPath+"\\DeviceXMLs";
             //       for (int i = 1; i < nameList.Length; i++)
             //       {
             //           path = path + nameList[i] + "\\";
             //       }

             //       rootDir = new DirectoryInfo(path);
             //   }
             //// for other Directories
             //   else
             //   {
             //       rootDir = new DirectoryInfo(parentNode.FullPath + "\\");
             //   }


                rootDir = new DirectoryInfo(parentNode.FullPath + "\\");

                parentNode.Nodes[0].Remove();
                foreach (DirectoryInfo dir in rootDir.GetDirectories())
                {
                    TreeNode node = new TreeNode();
                    node.Text = dir.Name;
                    node.Nodes.Add("");
                    parentNode.Nodes.Add(node);
                }
                //Fill files
                foreach (FileInfo file in rootDir.GetFiles())
                {
                    TreeNode node = new TreeNode();
                    node.Text = file.Name;
                    node.ImageIndex = 2;
                    node.SelectedImageIndex = 2;
                    parentNode.Nodes.Add(node);
                }
            }

            catch (Exception ex)
            {
                //TODO : 
            }

            return parentNode;
        }
    }
}