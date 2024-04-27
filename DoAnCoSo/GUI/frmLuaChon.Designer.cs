namespace DoAnCoSo.GUI
{
    partial class frmLuaChon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLuaChon));
            this.rdbnhap = new System.Windows.Forms.RadioButton();
            this.rdbxuat = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlcok = new System.Windows.Forms.Button();
            this.btnlcback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbnhap
            // 
            this.rdbnhap.AutoSize = true;
            this.rdbnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbnhap.Location = new System.Drawing.Point(102, 47);
            this.rdbnhap.Name = "rdbnhap";
            this.rdbnhap.Size = new System.Drawing.Size(146, 24);
            this.rdbnhap.TabIndex = 0;
            this.rdbnhap.TabStop = true;
            this.rdbnhap.Text = "Hóa đơn nhập";
            this.rdbnhap.UseVisualStyleBackColor = true;
            // 
            // rdbxuat
            // 
            this.rdbxuat.AutoSize = true;
            this.rdbxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbxuat.Location = new System.Drawing.Point(102, 94);
            this.rdbxuat.Name = "rdbxuat";
            this.rdbxuat.Size = new System.Drawing.Size(141, 24);
            this.rdbxuat.TabIndex = 1;
            this.rdbxuat.TabStop = true;
            this.rdbxuat.Text = "Hóa đơn xuất";
            this.rdbxuat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbnhap);
            this.groupBox1.Controls.Add(this.rdbxuat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Option:";
            // 
            // btnlcok
            // 
            this.btnlcok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlcok.Location = new System.Drawing.Point(26, 192);
            this.btnlcok.Name = "btnlcok";
            this.btnlcok.Size = new System.Drawing.Size(75, 54);
            this.btnlcok.TabIndex = 3;
            this.btnlcok.Text = "OK";
            this.btnlcok.UseVisualStyleBackColor = true;
            this.btnlcok.Click += new System.EventHandler(this.btnlcok_Click);
            // 
            // btnlcback
            // 
            this.btnlcback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlcback.Location = new System.Drawing.Point(323, 192);
            this.btnlcback.Name = "btnlcback";
            this.btnlcback.Size = new System.Drawing.Size(75, 54);
            this.btnlcback.TabIndex = 4;
            this.btnlcback.Text = "Back";
            this.btnlcback.UseVisualStyleBackColor = true;
            this.btnlcback.Click += new System.EventHandler(this.btnlcback_Click);
            // 
            // frmLuaChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 265);
            this.Controls.Add(this.btnlcback);
            this.Controls.Add(this.btnlcok);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLuaChon";
            this.Text = "Hóa đơn nhập, xuất";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbnhap;
        private System.Windows.Forms.RadioButton rdbxuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlcok;
        private System.Windows.Forms.Button btnlcback;
    }
}