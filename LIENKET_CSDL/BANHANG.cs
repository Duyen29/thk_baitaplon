using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIENKET_CSDL
{
    public partial class BANHANG : Form
    {
        public BANHANG()
        {
            InitializeComponent();
        }
        String chuoiketnoi = @"Data Source=Admin\SQLEXPRESS;Initial Catalog=THIHOCKY;Integrated Security=True";
        String sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        DataTable dt;

        private void BANHANG_Load(object sender, EventArgs e)
        {

        }
        public void hienthiBANHANG()
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
                dgvHDBH.DataSource = dt;
                dgvHDBH.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            hienthiBANHANG();
        }

        private void cmd_them_Click(object sender, EventArgs e)
        {
            string SOHD= text_SOHD.Text;
            string MAHANG = text_MAHANG.Text;
            string NGAYTHANG = text_NGAYTHANG.Text;
            string MAKH = text_MAKH.Text;
            // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

            try
            {

                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                sql = $"INSERT INTO [dbo].[HD_BANHANG]" +
                    $"([SOHD],[MAHANG],[NGAYTHANG],[MAKH])" +
                    $"VALUES (N'{SOHD}',N'{MAHANG}',N'{NGAYTHANG}',N'{MAKH}')";
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
            ketnoi.Close();
            hienthiBANHANG();
            MessageBox.Show("THÊM THÀNH CÔNG!!");
        }
    }
}
