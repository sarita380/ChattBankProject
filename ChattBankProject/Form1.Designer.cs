namespace ChattBankProject
{
    partial class ChattBankForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chattPict = new System.Windows.Forms.PictureBox();
            this.ExButton = new System.Windows.Forms.Button();
            this.testCustButton = new System.Windows.Forms.Button();
            this.testAcctbButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chattPict)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To Chatt Bank";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Customer ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Admin  ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chattPict
            // 
            this.chattPict.Image = global::ChattBankProject.Properties.Resources.bank;
            this.chattPict.Location = new System.Drawing.Point(12, 39);
            this.chattPict.Name = "chattPict";
            this.chattPict.Size = new System.Drawing.Size(260, 171);
            this.chattPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chattPict.TabIndex = 0;
            this.chattPict.TabStop = false;
            // 
            // ExButton
            // 
            this.ExButton.Location = new System.Drawing.Point(280, 97);
            this.ExButton.Name = "ExButton";
            this.ExButton.Size = new System.Drawing.Size(75, 23);
            this.ExButton.TabIndex = 4;
            this.ExButton.Text = "Exit";
            this.ExButton.UseVisualStyleBackColor = true;
            this.ExButton.Click += new System.EventHandler(this.ExButton_Click);
            // 
            // testCustButton
            // 
            this.testCustButton.Location = new System.Drawing.Point(12, 228);
            this.testCustButton.Name = "testCustButton";
            this.testCustButton.Size = new System.Drawing.Size(89, 23);
            this.testCustButton.TabIndex = 5;
            this.testCustButton.Text = "TestCustSelect";
            this.testCustButton.UseVisualStyleBackColor = true;
            this.testCustButton.Click += new System.EventHandler(this.testCustButton_Click);
            // 
            // testAcctbButton
            // 
            this.testAcctbButton.Location = new System.Drawing.Point(12, 257);
            this.testAcctbButton.Name = "testAcctbButton";
            this.testAcctbButton.Size = new System.Drawing.Size(89, 23);
            this.testAcctbButton.TabIndex = 6;
            this.testAcctbButton.Text = "TestAccount";
            this.testAcctbButton.UseVisualStyleBackColor = true;
            this.testAcctbButton.Click += new System.EventHandler(this.testAcctbButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(188, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Insert";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(269, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(107, 257);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "updateAcct";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(188, 257);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "InsertAcct";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(269, 257);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "deleteAcct";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // ChattBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 349);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.testAcctbButton);
            this.Controls.Add(this.testCustButton);
            this.Controls.Add(this.ExButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chattPict);
            this.Name = "ChattBankForm";
            this.Text = "ChattBank";
            ((System.ComponentModel.ISupportInitialize)(this.chattPict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox chattPict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ExButton;
        private System.Windows.Forms.Button testCustButton;
        private System.Windows.Forms.Button testAcctbButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

