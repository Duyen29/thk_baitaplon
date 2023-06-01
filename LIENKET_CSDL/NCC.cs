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
    public partial class NCC : Form
    {
        public NCC()
        {
            InitializeComponent();
        }
        String chuoiketnoi = @"Data Source=Admin\SQLEXPRESS;Initial Catalog=THIHOCKY;Integrated Security=True";
        String sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        DataTable dt;

        private void cmd_view_Click(object sender, EventArgs e)
        {
            hienthihoadon2();
        }

        private void NCC_Load(object sender, EventArgs e)
        {

        }
        public void hienthihoadon2()
        {
            try
            {

                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                sql = @"select * from DM_NHACUNGCAP";
                thuchien = new SqlCommand();
                thuchien.Connection = ketnoi;
                thuchien.CommandText = sql;
                thuchien.CommandType = CommandType.Text;
                docdulieu = thuchien.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(docdulieu);
                dgvDMNCC.DataSource = dt;
                dgvDMNCC.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đọc dữ liệu nhà cung cấp");
            }
            docdulieu.Close();
            ketnoi.Close();
        }

        private void cmd_them_Click(object sender, EventArgs e)
        {
            string MANCC = text_MANCC.Text;
            string TENNCC = text_TENNCC.Text;
            string DIACHI = text_DIACHI.Text;
            string SODIENTHOAI = text_SODIENTHOAI.Text;

            // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

            try
            {

                ketnoi = new SqlConnection(chuoiketnoi);
                ketnoi.Open();
                sql = $"INSERT INTO [dbo].[DM_NHACUNGCAP]" +
                    $"([MANCC],[TENNCC],[DIACHI],[SODIENTHOAI])" +
                    $"VALUES (N'{MANCC}',N'{TENNCC}',N'{DIACHI}',{SODIENTHOAI})";
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

        private void cmd_xoa_Click(object sender, EventArgs e)
        {
            if (dgvDMNCC.SelectedRows.Count > 0)
            {
                string MANCCCanXoa = dgvDMNCC.SelectedRows[0].Cells[0].Value.ToString();

                ketnoi.Open();
                string lenhxoa = "delete from DM_NHACUNGCAP where MANCC ='" + MANCCCanXoa + "'";

                thuchien = new SqlCommand(lenhxoa, ketnoi);
                thuchien.ExecuteNonQuery();

                ketnoi.Close();
                hienthihoadon2();
                MessageBox.Show(" XOÁ THÀNH CÔNG!!");
            }
        }

        private void cmd_sua_Click(object sender, EventArgs e)
        {
            if (dgvDMNCC.SelectedRows.Count > 0)
            {
                string MANCCSUA = dgvDMNCC.SelectedRows[0].Cells[0].Value.ToString();
                //  MessageBox.Show(MAKHSua);
                // Lấy tất cả thông tin muốn thêm
                string MANCC = text_MANCC.Text;
                string TENNCC = text_TENNCC.Text;
                string DIACHI = text_DIACHI.Text;
                string SODIENTHOAI = text_SODIENTHOAI.Text;
                // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

                string sql = $"UPDATE [dbo].[DM_NHACUNGCAP]" +
                    $"SET " +
                    $"[MANCC] = N'{MANCC}'," +
                    $"[TENNCC] = N'{TENNCC}'," +
                    $"[DIACHI] = N'{DIACHI}'," +
                    $"[SODIENTHOAI] = {SODIENTHOAI} " +
                    $"WHERE MANCC = N'{MANCCSUA}' ";
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
