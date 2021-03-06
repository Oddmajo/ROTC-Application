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
    //NOTE: TAB sequence not working correctly for AddItemsMenu
    public partial class AddItemsMenu : Form
    {
        private string tempName;
        private uint tempLIN;
        private uint tempNSN;
        private uint tempNumTotal;
        private uint tempNumLeft;

        public AddItemsMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ExistingSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //This function is called when the user clicks the left finish button
        //It checks to make sure the user has selected the correct items and given the correct number
        //If so, the form terminates
        private void FinishButton1_Click(object sender, EventArgs e)
        {
            //Instead of just checking selected Text, maybe it should check the item itself and include the name designation 
            //no matter what it was selected with
            //
            uint number = Convert.ToUInt32(NumberAddedBox1.Text);//catch format exception
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rotcDB.accdb;Persist Security Info=True");
            con.Open();
            OleDbDataReader reader = null;
            String myString = "SELECT * FROM ITEM WHERE NSN = '" + NSNBox1.Text + "'";
            OleDbCommand myCommand = new OleDbCommand(myString, con);
            reader = myCommand.ExecuteReader();
            reader.Read();
            tempName = reader["Name"].ToString();
            CurrentItem.Text = NameBox.Text;
            CurrentNumber.Text = (string)reader["NumTotal"];
            String check = "Are you sure you want to increase the number of " + NameBox.Text + " in your inventory by "
                + NumberAddedBox1.Text + "?";
            reader.Close();
            con.Close();
            DialogResult DummyCheck = MessageBox.Show(check, "", MessageBoxButtons.YesNo);
            if (DummyCheck == DialogResult.Yes)
            {
                //add to dataBase Using sql
                con.Open();
                myString = "DECLARE @addvalue int; SET @addvalue = " + NumberAddedBox1.Text + "; UPDATE ITEM SET NumTotal = NumTotal+@addvalue, NumLeft = NumLeft+@addvalue WHERE NSN = '" + NSNBox1.Text + "'";
                myCommand = new OleDbCommand(myString, con);
                myCommand.ExecuteReader();
                con.Close();
                this.Close();
            }
        }

        //This function is called when the user clicks the right finish button
        //It makes sure the user has inputed the correct name, LIN, and NSN - as well as the correct number
        //If so, the form terminates
        private void FinishButton2_Click(object sender, EventArgs e)
        {

            String check = "Are you sure you want to add " + NumberAddedBox2.Text + " of " + NameBox.Text + "(LIN: " + LINBox.Text + ")(NSN: "+ NSNBox2.Text + ") to your inventory?";
            DialogResult DummyCheck = MessageBox.Show(check, "", MessageBoxButtons.YesNo);
            if (DummyCheck == DialogResult.Yes)
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rotcDB.accdb;Persist Security Info=True");
                con.Open();
                String myString = "INSERT INTO ITEM (NSN,LIN,Namme,NumTotal,NumLeft) VALUES ('" + NSNBox2.Text + "','" + LINBox.Text + "','" + NameBox.Text + "','" + NumberAddedBox2.Text + "','" + NumberAddedBox2.Text + "')";
                OleDbCommand myCommand = new OleDbCommand(myString, con);
                myCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("LIN Number: " + tempLIN + "\nNSN Number: " + tempNSN + "\nName: " + tempName + "\nQuantity: " + tempNumTotal);
                this.Close();
            }
                
        }

       

        private void NSNBox1_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = SearchButton;
        }


        //Needs to search Database for the item matching the NSN number in NSNBox1
        //It then needs to change CurrentItem and CurrentNumber to reflect the name and # of recovered item
        private void SearchButton_Click(object sender, EventArgs e)
        {
            CurrentItem.Text = "You changed";
        }

        private void NSNBox1_Leave(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = null;
        }

        private void LINBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
