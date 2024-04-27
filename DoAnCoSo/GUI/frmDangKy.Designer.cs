namespace DoAnCoSo.GUI
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttendangky = new System.Windows.Forms.TextBox();
            this.lbtendn = new System.Windows.Forms.Label();
            this.grbttdk = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btndangky = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtxacnhanmk = new System.Windows.Forms.TextBox();
            this.dgvtttaikhoan = new System.Windows.Forms.DataGridView();
            this.grbttdk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtttaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(213, 121);
            this.txtmatkhau.Multiline = true;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(247, 30);
            this.txtmatkhau.TabIndex = 14;
            // 
            // txttendangky
            // 
            this.txttendangky.Location = new System.Drawing.Point(213, 71);
            this.txttendangky.Multiline = true;
            this.txttendangky.Name = "txttendangky";
            this.txttendangky.Size = new System.Drawing.Size(247, 30);
            this.txttendangky.TabIndex = 13;
            // 
            // lbtendn
            // 
            this.lbtendn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtendn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtendn.Location = new System.Drawing.Point(6, 71);
            this.lbtendn.Name = "lbtendn";
            this.lbtendn.Size = new System.Drawing.Size(125, 30);
            this.lbtendn.TabIndex = 11;
            this.lbtendn.Text = "Tên đăng nhập: ";
            this.lbtendn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbttdk
            // 
            this.grbttdk.Controls.Add(this.label3);
            this.grbttdk.Controls.Add(this.btnback);
            this.grbttdk.Controls.Add(this.label2);
            this.grbttdk.Controls.Add(this.btndangky);
            this.grbttdk.Controls.Add(this.label1);
            this.grbttdk.Controls.Add(this.button1);
            this.grbttdk.Controls.Add(this.txtemail);
            this.grbttdk.Controls.Add(this.txtxacnhanmk);
            this.grbttdk.Controls.Add(this.lbtendn);
            this.grbttdk.Controls.Add(this.txtmatkhau);
            this.grbttdk.Controls.Add(this.txttendangky);
            this.grbttdk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbttdk.Location = new System.Drawing.Point(12, 12);
            this.grbttdk.Name = "grbttdk";
            this.grbttdk.Size = new System.Drawing.Size(530, 583);
            this.grbttdk.TabIndex = 15;
            this.grbttdk.TabStop = false;
            this.grbttdk.Text = "Thông tin đăng ký";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnback.FlatAppearance.BorderSize = 3;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(6, 525);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(101, 52);
            this.btnback.TabIndex = 21;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Xác nhận mật khẩu:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btndangky
            // 
            this.btndangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btndangky.FlatAppearance.BorderSize = 3;
            this.btndangky.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndangky.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangky.Location = new System.Drawing.Point(6, 290);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(168, 75);
            this.btndangky.TabIndex = 20;
            this.btndangky.Text = "Đăng ký";
            this.btndangky.UseVisualStyleBackColor = false;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mật khẩu: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(9, 8);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(213, 221);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(306, 30);
            this.txtemail.TabIndex = 18;
            // 
            // txtxacnhanmk
            // 
            this.txtxacnhanmk.Location = new System.Drawing.Point(213, 171);
            this.txtxacnhanmk.Multiline = true;
            this.txtxacnhanmk.Name = "txtxacnhanmk";
            this.txtxacnhanmk.PasswordChar = '*';
            this.txtxacnhanmk.Size = new System.Drawing.Size(247, 30);
            this.txtxacnhanmk.TabIndex = 17;
            // 
            // dgvtttaikhoan
            // 
            this.dgvtttaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtttaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtttaikhoan.Location = new System.Drawing.Point(564, 12);
            this.dgvtttaikhoan.Name = "dgvtttaikhoan";
            this.dgvtttaikhoan.RowHeadersWidth = 51;
            this.dgvtttaikhoan.RowTemplate.Height = 24;
            this.dgvtttaikhoan.Size = new System.Drawing.Size(441, 583);
            this.dgvtttaikhoan.TabIndex = 16;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1017, 621);
            this.Controls.Add(this.dgvtttaikhoan);
            this.Controls.Add(this.grbttdk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangKy";
            this.Text = "Tạo tài khoản";
            this.grbttdk.ResumeLayout(false);
            this.grbttdk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtttaikhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttendangky;
        private System.Windows.Forms.Label lbtendn;
        private System.Windows.Forms.GroupBox grbttdk;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtxacnhanmk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtttaikhoan;
    }
}