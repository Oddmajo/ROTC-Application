using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROTC_Application
{
    public partial class AddPersonMenu : Form
    {
        public AddPersonMenu()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            string first = FirstNameBox.Text;
            string last = LastNameBox.Text;
            string socSecurity = SSBox.Text;
            string day = DayBox.Text;
            string month = MonthBox.Text;
            string year = YearBox.Text;
            string grade = CheckYear();
            string rank = RankBox.Text;
            string school = SchoolBox.Text;

            

            //This will need to take information from the form and add a person to the database
            //It will need to check for incomplete or incompatable data
            //Currently it will just close the window
            String check = "Are you sure you want to add " + first + " " + last + " to your personnel list?";
            DialogResult DummyCheck = MessageBox.Show(check,"",MessageBoxButtons.YesNo);
            if (DummyCheck == DialogResult.Yes)
            {
                MessageBox.Show(first + " " + last + "\nSocSec: xxx-xx-" + socSecurity
                     + "\nBirthday: " + day + "/" + month + "/" + year + "\nGrade: " + grade + "\nRank: " + rank
                     + "\nSchool: " + school);

                this.Close();
            }
        }

        string CheckYear() 
        {
            if (FreshButton.Checked)
                return FreshButton.Text;
            if (SophButton.Checked)
                return SophButton.Text;
            if (JunButton.Checked)
                return JunButton.Text;
            if (SenButton.Checked)
                return SenButton.Text;
            return "";            
        }

    }
}
