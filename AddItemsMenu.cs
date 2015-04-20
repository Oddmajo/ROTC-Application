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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Matthew\Documents\myDb.mdf;Integrated Security=True;");
            con.Open();
            SqlDataReader reader = null;
            String myString = "SELECT * FROM ITEM WHERE NSN = '" + tempNSN + "'";
            SqlCommand myCommand = new SqlCommand(myString, con);
            reader = myCommand.ExecuteReader();
            reader.Read();
            tempName = reader["Name"].ToString();
            label2.Text = tempName;
            CurrentNumber.Text = (string)reader["NumTotal"];
            String check = "Are you sure you want to increase the number of " + tempName + " in your inventory by "
                + number + "?";
            reader.Close();
            con.Close();
            DialogResult DummyCheck = MessageBox.Show(check, "", MessageBoxButtons.YesNo);
            if (DummyCheck == DialogResult.Yes)
            {
                //add to dataBase Using sql
                con.Open();
                myString = "DECLARE @addvalue int; SET @addvalue = " + number + "; UPDATE ITEM SET NumTotal = NumTotal+@addvalue, NumLeft = NumLeft+@addvalue WHERE NSN = '" + tempNSN + "'";
                myCommand = new SqlCommand(myString, con);
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

            String check = "Are you sure you want to add " + tempNumTotal + " of " + tempName + "(LIN: " + tempLIN + ")(NSN: "+ tempNSN + ") to your inventory?";
            DialogResult DummyCheck = MessageBox.Show(check, "", MessageBoxButtons.YesNo);
            if (DummyCheck == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Matthew\Documents\myDb.mdf;Integrated Security=True;");
                con.Open();
                String myString = "INSERT INTO ITEM (NSN,LIN,Name,NumTotal,NumLeft) VALUES ('" + tempNSN + "','" + tempLIN + "','" + tempName + "','" + tempNumTotal + "','" + tempNumLeft + "')";
                SqlCommand myCommand = new SqlCommand(myString, con);
                myCommand.ExecuteReader();
                con.Close();
                MessageBox.Show("LIN Number: " + tempLIN + "\nNSN Number: " + tempNSN + "\nName: " + tempName + "\nQuantity: " + tempNumTotal);
                this.Close();
            }
                
        }

        private void LINBox_TextChanged(object sender, EventArgs e)
        {
            tempLIN = Convert.ToUInt32(LINBox.Text);
        }

        private void NSNBox_TextChanged(object sender, EventArgs e)
        {
            tempNSN = Convert.ToUInt32(NSNBox.Text);//catch format exception
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            tempName = NameBox.Text;
        }

        private void NumberAddedBox2_TextChanged(object sender, EventArgs e)
        {
            tempNumTotal = Convert.ToUInt32(NumberAddedBox2.Text);//catch format exception
            tempNumLeft = tempNumTotal;
        }

        private void NSNButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NSNButton_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void NumberAddedBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentNumber_Click(object sender, EventArgs e)
        {

        }

    }
}
