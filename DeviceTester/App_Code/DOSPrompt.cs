using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceTester
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

        public static string CMDAutomate(string command)
        {
            try
            {

                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
                startInfo.Arguments = "/C " + command;
                startInfo.RedirectStandardError = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                System.Diagnostics.Process p = System.Diagnostics.Process.Start(startInfo);
                string output = p.StandardOutput.ReadToEnd();
                string error = p.StandardError.ReadToEnd();

                p.WaitForExit();
                if (output.Length != 0)
                    return output;
                else if (error.Length != 0)
                    return error;
                else return "...";


                
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public static string CMDAutomate(string arguments,string program)
        {
            try
            {

                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo(program);
                startInfo.Arguments =arguments;
                startInfo.RedirectStandardError = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                System.Diagnostics.Process p = System.Diagnostics.Process.Start(startInfo);
                string output = p.StandardOutput.ReadToEnd();
                string error = p.StandardError.ReadToEnd();

                p.WaitForExit();
                if (output.Length != 0)
                    return output;
                else if (error.Length != 0)
                    return error;
                else return "...";



            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string RunPython(string args)
        {
            return DOSPrompt.CMDAutomate(args, "C:\\python3.5\\python.exe");
        }

        public static string RunPythonFile(string fileName,string args)
        {
            string path = "\"" + System.Windows.Forms.Application.StartupPath + "\\Py\\"+fileName+"\" ";
            return DOSPrompt.CMDAutomate(path +args, "C:\\python3.5\\python.exe");
        }
    }
}


/*System.Diagnostics.Process myprocess = new System.Diagnostics.Process();

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

                string s =SR.ReadToEnd(); //'returns results of the command window

                SW.Close();
                SR.Close();
                return s;*/