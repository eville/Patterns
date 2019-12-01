using System;
using System.Windows.Forms;

namespace ServiceLocatorAdvanced
{
    public partial class Form1 : Form
    {
        private ILog log = ServiceLocator.GetService<ILog>("logger");
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var message = "Button 1 Clicked";
            this.label1.Text += message + Environment.NewLine;
            log.Log(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var message = "Button 2 Clicked";
            this.label1.Text += message + Environment.NewLine;
            log.Log(message);
        }
    }
}
