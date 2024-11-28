using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        private string sqlConn()
        {
            return "Data Source=10.12.42.7;Initial Catalog=MyDb;User ID=SuperAdmin";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sqlConn());
            try
            {
                conn.Open();
                string userName = textBox1.Text;
                string password = textBox2.Text;
                string sqlStr = "SELECT * FROM login WHERE Uname = @userName and psw = @password";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@userName ", userName);
                cmd.Parameters.AddWithValue("@password ", password);
                SqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Salam");
            }catch(SqlException sq)
            {
                MessageBox.Show($"{sq.Message}");
            }
        }
    }
}
