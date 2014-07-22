using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenioColletor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            { 
                Hide();
                VCNotification.ShowBalloonTip(1000);
            }
            

            
        }

        private void VCNotification_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();

            if (DateTime.Now.Second % 2 == 0)
                lblStatus.Text = "Collecting files in the folder 'User Desktop'";
            else
                lblStatus.Text = "Collecting files in the folder 'System windows'";

            WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
            
            lblStatus.Text = "";
        }

        private void VCNotificationCMenu_Click(object sender, EventArgs e)
        {

        }

        private void cmRestore_Click(object sender, EventArgs e)
        {
            Show();

            if (DateTime.Now.Second % 2 == 0)
                lblStatus.Text = "Collecting files in the folder 'User Desktop' with upgraded version";
            else
                lblStatus.Text = "Collecting files in the folder 'System windows' with upgraded version";

            WindowState = FormWindowState.Normal;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
