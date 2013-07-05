namespace GUI
{
    partial class frmNhombenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhombenh));
            this.txtMota = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaNhom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenNhom = new DevExpress.XtraEditors.TextEdit();
            this.lblTennhom = new DevExpress.XtraEditors.LabelControl();
            this.lblTieude = new DevExpress.XtraEditors.LabelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(149, 158);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(308, 96);
            this.txtMota.TabIndex = 71;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.labelControl2.Location = new System.Drawing.Point(78, 158);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 69;
            this.labelControl2.Text = "-Mô tả";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(149, 87);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(308, 20);
            this.txtMaNhom.TabIndex = 61;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.labelControl1.Location = new System.Drawing.Point(78, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 70;
            this.labelControl1.Text = "-Mã Nhóm";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnHuy.Appearance.Options.UseForeColor = true;
            this.btnHuy.Location = new System.Drawing.Point(267, 296);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 68;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.Location = new System.Drawing.Point(186, 296);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 67;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(149, 120);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(308, 20);
            this.txtTenNhom.TabIndex = 63;
            // 
            // lblTennhom
            // 
            this.lblTennhom.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblTennhom.Location = new System.Drawing.Point(78, 124);
            this.lblTennhom.Name = "lblTennhom";
            this.lblTennhom.Size = new System.Drawing.Size(51, 13);
            this.lblTennhom.TabIndex = 64;
            this.lblTennhom.Text = "-Tên nhóm";
            // 
            // lblTieude
            // 
            this.lblTieude.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblTieude.Location = new System.Drawing.Point(194, 26);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(188, 28);
            this.lblTieude.TabIndex = 62;
            this.lblTieude.Text = " Thêm Nhóm Bệnh";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnThoat.Appearance.Options.UseForeColor = true;
            this.btnThoat.Location = new System.Drawing.Point(348, 296);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 72;
            this.btnThoat.Text = "&Thoát";
            // 
            // frmNhombenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 345);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.lblTennhom);
            this.Controls.Add(this.lblTieude);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhombenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNhombenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtMota;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtMaNhom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.TextEdit txtTenNhom;
        private DevExpress.XtraEditors.LabelControl lblTennhom;
        private DevExpress.XtraEditors.LabelControl lblTieude;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}