﻿namespace LIENKET_CSDL
{
    partial class hoadon
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
            this.txtLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmd_them = new System.Windows.Forms.Button();
            this.cmd_sua = new System.Windows.Forms.Button();
            this.cmd_xoa = new System.Windows.Forms.Button();
            this.cmd_view = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_SOHD = new System.Windows.Forms.Label();
            this.txt_MAHANG = new System.Windows.Forms.Label();
            this.txt_NGAYTHANG = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.text_DONVI = new System.Windows.Forms.TextBox();
            this.text_TENHANG = new System.Windows.Forms.TextBox();
            this.text_MAHANG = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(43, 321);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(630, 150);
            this.dgvHoaDon.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "THÔNG TIN DANH MỤC SẢN PHẨM";
            // 
            // cmd_them
            // 
            this.cmd_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmd_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_them.Location = new System.Drawing.Point(794, 58);
            this.cmd_them.Name = "cmd_them";
            this.cmd_them.Size = new System.Drawing.Size(98, 33);
            this.cmd_them.TabIndex = 0;
            this.cmd_them.Text = "THÊM";
            this.cmd_them.UseVisualStyleBackColor = false;
            this.cmd_them.Click += new System.EventHandler(this.cmd_them_Click);
            // 
            // cmd_sua
            // 
            this.cmd_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmd_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_sua.Location = new System.Drawing.Point(795, 98);
            this.cmd_sua.Name = "cmd_sua";
            this.cmd_sua.Size = new System.Drawing.Size(97, 33);
            this.cmd_sua.TabIndex = 4;
            this.cmd_sua.Text = "SỬA";
            this.cmd_sua.UseVisualStyleBackColor = false;
            this.cmd_sua.Click += new System.EventHandler(this.cmd_sua_Click);
            // 
            // cmd_xoa
            // 
            this.cmd_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmd_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_xoa.Location = new System.Drawing.Point(795, 137);
            this.cmd_xoa.Name = "cmd_xoa";
            this.cmd_xoa.Size = new System.Drawing.Size(97, 33);
            this.cmd_xoa.TabIndex = 5;
            this.cmd_xoa.Text = "XOÁ";
            this.cmd_xoa.UseVisualStyleBackColor = false;
            this.cmd_xoa.Click += new System.EventHandler(this.cmd_xoa_Click);
            // 
            // cmd_view
            // 
            this.cmd_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmd_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_view.Location = new System.Drawing.Point(794, 176);
            this.cmd_view.Name = "cmd_view";
            this.cmd_view.Size = new System.Drawing.Size(97, 33);
            this.cmd_view.TabIndex = 6;
            this.cmd_view.Text = "VIEW";
            this.cmd_view.UseVisualStyleBackColor = false;
            this.cmd_view.Click += new System.EventHandler(this.cmd_view_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(233, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "THÔNG TIN CHI TIẾT DANH MỤC SẢN PHẢM\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LIENKET_CSDL.Properties.Resources.haha;
            this.pictureBox1.Location = new System.Drawing.Point(532, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txt_SOHD
            // 
            this.txt_SOHD.AutoSize = true;
            this.txt_SOHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SOHD.Location = new System.Drawing.Point(28, 31);
            this.txt_SOHD.Name = "txt_SOHD";
            this.txt_SOHD.Size = new System.Drawing.Size(96, 19);
            this.txt_SOHD.TabIndex = 0;
            this.txt_SOHD.Text = "MÃ  HÀNG:";
            // 
            // txt_MAHANG
            // 
            this.txt_MAHANG.AutoSize = true;
            this.txt_MAHANG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MAHANG.Location = new System.Drawing.Point(27, 110);
            this.txt_MAHANG.Name = "txt_MAHANG";
            this.txt_MAHANG.Size = new System.Drawing.Size(97, 19);
            this.txt_MAHANG.TabIndex = 1;
            this.txt_MAHANG.Text = "TÊN HÀNG:";
            // 
            // txt_NGAYTHANG
            // 
            this.txt_NGAYTHANG.AutoSize = true;
            this.txt_NGAYTHANG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NGAYTHANG.Location = new System.Drawing.Point(49, 190);
            this.txt_NGAYTHANG.Name = "txt_NGAYTHANG";
            this.txt_NGAYTHANG.Size = new System.Drawing.Size(75, 19);
            this.txt_NGAYTHANG.TabIndex = 2;
            this.txt_NGAYTHANG.Text = "ĐƠN VỊ: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.text_DONVI);
            this.groupBox1.Controls.Add(this.text_TENHANG);
            this.groupBox1.Controls.Add(this.text_MAHANG);
            this.groupBox1.Controls.Add(this.txt_NGAYTHANG);
            this.groupBox1.Controls.Add(this.txt_MAHANG);
            this.groupBox1.Controls.Add(this.txt_SOHD);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(43, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // text_DONVI
            // 
            this.text_DONVI.Location = new System.Drawing.Point(185, 175);
            this.text_DONVI.Multiline = true;
            this.text_DONVI.Name = "text_DONVI";
            this.text_DONVI.Size = new System.Drawing.Size(120, 46);
            this.text_DONVI.TabIndex = 5;
            // 
            // text_TENHANG
            // 
            this.text_TENHANG.Location = new System.Drawing.Point(185, 96);
            this.text_TENHANG.Multiline = true;
            this.text_TENHANG.Name = "text_TENHANG";
            this.text_TENHANG.Size = new System.Drawing.Size(120, 46);
            this.text_TENHANG.TabIndex = 4;
            // 
            // text_MAHANG
            // 
            this.text_MAHANG.Location = new System.Drawing.Point(185, 19);
            this.text_MAHANG.Multiline = true;
            this.text_MAHANG.Name = "text_MAHANG";
            this.text_MAHANG.Size = new System.Drawing.Size(120, 51);
            this.text_MAHANG.TabIndex = 3;
            // 
            // hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(909, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmd_view);
            this.Controls.Add(this.cmd_xoa);
            this.Controls.Add(this.cmd_sua);
            this.Controls.Add(this.cmd_them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "hoadon";
            this.Text = "hoadon1";
            this.Load += new System.EventHandler(this.hoadon_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip txtLog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmd_them;
        private System.Windows.Forms.Button cmd_sua;
        private System.Windows.Forms.Button cmd_xoa;
        private System.Windows.Forms.Button cmd_view;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt_SOHD;
        private System.Windows.Forms.Label txt_MAHANG;
        private System.Windows.Forms.Label txt_NGAYTHANG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_DONVI;
        private System.Windows.Forms.TextBox text_TENHANG;
        private System.Windows.Forms.TextBox text_MAHANG;
    }
}

