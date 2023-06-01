namespace LIENKET_CSDL
{
    partial class BANHANG
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
            this.cmd_view = new System.Windows.Forms.Button();
            this.cmd_sua = new System.Windows.Forms.Button();
            this.cmd_xoa = new System.Windows.Forms.Button();
            this.cmd_them = new System.Windows.Forms.Button();
            this.dgvHDBH = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_MAKH = new System.Windows.Forms.TextBox();
            this.text_NGAYTHANG = new System.Windows.Forms.TextBox();
            this.text_MAHANG = new System.Windows.Forms.TextBox();
            this.text_SOHD = new System.Windows.Forms.TextBox();
            this.txt_SOHD = new System.Windows.Forms.Label();
            this.txt_MAHANG = new System.Windows.Forms.Label();
            this.txt_MAKH = new System.Windows.Forms.Label();
            this.txt_NGAYTHANG = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBH)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_view
            // 
            this.cmd_view.BackColor = System.Drawing.Color.Cornsilk;
            this.cmd_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_view.Location = new System.Drawing.Point(659, 238);
            this.cmd_view.Name = "cmd_view";
            this.cmd_view.Size = new System.Drawing.Size(127, 43);
            this.cmd_view.TabIndex = 20;
            this.cmd_view.Text = "VIEW";
            this.cmd_view.UseVisualStyleBackColor = false;
            this.cmd_view.Click += new System.EventHandler(this.cmd_view_Click);
            // 
            // cmd_sua
            // 
            this.cmd_sua.BackColor = System.Drawing.Color.Cornsilk;
            this.cmd_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_sua.Location = new System.Drawing.Point(459, 238);
            this.cmd_sua.Name = "cmd_sua";
            this.cmd_sua.Size = new System.Drawing.Size(139, 43);
            this.cmd_sua.TabIndex = 19;
            this.cmd_sua.Text = "SỬA";
            this.cmd_sua.UseVisualStyleBackColor = false;
            // 
            // cmd_xoa
            // 
            this.cmd_xoa.BackColor = System.Drawing.Color.Cornsilk;
            this.cmd_xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_xoa.Location = new System.Drawing.Point(241, 238);
            this.cmd_xoa.Name = "cmd_xoa";
            this.cmd_xoa.Size = new System.Drawing.Size(137, 45);
            this.cmd_xoa.TabIndex = 18;
            this.cmd_xoa.Text = "XOÁ";
            this.cmd_xoa.UseVisualStyleBackColor = false;
            // 
            // cmd_them
            // 
            this.cmd_them.BackColor = System.Drawing.Color.Cornsilk;
            this.cmd_them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_them.Location = new System.Drawing.Point(44, 238);
            this.cmd_them.Name = "cmd_them";
            this.cmd_them.Size = new System.Drawing.Size(123, 45);
            this.cmd_them.TabIndex = 17;
            this.cmd_them.Text = "THÊM";
            this.cmd_them.UseVisualStyleBackColor = false;
            this.cmd_them.Click += new System.EventHandler(this.cmd_them_Click);
            // 
            // dgvHDBH
            // 
            this.dgvHDBH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvHDBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBH.Location = new System.Drawing.Point(65, 330);
            this.dgvHDBH.MultiSelect = false;
            this.dgvHDBH.Name = "dgvHDBH";
            this.dgvHDBH.ReadOnly = true;
            this.dgvHDBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDBH.Size = new System.Drawing.Size(635, 192);
            this.dgvHDBH.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.text_MAKH);
            this.groupBox1.Controls.Add(this.text_NGAYTHANG);
            this.groupBox1.Controls.Add(this.text_MAHANG);
            this.groupBox1.Controls.Add(this.text_SOHD);
            this.groupBox1.Controls.Add(this.txt_SOHD);
            this.groupBox1.Controls.Add(this.txt_MAHANG);
            this.groupBox1.Controls.Add(this.txt_MAKH);
            this.groupBox1.Controls.Add(this.txt_NGAYTHANG);
            this.groupBox1.Location = new System.Drawing.Point(44, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 175);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // text_MAKH
            // 
            this.text_MAKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_MAKH.Location = new System.Drawing.Point(569, 94);
            this.text_MAKH.Multiline = true;
            this.text_MAKH.Name = "text_MAKH";
            this.text_MAKH.Size = new System.Drawing.Size(137, 44);
            this.text_MAKH.TabIndex = 8;
            // 
            // text_NGAYTHANG
            // 
            this.text_NGAYTHANG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_NGAYTHANG.Location = new System.Drawing.Point(569, 13);
            this.text_NGAYTHANG.Multiline = true;
            this.text_NGAYTHANG.Name = "text_NGAYTHANG";
            this.text_NGAYTHANG.Size = new System.Drawing.Size(140, 47);
            this.text_NGAYTHANG.TabIndex = 7;
            // 
            // text_MAHANG
            // 
            this.text_MAHANG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_MAHANG.Location = new System.Drawing.Point(186, 94);
            this.text_MAHANG.Multiline = true;
            this.text_MAHANG.Name = "text_MAHANG";
            this.text_MAHANG.Size = new System.Drawing.Size(148, 44);
            this.text_MAHANG.TabIndex = 6;
            // 
            // text_SOHD
            // 
            this.text_SOHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_SOHD.Location = new System.Drawing.Point(186, 0);
            this.text_SOHD.Multiline = true;
            this.text_SOHD.Name = "text_SOHD";
            this.text_SOHD.Size = new System.Drawing.Size(148, 47);
            this.text_SOHD.TabIndex = 5;
            // 
            // txt_SOHD
            // 
            this.txt_SOHD.AutoSize = true;
            this.txt_SOHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SOHD.Location = new System.Drawing.Point(42, 16);
            this.txt_SOHD.Name = "txt_SOHD";
            this.txt_SOHD.Size = new System.Drawing.Size(110, 17);
            this.txt_SOHD.TabIndex = 1;
            this.txt_SOHD.Text = "SỐ HOÁ ĐƠN:";
            // 
            // txt_MAHANG
            // 
            this.txt_MAHANG.AutoSize = true;
            this.txt_MAHANG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAHANG.Location = new System.Drawing.Point(60, 107);
            this.txt_MAHANG.Name = "txt_MAHANG";
            this.txt_MAHANG.Size = new System.Drawing.Size(92, 17);
            this.txt_MAHANG.TabIndex = 2;
            this.txt_MAHANG.Text = "MÃ HÀNG :";
            // 
            // txt_MAKH
            // 
            this.txt_MAKH.AutoSize = true;
            this.txt_MAKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAKH.Location = new System.Drawing.Point(384, 97);
            this.txt_MAKH.Name = "txt_MAKH";
            this.txt_MAKH.Size = new System.Drawing.Size(154, 17);
            this.txt_MAKH.TabIndex = 4;
            this.txt_MAKH.Text = "MÃ KHÁCH HÀNG :";
            // 
            // txt_NGAYTHANG
            // 
            this.txt_NGAYTHANG.AutoSize = true;
            this.txt_NGAYTHANG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NGAYTHANG.Location = new System.Drawing.Point(420, 16);
            this.txt_NGAYTHANG.Name = "txt_NGAYTHANG";
            this.txt_NGAYTHANG.Size = new System.Drawing.Size(118, 17);
            this.txt_NGAYTHANG.TabIndex = 3;
            this.txt_NGAYTHANG.Text = "NGÀY THÁNG :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(85, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(441, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "THÔNG TIN CHI TIẾT HOÁ ĐƠN BÁN HÀNG\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "HOÁ ĐƠN BÁN HÀNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LIENKET_CSDL.Properties.Resources.tai_hinh_dong_de_thuong;
            this.pictureBox1.Location = new System.Drawing.Point(736, 311);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // BANHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmd_view);
            this.Controls.Add(this.cmd_sua);
            this.Controls.Add(this.cmd_xoa);
            this.Controls.Add(this.cmd_them);
            this.Controls.Add(this.dgvHDBH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "BANHANG";
            this.Text = "BANHANG";
            this.Load += new System.EventHandler(this.BANHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmd_view;
        private System.Windows.Forms.Button cmd_sua;
        private System.Windows.Forms.Button cmd_xoa;
        private System.Windows.Forms.Button cmd_them;
        private System.Windows.Forms.DataGridView dgvHDBH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_MAKH;
        private System.Windows.Forms.TextBox text_NGAYTHANG;
        private System.Windows.Forms.TextBox text_MAHANG;
        private System.Windows.Forms.TextBox text_SOHD;
        private System.Windows.Forms.Label txt_SOHD;
        private System.Windows.Forms.Label txt_MAHANG;
        private System.Windows.Forms.Label txt_MAKH;
        private System.Windows.Forms.Label txt_NGAYTHANG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}