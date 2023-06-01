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
    public partial class hoadon2 : Form

    {
        
        public hoadon2()
        {
            InitializeComponent();
        }
        String chuoiketnoi = @"Data Source=Admin\SQLEXPRESS;Initial Catalog=THIHOCKY;Integrated Security=True";
        String sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        DataTable dt;
        private void hoadon2_Load(object sender, EventArgs e)
        {

        }
        //HIỂN THỊ VIEW
        public void hienthihoadon2()
        {
            try
            {

                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                sql = @"select * from DM_KHACHHANG";
                thuchien = new SqlCommand();
                thuchien.Connection = ketnoi;
                thuchien.CommandText = sql;
                thuchien.CommandType = CommandType.Text;
                docdulieu = thuchien.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(docdulieu);
              dgvDMKH.DataSource = dt;
                dgvDMKH.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            hienthihoadon2();
        }
        //THÊM
        private void cmd_them_Click(object sender, EventArgs e)
        {
            string MAKH =text_MAKH.Text;
            string TENKH = text_TENKH.Text;
            string DIACHI = text_DIACHI.Text;
            string SODIENTHOAI= textSODIENTHOAI.Text;
            // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

            try
            {

                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                sql = $"INSERT INTO [dbo].[DM_KHACHHANG]" +
                    $"([MAKH],[TENKH],[DIACHI],[SODIENTHOAI])" +
                    $"VALUES (N'{MAKH}',N'{TENKH}',N'{DIACHI}',{SODIENTHOAI})";
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
            hienthihoadon2();
            MessageBox.Show("THÊM THÀNH CÔNG!!");
        }
        //XOÁ
        private void cmd_xoa_Click(object sender, EventArgs e)
        {
            if (dgvDMKH.SelectedRows.Count > 0)
            {
                string MAKHCanXoa = dgvDMKH.SelectedRows[0].Cells[0].Value.ToString();

                ketnoi.Open();
                string lenhxoa = "delete from DM_KHACHHANG where MAKH ='" + MAKHCanXoa + "'";

                thuchien = new SqlCommand(lenhxoa, ketnoi);
                thuchien.ExecuteNonQuery();

                ketnoi.Close();
                hienthihoadon2();
                MessageBox.Show(" XOÁ THÀNH CÔNG!!");
            }
        }
        //SỬA
        private void cmd_sua_Click(object sender, EventArgs e)
        {
            if (dgvDMKH.SelectedRows.Count > 0)
            {
                string MAKHSUA = dgvDMKH.SelectedRows[0].Cells[0].Value.ToString();
                //  MessageBox.Show(MAKHSua);
                // Lấy tất cả thông tin muốn thêm
                string MAKH = text_MAKH.Text;
                string TENKH = text_TENKH.Text;
                string DIACHI= text_DIACHI.Text;
                string SODIENTHOAI = textSODIENTHOAI.Text;
                // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

                string sql = $"UPDATE [dbo].[DM_KHACHHANG]" +
                    $"SET " +
                    $"[MAKH] = N'{MAKH}'," +
                    $"[TENKH] = N'{TENKH }'," +
                    $"[DIACHI] = N'{DIACHI }'," +
                    $"[SODIENTHOAI] = {SODIENTHOAI } " +
                    $"WHERE MAKH = N'{MAKHSUA}' ";
                Console.WriteLine(sql);
                ketnoi.Open();
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
               
                ketnoi.Close();
                hienthihoadon2();

            }
        }
       
    }
}
