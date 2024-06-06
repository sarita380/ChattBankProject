namespace ChattBankProject
{
    partial class adminLogIn
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adIdTbox = new System.Windows.Forms.TextBox();
            this.adPassTbox = new System.Windows.Forms.TextBox();
            this.logBotton = new System.Windows.Forms.Button();
            this.exButton = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ChattBankProject.Properties.Resources.bank;
            this.pictureBox1.Location = new System.Drawing.Point(23, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chatt Bank Log in  page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Log in as a Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Admin ID No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // adIdTbox
            // 
            this.adIdTbox.Location = new System.Drawing.Point(114, 138);
            this.adIdTbox.Name = "adIdTbox";
            this.adIdTbox.Size = new System.Drawing.Size(100, 20);
            this.adIdTbox.TabIndex = 5;
            // 
            // adPassTbox
            // 
            this.adPassTbox.Location = new System.Drawing.Point(114, 167);
            this.adPassTbox.Name = "adPassTbox";
            this.adPassTbox.Size = new System.Drawing.Size(100, 20);
            this.adPassTbox.TabIndex = 6;
            // 
            // logBotton
            // 
            this.logBotton.Location = new System.Drawing.Point(23, 226);
            this.logBotton.Name = "logBotton";
            this.logBotton.Size = new System.Drawing.Size(75, 23);
            this.logBotton.TabIndex = 7;
            this.logBotton.Text = "Log In";
            this.logBotton.UseVisualStyleBackColor = true;
            this.logBotton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exButton
            // 
            this.exButton.Location = new System.Drawing.Point(185, 226);
            this.exButton.Name = "exButton";
            this.exButton.Size = new System.Drawing.Size(75, 23);
            this.exButton.TabIndex = 8;
            this.exButton.Text = "Exit";
            this.exButton.UseVisualStyleBackColor = true;
            this.exButton.Click += new System.EventHandler(this.exButton_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(104, 226);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 9;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // adminLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.exButton);
            this.Controls.Add(this.logBotton);
            this.Controls.Add(this.adPassTbox);
            this.Controls.Add(this.adIdTbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "adminLogIn";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adIdTbox;
        private System.Windows.Forms.TextBox adPassTbox;
        private System.Windows.Forms.Button logBotton;
        private System.Windows.Forms.Button exButton;
        private System.Windows.Forms.Button clearB;
    }
}