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

namespace Btl_QLCF
{
    public partial class Register : Form
    {
        private bool exitMessageBoxShown;

        public Register()
        {
            InitializeComponent();
        }

        private void btnDk_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            string username = txtTenTaiKhoan.Text.Trim();
            string password = txtMatkhauDK.Text.Trim();
            if (string.IsNullOrWhiteSpace(username)
                || string.IsNullOrWhiteSpace(password)
            )
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                if (txtMatkhauDK.Text != txtMatKhau1DK.Text)
                {
                    txtTenTaiKhoan.Text = "";
                    txtMatkhauDK.Text = "";
                    txtMatKhau1DK.Clear();
                    MessageBox.Show("Mat khau khong trung khop", "Chu y", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string sql = "insert into tbTaiKhoan(username,password) values('" +
                        txtTenTaiKhoan.Text + "',N'" +
                        txtMatkhauDK.Text + "')";
                    
                    db.getValues(sql);
                    btnQuayLai_Click(sender, e);

                    MessageBox.Show("Tao tai khoan moi thanh cong", "Chu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked != true)
            {
                btnDk.Enabled = false;
                btnQuayLai.Enabled = false;
            }
            else
            {
                btnDk.Enabled = true;
                btnQuayLai.Enabled = true;
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }

        private void btnThoatDK_Click(object sender, EventArgs e)
        {
            if (!exitMessageBoxShown)
            {
                DialogResult dlr = MessageBox.Show("Ban muon thoat chuong trinh", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr != DialogResult.No)
                {
                    Application.Exit();
                }
                exitMessageBoxShown = true;
            }
        }
        
        
    }
}
