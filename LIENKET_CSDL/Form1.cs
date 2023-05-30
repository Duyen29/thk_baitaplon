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
                sql = @"select * from DM_SANPHAM";
                thuchien = new SqlCommand();
                thuchien.Connection = ketnoi;
                thuchien.CommandText = sql;
                thuchien.CommandType = CommandType.Text;
                docdulieu = thuchien.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(docdulieu);
                dgvHoaDon.DataSource = dt;
                dgvHoaDon.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            string MAHANG = text_MAHANG.Text;
            string TENHANG= text_TENHANG.Text;
            string DONVI = text_DONVI.Text;
            
            // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

            try
            {

                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                sql = $"INSERT INTO [dbo].[DM_SANPHAM]" +
                    $"([MAHANG],[TENHANG],[DONVI])" +
                    $"VALUES (N'{TENHANG}',N'{TENHANG}',N'{DONVI}')";
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
            hienthiHoaDon();
            MessageBox.Show("THÊM THÀNH CÔNG!!");
        }

        private void cmd_sua_Click(object sender, EventArgs e)
        {

            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                string MAHANGSUA = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
                //  MessageBox.Show(MAHANGSua);
                // Lấy tất cả thông tin muốn thêm
                string MAHANG = text_MAHANG.Text;
                string TENHANG = text_TENHANG.Text;
                string DONVI = text_DONVI.Text;
               
                // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

                string sql = $"UPDATE [dbo].[DM_SANPHAM]" +
                    $"SET " +
                    $"[MAHANG] = N'{MAHANG}'," +
                    $"[TENHANG] = N'{TENHANG}'," +
                    $"[DONVI] = N'{DONVI}'" +
                    $"WHERE MAHANG = N'{MAHANGSUA}' ";
                Console.WriteLine(sql);
                ketnoi.Open();
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();

                ketnoi.Close();
                hienthiHoaDon();

            }
        }

        private void cmd_xoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                string MAHANGCanXoa = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();

                ketnoi.Open();
                string lenhxoa = "delete from DM_SANPHAM where MAHANG ='" + MAHANGCanXoa + "'";

                thuchien = new SqlCommand(lenhxoa, ketnoi);
                thuchien.ExecuteNonQuery();

                ketnoi.Close();
                hienthiHoaDon();
                MessageBox.Show(" XOÁ THÀNH CÔNG!!");
            }
        }
    }
}
  

