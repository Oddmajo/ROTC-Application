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
            this.NSNButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.NumberRemovedSelect = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumberRemovedSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // NSNButton
            // 
            this.NSNButton.AutoSize = true;
            this.NSNButton.Location = new System.Drawing.Point(29, 13);
            this.NSNButton.Margin = new System.Windows.Forms.Padding(4);
            this.NSNButton.Name = "NSNButton";
            this.NSNButton.Size = new System.Drawing.Size(58, 21);
            this.NSNButton.TabIndex = 6;
            this.NSNButton.TabStop = true;
            this.NSNButton.Text = "NSN";
            this.NSNButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Number Removed:";
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.AutoSize = true;
            this.CurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentNumber.Location = new System.Drawing.Point(245, 102);
            this.CurrentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.Size = new System.Drawing.Size(74, 20);
            this.CurrentNumber.TabIndex = 64;
            this.CurrentNumber.Text = "Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Current Stock:";
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(91, 207);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(4);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(268, 64);
            this.FinishButton.TabIndex = 65;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // NumberRemovedSelect
            // 
            this.NumberRemovedSelect.Location = new System.Drawing.Point(249, 139);
            this.NumberRemovedSelect.Margin = new System.Windows.Forms.Padding(4);
            this.NumberRemovedSelect.Name = "NumberRemovedSelect";
            this.NumberRemovedSelect.Size = new System.Drawing.Size(85, 22);
            this.NumberRemovedSelect.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Item";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 68;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RemoveItemsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 289);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberRemovedSelect);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CurrentNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NSNButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RemoveItemsMenu";
            this.Text = "Remove Items";
            ((System.ComponentModel.ISupportInitialize)(this.NumberRemovedSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton NSNButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.NumericUpDown NumberRemovedSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}