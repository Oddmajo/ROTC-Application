namespace ROTC_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemsMenu));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.CurrentItem = new System.Windows.Forms.Label();
            this.NSNBox1 = new System.Windows.Forms.TextBox();
            this.FinishButton1 = new System.Windows.Forms.Button();
            this.NumberAddedBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NumberAddedBox2 = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NSNBox2 = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.CurrentItem);
            this.panel1.Controls.Add(this.NSNBox1);
            this.panel1.Controls.Add(this.FinishButton1);
            this.panel1.Controls.Add(this.NumberAddedBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CurrentNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(17, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 353);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 142);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Inventory Item:";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(217, 90);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(113, 32);
            this.SearchButton.TabIndex = 66;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 65;
            this.label10.Text = "NSN Number:";
            // 
            // CurrentItem
            // 
            this.CurrentItem.AutoSize = true;
            this.CurrentItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CurrentItem.Location = new System.Drawing.Point(201, 142);
            this.CurrentItem.Name = "CurrentItem";
            this.CurrentItem.Size = new System.Drawing.Size(45, 20);
            this.CurrentItem.TabIndex = 61;
            this.CurrentItem.Text = "Item";
            // 
            // NSNBox1
            // 
            this.NSNBox1.Location = new System.Drawing.Point(157, 52);
            this.NSNBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NSNBox1.Name = "NSNBox1";
            this.NSNBox1.Size = new System.Drawing.Size(172, 22);
            this.NSNBox1.TabIndex = 1;
            this.NSNBox1.Enter += new System.EventHandler(this.NSNBox1_Enter);
            this.NSNBox1.Leave += new System.EventHandler(this.NSNBox1_Leave);
            // 
            // FinishButton1
            // 
            this.FinishButton1.Location = new System.Drawing.Point(63, 277);
            this.FinishButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FinishButton1.Name = "FinishButton1";
            this.FinishButton1.Size = new System.Drawing.Size(268, 64);
            this.FinishButton1.TabIndex = 5;
            this.FinishButton1.Text = "Finish";
            this.FinishButton1.UseVisualStyleBackColor = true;
            this.FinishButton1.Click += new System.EventHandler(this.FinishButton1_Click);
            // 
            // NumberAddedBox1
            // 
            this.NumberAddedBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberAddedBox1.Location = new System.Drawing.Point(217, 224);
            this.NumberAddedBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberAddedBox1.Name = "NumberAddedBox1";
            this.NumberAddedBox1.Size = new System.Drawing.Size(48, 26);
            this.NumberAddedBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Number Added:";
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.AutoSize = true;
            this.CurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentNumber.Location = new System.Drawing.Point(201, 182);
            this.CurrentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.Size = new System.Drawing.Size(74, 20);
            this.CurrentNumber.TabIndex = 58;
            this.CurrentNumber.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Current Stock:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Existing Items";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NumberAddedBox2);
            this.panel2.Controls.Add(this.NameBox);
            this.panel2.Controls.Add(this.NSNBox2);
            this.panel2.Controls.Add(this.LINBox);
            this.panel2.Controls.Add(this.FinishButton2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(375, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 353);
            this.panel2.TabIndex = 1;
            // 
            // NumberAddedBox2
            // 
            this.NumberAddedBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberAddedBox2.Location = new System.Drawing.Point(184, 224);
            this.NumberAddedBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberAddedBox2.Name = "NumberAddedBox2";
            this.NumberAddedBox2.Size = new System.Drawing.Size(160, 26);
            this.NumberAddedBox2.TabIndex = 9;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(184, 167);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(160, 26);
            this.NameBox.TabIndex = 8;
            // 
            // NSNBox2
            // 
            this.NSNBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NSNBox2.Location = new System.Drawing.Point(184, 112);
            this.NSNBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NSNBox2.Name = "NSNBox2";
            this.NSNBox2.Size = new System.Drawing.Size(160, 26);
            this.NSNBox2.TabIndex = 7;
            // 
            // LINBox
            // 
            this.LINBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LINBox.Location = new System.Drawing.Point(184, 58);
            this.LINBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LINBox.Name = "LINBox";
            this.LINBox.Size = new System.Drawing.Size(160, 26);
            this.LINBox.TabIndex = 6;
            this.LINBox.TextChanged += new System.EventHandler(this.LINBox_TextChanged);
            // 
            // FinishButton2
            // 
            this.FinishButton2.Location = new System.Drawing.Point(55, 277);
            this.FinishButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FinishButton2.Name = "FinishButton2";
            this.FinishButton2.Size = new System.Drawing.Size(268, 64);
            this.FinishButton2.TabIndex = 10;
            this.FinishButton2.Text = "Finish";
            this.FinishButton2.UseVisualStyleBackColor = true;
            this.FinishButton2.Click += new System.EventHandler(this.FinishButton2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Number Added:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Item Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "NSN Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "LIN Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "New Items";
            // 
            // AddItemsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 386);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.TextBox NSNBox2;
        private System.Windows.Forms.TextBox LINBox;
        private System.Windows.Forms.Button FinishButton2;
        private System.Windows.Forms.Button FinishButton1;
        private System.Windows.Forms.TextBox NSNBox1;
        private System.Windows.Forms.Label CurrentItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SearchButton;
    }
}