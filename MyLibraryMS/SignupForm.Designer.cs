namespace MyLibraryMS
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.SignupBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.UserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PhoneNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SignupBtn);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(262, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 302);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = global::MyLibraryMS.Properties.Resources.minimize;
            this.pictureBox4.Location = new System.Drawing.Point(260, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::MyLibraryMS.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(291, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "PhoneNo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "UserName:";
            // 
            // PhoneNo
            // 
            this.PhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PhoneNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PhoneNo.HintForeColor = System.Drawing.Color.Empty;
            this.PhoneNo.HintText = "";
            this.PhoneNo.isPassword = false;
            this.PhoneNo.LineFocusedColor = System.Drawing.Color.Blue;
            this.PhoneNo.LineIdleColor = System.Drawing.Color.Gray;
            this.PhoneNo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PhoneNo.LineThickness = 3;
            this.PhoneNo.Location = new System.Drawing.Point(130, 176);
            this.PhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(131, 34);
            this.PhoneNo.TabIndex = 6;
            this.PhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(92, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SignupBtn
            // 
            this.SignupBtn.ActiveBorderThickness = 1;
            this.SignupBtn.ActiveCornerRadius = 20;
            this.SignupBtn.ActiveFillColor = System.Drawing.Color.White;
            this.SignupBtn.ActiveForecolor = System.Drawing.Color.Black;
            this.SignupBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.SignupBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SignupBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignupBtn.BackgroundImage")));
            this.SignupBtn.ButtonText = "Sign Up";
            this.SignupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SignupBtn.IdleBorderThickness = 1;
            this.SignupBtn.IdleCornerRadius = 20;
            this.SignupBtn.IdleFillColor = System.Drawing.Color.Teal;
            this.SignupBtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.SignupBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SignupBtn.Location = new System.Drawing.Point(144, 229);
            this.SignupBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(86, 43);
            this.SignupBtn.TabIndex = 4;
            this.SignupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.HintForeColor = System.Drawing.Color.Empty;
            this.Password.HintText = "";
            this.Password.isPassword = false;
            this.Password.LineFocusedColor = System.Drawing.Color.Blue;
            this.Password.LineIdleColor = System.Drawing.Color.Gray;
            this.Password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(131, 133);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(131, 34);
            this.Password.TabIndex = 3;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UserName
            // 
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName.HintForeColor = System.Drawing.Color.Empty;
            this.UserName.HintText = "";
            this.UserName.isPassword = false;
            this.UserName.LineFocusedColor = System.Drawing.Color.Blue;
            this.UserName.LineIdleColor = System.Drawing.Color.Gray;
            this.UserName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UserName.LineThickness = 3;
            this.UserName.Location = new System.Drawing.Point(131, 93);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(131, 30);
            this.UserName.TabIndex = 2;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MyLibraryMS.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(675, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::MyLibraryMS.Properties.Resources.minimize;
            this.pictureBox2.Location = new System.Drawing.Point(654, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibraryMS.Properties.Resources.Brown_and_Blue_Photo_Library_Birthday_Virtual_Background__1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 302);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignupForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 SignupBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhoneNo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}