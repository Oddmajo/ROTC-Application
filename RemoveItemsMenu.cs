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
    public partial class RemoveItemsMenu : Form
    {
        public RemoveItemsMenu()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            String number = (NumberRemovedSelect.Value).ToString();

            String check = "Are you sure you want to remove " + number + " (max: " + CurrentNumber.Text + ") of "
                + number + " from your inventory?";
            DialogResult DummyCheck = MessageBox.Show(check, "", MessageBoxButtons.YesNo);
            if (DummyCheck == DialogResult.Yes)
            {
                //subtract number from numLeft and NumTotal in database
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            uint selected = Convert.ToUInt32(textBox1.Text);
            //Find numtotal and numleft from the database and update label2 with name and currentNumber with numTotal
        }
    }
}
