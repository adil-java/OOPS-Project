namespace MyLibraryMS
{
    partial class LibranianForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.LibName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LibraryGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LaddBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LibId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Libpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.Libphone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(18, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 48;
            this.label6.Text = "Name :";
            // 
            // LibName
            // 
            this.LibName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LibName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LibName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LibName.HintForeColor = System.Drawing.Color.Empty;
            this.LibName.HintText = "";
            this.LibName.isPassword = false;
            this.LibName.LineFocusedColor = System.Drawing.Color.White;
            this.LibName.LineIdleColor = System.Drawing.Color.White;
            this.LibName.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.LibName.LineThickness = 3;
            this.LibName.Location = new System.Drawing.Point(108, 116);
            this.LibName.Margin = new System.Windows.Forms.Padding(0);
            this.LibName.Name = "LibName";
            this.LibName.Size = new System.Drawing.Size(131, 44);
            this.LibName.TabIndex = 47;
            this.LibName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LibraryGridView
            // 
            this.LibraryGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.LibraryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibraryGridView.GridColor = System.Drawing.SystemColors.Info;
            this.LibraryGridView.Location = new System.Drawing.Point(283, 62);
            this.LibraryGridView.Name = "LibraryGridView";
            this.LibraryGridView.RowTemplate.Height = 25;
            this.LibraryGridView.Size = new System.Drawing.Size(348, 311);
            this.LibraryGridView.TabIndex = 44;
            this.LibraryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(108, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 43;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LaddBtn
            // 
            this.LaddBtn.Location = new System.Drawing.Point(27, 276);
            this.LaddBtn.Name = "LaddBtn";
            this.LaddBtn.Size = new System.Drawing.Size(75, 23);
            this.LaddBtn.TabIndex = 41;
            this.LaddBtn.Text = "Add";
            this.LaddBtn.UseVisualStyleBackColor = true;
            this.LaddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LibId
            // 
            this.LibId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LibId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LibId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LibId.HintForeColor = System.Drawing.Color.Empty;
            this.LibId.HintText = "";
            this.LibId.isPassword = false;
            this.LibId.LineFocusedColor = System.Drawing.Color.White;
            this.LibId.LineIdleColor = System.Drawing.Color.White;
            this.LibId.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.LibId.LineThickness = 3;
            this.LibId.Location = new System.Drawing.Point(108, 71);
            this.LibId.Margin = new System.Windows.Forms.Padding(0);
            this.LibId.Name = "LibId";
            this.LibId.Size = new System.Drawing.Size(131, 44);
            this.LibId.TabIndex = 35;
            this.LibId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(235, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libranian";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 55);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::MyLibraryMS.Properties.Resources.minimize;
            this.pictureBox1.Location = new System.Drawing.Point(585, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 28);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.Image = global::MyLibraryMS.Properties.Resources.close;
            this.pictureBox4.Location = new System.Drawing.Point(608, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 28);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(18, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Password :";
            // 
            // Libpass
            // 
            this.Libpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Libpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Libpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Libpass.HintForeColor = System.Drawing.Color.Empty;
            this.Libpass.HintText = "";
            this.Libpass.isPassword = false;
            this.Libpass.LineFocusedColor = System.Drawing.Color.White;
            this.Libpass.LineIdleColor = System.Drawing.Color.White;
            this.Libpass.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.Libpass.LineThickness = 3;
            this.Libpass.Location = new System.Drawing.Point(108, 160);
            this.Libpass.Margin = new System.Windows.Forms.Padding(0);
            this.Libpass.Name = "Libpass";
            this.Libpass.Size = new System.Drawing.Size(131, 44);
            this.Libpass.TabIndex = 49;
            this.Libpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(18, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Phone no :";
            // 
            // Libphone
            // 
            this.Libphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Libphone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Libphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Libphone.HintForeColor = System.Drawing.Color.Empty;
            this.Libphone.HintText = "";
            this.Libphone.isPassword = false;
            this.Libphone.LineFocusedColor = System.Drawing.Color.White;
            this.Libphone.LineIdleColor = System.Drawing.Color.White;
            this.Libphone.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.Libphone.LineThickness = 3;
            this.Libphone.Location = new System.Drawing.Point(108, 204);
            this.Libphone.Margin = new System.Windows.Forms.Padding(0);
            this.Libphone.Name = "Libphone";
            this.Libphone.Size = new System.Drawing.Size(131, 44);
            this.Libphone.TabIndex = 51;
            this.Libphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LibranianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(637, 384);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Libphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Libpass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LibName);
            this.Controls.Add(this.LibraryGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LaddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LibId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibranianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibranianForm";
            this.Load += new System.EventHandler(this.LibranianForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LibName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView LibraryGridView;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button LaddBtn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LibId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Libpass;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Libphone;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}