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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        DBConnection db1 = new DBConnection();
        private void Staff_Load(object sender, EventArgs e)
        {
            dgvStaff.DataSource = db1.DataTable("select * from tbNhanVien");
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbNhanVien values('N" +
                txtMaNV.Text + "','" +
                txtTenNV.Text + "','" +
                txtNamSinh.Text + "','" +
                txtNgayLam.Text + "','" +
                txtLuongCB.Text + "','" +
                cbCaLam.Text + "')";
            db1.getValues(sql); 
            dgvStaff.DataSource = db1.DataTable("select * from tbNhanVien");
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            string sql = "update tbNhanVien set tenNV = N'" +
                txtTenNV.Text + "',namSinh= '" +
                txtNamSinh.Text + "',ngayLam= '" +
                txtNgayLam.Text + "',luongCB= '" +
                txtLuongCB.Text + "',caLam= '" +
                cbCaLam.Text + "' where maNV= '" +
                txtMaNV.Text + "'";
            db1.getValues(sql);
            dgvStaff.DataSource = db1.DataTable("select * from tbNhanVien");
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            string sql = "delete tbNhanVien where maNV= '" +
                txtMaNV.Text + "'";
            db1.getValues(sql);
            dgvStaff.DataSource = db1.DataTable("select * from tbNhanVien");
        }
        

        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban muon thoat khong?","Chu y",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            Login login = new Login();
        }
        private void dgvStaff_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvStaff.CurrentRow != null)
            {
                txtMaNV.Text = dgvStaff.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dgvStaff.CurrentRow.Cells[1].Value.ToString();
                txtNamSinh.Text = dgvStaff.CurrentRow.Cells[2].Value.ToString();
                txtNgayLam.Text = dgvStaff.CurrentRow.Cells[3].Value.ToString();
                txtLuongCB.Text = dgvStaff.CurrentRow.Cells[4].Value.ToString();
                cbCaLam.Text = dgvStaff.CurrentRow.Cells[5].Value.ToString();

            }

        }

       
    }
}
