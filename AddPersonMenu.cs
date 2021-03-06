﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
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
            bool error = false;

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
                DateTime myDateTime;
                try
                {
                    myDateTime = new DateTime(year, month, day);
                    if (rank < 1 || rank > 5)
                    {
                        throw new ArgumentOutOfRangeException(null, "MS level out of range");
                    }
                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rotcDB.accdb;Persist Security Info=True");
                    con.Open();
                    String myString = "INSERT INTO PERSON (LName,FName,School,MsNum,SOC,DOB) VALUES ('" + last + "','" + first + "','" + school + "','" + rank + "','" + socSecurity + "','" + myDateTime + "')";
                    OleDbCommand myCommand = new OleDbCommand(myString, con);
                    myCommand.ExecuteReader();
                    con.Close();
                    MessageBox.Show(first + " " + last + "\nSocSec: xxx-xx-" + socSecurity
                         + "\nBirthday: " + day + "/" + month + "/" + year + "\nRank: " + rank + "\nSchool: " + school);

                    this.Close();
                }

                //STILL BROKEN CANT CATCH ALL OF SAME TYPE OF ERROR AT ONCE
                catch (Exception ex)
                {
                    if (ex is ArgumentOutOfRangeException)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (ex is FormatException)
                    {
                        MessageBox.Show("Please make sure every box is filled out.");
                        return;
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MonthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MonthBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
