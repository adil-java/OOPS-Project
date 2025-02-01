namespace MyLibraryMS
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BookCount = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.Label();
            this.Issue = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 48);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(141, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "DashBoard";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "DashBoard";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MyLibraryMS.Properties.Resources.user1;
            this.pictureBox4.Location = new System.Drawing.Point(282, 181);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 61);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MyLibraryMS.Properties.Resources._return;
            this.pictureBox3.Location = new System.Drawing.Point(282, 59);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 61);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyLibraryMS.Properties.Resources.Issue;
            this.pictureBox2.Location = new System.Drawing.Point(69, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 61);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyLibraryMS.Properties.Resources.open_book__1_;
            this.pictureBox1.Location = new System.Drawing.Point(69, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 61);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BookCount
            // 
            this.BookCount.AutoSize = true;
            this.BookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BookCount.Location = new System.Drawing.Point(87, 123);
            this.BookCount.Name = "BookCount";
            this.BookCount.Size = new System.Drawing.Size(32, 33);
            this.BookCount.TabIndex = 2;
            this.BookCount.Text = "0";
            this.BookCount.Click += new System.EventHandler(this.BookCount_Click);
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return.Location = new System.Drawing.Point(298, 123);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(32, 33);
            this.Return.TabIndex = 6;
            this.Return.Text = "0";
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Issue
            // 
            this.Issue.AutoSize = true;
            this.Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Issue.Location = new System.Drawing.Point(87, 256);
            this.Issue.Name = "Issue";
            this.Issue.Size = new System.Drawing.Size(32, 33);
            this.Issue.TabIndex = 7;
            this.Issue.Text = "0";
            this.Issue.Click += new System.EventHandler(this.Issue_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Admin.Location = new System.Drawing.Point(301, 253);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(32, 33);
            this.Admin.TabIndex = 8;
            this.Admin.Text = "0";
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Issue);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.BookCount);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BookCount;
        private System.Windows.Forms.Label Return;
        private System.Windows.Forms.Label Issue;
        private System.Windows.Forms.Label Admin;
    }
}