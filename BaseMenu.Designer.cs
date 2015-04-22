namespace ROTC_Application
{
    partial class BaseMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseMenu));
            this.ViewInventoryButton = new System.Windows.Forms.Button();
            this.RemoveItemsButton = new System.Windows.Forms.Button();
            this.AddItemsButton = new System.Windows.Forms.Button();
            this.ViewRosterButton = new System.Windows.Forms.Button();
            this.ManageAssignedGearButton = new System.Windows.Forms.Button();
            this.RemovePersonButton = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewInventoryButton
            // 
            this.ViewInventoryButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ViewInventoryButton.Location = new System.Drawing.Point(581, 189);
            this.ViewInventoryButton.Name = "ViewInventoryButton";
            this.ViewInventoryButton.Size = new System.Drawing.Size(253, 68);
            this.ViewInventoryButton.TabIndex = 23;
            this.ViewInventoryButton.Text = "View Inventory";
            this.ViewInventoryButton.UseVisualStyleBackColor = true;
            this.ViewInventoryButton.Click += new System.EventHandler(this.ViewInventoryButton_Click);
            // 
            // RemoveItemsButton
            // 
            this.RemoveItemsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RemoveItemsButton.Location = new System.Drawing.Point(295, 189);
            this.RemoveItemsButton.Name = "RemoveItemsButton";
            this.RemoveItemsButton.Size = new System.Drawing.Size(253, 68);
            this.RemoveItemsButton.TabIndex = 22;
            this.RemoveItemsButton.Text = "Remove Items";
            this.RemoveItemsButton.UseVisualStyleBackColor = true;
            this.RemoveItemsButton.Click += new System.EventHandler(this.RemoveItemsButton_Click);
            // 
            // AddItemsButton
            // 
            this.AddItemsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddItemsButton.Location = new System.Drawing.Point(8, 189);
            this.AddItemsButton.Name = "AddItemsButton";
            this.AddItemsButton.Size = new System.Drawing.Size(253, 68);
            this.AddItemsButton.TabIndex = 21;
            this.AddItemsButton.Text = "Add Items";
            this.AddItemsButton.UseVisualStyleBackColor = true;
            this.AddItemsButton.Click += new System.EventHandler(this.AddItemsButton_Click);
            // 
            // ViewRosterButton
            // 
            this.ViewRosterButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ViewRosterButton.Location = new System.Drawing.Point(581, 40);
            this.ViewRosterButton.Name = "ViewRosterButton";
            this.ViewRosterButton.Size = new System.Drawing.Size(253, 68);
            this.ViewRosterButton.TabIndex = 20;
            this.ViewRosterButton.Text = "View Roster";
            this.ViewRosterButton.UseVisualStyleBackColor = true;
            this.ViewRosterButton.Click += new System.EventHandler(this.ViewRosterButton_Click);
            // 
            // ManageAssignedGearButton
            // 
            this.ManageAssignedGearButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ManageAssignedGearButton.Location = new System.Drawing.Point(295, 40);
            this.ManageAssignedGearButton.Name = "ManageAssignedGearButton";
            this.ManageAssignedGearButton.Size = new System.Drawing.Size(253, 68);
            this.ManageAssignedGearButton.TabIndex = 19;
            this.ManageAssignedGearButton.Text = "Manage Assigned Gear";
            this.ManageAssignedGearButton.UseVisualStyleBackColor = true;
            this.ManageAssignedGearButton.Click += new System.EventHandler(this.ManageAssignedGearButton_Click);
            // 
            // RemovePersonButton
            // 
            this.RemovePersonButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RemovePersonButton.Location = new System.Drawing.Point(145, 40);
            this.RemovePersonButton.Name = "RemovePersonButton";
            this.RemovePersonButton.Size = new System.Drawing.Size(116, 68);
            this.RemovePersonButton.TabIndex = 18;
            this.RemovePersonButton.Text = "Remove Person";
            this.RemovePersonButton.UseVisualStyleBackColor = true;
            this.RemovePersonButton.Click += new System.EventHandler(this.RemovePersonButton_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddPersonButton.Location = new System.Drawing.Point(8, 40);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(116, 68);
            this.AddPersonButton.TabIndex = 17;
            this.AddPersonButton.Text = "Add Person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(27, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Manage Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Manage Personnel";
            // 
            // BaseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 277);
            this.Controls.Add(this.ViewInventoryButton);
            this.Controls.Add(this.RemoveItemsButton);
            this.Controls.Add(this.AddItemsButton);
            this.Controls.Add(this.ViewRosterButton);
            this.Controls.Add(this.ManageAssignedGearButton);
            this.Controls.Add(this.RemovePersonButton);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BaseMenu";
            this.Text = "ROTC Personnel and Inventory Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewInventoryButton;
        private System.Windows.Forms.Button RemoveItemsButton;
        private System.Windows.Forms.Button AddItemsButton;
        private System.Windows.Forms.Button ViewRosterButton;
        private System.Windows.Forms.Button ManageAssignedGearButton;
        private System.Windows.Forms.Button RemovePersonButton;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}