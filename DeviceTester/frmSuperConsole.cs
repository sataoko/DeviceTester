using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeviceTester
{
    public partial class frmSuperConsole : Form
    {
        private string helpText;

        public frmSuperConsole()
        {
            InitializeComponent();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("ShellControl Demo");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("*******************************************");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("Commands Available");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("(1) All DOS commands that operate on a single line");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("(2) prompt - Changes prompt. Usage (prompt=<desired_prompt>");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("(3) history - prints history of entered commands");
            stringBuilder.Append(System.Environment.NewLine);
            stringBuilder.Append("(4) cls - Clears the screen");
            stringBuilder.Append(System.Environment.NewLine);

            helpText = stringBuilder.ToString();
        }
        private string GetHelpText()
        {
            return helpText;
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

        private void shellControl1_CommandEntered(object sender, CommandEnteredEventArgs e)
        {
            if (!ProcessInternalCommand(e.Command))
            {
                if (rbDos.Checked)
                {
                    string s = DOSPrompt.CMDAutomate(e.Command);
                    shellControl1.WriteText(s);
                    txtLastOutput.Text = s;

                }

                if (rbASCII.Checked)
                {
                    byte[] r = Common.SendBytes(txtIP.Text, txtPort.Text, ASCIIEncoding.ASCII.GetBytes(e.Command));
                    shellControl1.WriteText(ASCIIEncoding.ASCII.GetString(r));
                }

                if (rbHEX.Checked)
                {
                    byte[] r = Common.SendBytes(txtIP.Text, txtPort.Text, Common.GetBytesFromHex(e.Command));
                    shellControl1.WriteText(ASCIIEncoding.ASCII.GetString(r));
                }
            }
            
        }

        private void lnkSelectDosCommand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNetworkCommands x = new frmNetworkCommands();
            if (x.ShowDialog() == DialogResult.OK)
            {
                shellControl1.SetCommand(x.DOSCommand);
            }
        }
    }
}
