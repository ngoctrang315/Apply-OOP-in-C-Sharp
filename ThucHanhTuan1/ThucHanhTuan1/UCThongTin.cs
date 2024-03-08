using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhTuan1
{
    public partial class UCThongTin : UserControl
    {
        public UCThongTin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gvHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = gvHS.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtGioiTinh.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtCMND.Text = row.Cells[4].Value.ToString();
                dtpDob.Text = row.Cells[5].Value.ToString();
                txtPhone.Text = row.Cells[6].Value.ToString();
                txtEmail.Text = row.Cells[7].Value.ToString();
            }
        }

        private void UCThongTin_Load(object sender, EventArgs e)
        {

        }
    }
}
