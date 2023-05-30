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
            ketnoi = new SqlConnection(chuoiketnoi);
            hienthi();
        }

        public void hienthi()
        {

            ketnoi.Open();
            sql = @"select SOHD,MAHANG,NGAYTHANG,MAKH from HD_BANHANG";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();

            dataGridView1 = new DataGridView();
            dataGridView1.DataSource = docdulieu;
            dataGridView1.DataSource = dataGridView1;
            docdulieu.Close();
            ketnoi.Close();
        }

        private void loatHD_BANHANG()
        {
            ketnoi = new SqlConnection(chuoiketnoi);

            ketnoi.Open();
            sql = "select* from HD_BANHANG ";
            hienthi();
            dataGridView1.DataSource = dt;
            ketnoi.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            sohd = row.Cells[0].Value.ToString();
        }

        private void cmd_view_Click(object sender, EventArgs e)
        {
            hienthi();
            dataGridView1.DataSource = dt;
           docdulieu.Close();
            ketnoi.Close();

        }

        
    }
  
}
