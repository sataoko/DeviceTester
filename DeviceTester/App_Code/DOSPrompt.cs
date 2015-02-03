using System;
using System.Collections.Generic;
using System.Text;

namespace TCPDeviceTester
{
    class DOSPrompt
    {
        public static void CMDAutomate(string command, System.Windows.Forms.TextBox txtResults)
        {
            System.Diagnostics.Process myprocess = new System.Diagnostics.Process();
         
            System.Diagnostics.ProcessStartInfo StartInfo = new System.Diagnostics.ProcessStartInfo();

            StartInfo.FileName = "cmd";//starts cmd window
            StartInfo.RedirectStandardInput = true;
            StartInfo.RedirectStandardOutput = true;
            StartInfo.CreateNoWindow = true;
            StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            StartInfo.UseShellExecute = false;//'required to redirect
            myprocess.StartInfo = StartInfo;
            myprocess.Start();
            System.IO.StreamReader SR = myprocess.StandardOutput;
            System.IO.StreamWriter SW = myprocess.StandardInput;
            SW.WriteLine(command);// 'the command you wish to run.....
            SW.WriteLine("exit");// 'exits command prompt window
            txtResults.Text = SR.ReadToEnd(); //'returns results of the command window
            SW.Close();
            SR.Close();
        }
    }
}
