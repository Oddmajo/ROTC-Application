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
            this.Close();
        }
    }
}
