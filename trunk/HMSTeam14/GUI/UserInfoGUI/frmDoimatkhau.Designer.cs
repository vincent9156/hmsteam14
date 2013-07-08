namespace GUI
{
    partial class frmDoimatkhau
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMatkhauhientai = new DevExpress.XtraEditors.TextEdit();
            this.txtMatkhaumoi = new DevExpress.XtraEditors.TextEdit();
            this.txtXacnhanmatkhau = new DevExpress.XtraEditors.TextEdit();
            this.btnDongydoimatkhau = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuybodoimatkhau = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhauhientai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhaumoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacnhanmatkhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(424, 70);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(127, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(163, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đổi Mật Khẩu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(55, 92);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật khẩu hiện tại:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(55, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(67, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mật khẩu mới:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(55, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Xác nhận mật khẩu:";
            // 
            // txtMatkhauhientai
            // 
            this.txtMatkhauhientai.Location = new System.Drawing.Point(159, 92);
            this.txtMatkhauhientai.Name = "txtMatkhauhientai";
            this.txtMatkhauhientai.Properties.PasswordChar = '*';
            this.txtMatkhauhientai.Size = new System.Drawing.Size(195, 20);
            this.txtMatkhauhientai.TabIndex = 4;
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Location = new System.Drawing.Point(159, 127);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.Properties.PasswordChar = '*';
            this.txtMatkhaumoi.Size = new System.Drawing.Size(195, 20);
            this.txtMatkhaumoi.TabIndex = 5;
            // 
            // txtXacnhanmatkhau
            // 
            this.txtXacnhanmatkhau.Location = new System.Drawing.Point(159, 165);
            this.txtXacnhanmatkhau.Name = "txtXacnhanmatkhau";
            this.txtXacnhanmatkhau.Properties.PasswordChar = '*';
            this.txtXacnhanmatkhau.Size = new System.Drawing.Size(195, 20);
            this.txtXacnhanmatkhau.TabIndex = 6;
            // 
            // btnDongydoimatkhau
            // 
            this.btnDongydoimatkhau.Location = new System.Drawing.Point(110, 210);
            this.btnDongydoimatkhau.Name = "btnDongydoimatkhau";
            this.btnDongydoimatkhau.Size = new System.Drawing.Size(75, 23);
            this.btnDongydoimatkhau.TabIndex = 7;
            this.btnDongydoimatkhau.Text = "&Đồng ý";
            this.btnDongydoimatkhau.Click += new System.EventHandler(this.btnDongydoimatkhau_Click);
            // 
            // btnHuybodoimatkhau
            // 
            this.btnHuybodoimatkhau.Location = new System.Drawing.Point(237, 210);
            this.btnHuybodoimatkhau.Name = "btnHuybodoimatkhau";
            this.btnHuybodoimatkhau.Size = new System.Drawing.Size(75, 23);
            this.btnHuybodoimatkhau.TabIndex = 8;
            this.btnHuybodoimatkhau.Text = "&Hủy bỏ";
            this.btnHuybodoimatkhau.Click += new System.EventHandler(this.btnHuybodoimatkhau_Click);
            // 
            // frmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 262);
            this.Controls.Add(this.btnHuybodoimatkhau);
            this.Controls.Add(this.btnDongydoimatkhau);
            this.Controls.Add(this.txtXacnhanmatkhau);
            this.Controls.Add(this.txtMatkhaumoi);
            this.Controls.Add(this.txtMatkhauhientai);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhauhientai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatkhaumoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacnhanmatkhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtMatkhauhientai;
        private DevExpress.XtraEditors.TextEdit txtMatkhaumoi;
        private DevExpress.XtraEditors.TextEdit txtXacnhanmatkhau;
        private DevExpress.XtraEditors.SimpleButton btnDongydoimatkhau;
        private DevExpress.XtraEditors.SimpleButton btnHuybodoimatkhau;

    }
}