using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Btl_QLCF
{
    public partial class Login : Form
    {
        private bool exitMessageBoxShown = false;
        
        /// <summary>
        /// //
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            string username = txtTaiKhoan.Text.Trim();
            string password = txtMatKhau.Text.Trim();
            string sql = "select role from tbTaiKhoan where username ='" +
                username + "'and password ='" +
                password + "'";
            if (string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(password)
            )
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
            
                string role = db.getValues(sql);
                if(role =="")
                {
                    MessageBox.Show("Tai khoan hoac Mat khau ban chua dung!!!", "Chu y", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaiKhoan.Focus();
                    txtTaiKhoan.SelectAll();
                }
                else
                {
                    Menu menu = new Menu(role);
                    this.Hide();
                    menu.Show();
            }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Ban muon thoat khong?", "Chu y", MessageBoxButtons.OK, MessageBoxIcon.Question);
            Application.Exit();

        }
        

        private void ckbMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !txtMatKhau.UseSystemPasswordChar;
        }       
        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter ) 
            {
                btnDangNhap.Focus();
            }
        }
    }
}
