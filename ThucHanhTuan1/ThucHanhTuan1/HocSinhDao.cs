using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThucHanhTuan1
{
    public class HocSinhDao : ConNguoiDao
    {
        public HocSinhDao()
        {
            tableName = "HocSinh";
        }
    }
}
