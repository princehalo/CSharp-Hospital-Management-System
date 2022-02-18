using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace EDI_Hospital_Management_System
{
    public partial class FDeskMenu : UserControl
    {
        
        public FDeskMenu()
        {
            InitializeComponent();
        }

        private void newPatBtn_Enter(object sender, EventArgs e)
        {
            newPatBtn.BackColor = Color.FromArgb(0, 102, 122);
        }
        private void newPatBtn_Leave(object sender, EventArgs e)
        {
            newPatBtn.BackColor = Color.Transparent;
        }

        private void newPatBtn_Click(object sender, EventArgs e)
        {
            FDeskMenu fDeskMenu1 = new FDeskMenu();
            this.Controls.Add(fDeskMenu1);
            fDeskMenu1.Visible = false;
            this.Hide();
            NewPatient newPatient1 = new NewPatient();
            newPatient1.Visible = true;
        }

    }

}
