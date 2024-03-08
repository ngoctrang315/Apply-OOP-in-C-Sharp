using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhTuan1
{
    public class GiaoVienDAO : ConNguoiDao
    {
        public GiaoVienDAO()
        {
            tableName = "GiaoVien";
        }
    }
}
