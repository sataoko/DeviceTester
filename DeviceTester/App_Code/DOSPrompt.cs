using System;
using System.Collections.Generic;
using System.Text;

namespace DeviceTester
{
    public class DOSPrompt
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
            string pythonExePath = Ini.IniFile.GetValue("Python", "ExePath");
            if (System.IO.File.Exists(pythonExePath))
            {
                return DOSPrompt.CMDAutomate(args, pythonExePath);
            }
            else return "error: " + pythonExePath + " not correct.";
        }

        public static string RunPythonFile(string fileName,string args)
        {
            string pythonExePath = Ini.IniFile.GetValue("Python","ExePath");
            if (System.IO.File.Exists(pythonExePath))
            {
                string pythonFilePath = "\"" + System.Windows.Forms.Application.StartupPath + "\\PythonFiles\\" + fileName + "\" ";
                string pythonFilePath2 = System.Windows.Forms.Application.StartupPath + "\\PythonFiles\\" + fileName;
                if (System.IO.File.Exists(pythonFilePath2))
                    return DOSPrompt.CMDAutomate(pythonFilePath + args, pythonExePath);
                else return "error : " + pythonExePath + " not found.";
            }
            else return "error : "+ pythonExePath + " not found.";
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