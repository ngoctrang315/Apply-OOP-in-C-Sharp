using System.Data;
using System.Data.SqlClient;


namespace ThucHanhTuan1
{
    public partial class FHocSinh : Form
    {

        HocSinhDao HocSinhDao = new HocSinhDao();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FHocSinh()
        {
            InitializeComponent();
        }

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            ucThongTin1.gvHS.DataSource = HocSinhDao.Load();
            ucThongTin1.btnThem.Click += btnThem_Click;
            ucThongTin1.btnXoa.Click += btnXoa_Click;
            ucThongTin1.btnSua.Click += btnSua_Click;
        }

        private void Refreshdata()
        {
            ucThongTin1.gvHS.DataSource = HocSinhDao.Load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh( ucThongTin1.txtId.Text, ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text,
                ucThongTin1.txtAddress.Text, ucThongTin1.txtCMND.Text, ucThongTin1.dtpDob.Value, ucThongTin1.txtPhone.Text, ucThongTin1.txtEmail.Text);
            HocSinhDao.Them(hs);
            Refreshdata();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(ucThongTin1.txtId.Text, ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text,
                ucThongTin1.txtAddress.Text, ucThongTin1.txtCMND.Text, ucThongTin1.dtpDob.Value, ucThongTin1.txtPhone.Text, ucThongTin1.txtEmail.Text);
            HocSinhDao.Xoa(hs);
            Refreshdata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(ucThongTin1.txtId.Text, ucThongTin1.txtName.Text, ucThongTin1.txtGioiTinh.Text, 
                ucThongTin1.txtAddress.Text, ucThongTin1.txtCMND.Text, ucThongTin1.dtpDob.Value, ucThongTin1.txtPhone.Text, ucThongTin1.txtEmail.Text);
            HocSinhDao.Sua(hs);
            Refreshdata();
        }

        private void btnGV_Click(object sender, EventArgs e)
        {
            FGiaoVien dlg2 = new FGiaoVien();
            dlg2.ShowDialog();
        }
    }
}
