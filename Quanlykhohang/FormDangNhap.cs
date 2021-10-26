﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlykhohang
{
    public partial class FormDangNhap : Form
    {
        

        public FormDangNhap()
        {
            InitializeComponent();
        }
        public SqlConnection openSQL()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection connect = openSQL();
            string query = "select flag from employee where username = '" + username.Text + "'and password = '" + password.Text + "';";

            SqlCommand cmd = new SqlCommand(query, connect);
           
            //SqlDataReader reader = cmd.ExecuteReader();
            
            
            if (cmd.ExecuteScalar() != null)
            {
                Boolean flag = (bool)cmd.ExecuteScalar();
                if (flag == false)
                {
                    const string message = "Tài khoản bị khóa!";
                    const string caption = "Đăng nhập";
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                }
                else
                {
                    FormTrangChu form = new FormTrangChu(username.Text);  
                    form.Show();
                    this.Hide();
                }

            }
            else
            {
                const string message = "Tài khoản hoặc mật khẩu sai!";
                const string caption = "Đăng nhập";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                username.Focus();
            }
            connect.Close();
        }
     
        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
