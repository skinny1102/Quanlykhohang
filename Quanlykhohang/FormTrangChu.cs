using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlykhohang
{
    public partial class FormTrangChu : Form
    {
       
        public String username;
        public FormTrangChu()
        {
            InitializeComponent();
        }
        public FormTrangChu(String user)
        {
            InitializeComponent();
            this.username = user;
        }
        private void addUser_Click(object sender, EventArgs e)
        {
            FormCapTaiKhoan form = new FormCapTaiKhoan();
            form.Show();
            this.Hide();
        }

        private void blockUser_Click(object sender, EventArgs e)
        {
            FormKhoaTaiKhoan formKhoaTaiKhoan = new FormKhoaTaiKhoan(username);
            formKhoaTaiKhoan.Show();
            this.Hide();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau formDoimatkhau = new FormDoiMatKhau(username);
            formDoimatkhau.Show();
            this.Hide();
        }
    }
}
