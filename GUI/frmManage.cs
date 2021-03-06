﻿using QuanLyTiemBanh.DTO;
using QuanLyTiemBanh.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyTiemBanh.GUI
{
    public partial class frmManage : Form
    {
        private Account loginAccount;

        private Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        internal frmManage(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }
        void ChangeAccount(int type)
        {
            groupBoxAdmin.Visible = type == 1;//1 là admin, 0 là nhân viên
            lbUserName.Text = "Xin chào: "+LoginAccount.UserName ;            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            lbNameButton.Text = "";
        }
        
        private void btnMin_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width == 40)
            {
                panelLeft.Width = 255;
            }
            else panelLeft.Width = 40;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            frmEmp f = new frmEmp();
            f.TopLevel = false;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Left;
            panelHienThi.Controls.Add(f);
            lbNameButton.Text = "Nhân Viên";
            f.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {            
            panelHienThi.Controls.Clear();
            frmAccount f = new frmAccount(loginAccount);
            f.TopLevel = false;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Left;
            panelHienThi.Controls.Add(f);
            lbNameButton.Text = "Tài khoản";
            f.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            frmCake f = new frmCake();
            f.TopLevel = false;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Left;
            panelHienThi.Controls.Add(f);
            lbNameButton.Text = "Sản Phẩm";
            f.Show();
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            frmCategory f = new frmCategory();
            f.TopLevel = false;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Left;
            panelHienThi.Controls.Add(f);
            lbNameButton.Text = "Phân loại";
            f.Show();
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            frmBillInfor f = new frmBillInfor();
            f.TopLevel = false;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Left;
            panelHienThi.Controls.Add(f);
            lbNameButton.Text = "Bill_Information";
            f.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            panelHienThi.Controls.Clear();
            frmBill f = new frmBill();
            f.TopLevel = false;
            f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f.Dock = DockStyle.Left;
            panelHienThi.Controls.Add(f);
            lbNameButton.Text = "Bill";
            f.Show();
        }
    }
}
