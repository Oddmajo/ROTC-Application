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
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.NumberRemovedSelect = new System.Windows.Forms.NumericUpDown();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LINBox1 = new System.Windows.Forms.TextBox();
            this.Selected = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRemovedSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Number Removed:";
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.AutoSize = true;
            this.CurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentNumber.Location = new System.Drawing.Point(195, 128);
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.Size = new System.Drawing.Size(64, 17);
            this.CurrentNumber.TabIndex = 64;
            this.CurrentNumber.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Current Stock:";
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(68, 195);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(201, 52);
            this.FinishButton.TabIndex = 65;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // NumberRemovedSelect
            // 
            this.NumberRemovedSelect.Location = new System.Drawing.Point(198, 158);
            this.NumberRemovedSelect.Name = "NumberRemovedSelect";
            this.NumberRemovedSelect.Size = new System.Drawing.Size(64, 20);
            this.NumberRemovedSelect.TabIndex = 66;
            this.NumberRemovedSelect.ValueChanged += new System.EventHandler(this.NumberRemovedSelect_ValueChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(164, 46);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 28);
            this.SearchButton.TabIndex = 73;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "LIN Number:";
            // 
            // LINBox1
            // 
            this.LINBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LINBox1.Location = new System.Drawing.Point(141, 17);
            this.LINBox1.Name = "LINBox1";
            this.LINBox1.Size = new System.Drawing.Size(128, 23);
            this.LINBox1.TabIndex = 71;
            // 
            // Selected
            // 
            this.Selected.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected.FormattingEnabled = true;
            this.Selected.Items.AddRange(new object[] {
            "Example Item 1",
            "Example Item 2"});
            this.Selected.Location = new System.Drawing.Point(40, 80);
            this.Selected.Name = "Selected";
            this.Selected.Size = new System.Drawing.Size(229, 24);
            this.Selected.TabIndex = 70;
            // 
            // RemoveItemsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 261);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LINBox1);
            this.Controls.Add(this.Selected);
            this.Controls.Add(this.NumberRemovedSelect);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CurrentNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RemoveItemsMenu";
            this.Text = "Remove Items";
            this.Load += new System.EventHandler(this.RemoveItemsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumberRemovedSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.NumericUpDown NumberRemovedSelect;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LINBox1;
        private System.Windows.Forms.ComboBox Selected;
    }
}