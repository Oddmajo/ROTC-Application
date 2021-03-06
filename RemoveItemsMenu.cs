﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ROTC_Application
{
    public partial class RemoveItemsMenu : Form
    {
        private string tempName;
        private uint tempLIN;
        private uint tempNSN;
        private uint tempNumTotal;
        private uint tempNumLeft;

        public RemoveItemsMenu()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------TODO
        //NEEDS TO BE UPDATED TO MICROSOFT ACCESS DATABASE
        //-----------------------------------------------------------TODO
        private void FinishButton_Click(object sender, EventArgs e)
        {
            uint number = Convert.ToUInt32(NumberRemovedSelect.Text);//catch format exception
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rotcDB.accdb;Persist Security Info=True");
            con.Open();
            OleDbDataReader reader = null;
            String myString = "SELECT * FROM ITEM WHERE NSN = '" + tempNSN + "'";
            OleDbCommand myCommand = new OleDbCommand(myString, con);
            reader = myCommand.ExecuteReader();
            reader.Read();
            tempName = reader["Name"].ToString();
            label2.Text = tempName;
            CurrentNumber.Text = (string)reader["NumTotal"];
            String check = "Are you sure you want to decrease the number of " + tempName + " in your inventory by "
                + number + "?";
            reader.Close();
            con.Close();
            
            DialogResult DummyCheck = MessageBox.Show(check, "", MessageBoxButtons.YesNo);
            if (DummyCheck == DialogResult.Yes)
            {
                //subtract number from numLeft and NumTotal in database
                con.Open();
                myString = "DECLARE @subvalue int; SET @subvalue = " + number + "; UPDATE ITEM SET NumTotal = NumTotal-@subvalue, NumLeft = NumLeft-@subvalue WHERE NSN = '" + tempNSN + "'";
                myCommand = new OleDbCommand(myString, con);
                myCommand.ExecuteReader();
                con.Close();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RemoveItemsMenu_Load(object sender, EventArgs e)
        {

        }

        private void NumberRemovedSelect_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
