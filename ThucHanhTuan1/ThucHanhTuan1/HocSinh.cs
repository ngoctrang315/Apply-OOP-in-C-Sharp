using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhTuan1
{
    public class HocSinh: ConNguoi
    {
        public HocSinh(string id, string name, string gioitinh, string diachi, string cmnd, DateTime dob, string phone, string email) : base(id,name,gioitinh,  diachi, cmnd, dob, phone, email)
        {
        }

        public HocSinh(string id) : base(id)
        {
        }
        public HocSinh() { }
    }
}
