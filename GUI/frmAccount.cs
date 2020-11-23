using QuanLyTiemBanh.DAO;
using QuanLyTiemBanh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemBanh.GUI
{
    public partial class frmAccount : Form
    {
        BindingSource accList = new BindingSource();
        public frmAccount()
        {
            InitializeComponent();
            //load data
            dtgvAcc.DataSource = accList;
            LoadAcc();
            LoadListEmp(cbEmp);
            AddAccountBinding();
        }

        #region xử lý datagridview và nội dung ở textbox
        void AddAccountBinding()
        {
            // nội dung textbox
            txtNameAcc.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "username", true, DataSourceUpdateMode.Never));
            txtPass.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "password", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dtgvAcc.DataSource, "type", true, DataSourceUpdateMode.Never));
            //cbEmp.DataBindings.Add(new Binding("Text", dtgvAcc.DataSource, "nhanvien_id", true, DataSourceUpdateMode.Never));

        }
        void LoadAcc()
        {
            accList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void LoadListEmp(ComboBox cb)
        {
            cb.DataSource = EmployeeDAO.Instance.GetListEmpToCb();
            cb.DisplayMember = "Name";
        }
        private void frmAccount_Load(object sender, EventArgs e)
        {                   
        }
        #endregion
        private event EventHandler insertAcc;
        public event EventHandler InsertAcc
        {
            add { insertAcc += value; }
            remove { insertAcc -= value; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName = txtNameAcc.Text;
            string pass = txtPass.Text;
            int type = (int)numericUpDown1.Value;
            int  nhanvien_id = (cbEmp.SelectedItem as Employee).Id;                       

            if (AccountDAO.Instance.InsertAccount(userName, pass, type, nhanvien_id))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadAcc();
                if (insertAcc != null)
                    insertAcc(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không thêm được tài khoản");
            }
        }
        private event EventHandler updateAcc;
        public event EventHandler UpdateAcc
        {
            add { updateAcc += value; }
            remove { updateAcc -= value; }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string userName = txtNameAcc.Text;
            string pass = txtPass.Text;
            int type = (int)numericUpDown1.Value;
            int nhanvien_id = (cbEmp.SelectedItem as Employee).Id;

            if (AccountDAO.Instance.UpdateAccount(userName, pass, type, nhanvien_id))
            {
                MessageBox.Show("Sửa tài khoản thành công");
                LoadAcc();
                if (updateAcc != null)
                    updateAcc(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không sửa được tài khoản");
            }
        }
        private event EventHandler deleteAcc;
        public event EventHandler DeleteAcc
        {
            add { deleteAcc += value; }
            remove { deleteAcc -= value; }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userName = txtNameAcc.Text;

            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadAcc();
                if (deleteAcc != null)
                    deleteAcc(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không xóa được tài khoản");
            }
        }

        private void lbHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Type: chỉ tồn tại giá trị 0 và 1 \n"+
                "Tên nhân viên: chỉ chấp nhận tên nhân viên trong cửa hàng", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
