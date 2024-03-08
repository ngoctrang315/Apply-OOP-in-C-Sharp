using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhTuan1
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void ThucThi(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thành công !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại !" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable HienThi(string sql)
        {
            try
            {
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
                DataTable DSHocSinh = new DataTable();
                sqlDataAdapter.Fill(DSHocSinh);
                return DSHocSinh;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
