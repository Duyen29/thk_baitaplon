using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace LIENKET_CSDL
{
    public partial class hoadon : Form
    {
        public hoadon()
        {
            InitializeComponent();
        }

        String chuoiketnoi = @"Data Source=Admin\SQLEXPRESS;Initial Catalog=baitaplon;Integrated Security=True";
        String sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        DataTable dt;


        String sohd;
        private void hoadon_Load_1(object sender, EventArgs e)
        {

        }

        public void hienthiHoaDon()
        {
            try
            {

                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                sql = @"select * from HD_BANHANG";
                thuchien = new SqlCommand();
                thuchien.Connection = ketnoi;
                thuchien.CommandText = sql;
                thuchien.CommandType = CommandType.Text;
                docdulieu = thuchien.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(docdulieu);
                dgvHoaDon.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đọc dữ liệu ban hang");
            }
            docdulieu.Close();
            ketnoi.Close();
        }

        private void cmd_view_Click(object sender, EventArgs e)
        {
            hienthiHoaDon();

        }

        private void cmd_them_Click(object sender, EventArgs e)
        {
            string SOHD = txt_SOHD.Text;
            string MAHANG = txt_MAHANG.Text;
            string NGAYTHANG = txt_NGAYTHANG.Text;
            string MAKH = txt_MAKH.Text;
            // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

            try
            {

                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                sql = @"insert into HD_BANHANG
	        values 
            (N'" + SOHD + "' , N'" + MAHANG + "' , '" + NGAYTHANG + "'  , N'" + MAKH + "')";
                thuchien = new SqlCommand();
                thuchien.Connection = ketnoi;
                thuchien.CommandText = sql;
                thuchien.CommandType = CommandType.Text;
                thuchien.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đọc dữ liệu ban hang");
            }
            docdulieu.Close();
            ketnoi.Close();
            MessageBox.Show("THÊM THÀNH CÔNG!!");
        }
    }
}
  

