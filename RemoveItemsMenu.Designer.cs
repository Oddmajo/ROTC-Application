namespace ROTC_Application
{
    partial class RemoveItemsMenu
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
            this.NameButton = new System.Windows.Forms.RadioButton();
            this.NSNButton = new System.Windows.Forms.RadioButton();
            this.LINButton = new System.Windows.Forms.RadioButton();
            this.Selected = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.NumberRemovedSelect = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRemovedSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // NameButton
            // 
            this.NameButton.AutoSize = true;
            this.NameButton.Location = new System.Drawing.Point(143, 10);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(59, 19);
            this.NameButton.TabIndex = 7;
            this.NameButton.TabStop = true;
            this.NameButton.Text = "Name";
            this.NameButton.UseVisualStyleBackColor = true;
            // 
            // NSNButton
            // 
            this.NSNButton.AutoSize = true;
            this.NSNButton.Location = new System.Drawing.Point(75, 10);
            this.NSNButton.Name = "NSNButton";
            this.NSNButton.Size = new System.Drawing.Size(51, 19);
            this.NSNButton.TabIndex = 6;
            this.NSNButton.TabStop = true;
            this.NSNButton.Text = "NSN";
            this.NSNButton.UseVisualStyleBackColor = true;
            // 
            // LINButton
            // 
            this.LINButton.AutoSize = true;
            this.LINButton.Location = new System.Drawing.Point(9, 10);
            this.LINButton.Name = "LINButton";
            this.LINButton.Size = new System.Drawing.Size(44, 19);
            this.LINButton.TabIndex = 5;
            this.LINButton.TabStop = true;
            this.LINButton.Text = "LIN";
            this.LINButton.UseVisualStyleBackColor = true;
            // 
            // Selected
            // 
            this.Selected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected.FormattingEnabled = true;
            this.Selected.Items.AddRange(new object[] {
            "Example Item 1",
            "Example Item 2"});
            this.Selected.Location = new System.Drawing.Point(22, 35);
            this.Selected.Name = "Selected";
            this.Selected.Size = new System.Drawing.Size(229, 26);
            this.Selected.TabIndex = 8;
            this.Selected.SelectedIndexChanged += new System.EventHandler(this.Selected_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Number Removed:";
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.AutoSize = true;
            this.CurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentNumber.Location = new System.Drawing.Point(184, 83);
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.Size = new System.Drawing.Size(67, 18);
            this.CurrentNumber.TabIndex = 64;
            this.CurrentNumber.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "Current Stock:";
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(68, 168);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(201, 52);
            this.FinishButton.TabIndex = 65;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // NumberRemovedSelect
            // 
            this.NumberRemovedSelect.Location = new System.Drawing.Point(187, 113);
            this.NumberRemovedSelect.Name = "NumberRemovedSelect";
            this.NumberRemovedSelect.Size = new System.Drawing.Size(64, 20);
            this.NumberRemovedSelect.TabIndex = 66;
            // 
            // RemoveItemsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 235);
            this.Controls.Add(this.NumberRemovedSelect);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CurrentNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameButton);
            this.Controls.Add(this.NSNButton);
            this.Controls.Add(this.LINButton);
            this.Controls.Add(this.Selected);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RemoveItemsMenu";
            this.Text = "Remove Items";
            ((System.ComponentModel.ISupportInitialize)(this.NumberRemovedSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton NameButton;
        private System.Windows.Forms.RadioButton NSNButton;
        private System.Windows.Forms.RadioButton LINButton;
        private System.Windows.Forms.ComboBox Selected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.NumericUpDown NumberRemovedSelect;
    }
}