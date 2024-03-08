using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhTuan1
{
    public partial class FGiaoVien : Form
    {
        GiaoVienDAO GiaoVienDAO = new GiaoVienDAO();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FGiaoVien()
        {
            InitializeComponent();
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            ucThongTin1.gvHS.DataSource = GiaoVienDAO.Load();
            ucThongTin1.btnThem.Click += btnThem_Click;
            ucThongTin1.btnXoa.Click += btnXoa_Click;
            ucThongTin1.btnSua.Click += btnSua_Click;
        }

        private void Refreshdata()
        {
            ucThongTin1.gvHS.DataSource = GiaoVienDAO.Load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(ucThongTin1.txtId.Text, ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text, ucThongTin1.txtAddress.Text, ucThongTin1.txtCMND.Text, ucThongTin1.dtpDob.Value, ucThongTin1.txtPhone.Text, ucThongTin1.txtEmail.Text);
            GiaoVienDAO.Them(gv);
            Refreshdata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(ucThongTin1.txtId.Text, ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text, ucThongTin1.txtAddress.Text, ucThongTin1.txtCMND.Text, ucThongTin1.dtpDob.Value, ucThongTin1.txtPhone.Text, ucThongTin1.txtEmail.Text);
            GiaoVienDAO.Xoa(gv);
            Refreshdata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(ucThongTin1.txtId.Text, ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text, ucThongTin1.txtAddress.Text, ucThongTin1.txtCMND.Text, ucThongTin1.dtpDob.Value, ucThongTin1.txtPhone.Text, ucThongTin1.txtEmail.Text);
            GiaoVienDAO.Sua(gv);
            Refreshdata();
        }
        private void ucThongTin1_Load(object sender, EventArgs e)
        {
        }
    }
}
