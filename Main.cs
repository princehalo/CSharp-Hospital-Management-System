using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDI_Hospital_Management_System
{
    public partial class Main : Form
    {
   
        
        public Main()
        {
            InitializeComponent();
            Load += new EventHandler(Main_Load);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DtTimer.Start();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DtTimer_Tick(object sender, EventArgs e)
        {
            DtLabel.Text = DateTime.Now.ToLongDateString();
            TimeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void frontDeskBtn_Click(object sender, EventArgs e)
        {
            fDeskMenu1.Visible = true;
            fDeskMenu1.BringToFront();
        }

        private void DptBtn_Click(object sender, EventArgs e)
        {
            dptMenu1.Visible = true;
            dptMenu1.BringToFront();
            if (dptMenu1.Visible)
                DptBtn.BackColor = Color.FromArgb(0, 85, 102);
            else
                DptBtn.BackColor = Color.Transparent;
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            patientsMenu1.Visible = true;
            patientsMenu1.BringToFront();
            if (patientsMenu1.Visible)
                patientsBtn.BackColor = Color.FromArgb(0, 85, 102);
            else if (!adminMenu1.Visible)
                patientsBtn.BackColor = Color.Transparent;
        }

        private void adminMnuBtn_Click(object sender, EventArgs e)
        {
            adminMenu1.Visible = true;
            adminMenu1.BringToFront();
            if (adminMenu1.Visible)
                adminMnuBtn.BackColor = Color.FromArgb(0, 85, 102);
            else if (!adminMenu1.Visible)
            {
                adminMnuBtn.BackColor = Color.Transparent;
            }
                
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {

        }

        private void cshUnitBtn_Click(object sender, EventArgs e)
        {
            cashUnit1.Visible = true;
            cashUnit1.BringToFront();
        }

        private void hmoNhisAcctBtn_Click(object sender, EventArgs e)
        {
            hmoNhisAcct1.Visible = true;
            hmoNhisAcct1.BringToFront();
        }

        private void newPatBtn_Click(object sender, EventArgs e)
        {
            newPatient1.Visible = true;
            newPatient1.BringToFront();
        }
    }
}
