using QuanLyTiemBanh.DAO;
using QuanLyTiemBanh.DTO;
using QuanLyTiemBanh.GUI;
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
    public partial class frmBill : Form
    {
        BindingSource billList = new BindingSource();
        public frmBill()
        {
            InitializeComponent();
            dtgvBill.DataSource = billList;
            AddBillBinding();
            LoadBill();
        }
        void AddBillBinding()
        {
            txtID.DataBindings.Add(new Binding("Text", dtgvBill.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtDayOut.DataBindings.Add(new Binding("Text", dtgvBill.DataSource, "day_out", true, DataSourceUpdateMode.Never));
            txtEmpID.DataBindings.Add(new Binding("Text", dtgvBill.DataSource, "emp_id", true, DataSourceUpdateMode.Never));
        }
        void LoadBill()
        {
            billList.DataSource = BillDAO.Instance.GetListBill();
        }
        private event EventHandler insertBill;
        public event EventHandler InsertBill
        {
            add { insertBill += value; }
            remove { insertBill -= value; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Emp_ID = int.Parse(txtEmpID.Text);
            if (BillDAO.Instance.InsertBill( Emp_ID))
            {
                MessageBox.Show("Thêm bill thành công");
                LoadBill();
                if (insertBill != null)
                    insertBill(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không thêm được bill");
            }
        }

        private event EventHandler deleteBill;
        public event EventHandler DeleteBill
        {
            add { deleteBill += value; }
            remove { deleteBill -= value; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);

            if (BillDAO.Instance.DeleteBill(ID))
            {
                MessageBox.Show("Xóa bill thành công");
                LoadBill();
                if (deleteBill != null)
                    deleteBill(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không xóa được bill");
            }
        }

        private void btnBillInfo_Click(object sender, EventArgs e)
        {
            string id = (string)txtID.Text;
            frmBillInfor f = new frmBillInfor(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
