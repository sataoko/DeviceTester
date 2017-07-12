using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DeviceTester
{
    public partial class frmMain : Form
    {
        private void SetConsoleMode()
        {
          if (rbConsoleIsInDeviceMode.Checked) _consoleMode = ConsoleMode.HEX;
          if (rbConsoleIsInDosMode.Checked) _consoleMode = ConsoleMode.DOS;
          if (rbConsoleIsInASCIIMode.Checked) _consoleMode = ConsoleMode.ASCII;
          if (rbConsoleIsInPythonMode.Checked) _consoleMode = ConsoleMode.Python;
        }

        private string GetHelpText()
        {
            return _consoleHelpText;
        }

        private bool ProcessInternalCommand(string command)
        {
            if (command == "cls")
                shellControl1.Clear();
            else if (command == "history")
            {
                string[] commands = shellControl1.GetCommandHistory();
                StringBuilder stringBuilder = new StringBuilder(commands.Length);
                foreach (string s in commands)
                {
                    stringBuilder.Append(s);
                    stringBuilder.Append(System.Environment.NewLine);
                }
                shellControl1.WriteText(stringBuilder.ToString());
            }
            else if (command == "help")
            {
                shellControl1.WriteText(GetHelpText());

            }
            else if (command.StartsWith("prompt"))
            {
                string[] parts = command.Split(new char[] { '=' });
                if (parts.Length == 2 && parts[0].Trim() == "prompt")
                    shellControl1.Prompt = parts[1].Trim();
            }
            else
                return false;

            return true;
        }

        
    }
}
