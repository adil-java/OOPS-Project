namespace MyLibraryMS
{
    partial class Firstpage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firstpage));
            this.label1 = new System.Windows.Forms.Label();
            this.Myprogress = new Bunifu.Framework.UI.BunifuProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Percentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(159, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Shop";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Myprogress
            // 
            this.Myprogress.BackColor = System.Drawing.Color.Silver;
            this.Myprogress.BorderRadius = 5;
            this.Myprogress.Location = new System.Drawing.Point(83, 244);
            this.Myprogress.MaximumValue = 100;
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.ProgressColor = System.Drawing.Color.Teal;
            this.Myprogress.Size = new System.Drawing.Size(451, 17);
            this.Myprogress.TabIndex = 1;
            this.Myprogress.Value = 0;
            this.Myprogress.progressChanged += new System.EventHandler(this.Myprogress_progressChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Percentage
            // 
            this.Percentage.AutoSize = true;
            this.Percentage.BackColor = System.Drawing.Color.Transparent;
            this.Percentage.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage.ForeColor = System.Drawing.Color.LightGray;
            this.Percentage.Location = new System.Drawing.Point(492, 262);
            this.Percentage.Name = "Percentage";
            this.Percentage.Size = new System.Drawing.Size(30, 27);
            this.Percentage.TabIndex = 2;
            this.Percentage.Text = "%\r\n";
            this.Percentage.Click += new System.EventHandler(this.label2_Click);
            // 
            // Firstpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::MyLibraryMS.Properties.Resources.Brown_and_Blue_Photo_Library_Birthday_Virtual_Background__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 341);
            this.Controls.Add(this.Percentage);
            this.Controls.Add(this.Myprogress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Firstpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Firstpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuProgressBar Myprogress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Percentage;
    }
}

