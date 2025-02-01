namespace MyLibraryMS
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.IssueGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ReturnGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReturnDate = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.IssueDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BookName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.IssueGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IssueGridView
            // 
            this.IssueGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.IssueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IssueGridView.GridColor = System.Drawing.SystemColors.Info;
            this.IssueGridView.Location = new System.Drawing.Point(271, 77);
            this.IssueGridView.Name = "IssueGridView";
            this.IssueGridView.RowTemplate.Height = 25;
            this.IssueGridView.Size = new System.Drawing.Size(429, 149);
            this.IssueGridView.TabIndex = 44;
            this.IssueGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssueGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(235, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Book";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 52);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MyLibraryMS.Properties.Resources.minimize;
            this.pictureBox1.Location = new System.Drawing.Point(652, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 28);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::MyLibraryMS.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(673, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 28);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Image = global::MyLibraryMS.Properties.Resources.arrow_left3__1_;
            this.pictureBox3.Location = new System.Drawing.Point(17, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ReturnGridView
            // 
            this.ReturnGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.ReturnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnGridView.GridColor = System.Drawing.SystemColors.Info;
            this.ReturnGridView.Location = new System.Drawing.Point(271, 251);
            this.ReturnGridView.Name = "ReturnGridView";
            this.ReturnGridView.RowTemplate.Height = 25;
            this.ReturnGridView.Size = new System.Drawing.Size(429, 149);
            this.ReturnGridView.TabIndex = 48;
            this.ReturnGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReturnGridView_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(431, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Issue Book";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(431, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Return Book";
            // 
            // ReturnDate
            // 
            this.ReturnDate.Location = new System.Drawing.Point(100, 229);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(131, 20);
            this.ReturnDate.TabIndex = 84;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(26, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 28);
            this.button4.TabIndex = 82;
            this.button4.Text = "Return Books";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(8, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "Return Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(11, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 79;
            this.label4.Text = "Books:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(13, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 77;
            this.label8.Text = "Name:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(161, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 28);
            this.button2.TabIndex = 88;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IssueDate
            // 
            this.IssueDate.Location = new System.Drawing.Point(100, 185);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(131, 20);
            this.IssueDate.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 89;
            this.label2.Text = "Issue Date:";
            // 
            // StudentName
            // 
            this.StudentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StudentName.HintForeColor = System.Drawing.Color.Empty;
            this.StudentName.HintText = "";
            this.StudentName.isPassword = false;
            this.StudentName.LineFocusedColor = System.Drawing.Color.White;
            this.StudentName.LineIdleColor = System.Drawing.Color.White;
            this.StudentName.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.StudentName.LineThickness = 3;
            this.StudentName.Location = new System.Drawing.Point(100, 95);
            this.StudentName.Margin = new System.Windows.Forms.Padding(0);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(131, 30);
            this.StudentName.TabIndex = 91;
            this.StudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BookName
            // 
            this.BookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BookName.HintForeColor = System.Drawing.Color.Empty;
            this.BookName.HintText = "";
            this.BookName.isPassword = false;
            this.BookName.LineFocusedColor = System.Drawing.Color.White;
            this.BookName.LineIdleColor = System.Drawing.Color.White;
            this.BookName.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.BookName.LineThickness = 3;
            this.BookName.Location = new System.Drawing.Point(100, 136);
            this.BookName.Margin = new System.Windows.Forms.Padding(0);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(131, 33);
            this.BookName.TabIndex = 92;
            this.BookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.IssueDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReturnGridView);
            this.Controls.Add(this.IssueGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IssueGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView IssueGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView ReturnGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ReturnDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker IssueDate;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox StudentName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BookName;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}