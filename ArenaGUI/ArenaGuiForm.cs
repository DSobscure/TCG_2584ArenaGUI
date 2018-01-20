using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ArenaGUI
{
    public partial class ArenaGuiForm : Form
    {
        private RemoteConnector connector;
        private Process process;
        public ArenaGuiForm()
        {
            InitializeComponent();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            if(programOpenFileDialog.FileName == null || !File.Exists(programOpenFileDialog.FileName))
            {
                MessageBox.Show("Program path required!");
                return;
            }
            if(ipTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("IP required!");
                return;
            }
            int port;
            if (portTextBox.Text.Trim().Length == 0 || !int.TryParse(portTextBox.Text.Trim(), out port))
            {
                MessageBox.Show("Port (int type) required!");
                return;
            }
            connector = new RemoteConnector(ipTextBox.Text.Trim(), port);

            StringBuilder argumentsBuilder = new StringBuilder();
            argumentsBuilder.Append($"{extraArgumentsTextBox.Text} ");
            if(debugModeCheckBox.Checked)
                argumentsBuilder.Append("--debug ");
            argumentsBuilder.Append($"--play=\"{playerArgumentsTextBox.Text}\" ");
            argumentsBuilder.Append($"--evil=\"{evilArgumentsTextBox.Text}\" ");

            process = new Process();
            process.StartInfo.FileName = programOpenFileDialog.FileName;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = argumentsBuilder.ToString();

            messageRichTextBox.AppendText($"{programOpenFileDialog.FileName} {argumentsBuilder.ToString()}\n");
            messageRichTextBox.ScrollToCaret();

            process.Start();
            connector.OnMessage += ForwardMessage;

            if (!connector.Connect())
            {
                MessageBox.Show("Connect failed!");
            }
            else
            {
                connectionSettingGroupBox.Enabled = false;
                programArgumentsGroupBox.Enabled = false;
                launchButton.Enabled = false;
                controlGroupBox.Enabled = true;
            }

            Task.Run(() =>
            {
                while (!process.HasExited)
                {
                    string programOutput = process.StandardOutput.ReadLine();
                    messageRichTextBox.InvokeIfRequired(() => messageRichTextBox.AppendText($"{programOutput}"));
                    messageRichTextBox.InvokeIfRequired(() => messageRichTextBox.ScrollToCaret());
                    connector.SendMessage(programOutput + "\n");
                }
            });
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void selectProgramButton_Click(object sender, EventArgs e)
        {
            programOpenFileDialog.ShowDialog();
        }

        private void ForwardMessage(string message)
        {
            if(messageRichTextBox.Lines.Length > 500)
            {
                messageRichTextBox.InvokeIfRequired(() => messageRichTextBox.Clear());
            }
            messageRichTextBox.InvokeIfRequired(() => messageRichTextBox.AppendText($"{message}"));
            messageRichTextBox.InvokeIfRequired(() => messageRichTextBox.ScrollToCaret());
            if(message.Contains("summary:") || message.Contains("score"))
            {
                recordRichTextBox.InvokeIfRequired(() => recordRichTextBox.AppendText($"{message}"));
                recordRichTextBox.InvokeIfRequired(() => recordRichTextBox.ScrollToCaret());
                messageRichTextBox.InvokeIfRequired(() => messageRichTextBox.Clear());
            }
            process.StandardInput.WriteLine(message);
            process.StandardInput.Flush();
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            connector.SendMessage("status\n");
        }

        private void renameButton_Click(object sender, EventArgs e)
        {
            connector.SendMessage($"name {usernameTextBox.Text}\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (playNameTextBox.Text.Trim().Length != 0)
            {
                connector.SendMessage($"register {playNameTextBox.Text} as play\n");
            }
            if (evilNameTextBox.Text.Trim().Length != 0)
            {
                connector.SendMessage($"register {evilNameTextBox.Text} as evil\n");
            }
        }

        private void sendCommandButton_Click(object sender, EventArgs e)
        {
            if (commandTextBox.Text.Trim().Length != 0)
            {
                connector.SendMessage($"{commandTextBox.Text}\n");
            }
        }
    }

    public static class Extension
    {
        public static void InvokeIfRequired(
            this Control control, MethodInvoker action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
