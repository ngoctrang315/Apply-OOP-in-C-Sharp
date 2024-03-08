using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThucHanhTuan1
{
    public class ConNguoiDao
    {
        protected DBConnection dbc = new DBConnection();
        protected string tableName;

        public DataTable Load()
        {
            return dbc.HienThi($"SELECT * FROM {tableName}");
        }

        public bool KiemTraNull(ConNguoi cn)
        {
            return !string.IsNullOrWhiteSpace(cn.Name) && !string.IsNullOrWhiteSpace(cn.GioiTinh) &&
                   !string.IsNullOrWhiteSpace(cn.Diachi) && !string.IsNullOrWhiteSpace(cn.Cmnd) &&
                   cn.Dob != default(DateTime) && !string.IsNullOrWhiteSpace(cn.Phone) &&
                   !string.IsNullOrWhiteSpace(cn.Email);
        }

        private bool KiemTraTuoi(DateTime dob)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - dob.Year;
            if (now.Month < dob.Month || (now.Month == dob.Month && now.Day < dob.Day))
            {
                age--;
            }
            return age < 17;
        }

        private bool KiemTraEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool KiemTrasdt(string phone)
        {
            return Regex.IsMatch(phone, @"^[0-9]{10}$");
        }

        public void Them(ConNguoi cn)
        {
            if (!KiemTraNull(cn))
            {
                MessageBox.Show("Không được để trống thông tin.");
                return;
            }

            // Kiểm tra tuổi
            if (KiemTraTuoi(cn.Dob))
            {
                MessageBox.Show("Chưa Đủ 17 tuổi");
                return;
            }

            // Kiểm tra email
            if (!KiemTraEmail(cn.Email))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ");
                return;
            }

            // Kiểm tra số điện thoại
            if (!KiemTrasdt(cn.Phone))
            {
                MessageBox.Show("Số điện thoại  xxx-xxxx-xxx mới hợp lệ");
                return;
            }
            else
            {
                string sqlStr = string.Format("INSERT INTO {0}(Id, Ten, GioiTinh, DiaChi, CMND, NgayThangNamSinh, Phone, Email)" +
                    " VALUES ('{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                                                tableName, cn.Id, cn.Name, cn.GioiTinh, cn.Diachi, cn.Cmnd, cn.Dob.Date, cn.Phone, cn.Email);
                dbc.ThucThi(sqlStr);
            }
        }


        public void Xoa(ConNguoi cn)
        {
            string sqlStr = string.Format("DELETE FROM {0} WHERE Id = '{1}'", tableName, cn.Id);
            dbc.ThucThi(sqlStr);
        }

        public void Sua(ConNguoi cn)
        {
            string sqlStr = string.Format("UPDATE {0} SET Ten = '{1}', GioiTinh = '{2}', DiaChi = '{3}', CMND = '{4}'," +
                " NgayThangNamSinh = '{5}', Phone = '{6}', Email = '{7}' WHERE Id = {8}",
                                          tableName, cn.Name, cn.GioiTinh, cn.Diachi, cn.Cmnd, cn.Dob.Date, cn.Phone, cn.Email, cn.Id);
            dbc.ThucThi(sqlStr);
        }
    }
}
