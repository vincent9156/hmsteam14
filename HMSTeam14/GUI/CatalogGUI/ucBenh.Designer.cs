namespace GUI
{
    partial class ucBenh
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
            this.grdBenh = new DevExpress.XtraGrid.GridControl();
            this.gridBenh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMabenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenbenhtv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenbenhta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaytao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangthai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnDanhmucphongkham = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenthuocTA = new DevExpress.XtraEditors.TextEdit();
            this.lblTenbenhTA = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnNhombenh = new DevExpress.XtraEditors.SimpleButton();
            this.btnKhongLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnTaomoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.chkTrangThai = new DevExpress.XtraEditors.CheckEdit();
            this.lblMota = new DevExpress.XtraEditors.LabelControl();
            this.lblTrangthai = new DevExpress.XtraEditors.LabelControl();
            this.txtMabenh = new DevExpress.XtraEditors.TextEdit();
            this.txtTenthuocTV = new DevExpress.XtraEditors.TextEdit();
            this.lblTenBenhTV = new DevExpress.XtraEditors.LabelControl();
            this.lblMaBenh = new DevExpress.XtraEditors.LabelControl();
            this.cbmNhombenh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtMota = new DevExpress.XtraEditors.MemoEdit();
            this.pnTimkiemDanhmucphongkham = new DevExpress.XtraEditors.PanelControl();
            this.lblDanhmucbenh = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBenh)).BeginInit();
            this.pnDanhmucphongkham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenthuocTA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMabenh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenthuocTV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbmNhombenh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTimkiemDanhmucphongkham)).BeginInit();
            this.pnTimkiemDanhmucphongkham.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdBenh
            // 
            this.grdBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBenh.Location = new System.Drawing.Point(0, 57);
            this.grdBenh.MainView = this.gridBenh;
            this.grdBenh.Name = "grdBenh";
            this.grdBenh.Size = new System.Drawing.Size(1264, 332);
            this.grdBenh.TabIndex = 44;
            this.grdBenh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBenh});
            // 
            // gridBenh
            // 
            this.gridBenh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMabenh,
            this.colTenbenhtv,
            this.colTenbenhta,
            this.colNgaytao,
            this.colTrangthai});
            this.gridBenh.GridControl = this.grdBenh;
            this.gridBenh.Name = "gridBenh";
            this.gridBenh.OptionsFind.AlwaysVisible = true;
            this.gridBenh.OptionsView.ShowGroupPanel = false;
            // 
            // colMabenh
            // 
            this.colMabenh.Caption = "Mã Bệnh";
            this.colMabenh.Name = "colMabenh";
            this.colMabenh.Visible = true;
            this.colMabenh.VisibleIndex = 0;
            // 
            // colTenbenhtv
            // 
            this.colTenbenhtv.Caption = "Tên Bệnh Tiếng Việt";
            this.colTenbenhtv.Name = "colTenbenhtv";
            this.colTenbenhtv.Visible = true;
            this.colTenbenhtv.VisibleIndex = 1;
            // 
            // colTenbenhta
            // 
            this.colTenbenhta.Caption = "Tên Bệnh Tiếng Anh";
            this.colTenbenhta.Name = "colTenbenhta";
            this.colTenbenhta.Visible = true;
            this.colTenbenhta.VisibleIndex = 2;
            // 
            // colNgaytao
            // 
            this.colNgaytao.Caption = "Ngày Tạo";
            this.colNgaytao.FieldName = "colNgaytao";
            this.colNgaytao.Name = "colNgaytao";
            this.colNgaytao.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.colNgaytao.Visible = true;
            this.colNgaytao.VisibleIndex = 3;
            // 
            // colTrangthai
            // 
            this.colTrangthai.Caption = "Trạng Thái";
            this.colTrangthai.FieldName = "colTrangthai";
            this.colTrangthai.Name = "colTrangthai";
            this.colTrangthai.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colTrangthai.Visible = true;
            this.colTrangthai.VisibleIndex = 4;
            // 
            // pnDanhmucphongkham
            // 
            this.pnDanhmucphongkham.Controls.Add(this.labelControl1);
            this.pnDanhmucphongkham.Controls.Add(this.txtTenthuocTA);
            this.pnDanhmucphongkham.Controls.Add(this.lblTenbenhTA);
            this.pnDanhmucphongkham.Controls.Add(this.panelControl1);
            this.pnDanhmucphongkham.Controls.Add(this.chkTrangThai);
            this.pnDanhmucphongkham.Controls.Add(this.lblMota);
            this.pnDanhmucphongkham.Controls.Add(this.lblTrangthai);
            this.pnDanhmucphongkham.Controls.Add(this.txtMabenh);
            this.pnDanhmucphongkham.Controls.Add(this.txtTenthuocTV);
            this.pnDanhmucphongkham.Controls.Add(this.lblTenBenhTV);
            this.pnDanhmucphongkham.Controls.Add(this.lblMaBenh);
            this.pnDanhmucphongkham.Controls.Add(this.cbmNhombenh);
            this.pnDanhmucphongkham.Controls.Add(this.txtMota);
            this.pnDanhmucphongkham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDanhmucphongkham.Location = new System.Drawing.Point(0, 389);
            this.pnDanhmucphongkham.Name = "pnDanhmucphongkham";
            this.pnDanhmucphongkham.Size = new System.Drawing.Size(1264, 153);
            this.pnDanhmucphongkham.TabIndex = 43;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.labelControl1.Location = new System.Drawing.Point(158, 77);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Nhóm bệnh";
            // 
            // txtTenthuocTA
            // 
            this.txtTenthuocTA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenthuocTA.Location = new System.Drawing.Point(488, 70);
            this.txtTenthuocTA.Name = "txtTenthuocTA";
            this.txtTenthuocTA.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.txtTenthuocTA.Properties.Appearance.Options.UseForeColor = true;
            this.txtTenthuocTA.Size = new System.Drawing.Size(248, 20);
            this.txtTenthuocTA.TabIndex = 39;
            // 
            // lblTenbenhTA
            // 
            this.lblTenbenhTA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenbenhTA.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblTenbenhTA.Location = new System.Drawing.Point(371, 74);
            this.lblTenbenhTA.Name = "lblTenbenhTA";
            this.lblTenbenhTA.Size = new System.Drawing.Size(96, 13);
            this.lblTenbenhTA.TabIndex = 38;
            this.lblTenbenhTA.Text = "Tên Bệnh Tiếng Anh";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnNhombenh);
            this.panelControl1.Controls.Add(this.btnKhongLuu);
            this.panelControl1.Controls.Add(this.btnSua);
            this.panelControl1.Controls.Add(this.btnTaomoi);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 123);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1264, 30);
            this.panelControl1.TabIndex = 37;
            // 
            // btnNhombenh
            // 
            this.btnNhombenh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhombenh.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnNhombenh.Appearance.Options.UseForeColor = true;
            this.btnNhombenh.Location = new System.Drawing.Point(499, 4);
            this.btnNhombenh.Name = "btnNhombenh";
            this.btnNhombenh.Size = new System.Drawing.Size(115, 23);
            this.btnNhombenh.TabIndex = 25;
            this.btnNhombenh.Text = "&Tạo nhóm bệnh";
            this.btnNhombenh.Click += new System.EventHandler(this.btnNhombenh_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhongLuu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnKhongLuu.Appearance.Options.UseForeColor = true;
            this.btnKhongLuu.Location = new System.Drawing.Point(877, 4);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(75, 23);
            this.btnKhongLuu.TabIndex = 24;
            this.btnKhongLuu.Text = "&Hủy bỏ";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnSua.Appearance.Options.UseForeColor = true;
            this.btnSua.Location = new System.Drawing.Point(706, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "&Sửa";
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaomoi.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnTaomoi.Appearance.Options.UseForeColor = true;
            this.btnTaomoi.Location = new System.Drawing.Point(622, 5);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaomoi.TabIndex = 20;
            this.btnTaomoi.Text = "&Tạo mới";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.Location = new System.Drawing.Point(791, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "&Lưu";
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkTrangThai.Location = new System.Drawing.Point(893, 72);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.chkTrangThai.Properties.Appearance.Options.UseForeColor = true;
            this.chkTrangThai.Properties.Caption = "Kích Hoạt";
            this.chkTrangThai.Size = new System.Drawing.Size(75, 19);
            this.chkTrangThai.TabIndex = 36;
            // 
            // lblMota
            // 
            this.lblMota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMota.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblMota.Location = new System.Drawing.Point(786, 37);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(27, 13);
            this.lblMota.TabIndex = 34;
            this.lblMota.Text = "Mô tả";
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrangthai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblTrangthai.Location = new System.Drawing.Point(786, 74);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(49, 13);
            this.lblTrangthai.TabIndex = 33;
            this.lblTrangthai.Text = "Trạng thái";
            // 
            // txtMabenh
            // 
            this.txtMabenh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMabenh.Enabled = false;
            this.txtMabenh.Location = new System.Drawing.Point(231, 34);
            this.txtMabenh.Name = "txtMabenh";
            this.txtMabenh.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.txtMabenh.Properties.Appearance.Options.UseForeColor = true;
            this.txtMabenh.Size = new System.Drawing.Size(92, 20);
            this.txtMabenh.TabIndex = 30;
            // 
            // txtTenthuocTV
            // 
            this.txtTenthuocTV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenthuocTV.Location = new System.Drawing.Point(488, 34);
            this.txtTenthuocTV.Name = "txtTenthuocTV";
            this.txtTenthuocTV.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.txtTenthuocTV.Properties.Appearance.Options.UseForeColor = true;
            this.txtTenthuocTV.Size = new System.Drawing.Size(248, 20);
            this.txtTenthuocTV.TabIndex = 32;
            // 
            // lblTenBenhTV
            // 
            this.lblTenBenhTV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenBenhTV.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblTenBenhTV.Location = new System.Drawing.Point(371, 37);
            this.lblTenBenhTV.Name = "lblTenBenhTV";
            this.lblTenBenhTV.Size = new System.Drawing.Size(95, 13);
            this.lblTenBenhTV.TabIndex = 31;
            this.lblTenBenhTV.Text = "Tên Bệnh Tiếng Việt";
            // 
            // lblMaBenh
            // 
            this.lblMaBenh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaBenh.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblMaBenh.Location = new System.Drawing.Point(158, 38);
            this.lblMaBenh.Name = "lblMaBenh";
            this.lblMaBenh.Size = new System.Drawing.Size(41, 13);
            this.lblMaBenh.TabIndex = 29;
            this.lblMaBenh.Text = "Mã Bệnh";
            // 
            // cbmNhombenh
            // 
            this.cbmNhombenh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbmNhombenh.Location = new System.Drawing.Point(231, 73);
            this.cbmNhombenh.Name = "cbmNhombenh";
            this.cbmNhombenh.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.cbmNhombenh.Properties.Appearance.Options.UseForeColor = true;
            this.cbmNhombenh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbmNhombenh.Size = new System.Drawing.Size(92, 20);
            this.cbmNhombenh.TabIndex = 41;
            // 
            // txtMota
            // 
            this.txtMota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMota.Location = new System.Drawing.Point(845, 30);
            this.txtMota.Name = "txtMota";
            this.txtMota.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.txtMota.Properties.Appearance.Options.UseForeColor = true;
            this.txtMota.Properties.DisplayFormat.FormatString = "d";
            this.txtMota.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtMota.Properties.EditFormat.FormatString = "d";
            this.txtMota.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtMota.Size = new System.Drawing.Size(248, 40);
            this.txtMota.TabIndex = 35;
            // 
            // pnTimkiemDanhmucphongkham
            // 
            this.pnTimkiemDanhmucphongkham.Controls.Add(this.lblDanhmucbenh);
            this.pnTimkiemDanhmucphongkham.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTimkiemDanhmucphongkham.Location = new System.Drawing.Point(0, 0);
            this.pnTimkiemDanhmucphongkham.Name = "pnTimkiemDanhmucphongkham";
            this.pnTimkiemDanhmucphongkham.Size = new System.Drawing.Size(1264, 57);
            this.pnTimkiemDanhmucphongkham.TabIndex = 42;
            // 
            // lblDanhmucbenh
            // 
            this.lblDanhmucbenh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDanhmucbenh.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhmucbenh.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblDanhmucbenh.Location = new System.Drawing.Point(513, 5);
            this.lblDanhmucbenh.Name = "lblDanhmucbenh";
            this.lblDanhmucbenh.Size = new System.Drawing.Size(393, 31);
            this.lblDanhmucbenh.TabIndex = 6;
            this.lblDanhmucbenh.Text = "Danh Mục Bệnh Trong Bệnh Viện";
            // 
            // ucBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdBenh);
            this.Controls.Add(this.pnDanhmucphongkham);
            this.Controls.Add(this.pnTimkiemDanhmucphongkham);
            this.Name = "ucBenh";
            this.Size = new System.Drawing.Size(1264, 542);
            this.Load += new System.EventHandler(this.ucBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBenh)).EndInit();
            this.pnDanhmucphongkham.ResumeLayout(false);
            this.pnDanhmucphongkham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenthuocTA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMabenh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenthuocTV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbmNhombenh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTimkiemDanhmucphongkham)).EndInit();
            this.pnTimkiemDanhmucphongkham.ResumeLayout(false);
            this.pnTimkiemDanhmucphongkham.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdBenh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBenh;
        private DevExpress.XtraGrid.Columns.GridColumn colMabenh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenbenhtv;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaytao;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangthai;
        private System.Windows.Forms.Panel pnDanhmucphongkham;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKhongLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnTaomoi;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.CheckEdit chkTrangThai;
        private DevExpress.XtraEditors.LabelControl lblMota;
        private DevExpress.XtraEditors.LabelControl lblTrangthai;
        private DevExpress.XtraEditors.TextEdit txtMabenh;
        private DevExpress.XtraEditors.TextEdit txtTenthuocTV;
        private DevExpress.XtraEditors.LabelControl lblTenBenhTV;
        private DevExpress.XtraEditors.LabelControl lblMaBenh;
        private DevExpress.XtraEditors.PanelControl pnTimkiemDanhmucphongkham;
        private DevExpress.XtraEditors.LabelControl lblDanhmucbenh;
        private DevExpress.XtraEditors.TextEdit txtTenthuocTA;
        private DevExpress.XtraEditors.LabelControl lblTenbenhTA;
        private DevExpress.XtraGrid.Columns.GridColumn colTenbenhta;
        private DevExpress.XtraEditors.SimpleButton btnNhombenh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbmNhombenh;
        private DevExpress.XtraEditors.MemoEdit txtMota;
    }
}
