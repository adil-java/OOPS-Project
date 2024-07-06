namespace MyLibraryMS
{
    partial class BookTbl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PubName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthorName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.BookName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.BookPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.BookQty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.Id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 52);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MyLibraryMS.Properties.Resources.minimize;
            this.pictureBox1.Location = new System.Drawing.Point(587, 12);
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
            this.pictureBox2.Location = new System.Drawing.Point(610, 15);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(235, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Entry";
            // 
            // BookGridView
            // 
            this.BookGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.BookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGridView.GridColor = System.Drawing.SystemColors.Info;
            this.BookGridView.Location = new System.Drawing.Point(271, 50);
            this.BookGridView.Name = "BookGridView";
            this.BookGridView.RowTemplate.Height = 25;
            this.BookGridView.Size = new System.Drawing.Size(366, 335);
            this.BookGridView.TabIndex = 29;
            this.BookGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(103, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(190, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(19, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Publisher :";
            // 
            // PubName
            // 
            this.PubName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PubName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PubName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PubName.HintForeColor = System.Drawing.Color.Empty;
            this.PubName.HintText = "";
            this.PubName.isPassword = false;
            this.PubName.LineFocusedColor = System.Drawing.Color.White;
            this.PubName.LineIdleColor = System.Drawing.Color.White;
            this.PubName.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.PubName.LineThickness = 3;
            this.PubName.Location = new System.Drawing.Point(112, 182);
            this.PubName.Margin = new System.Windows.Forms.Padding(0);
            this.PubName.Name = "PubName";
            this.PubName.Size = new System.Drawing.Size(131, 44);
            this.PubName.TabIndex = 20;
            this.PubName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Author:";
            // 
            // AuthorName
            // 
            this.AuthorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AuthorName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AuthorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AuthorName.HintForeColor = System.Drawing.Color.Empty;
            this.AuthorName.HintText = "";
            this.AuthorName.isPassword = false;
            this.AuthorName.LineFocusedColor = System.Drawing.Color.White;
            this.AuthorName.LineIdleColor = System.Drawing.Color.White;
            this.AuthorName.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.AuthorName.LineThickness = 3;
            this.AuthorName.Location = new System.Drawing.Point(112, 136);
            this.AuthorName.Margin = new System.Windows.Forms.Padding(0);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(131, 44);
            this.AuthorName.TabIndex = 18;
            this.AuthorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AuthorName.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(21, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Bookname:";
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
            this.BookName.Location = new System.Drawing.Point(112, 92);
            this.BookName.Margin = new System.Windows.Forms.Padding(0);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(131, 44);
            this.BookName.TabIndex = 16;
            this.BookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BookName.OnValueChanged += new System.EventHandler(this.BookName_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(22, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Price :";
            // 
            // BookPrice
            // 
            this.BookPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BookPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BookPrice.HintForeColor = System.Drawing.Color.Empty;
            this.BookPrice.HintText = "";
            this.BookPrice.isPassword = false;
            this.BookPrice.LineFocusedColor = System.Drawing.Color.White;
            this.BookPrice.LineIdleColor = System.Drawing.Color.White;
            this.BookPrice.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.BookPrice.LineThickness = 3;
            this.BookPrice.Location = new System.Drawing.Point(112, 229);
            this.BookPrice.Margin = new System.Windows.Forms.Padding(0);
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.Size = new System.Drawing.Size(131, 44);
            this.BookPrice.TabIndex = 30;
            this.BookPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(22, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Quantity :";
            // 
            // BookQty
            // 
            this.BookQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookQty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BookQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BookQty.HintForeColor = System.Drawing.Color.Empty;
            this.BookQty.HintText = "";
            this.BookQty.isPassword = false;
            this.BookQty.LineFocusedColor = System.Drawing.Color.White;
            this.BookQty.LineIdleColor = System.Drawing.Color.White;
            this.BookQty.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.BookQty.LineThickness = 3;
            this.BookQty.Location = new System.Drawing.Point(112, 273);
            this.BookQty.Margin = new System.Windows.Forms.Padding(0);
            this.BookQty.Name = "BookQty";
            this.BookQty.Size = new System.Drawing.Size(131, 44);
            this.BookQty.TabIndex = 32;
            this.BookQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "ID(optional):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Id
            // 
            this.Id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Id.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Id.HintForeColor = System.Drawing.Color.Empty;
            this.Id.HintText = "";
            this.Id.isPassword = false;
            this.Id.LineFocusedColor = System.Drawing.Color.LightGray;
            this.Id.LineIdleColor = System.Drawing.Color.White;
            this.Id.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.Id.LineThickness = 3;
            this.Id.Location = new System.Drawing.Point(115, 52);
            this.Id.Margin = new System.Windows.Forms.Padding(0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(131, 44);
            this.Id.TabIndex = 35;
            this.Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Id.OnValueChanged += new System.EventHandler(this.Id_OnValueChanged);
            // 
            // BookTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(637, 384);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BookQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BookPrice);
            this.Controls.Add(this.BookGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PubName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookTbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookTbl";
            this.Load += new System.EventHandler(this.BookTbl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BookGridView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PubName;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AuthorName;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BookName;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BookPrice;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BookQty;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Id;
    }
}