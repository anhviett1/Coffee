using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Btl_QLCF
{
    public partial class Menu : Form
    {
        private string role;
        public Menu(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Phan quyen
            if (role == "0")
            {
                
            }
            else
            {
                NhanVien.Enabled = true;
            }
        }



        private void adDangXuat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        private void adDoiMK_Click(object sender, EventArgs e)
        {

        }
        private void adThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.Show();
        }

        private void NhanVien_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
        }
    }
}
