using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Btl_QLCF
{
    class DBConnection
    {
        private string db = @"Data Source=.\sqlexpress04;Initial Catalog=Btl_QLCF;Integrated Security=True;Encrypt=False";
        
        public DataTable DataTable(string sql)
        {
            SqlConnection conn = new SqlConnection(db);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            conn.Close();
            return dt;

        }
        public string getValues(string sql)
        {           
            SqlConnection con = new SqlConnection(db);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose(); 
            return cmd.CommandText;
        }



        public object getValues1(string sql)
        {
            SqlConnection con = new SqlConnection(db);
            con.Open();
            object k = null;
            SqlCommand cmd = new SqlCommand(sql, con);
            k = cmd.ExecuteScalar();
            con.Close();
            cmd.Dispose();
            return k;

        }
        public string tinhthanhtien()
        {
            string sql = "UPDATE tb_dsmon SET thanhtien = gia * soluong";
            SqlConnection con = new SqlConnection(db);
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteScalar();
            return cmd.CommandText;

        }
        public String tong_t(String ban)
        {
            String tt = "0";
            string sql = "select sum(thanhtien)  from tb_dsmon where ban = '" + ban + "'";
            if (getValues1(sql).ToString() != null)
            {
                tt = getValues1(sql).ToString();
                return tt;
            }
            else return "0";
        }





    }
}
