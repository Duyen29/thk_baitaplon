namespace LIENKET_CSDL
{
    partial class hoadon2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MAKH = new System.Windows.Forms.Label();
            this.txt_TENKH = new System.Windows.Forms.Label();
            this.txt_DIACHI = new System.Windows.Forms.Label();
            this.txt_SODIENTHOAI = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textSODIENTHOAI = new System.Windows.Forms.TextBox();
            this.text_DIACHI = new System.Windows.Forms.TextBox();
            this.text_TENKH = new System.Windows.Forms.TextBox();
            this.text_MAKH = new System.Windows.Forms.TextBox();
            this.dgvDMKH = new System.Windows.Forms.DataGridView();
            this.cmd_them = new System.Windows.Forms.Button();
            this.cmd_xoa = new System.Windows.Forms.Button();
            this.cmd_sua = new System.Windows.Forms.Button();
            this.cmd_view = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // txt_MAKH
            // 
            this.txt_MAKH.AutoSize = true;
            this.txt_MAKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAKH.Location = new System.Drawing.Point(22, 16);
            this.txt_MAKH.Name = "txt_MAKH";
            this.txt_MAKH.Size = new System.Drawing.Size(154, 17);
            this.txt_MAKH.TabIndex = 1;
            this.txt_MAKH.Text = "MÃ KHÁCH HÀNG :";
            // 
            // txt_TENKH
            // 
            this.txt_TENKH.AutoSize = true;
            this.txt_TENKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENKH.Location = new System.Drawing.Point(22, 97);
            this.txt_TENKH.Name = "txt_TENKH";
            this.txt_TENKH.Size = new System.Drawing.Size(159, 17);
            this.txt_TENKH.TabIndex = 2;
            this.txt_TENKH.Text = "TÊN KHÁCH HÀNG :";
            // 
            // txt_DIACHI
            // 
            this.txt_DIACHI.AutoSize = true;
            this.txt_DIACHI.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DIACHI.Location = new System.Drawing.Point(465, 16);
            this.txt_DIACHI.Name = "txt_DIACHI";
            this.txt_DIACHI.Size = new System.Drawing.Size(77, 17);
            this.txt_DIACHI.TabIndex = 3;
            this.txt_DIACHI.Text = "ĐỊA CHỈ :";
            // 
            // txt_SODIENTHOAI
            // 
            this.txt_SODIENTHOAI.AutoSize = true;
            this.txt_SODIENTHOAI.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SODIENTHOAI.Location = new System.Drawing.Point(420, 94);
            this.txt_SODIENTHOAI.Name = "txt_SODIENTHOAI";
            this.txt_SODIENTHOAI.Size = new System.Drawing.Size(134, 17);
            this.txt_SODIENTHOAI.TabIndex = 4;
            this.txt_SODIENTHOAI.Text = "SỐ ĐIỆN THOẠI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(129, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(492, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "THÔNG TIN CHI TIẾT DANH MỤC KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.textSODIENTHOAI);
            this.groupBox1.Controls.Add(this.text_DIACHI);
            this.groupBox1.Controls.Add(this.text_TENKH);
            this.groupBox1.Controls.Add(this.text_MAKH);
            this.groupBox1.Controls.Add(this.txt_MAKH);
            this.groupBox1.Controls.Add(this.txt_TENKH);
            this.groupBox1.Controls.Add(this.txt_SODIENTHOAI);
            this.groupBox1.Controls.Add(this.txt_DIACHI);
            this.groupBox1.Location = new System.Drawing.Point(46, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 155);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // textSODIENTHOAI
            // 
            this.textSODIENTHOAI.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSODIENTHOAI.Location = new System.Drawing.Point(569, 94);
            this.textSODIENTHOAI.Multiline = true;
            this.textSODIENTHOAI.Name = "textSODIENTHOAI";
            this.textSODIENTHOAI.Size = new System.Drawing.Size(137, 44);
            this.textSODIENTHOAI.TabIndex = 8;
            // 
            // text_DIACHI
            // 
            this.text_DIACHI.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_DIACHI.Location = new System.Drawing.Point(569, 13);
            this.text_DIACHI.Multiline = true;
            this.text_DIACHI.Name = "text_DIACHI";
            this.text_DIACHI.Size = new System.Drawing.Size(140, 47);
            this.text_DIACHI.TabIndex = 7;
            // 
            // text_TENKH
            // 
            this.text_TENKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_TENKH.Location = new System.Drawing.Point(202, 91);
            this.text_TENKH.Multiline = true;
            this.text_TENKH.Name = "text_TENKH";
            this.text_TENKH.Size = new System.Drawing.Size(148, 44);
            this.text_TENKH.TabIndex = 6;
            // 
            // text_MAKH
            // 
            this.text_MAKH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_MAKH.Location = new System.Drawing.Point(202, 13);
            this.text_MAKH.Multiline = true;
            this.text_MAKH.Name = "text_MAKH";
            this.text_MAKH.Size = new System.Drawing.Size(148, 47);
            this.text_MAKH.TabIndex = 5;
            // 
            // dgvDMKH
            // 
            this.dgvDMKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDMKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDMKH.Location = new System.Drawing.Point(61, 318);
            this.dgvDMKH.MultiSelect = false;
            this.dgvDMKH.Name = "dgvDMKH";
            this.dgvDMKH.ReadOnly = true;
            this.dgvDMKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDMKH.Size = new System.Drawing.Size(587, 171);
            this.dgvDMKH.TabIndex = 7;
            // 
            // cmd_them
            // 
            this.cmd_them.BackColor = System.Drawing.Color.Cornsilk;
            this.cmd_them.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_them.Location = new System.Drawing.Point(119, 211);
            this.cmd_them.Name = "cmd_them";
            this.cmd_them.Size = new System.Drawing.Size(103, 39);
            this.cmd_them.TabIndex = 8;
            this.cmd_them.Text = "THÊM";
            this.cmd_them.UseVisualStyleBackColor = false;
            this.cmd_them.Click += new System.EventHandler(this.cmd_them_Click);
            // 
            // cmd_xoa
            // 
            this.cmd_xoa.BackColor = System.Drawing.Color.Cornsilk;
            this.cmd_xoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_xoa.Location = new System.Drawing.Point(326, 211);
            this.cmd_xoa.Name = "cmd_xoa";
            this.cmd_xoa.Size = new System.Drawing.Size(96, 39);
            this.cmd_xoa.TabIndex = 9;
            this.cmd_xoa.Text = "XOÁ";
            this.cmd_xoa.UseVisualStyleBackColor = false;
            this.cmd_xoa.Click += new System.EventHandler(this.cmd_xoa_Click);
            // 
            // cmd_sua
            // 
            this.cmd_sua.BackColor = System.Drawing.Color.Cornsilk;
            this.cmd_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_sua.Location = new System.Drawing.Point(520, 210);
            this.cmd_sua.Name = "cmd_sua";
            this.cmd_sua.Size = new System.Drawing.Size(101, 40);
            this.cmd_sua.TabIndex = 10;
            this.cmd_sua.Text = "SỬA";
            this.cmd_sua.UseVisualStyleBackColor = false;
            this.cmd_sua.Click += new System.EventHandler(this.cmd_sua_Click);
            // 
            // cmd_view
            // 
            this.cmd_view.BackColor = System.Drawing.Color.Cornsilk;
            this.cmd_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_view.Location = new System.Drawing.Point(705, 211);
            this.cmd_view.Name = "cmd_view";
            this.cmd_view.Size = new System.Drawing.Size(94, 39);
            this.cmd_view.TabIndex = 11;
            this.cmd_view.Text = "VIEW";
            this.cmd_view.UseVisualStyleBackColor = false;
            this.cmd_view.Click += new System.EventHandler(this.cmd_view_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LIENKET_CSDL.Properties.Resources.hinh_anh_dong_de_thuong;
            this.pictureBox1.Location = new System.Drawing.Point(687, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // hoadon2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(876, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmd_view);
            this.Controls.Add(this.cmd_sua);
            this.Controls.Add(this.cmd_xoa);
            this.Controls.Add(this.cmd_them);
            this.Controls.Add(this.dgvDMKH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "hoadon2";
            this.Text = "hoadon2";
            this.Load += new System.EventHandler(this.hoadon2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDMKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_MAKH;
        private System.Windows.Forms.Label txt_TENKH;
        private System.Windows.Forms.Label txt_DIACHI;
        private System.Windows.Forms.Label txt_SODIENTHOAI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDMKH;
        private System.Windows.Forms.Button cmd_them;
        private System.Windows.Forms.Button cmd_xoa;
        private System.Windows.Forms.Button cmd_sua;
        private System.Windows.Forms.Button cmd_view;
        private System.Windows.Forms.TextBox textSODIENTHOAI;
        private System.Windows.Forms.TextBox text_DIACHI;
        private System.Windows.Forms.TextBox text_TENKH;
        private System.Windows.Forms.TextBox text_MAKH;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}