using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAnNhom
{
    class LopKetNoi
    {

        SqlConnection conn = null;
        private void MoKetnoi()
        {
            string sqlCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\odink\OneDrive\Desktop\doanfinal\CS464C_Nhom1\DoAnNhom\DoAnNhom\Database.mdf;Integrated Security=True";
            conn = new SqlConnection(sqlCon);
            conn.Open();
        }

        private void DongKetnoi()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable Laydulieu(string sql)
        {
            DataTable dt = new DataTable();
            MoKetnoi();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                DongKetnoi();
            }
            return dt;
        }

        public int CapNhat(string sql)
        {
            int ketqua = 0;
            try
            {
                MoKetnoi();
                SqlCommand cmd = new SqlCommand(sql, conn);
                ketqua = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Lổi Cập Nhật : " + ex.Message);
            }
            finally
            {
                DongKetnoi();
            }
            return ketqua;
        }
    }
}
