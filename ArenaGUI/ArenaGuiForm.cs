using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ArenaGUI
{
    public partial class ArenaGuiForm : Form
    {
        private Process process;
        public ArenaGuiForm()
        {
            InitializeComponent();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            //for(int i = 0; i < 1000; i++)
            //{
            //    messageRichTextBox.AppendText($"{i}\n");
            //    messageRichTextBox.ScrollToCaret();
            //}
            process = new Process();
            process.StartInfo.FileName = "Echo.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            while(!process.HasExited)
            {
                process.StandardInput.WriteLine("test");
                process.StandardInput.Flush();
                messageRichTextBox.AppendText($"{process.StandardOutput.ReadLine()}\n");
            }
        }
    }
}
