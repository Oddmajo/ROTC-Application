﻿namespace ROTC_Application
{
    partial class AddItemsMenu
    {
        //HI!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FinishButton1 = new System.Windows.Forms.Button();
            this.NumberAddedBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameButton = new System.Windows.Forms.RadioButton();
            this.NSNButton = new System.Windows.Forms.RadioButton();
            this.LINButton = new System.Windows.Forms.RadioButton();
            this.ExistingSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumberAddedBox2 = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NSNBox = new System.Windows.Forms.TextBox();
            this.LINBox = new System.Windows.Forms.TextBox();
            this.FinishButton2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FinishButton1);
            this.panel1.Controls.Add(this.NumberAddedBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CurrentNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NameButton);
            this.panel1.Controls.Add(this.NSNButton);
            this.panel1.Controls.Add(this.LINButton);
            this.panel1.Controls.Add(this.ExistingSelect);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 287);
            this.panel1.TabIndex = 0;
            // 
            // FinishButton1
            // 
            this.FinishButton1.Location = new System.Drawing.Point(47, 225);
            this.FinishButton1.Name = "FinishButton1";
            this.FinishButton1.Size = new System.Drawing.Size(201, 52);
            this.FinishButton1.TabIndex = 5;
            this.FinishButton1.Text = "Finish";
            this.FinishButton1.UseVisualStyleBackColor = true;
            this.FinishButton1.Click += new System.EventHandler(this.FinishButton1_Click);
            // 
            // NumberAddedBox1
            // 
            this.NumberAddedBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberAddedBox1.Location = new System.Drawing.Point(163, 182);
            this.NumberAddedBox1.Name = "NumberAddedBox1";
            this.NumberAddedBox1.Size = new System.Drawing.Size(37, 24);
            this.NumberAddedBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "Number Added:";
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.AutoSize = true;
            this.CurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentNumber.Location = new System.Drawing.Point(160, 148);
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.Size = new System.Drawing.Size(67, 18);
            this.CurrentNumber.TabIndex = 58;
            this.CurrentNumber.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 57;
            this.label1.Text = "Current Stock:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameButton
            // 
            this.NameButton.AutoSize = true;
            this.NameButton.Location = new System.Drawing.Point(141, 47);
            this.NameButton.Name = "NameButton";
            this.NameButton.Size = new System.Drawing.Size(59, 19);
            this.NameButton.TabIndex = 3;
            this.NameButton.TabStop = true;
            this.NameButton.Text = "Name";
            this.NameButton.UseVisualStyleBackColor = true;
            // 
            // NSNButton
            // 
            this.NSNButton.AutoSize = true;
            this.NSNButton.Location = new System.Drawing.Point(73, 47);
            this.NSNButton.Name = "NSNButton";
            this.NSNButton.Size = new System.Drawing.Size(51, 19);
            this.NSNButton.TabIndex = 2;
            this.NSNButton.TabStop = true;
            this.NSNButton.Text = "NSN";
            this.NSNButton.UseVisualStyleBackColor = true;
            // 
            // LINButton
            // 
            this.LINButton.AutoSize = true;
            this.LINButton.Location = new System.Drawing.Point(7, 47);
            this.LINButton.Name = "LINButton";
            this.LINButton.Size = new System.Drawing.Size(44, 19);
            this.LINButton.TabIndex = 1;
            this.LINButton.TabStop = true;
            this.LINButton.Text = "LIN";
            this.LINButton.UseVisualStyleBackColor = true;
            // 
            // ExistingSelect
            // 
            this.ExistingSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExistingSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingSelect.FormattingEnabled = true;
            this.ExistingSelect.Items.AddRange(new object[] {
            "Example Item 1",
            "Example Item 2"});
            this.ExistingSelect.Location = new System.Drawing.Point(20, 72);
            this.ExistingSelect.Name = "ExistingSelect";
            this.ExistingSelect.Size = new System.Drawing.Size(229, 26);
            this.ExistingSelect.TabIndex = 4;
            this.ExistingSelect.SelectedIndexChanged += new System.EventHandler(this.ExistingSelect_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 22);
            this.label6.TabIndex = 52;
            this.label6.Text = "Existing Items";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NumberAddedBox2);
            this.panel2.Controls.Add(this.NameBox);
            this.panel2.Controls.Add(this.NSNBox);
            this.panel2.Controls.Add(this.LINBox);
            this.panel2.Controls.Add(this.FinishButton2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(281, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 287);
            this.panel2.TabIndex = 1;
            // 
            // NumberAddedBox2
            // 
            this.NumberAddedBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberAddedBox2.Location = new System.Drawing.Point(138, 182);
            this.NumberAddedBox2.Name = "NumberAddedBox2";
            this.NumberAddedBox2.Size = new System.Drawing.Size(121, 24);
            this.NumberAddedBox2.TabIndex = 9;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(138, 136);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(121, 24);
            this.NameBox.TabIndex = 8;
            // 
            // NSNBox
            // 
            this.NSNBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSNBox.Location = new System.Drawing.Point(138, 91);
            this.NSNBox.Name = "NSNBox";
            this.NSNBox.Size = new System.Drawing.Size(121, 24);
            this.NSNBox.TabIndex = 7;
            // 
            // LINBox
            // 
            this.LINBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LINBox.Location = new System.Drawing.Point(138, 47);
            this.LINBox.Name = "LINBox";
            this.LINBox.Size = new System.Drawing.Size(121, 24);
            this.LINBox.TabIndex = 6;
            // 
            // FinishButton2
            // 
            this.FinishButton2.Location = new System.Drawing.Point(58, 225);
            this.FinishButton2.Name = "FinishButton2";
            this.FinishButton2.Size = new System.Drawing.Size(201, 52);
            this.FinishButton2.TabIndex = 10;
            this.FinishButton2.Text = "Finish";
            this.FinishButton2.UseVisualStyleBackColor = true;
            this.FinishButton2.Click += new System.EventHandler(this.FinishButton2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 18);
            this.label9.TabIndex = 62;
            this.label9.Text = "Number Added:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 64;
            this.label8.Text = "Item Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "NSN Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "LIN Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "New Items";
            // 
            // AddItemsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 314);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddItemsMenu";
            this.Text = "Add Items";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ExistingSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton NameButton;
        private System.Windows.Forms.RadioButton NSNButton;
        private System.Windows.Forms.RadioButton LINButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NumberAddedBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberAddedBox2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox NSNBox;
        private System.Windows.Forms.TextBox LINBox;
        private System.Windows.Forms.Button FinishButton2;
        private System.Windows.Forms.Button FinishButton1;
    }
}