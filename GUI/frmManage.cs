using QuanLyTiemBanh.DTO;
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

        //public Account LoginAccount
        //{
        //    get { return loginAccount; }
        //    set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        //}
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
            //adminToolStripMenuItem.Enabled = type == 1;
            lbUserName.Text = LoginAccount.UserName ;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            frmEmp f = new frmEmp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
