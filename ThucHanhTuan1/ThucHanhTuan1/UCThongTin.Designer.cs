namespace ThucHanhTuan1
{
    partial class UCThongTin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtGioiTinh = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            dtpDob = new DateTimePicker();
            txtCMND = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            lblDoB = new Label();
            lblCMND = new Label();
            lblAdress = new Label();
            lblName = new Label();
            gvHS = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvHS).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtGioiTinh);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dtpDob);
            panel1.Controls.Add(txtCMND);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblDoB);
            panel1.Controls.Add(lblCMND);
            panel1.Controls.Add(lblAdress);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(17, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 356);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 254);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 23);
            txtEmail.TabIndex = 36;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(116, 225);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(193, 23);
            txtPhone.TabIndex = 35;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(116, 84);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(193, 23);
            txtGioiTinh.TabIndex = 34;
            // 
            // txtId
            // 
            txtId.Location = new Point(118, 13);
            txtId.Name = "txtId";
            txtId.Size = new Size(193, 23);
            txtId.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 252);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 32;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 223);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 31;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 30;
            label2.Text = "Gioi Tinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 19);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 29;
            label1.Text = "ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Location = new Point(3, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 46);
            panel2.TabIndex = 28;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(7, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 8;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(100, 12);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(195, 12);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(116, 189);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(193, 23);
            dtpDob.TabIndex = 20;
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(116, 148);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(193, 23);
            txtCMND.TabIndex = 25;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(118, 113);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(193, 23);
            txtAddress.TabIndex = 26;
            // 
            // txtName
            // 
            txtName.Location = new Point(118, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 23);
            txtName.TabIndex = 19;
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Location = new Point(1, 190);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(117, 15);
            lblDoB.TabIndex = 18;
            lblDoB.Text = "NgayThangNamSinh";
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Location = new Point(1, 151);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(43, 15);
            lblCMND.TabIndex = 17;
            lblCMND.Text = "CMND";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Location = new Point(3, 111);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(42, 15);
            lblAdress.TabIndex = 16;
            lblAdress.Text = "DiaChi";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 55);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 15;
            lblName.Text = "Ho ten";
            // 
            // gvHS
            // 
            gvHS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvHS.Location = new Point(360, 14);
            gvHS.Name = "gvHS";
            gvHS.Size = new Size(672, 370);
            gvHS.TabIndex = 27;
            gvHS.CellClick += gvHS_CellClick;
            // 
            // UCThongTin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(gvHS);
            Name = "UCThongTin";
            Size = new Size(1044, 400);
            Load += UCThongTin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvHS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDoB;
        private Label lblCMND;
        private Label lblAdress;
        private Label lblName;
        public DataGridView gvHS;
        public TextBox txtCMND;
        public TextBox txtAddress;
        public TextBox txtName;
        public DateTimePicker dtpDob;
        private Panel panel2;
        public Button btnThem;
        public Button btnXoa;
        public Button btnSua;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtEmail;
        public TextBox txtPhone;
        public TextBox txtGioiTinh;
        public TextBox txtId;
    }
}
