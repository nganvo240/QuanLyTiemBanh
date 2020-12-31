using QuanLyTiemBanh.DAO;
using QuanLyTiemBanh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemBanh.GUI
{
    public partial class frmBillInfor : Form
    {
        private string ID;
        BindingSource billInfoList = new BindingSource();
        public frmBillInfor()
        {
            InitializeComponent();
            dtgvBillInfo.DataSource = billInfoList;
            //AddBillInfoBinding();
            LoadBillInfo();
        }
        public frmBillInfor(string id)
        {
            this.ID = id;
            InitializeComponent();
            dtgvBillInfo.DataSource = billInfoList;
            LoadBillInfo();
        }
        //void AddBillInfoBinding()
        //{
        //    txtID.DataBindings.Add(new Binding("Text", dtgvBillInfo.DataSource, "id", true, DataSourceUpdateMode.Never));
        //    txtCakeID.DataBindings.Add(new Binding("Text", dtgvBillInfo.DataSource, "cake_id", true, DataSourceUpdateMode.Never));
        //    txtBillID.DataBindings.Add(new Binding("Text", dtgvBillInfo.DataSource, "bill_id", true, DataSourceUpdateMode.Never));
        //    txtAmount.DataBindings.Add(new Binding("Text", dtgvBillInfo.DataSource, "amount", true, DataSourceUpdateMode.Never));
        //    txtPrice.DataBindings.Add(new Binding("Text", dtgvBillInfo.DataSource, "price", true, DataSourceUpdateMode.Never));
        //}
        void LoadBillInfo()
        {
            lbID.Text = ID;
            int id = int.Parse(ID);
            string query = "SELECT * FROM CAKE";
            cmbCake.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cmbCake.DisplayMember = "name";
            cmbCake.ValueMember = "id";
            billInfoList.DataSource = BillInfoDAO.Instance.GetListBillInfo(id);
        }
        private event EventHandler insertBillInfo;
        public event EventHandler InsertBillInfo
        {
            add { insertBillInfo += value; }
            remove { insertBillInfo -= value; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Bill_ID = int.Parse(lbID.Text);
            string Cake_name = cmbCake.Text;
            string cakeID = cmbCake.SelectedValue.ToString();
            int Cake_ID = int.Parse(cakeID);
            int Amount = int.Parse(txtAmount.Text);
            if (BillInfoDAO.Instance.InsertBillInfo( Bill_ID, Cake_ID, Amount))
            {
                MessageBox.Show("Thêm bill thành công");
                LoadBillInfo();
                if (insertBillInfo != null)
                    insertBillInfo(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không thêm được bill");
            }
        }
        private event EventHandler deleteBillInfo;
        public event EventHandler DeleteBillInfo
        {
            add { deleteBillInfo += value; }
            remove { deleteBillInfo -= value; }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Cake_name = cmbCake.Text;
            string cakeID = cmbCake.SelectedValue.ToString();
            int Cake_ID = int.Parse(cakeID);
            if (BillInfoDAO.Instance.DeleteBillInfo(Cake_ID))
            {
                MessageBox.Show("Xóa bill thành công");
                LoadBillInfo();
                if (deleteBillInfo != null)
                    deleteBillInfo(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không xóa được bill");
            }
        }
    }
}
