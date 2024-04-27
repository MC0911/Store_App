namespace DoAnCoSo
{
    partial class frmdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangnhap));
            this.grbthongtindn = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.lbmk = new System.Windows.Forms.Label();
            this.lbtendn = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.cbghinho = new System.Windows.Forms.CheckBox();
            this.grbthongtindn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbthongtindn
            // 
            this.grbthongtindn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbthongtindn.Controls.Add(this.cbghinho);
            this.grbthongtindn.Controls.Add(this.pictureBox2);
            this.grbthongtindn.Controls.Add(this.pictureBox1);
            this.grbthongtindn.Controls.Add(this.btndangnhap);
            this.grbthongtindn.Controls.Add(this.txtmatkhau);
            this.grbthongtindn.Controls.Add(this.txttendangnhap);
            this.grbthongtindn.Controls.Add(this.lbmk);
            this.grbthongtindn.Controls.Add(this.lbtendn);
            this.grbthongtindn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbthongtindn.Location = new System.Drawing.Point(24, 64);
            this.grbthongtindn.Name = "grbthongtindn";
            this.grbthongtindn.Size = new System.Drawing.Size(729, 233);
            this.grbthongtindn.TabIndex = 7;
            this.grbthongtindn.TabStop = false;
            this.grbthongtindn.Text = "Thông tin đăng nhập";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoAnCoSo.Properties.Resources.Icons8_Windows_8_Security_Password_2;
            this.pictureBox2.Location = new System.Drawing.Point(120, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAnCoSo.Properties.Resources.user_icon_150670;
            this.pictureBox1.Location = new System.Drawing.Point(120, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btndangnhap
            // 
            this.btndangnhap.BackColor = System.Drawing.Color.Pink;
            this.btndangnhap.FlatAppearance.BorderSize = 3;
            this.btndangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangnhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Location = new System.Drawing.Point(286, 152);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(170, 65);
            this.btndangnhap.TabIndex = 11;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = false;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(286, 86);
            this.txtmatkhau.Multiline = true;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(220, 30);
            this.txtmatkhau.TabIndex = 10;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(286, 48);
            this.txttendangnhap.Multiline = true;
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(220, 30);
            this.txttendangnhap.TabIndex = 9;
            // 
            // lbmk
            // 
            this.lbmk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmk.Location = new System.Drawing.Point(156, 86);
            this.lbmk.Name = "lbmk";
            this.lbmk.Size = new System.Drawing.Size(84, 30);
            this.lbmk.TabIndex = 8;
            this.lbmk.Text = "Mật khẩu:";
            this.lbmk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtendn
            // 
            this.lbtendn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtendn.Location = new System.Drawing.Point(156, 48);
            this.lbtendn.Name = "lbtendn";
            this.lbtendn.Size = new System.Drawing.Size(124, 30);
            this.lbtendn.TabIndex = 7;
            this.lbtendn.Text = "Tên đăng nhập: ";
            this.lbtendn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnthoat
            // 
            this.btnthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnthoat.BackColor = System.Drawing.Color.Pink;
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = global::DoAnCoSo.Properties.Resources.exit;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(638, 327);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(115, 63);
            this.btnthoat.TabIndex = 12;
            this.btnthoat.Text = "Exit";
            this.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // cbghinho
            // 
            this.cbghinho.AutoSize = true;
            this.cbghinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbghinho.Location = new System.Drawing.Point(286, 122);
            this.cbghinho.Name = "cbghinho";
            this.cbghinho.Size = new System.Drawing.Size(188, 24);
            this.cbghinho.TabIndex = 15;
            this.cbghinho.Text = "Ghi nhớ đăng nhập";
            this.cbghinho.UseVisualStyleBackColor = true;
            // 
            // frmdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 402);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.grbthongtindn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(673, 47);
            this.Name = "frmdangnhap";
            this.Text = "Đăng nhập";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmdangnhap_FormClosing);
            this.Load += new System.EventHandler(this.frmdangnhap_Load);
            this.grbthongtindn.ResumeLayout(false);
            this.grbthongtindn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbthongtindn;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.Label lbmk;
        private System.Windows.Forms.Label lbtendn;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox cbghinho;
    }
}

