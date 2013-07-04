namespace GUI
{
    partial class ucBenhtheophongkham
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
            this.pnTimkiemDanhmucphongkham = new DevExpress.XtraEditors.PanelControl();
            this.lblDanhmucthuoc = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.lblBenh = new DevExpress.XtraEditors.LabelControl();
            this.lblPhongkham = new DevExpress.XtraEditors.LabelControl();
            this.grdLoaibenhtheopk = new DevExpress.XtraGrid.GridControl();
            this.gridLoaibenhtheopk = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMabenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenbenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpTenbenh = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPhongkham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPhongKham = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbMabenh = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbTenbenh = new DevExpress.XtraEditors.LookUpEdit();
            this.LookUpTenPhong = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTimkiemDanhmucphongkham)).BeginInit();
            this.pnTimkiemDanhmucphongkham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoaibenhtheopk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaibenhtheopk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpTenbenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhongKham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMabenh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTenbenh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpTenPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTimkiemDanhmucphongkham
            // 
            this.pnTimkiemDanhmucphongkham.Controls.Add(this.lblDanhmucthuoc);
            this.pnTimkiemDanhmucphongkham.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTimkiemDanhmucphongkham.Location = new System.Drawing.Point(0, 0);
            this.pnTimkiemDanhmucphongkham.Name = "pnTimkiemDanhmucphongkham";
            this.pnTimkiemDanhmucphongkham.Size = new System.Drawing.Size(1264, 57);
            this.pnTimkiemDanhmucphongkham.TabIndex = 40;
            // 
            // lblDanhmucthuoc
            // 
            this.lblDanhmucthuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDanhmucthuoc.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhmucthuoc.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblDanhmucthuoc.Location = new System.Drawing.Point(460, 5);
            this.lblDanhmucthuoc.Name = "lblDanhmucthuoc";
            this.lblDanhmucthuoc.Size = new System.Drawing.Size(424, 31);
            this.lblDanhmucthuoc.TabIndex = 6;
            this.lblDanhmucthuoc.Text = "Danh Mục Bệnh Trong Phòng Khám";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 508);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1264, 34);
            this.panelControl1.TabIndex = 41;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnXoa);
            this.panelControl2.Controls.Add(this.btnThem);
            this.panelControl2.Controls.Add(this.lblBenh);
            this.panelControl2.Controls.Add(this.lblPhongkham);
            this.panelControl2.Controls.Add(this.grdLoaibenhtheopk);
            this.panelControl2.Controls.Add(this.cmbPhongKham);
            this.panelControl2.Controls.Add(this.cmbMabenh);
            this.panelControl2.Controls.Add(this.cmbTenbenh);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 57);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1264, 451);
            this.panelControl2.TabIndex = 42;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(851, 68);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(750, 68);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "&Thêm loại bệnh ";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblBenh
            // 
            this.lblBenh.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblBenh.Location = new System.Drawing.Point(114, 74);
            this.lblBenh.Name = "lblBenh";
            this.lblBenh.Size = new System.Drawing.Size(57, 13);
            this.lblBenh.TabIndex = 3;
            this.lblBenh.Text = "-Loại Bệnh :";
            // 
            // lblPhongkham
            // 
            this.lblPhongkham.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(37)))), ((int)(((byte)(127)))));
            this.lblPhongkham.Location = new System.Drawing.Point(114, 40);
            this.lblPhongkham.Name = "lblPhongkham";
            this.lblPhongkham.Size = new System.Drawing.Size(69, 13);
            this.lblPhongkham.TabIndex = 1;
            this.lblPhongkham.Text = "-Phòng khám :";
            // 
            // grdLoaibenhtheopk
            // 
            this.grdLoaibenhtheopk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdLoaibenhtheopk.Location = new System.Drawing.Point(2, 149);
            this.grdLoaibenhtheopk.MainView = this.gridLoaibenhtheopk;
            this.grdLoaibenhtheopk.Name = "grdLoaibenhtheopk";
            this.grdLoaibenhtheopk.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpTenbenh,
            this.LookUpTenPhong});
            this.grdLoaibenhtheopk.Size = new System.Drawing.Size(1260, 300);
            this.grdLoaibenhtheopk.TabIndex = 0;
            this.grdLoaibenhtheopk.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridLoaibenhtheopk});
            // 
            // gridLoaibenhtheopk
            // 
            this.gridLoaibenhtheopk.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMabenh,
            this.colTenbenh,
            this.colPhongkham});
            this.gridLoaibenhtheopk.GridControl = this.grdLoaibenhtheopk;
            this.gridLoaibenhtheopk.Name = "gridLoaibenhtheopk";
            this.gridLoaibenhtheopk.OptionsFind.AlwaysVisible = true;
            this.gridLoaibenhtheopk.OptionsView.ShowGroupPanel = false;
            this.gridLoaibenhtheopk.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridLoaibenhtheopk_RowClick);
            //this.gridLoaibenhtheopk.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridLoaibenhtheopk_FocusedRowChanged);
            // 
            // colMabenh
            // 
            this.colMabenh.Caption = "Mã bệnh";
            this.colMabenh.FieldName = "MABENH";
            this.colMabenh.Name = "colMabenh";
            this.colMabenh.OptionsColumn.AllowEdit = false;
            this.colMabenh.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colMabenh.Visible = true;
            this.colMabenh.VisibleIndex = 1;
            this.colMabenh.Width = 121;
            // 
            // colTenbenh
            // 
            this.colTenbenh.Caption = "Tên bệnh";
            this.colTenbenh.ColumnEdit = this.LookUpTenbenh;
            this.colTenbenh.FieldName = "MABENH";
            this.colTenbenh.Name = "colTenbenh";
            this.colTenbenh.OptionsColumn.AllowEdit = false;
            this.colTenbenh.Visible = true;
            this.colTenbenh.VisibleIndex = 2;
            this.colTenbenh.Width = 272;
            // 
            // LookUpTenbenh
            // 
            this.LookUpTenbenh.AutoHeight = false;
            this.LookUpTenbenh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpTenbenh.Name = "LookUpTenbenh";
            this.LookUpTenbenh.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colPhongkham
            // 
            this.colPhongkham.Caption = "Phòng khám";
            this.colPhongkham.ColumnEdit = this.LookUpTenPhong;
            this.colPhongkham.FieldName = "MAPHONGKHAM";
            this.colPhongkham.Name = "colPhongkham";
            this.colPhongkham.OptionsColumn.AllowEdit = false;
            this.colPhongkham.Visible = true;
            this.colPhongkham.VisibleIndex = 0;
            this.colPhongkham.Width = 210;
            // 
            // cmbPhongKham
            // 
            this.cmbPhongKham.Location = new System.Drawing.Point(225, 37);
            this.cmbPhongKham.Name = "cmbPhongKham";
            this.cmbPhongKham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPhongKham.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAPHONGKHAM", 10, "Mã phòng khám"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENPHONG", 30, "Tên phòng khám")});
            this.cmbPhongKham.Properties.NullText = "";
            this.cmbPhongKham.Size = new System.Drawing.Size(478, 20);
            this.cmbPhongKham.TabIndex = 14;
            // 
            // cmbMabenh
            // 
            this.cmbMabenh.Location = new System.Drawing.Point(225, 71);
            this.cmbMabenh.Name = "cmbMabenh";
            this.cmbMabenh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMabenh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MABENH", "Mã bệnh")});
            this.cmbMabenh.Properties.NullText = "";
            this.cmbMabenh.Size = new System.Drawing.Size(96, 20);
            this.cmbMabenh.TabIndex = 4;
            this.cmbMabenh.EditValueChanged += new System.EventHandler(this.cmbMabenh_EditValueChanged);
            // 
            // cmbTenbenh
            // 
            this.cmbTenbenh.Location = new System.Drawing.Point(340, 71);
            this.cmbTenbenh.Name = "cmbTenbenh";
            this.cmbTenbenh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTenbenh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENBENHTV", "Tên bệnh tiếng việt"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENBENHTA", "Tên bệnh tiếng anh")});
            this.cmbTenbenh.Properties.LookAndFeel.SkinName = "VS2010";
            this.cmbTenbenh.Properties.NullText = "";
            this.cmbTenbenh.Size = new System.Drawing.Size(363, 20);
            this.cmbTenbenh.TabIndex = 5;
            this.cmbTenbenh.EditValueChanged += new System.EventHandler(this.cmbTenbenh_EditValueChanged);
            // 
            // LookUpTenPhong
            // 
            this.LookUpTenPhong.AutoHeight = false;
            this.LookUpTenPhong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpTenPhong.Name = "LookUpTenPhong";
            // 
            // ucBenhtheophongkham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnTimkiemDanhmucphongkham);
            this.Name = "ucBenhtheophongkham";
            this.Size = new System.Drawing.Size(1264, 542);
            this.Load += new System.EventHandler(this.ucBenhtheophongkham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnTimkiemDanhmucphongkham)).EndInit();
            this.pnTimkiemDanhmucphongkham.ResumeLayout(false);
            this.pnTimkiemDanhmucphongkham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoaibenhtheopk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaibenhtheopk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpTenbenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPhongKham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMabenh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTenbenh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpTenPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnTimkiemDanhmucphongkham;
        private DevExpress.XtraEditors.LabelControl lblDanhmucthuoc;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblBenh;
        private DevExpress.XtraEditors.LabelControl lblPhongkham;
        private DevExpress.XtraGrid.GridControl grdLoaibenhtheopk;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLoaibenhtheopk;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.Columns.GridColumn colMabenh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenbenh;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongkham;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.LookUpEdit cmbPhongKham;
        private DevExpress.XtraEditors.LookUpEdit cmbMabenh;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit LookUpTenbenh;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.LookUpEdit cmbTenbenh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpTenPhong;
    }
}
