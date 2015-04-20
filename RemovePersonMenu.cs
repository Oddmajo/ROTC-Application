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
    public partial class RemovePersonMenu : Form
    {
        public RemovePersonMenu()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            //This will need to remove the desired person from the database
            //Currently it will just close the window
            String check = "Are you sure you want to remove " + FirstNameBox.Text + " " + LastNameBox.Text + " from your personnel list?";
            DialogResult DummyCheck = MessageBox.Show(check,"",MessageBoxButtons.YesNo);
            if(DummyCheck==DialogResult.Yes)
                this.Close();
        }

        private void RemovePersonMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
