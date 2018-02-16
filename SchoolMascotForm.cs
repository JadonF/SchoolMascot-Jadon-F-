/*
 * Created by: Jadon Fournier
 * Created on: Thursday, Feb. 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - SchoolMascot
 * This program shows the names of schools with the name of their mascot. You can use the menu to either exit the program, or change the school shown.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SchoolMascot_Jadon_F_
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void mniSchools_Click(object sender, EventArgs e)
        {

        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {

            lblSchool.Text = "Immaculata";
            lblMascot.Text = "Saints";
        }

        private void mniStJoes_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Saint Joe's";
            lblMascot.Text = "Coffee Cups";
        }

        private void mniMotherTeresa_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Mother Teresa";
            lblMascot.Text = "Alligators";
        }

        private void mniStMarks_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Saint Mark's";
            lblMascot.Text = "Matresses";
        }

        private void lblSchool_Click(object sender, EventArgs e)
        {

        }

        private void lblMascot_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
