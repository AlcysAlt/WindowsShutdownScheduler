using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int timeLeftToShutdown;
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        { seconds_txt.Text = "0";
          minutes_txt.Text = "0";
            hours_txt.Text = "0";
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void seconds_txt_TextChanged(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Timer Started");
            var shutdownTimer = Convert.ToString((Double.Parse(hours_txt.Text) * 3600) + (Double.Parse(minutes_txt.Text) * 60) + Double.Parse(seconds_txt.Text));
            int timeLeftToShutdown = Convert.ToInt32(shutdownTimer);
            var psi = new ProcessStartInfo("shutdown", "/s /t " + shutdownTimer);
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        public void minutes_txt_TextChanged(object sender, EventArgs e)
        {

        }



        private void abortShutdown_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shutdown Cancelled");
            var cancelShutdown = new ProcessStartInfo("shutdown", "/a");
            cancelShutdown.CreateNoWindow = true;
            cancelShutdown.UseShellExecute = false;
            Process.Start(cancelShutdown);
        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
