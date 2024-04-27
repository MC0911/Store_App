namespace DoAnCoSo.GUI
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbhdxuat = new System.Windows.Forms.RadioButton();
            this.rdbhdnhap = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxembill = new System.Windows.Forms.Button();
            this.dtpdateto = new System.Windows.Forms.DateTimePicker();
            this.dtpdatefrom = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvthongkehd = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongkehd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdbhdxuat);
            this.panel3.Controls.Add(this.rdbhdnhap);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnxembill);
            this.panel3.Controls.Add(this.dtpdateto);
            this.panel3.Controls.Add(this.dtpdatefrom);
            this.panel3.Location = new System.Drawing.Point(6, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 61);
            this.panel3.TabIndex = 2;
            // 
            // rdbhdxuat
            // 
            this.rdbhdxuat.AutoSize = true;
            this.rdbhdxuat.Location = new System.Drawing.Point(721, 30);
            this.rdbhdxuat.Name = "rdbhdxuat";
            this.rdbhdxuat.Size = new System.Drawing.Size(107, 20);
            this.rdbhdxuat.TabIndex = 6;
            this.rdbhdxuat.TabStop = true;
            this.rdbhdxuat.Text = "Hóa đơn xuất";
            this.rdbhdxuat.UseVisualStyleBackColor = true;
            // 
            // rdbhdnhap
            // 
            this.rdbhdnhap.AutoSize = true;
            this.rdbhdnhap.Location = new System.Drawing.Point(721, 4);
            this.rdbhdnhap.Name = "rdbhdnhap";
            this.rdbhdnhap.Size = new System.Drawing.Size(113, 20);
            this.rdbhdnhap.TabIndex = 5;
            this.rdbhdnhap.TabStop = true;
            this.rdbhdnhap.Text = "Hóa đơn nhập";
            this.rdbhdnhap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày:";
            // 
            // btnxembill
            // 
            this.btnxembill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxembill.Location = new System.Drawing.Point(867, 4);
            this.btnxembill.Name = "btnxembill";
            this.btnxembill.Size = new System.Drawing.Size(109, 46);
            this.btnxembill.TabIndex = 2;
            this.btnxembill.Text = "Xem";
            this.btnxembill.UseVisualStyleBackColor = true;
            this.btnxembill.Click += new System.EventHandler(this.btnxembill_Click);
            // 
            // dtpdateto
            // 
            this.dtpdateto.Location = new System.Drawing.Point(446, 12);
            this.dtpdateto.Name = "dtpdateto";
            this.dtpdateto.Size = new System.Drawing.Size(254, 22);
            this.dtpdateto.TabIndex = 1;
            // 
            // dtpdatefrom
            // 
            this.dtpdatefrom.Location = new System.Drawing.Point(85, 12);
            this.dtpdatefrom.Name = "dtpdatefrom";
            this.dtpdatefrom.Size = new System.Drawing.Size(254, 22);
            this.dtpdatefrom.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvthongkehd);
            this.panel1.Location = new System.Drawing.Point(5, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 432);
            this.panel1.TabIndex = 3;
            // 
            // dgvthongkehd
            // 
            this.dgvthongkehd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvthongkehd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvthongkehd.Location = new System.Drawing.Point(3, 3);
            this.dgvthongkehd.Name = "dgvthongkehd";
            this.dgvthongkehd.RowHeadersWidth = 51;
            this.dgvthongkehd.RowTemplate.Height = 24;
            this.dgvthongkehd.Size = new System.Drawing.Size(979, 424);
            this.dgvthongkehd.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(5, 517);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(95, 33);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnshowall
            // 
            this.btnshowall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowall.Location = new System.Drawing.Point(875, 513);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(116, 38);
            this.btnshowall.TabIndex = 5;
            this.btnshowall.Text = "Show all";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 562);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKe";
            this.Text = "Thống kê";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvthongkehd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdbhdxuat;
        private System.Windows.Forms.RadioButton rdbhdnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxembill;
        private System.Windows.Forms.DateTimePicker dtpdateto;
        private System.Windows.Forms.DateTimePicker dtpdatefrom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvthongkehd;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnshowall;
    }
}