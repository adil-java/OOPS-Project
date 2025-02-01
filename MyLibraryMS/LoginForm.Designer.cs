namespace MyLibraryMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 341);
            this.panel1.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.HintForeColor = System.Drawing.Color.Empty;
            this.Password.HintText = "";
            this.Password.isPassword = true;
            this.Password.LineFocusedColor = System.Drawing.Color.Blue;
            this.Password.LineIdleColor = System.Drawing.Color.Gray;
            this.Password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Password.LineThickness = 3;
            this.Password.Location = new System.Drawing.Point(119, 183);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(136, 33);
            this.Password.TabIndex = 14;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(165, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sign Up";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.ActiveBorderThickness = 1;
            this.LoginBtn.ActiveCornerRadius = 20;
            this.LoginBtn.ActiveFillColor = System.Drawing.Color.White;
            this.LoginBtn.ActiveForecolor = System.Drawing.Color.Black;
            this.LoginBtn.ActiveLineColor = System.Drawing.Color.Black;
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.ButtonText = "Login";
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.Transparent;
            this.LoginBtn.IdleBorderThickness = 1;
            this.LoginBtn.IdleCornerRadius = 20;
            this.LoginBtn.IdleFillColor = System.Drawing.Color.Teal;
            this.LoginBtn.IdleForecolor = System.Drawing.Color.Transparent;
            this.LoginBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.LoginBtn.Location = new System.Drawing.Point(67, 251);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(86, 43);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.Click += new System.EventHandler(this.bunifuThinButton21_Click);
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
            this.UserName.Location = new System.Drawing.Point(119, 142);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(136, 33);
            this.UserName.TabIndex = 2;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserName.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::MyLibraryMS.Properties.Resources.minimize;
            this.pictureBox2.Location = new System.Drawing.Point(554, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MyLibraryMS.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(575, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibraryMS.Properties.Resources.Yellow_Bold_Self_Improvement_Tips_Square_Carousel_Instagram_Post;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 341);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password;
        public Bunifu.Framework.UI.BunifuMaterialTextbox UserName;
    }
}