using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
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
            uint socSecurity = Convert.ToUInt32(SSBox.Text); //catch format exception
            int day = Convert.ToInt32(DayBox.Text);//catch format exception
            int month = Convert.ToInt32(MonthBox.Text);//catch format exception
            int year = Convert.ToInt32(YearBox.Text);//catch format exception
            uint rank = Convert.ToUInt32(RankBox.Text);//catch format exception
            string school = SchoolBox.Text;


            //-----------------------------------------------------------TODO
            //NEEDS TO BE UPDATED TO MICROSOFT ACCESS DATABASE
            //-----------------------------------------------------------TODO
            //This will need to take information from the form and add a person to the database
            //It will need to check for incomplete or incompatable data
            //Currently it will just close the window
            String check = "Are you sure you want to add " + first + " " + last + " to your personnel list?";
            DialogResult DummyCheck = MessageBox.Show(check, "", MessageBoxButtons.YesNo);
            if (DummyCheck == DialogResult.Yes)
            {
                DateTime myDateTime = new DateTime(year, month, day);
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Matthew\Documents\myDb.mdf;Integrated Security=True;");
                con.Open();
                String myString = "INSERT INTO PERSON (LName,FName,School,MsNum,SOC,DOB) VALUES ('" + last + "','" + first + "','" + school + "','" + rank + "','" + socSecurity + "','" + myDateTime + "')";
                SqlCommand myCommand = new SqlCommand(myString, con);
                myCommand.ExecuteReader();
                con.Close();
                MessageBox.Show(first + " " + last + "\nSocSec: xxx-xx-" + socSecurity
                     + "\nBirthday: " + day + "/" + month + "/" + year + "\nRank: " + rank + "\nSchool: " + school);

                this.Close();
            }
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
