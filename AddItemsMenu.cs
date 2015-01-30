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
    //NOTE: TAB sequence not working correctly for AddItemsMenu
    public partial class AddItemsMenu : Form
    {
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
            CurrentNumber.Text = "Test";
            String selected = ExistingSelect.Text;
            if (selected.Equals("Example Item 1",StringComparison.Ordinal))
                CurrentNumber.Text = "5";
            if (selected.Equals("Example Item 2",StringComparison.Ordinal))
                CurrentNumber.Text = "10";

        }

        //This function is called when the user clicks the left finish button
        //It checks to make sure the user has selected the correct items and given the correct number
        //If so, the form terminates
        private void FinishButton1_Click(object sender, EventArgs e)
        {
            //Instead of just checking selected Text, maybe it should check the item itself and include the name designation 
            //no matter what it was selected with
            //
            String number = NumberAddedBox1.Text;

            String check = "Are you sure you want to increase the number of " + ExistingSelect.Text + " in your inventory by "
                + number + "?";
            DialogResult DummyCheck = MessageBox.Show(check, "", MessageBoxButtons.YesNo);
            if (DummyCheck == DialogResult.Yes)
                this.Close();
        }

        //This function is called when the user clicks the right finish button
        //It makes sure the user has inputed the correct name, LIN, and NSN - as well as the correct number
        //If so, the form terminates
        private void FinishButton2_Click(object sender, EventArgs e)
        {
            String numLIN = LINBox.Text;
            String numNSN = NSNBox.Text;
            String name = NameBox.Text;
            String number = NumberAddedBox2.Text;

            String check = "Are you sure you want to add " + number + " of " + name + "(LIN: " + numLIN + ")(NSN: "+ numNSN + ") to your inventory?";
            DialogResult DummyCheck = MessageBox.Show(check, "", MessageBoxButtons.YesNo);
            if (DummyCheck == DialogResult.Yes)
            {
                MessageBox.Show("LIN Number: " + numLIN + "\nNSN Number: " + numNSN + "\nName: " + name + "\nQuantity: " + number);
                this.Close();
            }
                
        }
    }
}
