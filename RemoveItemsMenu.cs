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

        private void Selected_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = Selected.Text;
            if (selected.Equals("Example Item 1", StringComparison.Ordinal))
            {
                CurrentNumber.Text = "5";
                NumberRemovedSelect.Maximum = 5;
            }
            if (selected.Equals("Example Item 2", StringComparison.Ordinal))
            {
                CurrentNumber.Text = "10";
                NumberRemovedSelect.Maximum = 10;
            }
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            String number = (NumberRemovedSelect.Value).ToString();

            String check = "Are you sure you want to remove " + number + " (max: " + CurrentNumber.Text + ") of "
                + Selected.Text + " from your inventory?";
            DialogResult DummyCheck = MessageBox.Show(check, "", MessageBoxButtons.YesNo);
            if (DummyCheck == DialogResult.Yes)
                this.Close();
        }
    }
}
