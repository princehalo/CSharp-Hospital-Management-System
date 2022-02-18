using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDI_Hospital_Management_System
{
    public partial class PatientDetails : UserControl
    {
        public PatientDetails()
        {
            InitializeComponent();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            panel1.Width = 180;
            panel1.Height = 251;
            panel1.BringToFront();
        }

        private void filterButton_Leave(object sender, EventArgs e)
        {
            panel1.Width = 45;
            panel1.Height = 37;
        }
    }
}
