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
    public partial class BaseMenu : Form
    {
        public BaseMenu()
        {
            InitializeComponent();
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            AddPersonMenu form = new AddPersonMenu();
            form.Show(this);
        }

        private void RemovePersonButton_Click(object sender, EventArgs e)
        {
            RemovePersonMenu form = new RemovePersonMenu();
            form.Show(this);
        }

        private void ManageAssignedGearButton_Click(object sender, EventArgs e)
        {
            ManageAssignedGearMenu form = new ManageAssignedGearMenu();
            form.Show(this);
        }

        private void ViewRosterButton_Click(object sender, EventArgs e)
        {
            ViewRosterMenu form = new ViewRosterMenu();
            form.Show(this);
        }

        private void AddItemsButton_Click(object sender, EventArgs e)
        {
            AddItemsMenu form = new AddItemsMenu();
            form.Show(this);
        }

        private void RemoveItemsButton_Click(object sender, EventArgs e)
        {
            RemoveItemsMenu form = new RemoveItemsMenu();
            form.Show(this);
        }

        private void ViewInventoryButton_Click(object sender, EventArgs e)
        {
            ViewInventoryMenu form = new ViewInventoryMenu();
            form.Show(this);
        }
    }
}
