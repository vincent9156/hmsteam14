namespace GUI
{
    partial class ucNhomnguoidung
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.grdNhomNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridNhomNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTennhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chklstTinhnang = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMota = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnKhongLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaomoi = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaNhom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkTrangthai = new DevExpress.XtraEditors.CheckEdit();
            this.txtTenNhom = new DevExpress.XtraEditors.TextEdit();
            this.lblTrangthai = new DevExpress.XtraEditors.LabelControl();
            this.lblTennhom = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhomNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chklstTinhnang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangthai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(884, 54);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.labelControl2.Location = new System.Drawing.Point(466, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(325, 33);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Quản Lý Nhóm Nhân Viên";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.grdNhomNhanVien);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 304);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(884, 258);
            this.panelControl3.TabIndex = 2;
            // 
            // grdNhomNhanVien
            // 
            this.grdNhomNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode1.RelationName = "Level1";
            this.grdNhomNhanVien.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdNhomNhanVien.Location = new System.Drawing.Point(2, -4);
            this.grdNhomNhanVien.MainView = this.gridNhomNhanVien;
            this.grdNhomNhanVien.Name = "grdNhomNhanVien";
            this.grdNhomNhanVien.Size = new System.Drawing.Size(880, 260);
            this.grdNhomNhanVien.TabIndex = 27;
            this.grdNhomNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridNhomNhanVien});
            // 
            // gridNhomNhanVien
            // 
            this.gridNhomNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhom,
            this.colTennhom,
            this.colMota,
            this.colTrangThai});
            this.gridNhomNhanVien.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridNhomNhanVien.GridControl = this.grdNhomNhanVien;
            this.gridNhomNhanVien.Name = "gridNhomNhanVien";
            this.gridNhomNhanVien.OptionsFind.AlwaysVisible = true;
            this.gridNhomNhanVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridNhomNhanVien.OptionsView.ShowGroupPanel = false;
            this.gridNhomNhanVien.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridNhomNguoiDung_RowClick);
            this.gridNhomNhanVien.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridNhomNhanVien_FocusedRowChanged);
            // 
            // colMaNhom
            // 
            this.colMaNhom.Caption = "Mã Nhóm";
            this.colMaNhom.FieldName = "MANHOMNHANVIEN";
            this.colMaNhom.Name = "colMaNhom";
            this.colMaNhom.OptionsColumn.AllowEdit = false;
            this.colMaNhom.Visible = true;
            this.colMaNhom.VisibleIndex = 0;
            this.colMaNhom.Width = 79;
            // 
            // colTennhom
            // 
            this.colTennhom.Caption = "Tên Nhóm";
            this.colTennhom.FieldName = "TENNHOMNHANVIEN";
            this.colTennhom.Name = "colTennhom";
            this.colTennhom.OptionsColumn.AllowEdit = false;
            this.colTennhom.Visible = true;
            this.colTennhom.VisibleIndex = 1;
            // 
            // colMota
            // 
            this.colMota.Caption = "Mô tả";
            this.colMota.FieldName = "MOTA";
            this.colMota.Name = "colMota";
            this.colMota.OptionsColumn.AllowEdit = false;
            this.colMota.Visible = true;
            this.colMota.VisibleIndex = 2;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng Thái";
            this.colTrangThai.FieldName = "TRANGTHAI";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.OptionsColumn.AllowEdit = false;
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 3;
            this.colTrangThai.Width = 105;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 54);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(884, 250);
            this.panelControl2.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chklstTinhnang);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtMota);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnKhongLuu);
            this.groupControl1.Controls.Add(this.btnTaomoi);
            this.groupControl1.Controls.Add(this.txtMaNhom);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.chkTrangthai);
            this.groupControl1.Controls.Add(this.txtTenNhom);
            this.groupControl1.Controls.Add(this.lblTrangthai);
            this.groupControl1.Controls.Add(this.lblTennhom);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(880, 246);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin nhóm nhân viên";
            // 
            // chklstTinhnang1
            // 
            this.chklstTinhnang.CheckOnClick = true;
            this.chklstTinhnang.Location = new System.Drawing.Point(652, 50);
            this.chklstTinhnang.Name = "chklstTinhnang1";
            this.chklstTinhnang.Size = new System.Drawing.Size(223, 143);
            this.chklstTinhnang.TabIndex = 91;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.labelControl4.Location = new System.Drawing.Point(593, 50);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 13);
            this.labelControl4.TabIndex = 90;
            this.labelControl4.Text = "Chức năng";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(186, 124);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(308, 69);
            this.txtMota.TabIndex = 89;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.labelControl3.Location = new System.Drawing.Point(115, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 88;
            this.labelControl3.Text = "Mô tả";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.Location = new System.Drawing.Point(702, 212);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 25);
            this.btnLuu.TabIndex = 85;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.Location = new System.Drawing.Point(628, 212);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 25);
            this.btnSua.TabIndex = 87;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhongLuu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnKhongLuu.Appearance.Options.UseForeColor = true;
            this.btnKhongLuu.Location = new System.Drawing.Point(776, 212);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(68, 25);
            this.btnKhongLuu.TabIndex = 86;
            this.btnKhongLuu.Text = "Hủy";
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaomoi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnTaomoi.Appearance.Options.UseForeColor = true;
            this.btnTaomoi.Location = new System.Drawing.Point(554, 212);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(68, 25);
            this.btnTaomoi.TabIndex = 84;
            this.btnTaomoi.Text = "Tạo Mới";
            this.btnTaomoi.Click += new System.EventHandler(this.btnTaomoi_Click);
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Enabled = false;
            this.txtMaNhom.Location = new System.Drawing.Point(186, 47);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(308, 20);
            this.txtMaNhom.TabIndex = 57;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.labelControl1.Location = new System.Drawing.Point(115, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 64;
            this.labelControl1.Text = "Mã Nhóm";
            // 
            // chkTrangthai
            // 
            this.chkTrangthai.Location = new System.Drawing.Point(184, 99);
            this.chkTrangthai.Name = "chkTrangthai";
            this.chkTrangthai.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.chkTrangthai.Properties.Appearance.Options.UseForeColor = true;
            this.chkTrangthai.Properties.Caption = "Kích Hoạt";
            this.chkTrangthai.Size = new System.Drawing.Size(75, 19);
            this.chkTrangthai.TabIndex = 61;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(186, 73);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(308, 20);
            this.txtTenNhom.TabIndex = 58;
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblTrangthai.Location = new System.Drawing.Point(115, 102);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(49, 13);
            this.lblTrangthai.TabIndex = 60;
            this.lblTrangthai.Text = "Trạng thái";
            // 
            // lblTennhom
            // 
            this.lblTennhom.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblTennhom.Location = new System.Drawing.Point(115, 76);
            this.lblTennhom.Name = "lblTennhom";
            this.lblTennhom.Size = new System.Drawing.Size(47, 13);
            this.lblTennhom.TabIndex = 59;
            this.lblTennhom.Text = "Tên nhóm";
            // 
            // ucNhomnguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucNhomnguoidung";
            this.Size = new System.Drawing.Size(884, 562);
            this.Load += new System.EventHandler(this.ucNhomNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNhomNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNhomNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chklstTinhnang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangthai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtMaNhom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkTrangthai;
        private DevExpress.XtraEditors.TextEdit txtTenNhom;
        private DevExpress.XtraEditors.LabelControl lblTrangthai;
        private DevExpress.XtraEditors.LabelControl lblTennhom;
        private DevExpress.XtraEditors.SimpleButton btnTaomoi;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnKhongLuu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl grdNhomNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridNhomNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTennhom;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colMota;
        private DevExpress.XtraEditors.MemoEdit txtMota;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckedListBoxControl chklstTinhnang;
        private DevExpress.XtraEditors.LabelControl labelControl4;

    }
}
