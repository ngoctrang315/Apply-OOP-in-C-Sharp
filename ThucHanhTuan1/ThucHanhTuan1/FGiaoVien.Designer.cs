namespace ThucHanhTuan1
{
    partial class FGiaoVien
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGV = new Button();
            ucThongTin1 = new UCThongTin();
            SuspendLayout();
            // 
            // btnGV
            // 
            btnGV.Location = new Point(130, 388);
            btnGV.Name = "btnGV";
            btnGV.Size = new Size(102, 46);
            btnGV.TabIndex = 27;
            btnGV.Text = "Hoc Sinh";
            btnGV.UseVisualStyleBackColor = true;
            // 
            // ucThongTin1
            // 
            ucThongTin1.Location = new Point(2, -3);
            ucThongTin1.Name = "ucThongTin1";
            ucThongTin1.Size = new Size(1038, 372);
            ucThongTin1.TabIndex = 28;
            // 
            // FGiaoVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 446);
            Controls.Add(ucThongTin1);
            Controls.Add(btnGV);
            Name = "FGiaoVien";
            Text = "FGiaoVien";
            Load += FGiaoVien_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGV;
        private UCThongTin ucThongTin1;
    }
}