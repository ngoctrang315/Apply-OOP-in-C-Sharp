using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanhTuan1
{
    public class ConNguoi
    {
        private string id;
        private string name;
        private string gioitinh;
        private string diachi;
        private string cmnd;
        private DateTime dob;
        private string phone;
        private string email;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Phương thức khởi tạo mặc định
        public ConNguoi()
        {
        }

        public ConNguoi(string id, string name, string gioitinh, string diachi, string cmnd, DateTime dob, string phone, string email)
        {
            this.Id = id;
            this.name = name;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.cmnd = cmnd;
            this.dob = dob;
            this.Phone = phone;
            this.Email = email;
        }

        public ConNguoi(string id)
        {
            this.id = id;
        }
    }
}
