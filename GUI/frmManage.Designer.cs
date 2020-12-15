namespace QuanLyTiemBanh.GUI
{
    partial class frmManage
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
            this.lbUserName = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panelFunction = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.groupBoxNhanVien = new System.Windows.Forms.GroupBox();
            this.btnChiTietHoaDon = new System.Windows.Forms.Button();
            this.groupBoxAdmin = new System.Windows.Forms.GroupBox();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnLoaiSanPham = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lbNameButton = new System.Windows.Forms.Label();
            this.lbvien = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelHienThi = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFunction.SuspendLayout();
            this.groupBoxNhanVien.SuspendLayout();
            this.groupBoxAdmin.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserName.AutoSize = true;
            this.lbUserName.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbUserName.Location = new System.Drawing.Point(571, 12);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(73, 13);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên tài khoản";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Controls.Add(this.panelFunction);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(170, 422);
            this.panelLeft.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.btnHelp);
            this.panelLogo.Controls.Add(this.btnMin);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(170, 121);
            this.panelLogo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyTiemBanh.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(45, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 73);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Location = new System.Drawing.Point(2, 35);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 21);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(2, 2);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(32, 21);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "=";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panelFunction
            // 
            this.panelFunction.Controls.Add(this.btnDangXuat);
            this.panelFunction.Controls.Add(this.groupBoxNhanVien);
            this.panelFunction.Controls.Add(this.groupBoxAdmin);
            this.panelFunction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFunction.Location = new System.Drawing.Point(0, 121);
            this.panelFunction.Margin = new System.Windows.Forms.Padding(2);
            this.panelFunction.Name = "panelFunction";
            this.panelFunction.Size = new System.Drawing.Size(170, 301);
            this.panelFunction.TabIndex = 5;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSize = true;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 271);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(170, 30);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "&Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // groupBoxNhanVien
            // 
            this.groupBoxNhanVien.Controls.Add(this.btnChiTietHoaDon);
            this.groupBoxNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNhanVien.Location = new System.Drawing.Point(0, 175);
            this.groupBoxNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxNhanVien.Name = "groupBoxNhanVien";
            this.groupBoxNhanVien.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxNhanVien.Size = new System.Drawing.Size(170, 126);
            this.groupBoxNhanVien.TabIndex = 1;
            this.groupBoxNhanVien.TabStop = false;
            this.groupBoxNhanVien.Text = "Nhân viên";
            // 
            // btnChiTietHoaDon
            // 
            this.btnChiTietHoaDon.AutoSize = true;
            this.btnChiTietHoaDon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChiTietHoaDon.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.btnChiTietHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTietHoaDon.Location = new System.Drawing.Point(2, 15);
            this.btnChiTietHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnChiTietHoaDon.Name = "btnChiTietHoaDon";
            this.btnChiTietHoaDon.Size = new System.Drawing.Size(166, 30);
            this.btnChiTietHoaDon.TabIndex = 6;
            this.btnChiTietHoaDon.Text = "&Chi tiết hóa đơn";
            this.btnChiTietHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdmin
            // 
            this.groupBoxAdmin.Controls.Add(this.btnHoaDon);
            this.groupBoxAdmin.Controls.Add(this.btnLoaiSanPham);
            this.groupBoxAdmin.Controls.Add(this.btnSanPham);
            this.groupBoxAdmin.Controls.Add(this.btnNhanVien);
            this.groupBoxAdmin.Controls.Add(this.btnTaiKhoan);
            this.groupBoxAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAdmin.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAdmin.Name = "groupBoxAdmin";
            this.groupBoxAdmin.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAdmin.Size = new System.Drawing.Size(170, 175);
            this.groupBoxAdmin.TabIndex = 0;
            this.groupBoxAdmin.TabStop = false;
            this.groupBoxAdmin.Text = "Admin";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.AutoSize = true;
            this.btnHoaDon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(2, 135);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(166, 30);
            this.btnHoaDon.TabIndex = 9;
            this.btnHoaDon.Text = "&Hóa đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLoaiSanPham
            // 
            this.btnLoaiSanPham.AutoSize = true;
            this.btnLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoaiSanPham.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.btnLoaiSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiSanPham.Location = new System.Drawing.Point(2, 105);
            this.btnLoaiSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoaiSanPham.Name = "btnLoaiSanPham";
            this.btnLoaiSanPham.Size = new System.Drawing.Size(166, 30);
            this.btnLoaiSanPham.TabIndex = 8;
            this.btnLoaiSanPham.Text = "&Loại Sản Phẩm";
            this.btnLoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoaiSanPham.UseVisualStyleBackColor = true;
            this.btnLoaiSanPham.Click += new System.EventHandler(this.btnLoaiSanPham_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.AutoSize = true;
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(2, 75);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(166, 30);
            this.btnSanPham.TabIndex = 7;
            this.btnSanPham.Text = "&Sản Phẩm";
            this.btnSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.AutoSize = true;
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(2, 45);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(166, 30);
            this.btnNhanVien.TabIndex = 6;
            this.btnNhanVien.Text = "&Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.AutoSize = true;
            this.btnTaiKhoan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.Image = global::QuanLyTiemBanh.Properties.Resources.bananas_icon;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(2, 15);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(166, 30);
            this.btnTaiKhoan.TabIndex = 5;
            this.btnTaiKhoan.Text = "&Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lbNameButton);
            this.panelTop.Controls.Add(this.lbvien);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Controls.Add(this.lbUserName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(170, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(714, 38);
            this.panelTop.TabIndex = 3;
            // 
            // lbNameButton
            // 
            this.lbNameButton.AutoSize = true;
            this.lbNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameButton.Location = new System.Drawing.Point(58, 9);
            this.lbNameButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameButton.Name = "lbNameButton";
            this.lbNameButton.Size = new System.Drawing.Size(124, 17);
            this.lbNameButton.TabIndex = 5;
            this.lbNameButton.Text = "Tên from đang mở";
            // 
            // lbvien
            // 
            this.lbvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbvien.Location = new System.Drawing.Point(0, 35);
            this.lbvien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbvien.Name = "lbvien";
            this.lbvien.Size = new System.Drawing.Size(714, 3);
            this.lbvien.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(13, 8);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 21);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelHienThi
            // 
            this.panelHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHienThi.Location = new System.Drawing.Point(170, 38);
            this.panelHienThi.Margin = new System.Windows.Forms.Padding(2);
            this.panelHienThi.Name = "panelHienThi";
            this.panelHienThi.Size = new System.Drawing.Size(714, 384);
            this.panelHienThi.TabIndex = 4;
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 422);
            this.Controls.Add(this.panelHienThi);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManage";
            this.panelLeft.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFunction.ResumeLayout(false);
            this.panelFunction.PerformLayout();
            this.groupBoxNhanVien.ResumeLayout(false);
            this.groupBoxNhanVien.PerformLayout();
            this.groupBoxAdmin.ResumeLayout(false);
            this.groupBoxAdmin.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelFunction;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label lbvien;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.GroupBox groupBoxNhanVien;
        private System.Windows.Forms.Button btnChiTietHoaDon;
        private System.Windows.Forms.GroupBox groupBoxAdmin;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnLoaiSanPham;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Label lbNameButton;
        private System.Windows.Forms.Panel panelHienThi;
    }
}