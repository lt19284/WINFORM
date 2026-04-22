using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLCF
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        void LoadAccountList()
        {
            SqlConnection connection = new SqlConnection("Data Source=LAMTHUC-DEV;Initial Catalog=QLCF;Integrated Security=True");
            // Mở kết Nối
            connection.Open();

            string query = "SELECT TenNguoiDung as [Tên Hiển Thị], TenDangNhap as [Tên Đăng Nhập] FROM dbo.TaiKhoan"; // Thực Hiện Câu Truy Vấn

            SqlCommand command = new SqlCommand(query, connection); //Tạo Query

            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dataTable);

            dtgvAccount.DataSource = dataTable;
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {

        }
    }
}
