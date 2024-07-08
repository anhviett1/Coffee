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
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }
        DBConnection conn = new DBConnection();
        private void Map_Load(object sender, EventArgs e)
        {
            tb_cokhach();
            loadmenu();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                gb6.Visible = false;
                gb3.Visible = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                gb3.Visible = false;
                gb6.Visible = true;
            }
        }
        private void btnban1n_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 1_N";
            string ban = "ban1n";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            conn.tinhthanhtien();
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban2n_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 2_N";
            string ban = "ban2n";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban3n_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 3_N";
            string ban = "ban3n";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban4n_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 4_N";
            string ban = "ban4n";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban5n_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 5_N";
            string ban = "ban5n";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban6n_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 6_N";
            string ban = "ban6n";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban7n_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 7_N";
            string ban = "ban7n";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban8n_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 8_N";
            string ban = "ban8n";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban9n_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 9_N";
            string ban = "ban9n";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban1s_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 1_S";
            string ban = "ban1s";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban2s_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 2_S";
            string ban = "ban2s";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban3s_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 3_S";
            string ban = "ban3s";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban4s_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 4_S";
            string ban = "ban4s";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban5s_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 5_S";
            string ban = "ban5s";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnban6s_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Bàn 6_S";
            string ban = "ban6s";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(sql);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnmangve_Click(object sender, EventArgs e)
        {
            lblbanchon.Text = "Mang về";
            string ban = "mangve";
            String sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
            dtgvhd.DataSource = conn.DataTable(ban);
            lbltongt.Text = conn.tong_t(ban);
            panelthem.Visible = false;
        }
        private void btnmon1_Click(object sender, EventArgs e)
        {
            panelthem.Visible = true;
            lblban.Text = kt_ban();
            lbltenmon.Text = btnmon1.Text;
            lblgia.Text = lblgiamon1.Text;
            txtmota.Text = "Không";
        }
        private void btnmon2_Click(object sender, EventArgs e)
        {
            panelthem.Visible = true;
            lblban.Text = kt_ban();
            lbltenmon.Text = btnmon2.Text;
            lblgia.Text = lblgiamon2.Text;
            txtmota.Text = "Không";
        }
        private void btnmon3_Click(object sender, EventArgs e)
        {
            panelthem.Visible = true;
            lblban.Text = kt_ban();
            lbltenmon.Text = btnmon3.Text;
            lblgia.Text = lblgiamon3.Text;
            txtmota.Text = "Không";
        }
        private void btnmon4_Click(object sender, EventArgs e)
        {
            panelthem.Visible = true;
            lblban.Text = kt_ban();
            lbltenmon.Text = btnmon4.Text;
            lblgia.Text = lblgiamon4.Text;
            txtmota.Text = "Không";
        }
        private void btnmon5_Click(object sender, EventArgs e)
        {
            panelthem.Visible = true;
            lblban.Text = kt_ban();
            lbltenmon.Text = btnmon5.Text;
            lblgia.Text = lblgiamon5.Text;
            txtmota.Text = "Không";
        }
        private void btnmon6_Click(object sender, EventArgs e)
        {
            panelthem.Visible = true;
            lblban.Text = kt_ban();
            lbltenmon.Text = btnmon6.Text;
            lblgia.Text = lblgiamon6.Text;
            txtmota.Text = "Không";
        }
        private void btnmon7_Click(object sender, EventArgs e)
        {
            panelthem.Visible = true;
            lblban.Text = kt_ban();
            lbltenmon.Text = btnmon7.Text;
            lblgia.Text = lblgiamon7.Text;
            txtmota.Text = "Không";
        }
        private void btnmon8_Click(object sender, EventArgs e)
        {
            panelthem.Visible = true;
            lblban.Text = kt_ban();
            lbltenmon.Text = btnmon8.Text;
            lblgia.Text = lblgiamon8.Text;
            txtmota.Text = "Không";
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            panelthem.Visible = false;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            String ban = lblban.Text;
            String monan = lbltenmon.Text;
            String gia = lblgia.Text;
            String soluong = nbsoluong.Text;
            String mota = txtmota.Text;
            String sql = "SELECT COUNT(*) FROM tb_dsmon WHERE LOWER(ban) = LOWER('" + ban + "') AND LOWER(monan) = LOWER('" + monan + "')";
            object k = null;
            k = conn.getValues1(sql);
            int i = int.Parse(k.ToString());
            if (i == 0)
            {
                sql = "INSERT INTO tb_dsmon (ban, monan, gia, soluong, mota) VALUES ('" + ban + "','" + monan + "','" + gia + "'," + soluong + ",'" + mota + "')";
                conn.getValues(sql);
                sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
                dtgvhd.DataSource = conn.DataTable(sql);
                tb_cokhach();
                lbltongt.Text = conn.tong_t(ban);
                panelthem.Visible = false;
                nbsoluong.Text = "0";
            }
            else
            {
                sql = "SELECT soluong FROM tb_dsmon WHERE LOWER(ban) = LOWER('" + ban + "') AND LOWER(monan) = LOWER('" + monan + "')";
                k = conn.getValues1(sql);
                i = int.Parse(k.ToString());
                int j = int.Parse(soluong.ToString());
                int sl = i + j;
                sql = "UPDATE tb_dsmon SET soluong = " + sl + " WHERE LOWER(ban) = LOWER('" + ban + "') AND LOWER(monan) = LOWER('" + monan + "')";
                conn.getValues(sql);
                sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
                dtgvhd.DataSource = conn.DataTable(sql);
                lbltongt.Text = conn.tong_t(ban);
                panelthem.Visible = false;
                nbsoluong.Text = "0";
            }
        }
        private void btnhd_Click(object sender, EventArgs e)
        {
            if (lblbanchon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn :", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Xác nhận thanh toán ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    String ban = kt_ban();
                    String sql = "Delete From tb_dsmon Where LOWER(ban) = LOWER('" + ban + "')";
                    conn.getValues(sql);
                    sql = "select monan, gia, soluong, thanhtien, mota from tb_dsmon where ban = '" + ban + "'";
                    dtgvhd.DataSource = conn.DataTable(sql);
                    tb_cokhach();
                }
            }
        }
        public void tb_cokhach()
        {
            for (int i = 1; i <= 9; i++)
            {
                string sql = "SELECT COUNT(*) FROM tb_dsmon where ban ='ban" + i + "n'";
                int count = (int)conn.getValues1(sql);
                if (count > 0)
                    switch (i)
                    {
                        case 1: btnban1n.BackColor = Color.Yellow; break;
                        case 2: btnban2n.BackColor = Color.Yellow; break;
                        case 3: btnban3n.BackColor = Color.Yellow; break;
                        case 4: btnban4n.BackColor = Color.Yellow; break;
                        case 5: btnban5n.BackColor = Color.Yellow; break;
                        case 6: btnban6n.BackColor = Color.Yellow; break;
                        case 7: btnban7n.BackColor = Color.Yellow; break;
                        case 8: btnban8n.BackColor = Color.Yellow; break;
                        case 9: btnban9n.BackColor = Color.Yellow; break;
                        default: break;
                    }
                else switch (i)
                    {
                        case 1: btnban1n.BackColor = Color.White; break;
                        case 2: btnban2n.BackColor = Color.White; break;
                        case 3: btnban3n.BackColor = Color.White; break;
                        case 4: btnban4n.BackColor = Color.White; break;
                        case 5: btnban5n.BackColor = Color.White; break;
                        case 6: btnban6n.BackColor = Color.White; break;
                        case 7: btnban7n.BackColor = Color.White; break;
                        case 8: btnban8n.BackColor = Color.White; break;
                        case 9: btnban9n.BackColor = Color.White; break;
                        default: break;
                    }
            }
            for (int i = 1; i <= 6; i++)
            {
                string sql = "SELECT COUNT(*) FROM tb_dsmon where ban ='ban" + i + "s'";
                int count = (int)conn.getValues1(sql);
                if (count > 0)
                    switch (i)
                    {
                        case 1: btnban1s.BackColor = Color.Yellow; break;
                        case 2: btnban2s.BackColor = Color.Yellow; break;
                        case 3: btnban3s.BackColor = Color.Yellow; break;
                        case 4: btnban4s.BackColor = Color.Yellow; break;
                        case 5: btnban5s.BackColor = Color.Yellow; break;
                        case 6: btnban6s.BackColor = Color.Yellow; break;
                        default: break;
                    }
                else switch (i)
                    {
                        case 1: btnban1s.BackColor = Color.White; break;
                        case 2: btnban2s.BackColor = Color.White; break;
                        case 3: btnban3s.BackColor = Color.White; break;
                        case 4: btnban4s.BackColor = Color.White; break;
                        case 5: btnban5s.BackColor = Color.White; break;
                        case 6: btnban6s.BackColor = Color.White; break;
                        default: break;
                    }
            }
        }
        public String kt_ban()
        {
            String ban = "";
            if (lblbanchon.Text == btnban1n.Text) ban = "ban1n";
            if (lblbanchon.Text == btnban2n.Text) ban = "ban2n";
            if (lblbanchon.Text == btnban3n.Text) ban = "ban3n";
            if (lblbanchon.Text == btnban4n.Text) ban = "ban4n";
            if (lblbanchon.Text == btnban5n.Text) ban = "ban5n";
            if (lblbanchon.Text == btnban6n.Text) ban = "ban6n";
            if (lblbanchon.Text == btnban7n.Text) ban = "ban7n";
            if (lblbanchon.Text == btnban8n.Text) ban = "ban8n";
            if (lblbanchon.Text == btnban9n.Text) ban = "ban9n";
            if (lblbanchon.Text == btnban1s.Text) ban = "ban1s";
            if (lblbanchon.Text == btnban2s.Text) ban = "ban2s";
            if (lblbanchon.Text == btnban3s.Text) ban = "ban3s";
            if (lblbanchon.Text == btnban4s.Text) ban = "ban4s";
            if (lblbanchon.Text == btnban5s.Text) ban = "ban5s";
            if (lblbanchon.Text == btnban6s.Text) ban = "ban6s";
            if (lblbanchon.Text == btnmangve.Text) ban = "mangve";
            return ban;
        }
        public void loadmenu()
        {
            String sql = "SELECT COUNT(*) FROM tb_menu";
            object k = conn.getValues1(sql);
            int count = int.Parse(k.ToString());
            for (int i = 1; i <= count; i++)
            {
                sql = "SELECT monan FROM tb_menu where stt = " + i;
                k = conn.getValues1(sql);
                String ten = k.ToString();
                String sql1 = "SELECT gia FROM tb_menu where stt = " + i;
                Object k1 = conn.getValues1(sql1);
                String ten1 = k1.ToString();
                var panel = this.Controls.Find($"pnmon{i}", true).FirstOrDefault() as Panel;
                if (panel != null)
                {
                    panel.Visible = true;
                }
                var button = this.Controls.Find($"btnmon{i}", true).FirstOrDefault() as Button;
                if (button != null)
                {
                    button.Text = ten;
                }
                var label = this.Controls.Find($"lblgiamon{i}", true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Text = ten1;
                }
            }
        }
        private void txtkhachtra_TextChanged(object sender, EventArgs e)
        {
            int x = int.Parse(txtkhachtra.Text);
            int y = int.Parse(lbltongt.Text);
            lbltienthua.Text = (x - y).ToString();
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void nbsoluong_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
