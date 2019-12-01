using System;
using System.Windows.Forms;
using System.IO;

namespace ServiceLocatorPatternWinFormsApp
{
    public partial class Form1 : Form
    {
        private StreamWriter logFile;
        
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var message = "Button 1 Clicked";
            this.label1.Text +=  message + Environment.NewLine;
            LogUserActions(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var message = "Button 2 Clicked";
            this.label1.Text += message + Environment.NewLine;
            LogUserActions(message);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogUserActions(string txt)
        {
            if(logFile == null)
            {
                logFile = new StreamWriter("actions.log");
            }
            logFile.WriteLine(txt);
            logFile.Flush();
        }
        
    }
}
