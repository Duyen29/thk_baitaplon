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
        String chuoiketnoi = @"Data Source=Admin\SQLEXPRESS;Initial Catalog=baitaplon;Integrated Security=True";
        String sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        DataTable dt;
    }
}
