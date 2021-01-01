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
    public partial class frmCake : Form
    {
        BindingSource cakeList = new BindingSource();
        public frmCake()
        {
            InitializeComponent();
            dtgvCake.DataSource = cakeList;
            AddCakeBinding();
            LoadCake();
        }

        void AddCakeBinding()
        {
            txtID.DataBindings.Add(new Binding("Text", dtgvCake.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dtgvCake.DataSource, "name", true, DataSourceUpdateMode.Never));
            txtPrice.DataBindings.Add(new Binding("Text", dtgvCake.DataSource, "price", true, DataSourceUpdateMode.Never));
            txtCategory_id.DataBindings.Add(new Binding("Text", dtgvCake.DataSource, "category_id", true, DataSourceUpdateMode.Never));
            txtAmount.DataBindings.Add(new Binding("Text", dtgvCake.DataSource, "amount", true, DataSourceUpdateMode.Never));
            txtPlace.DataBindings.Add(new Binding("Text", dtgvCake.DataSource, "place", true, DataSourceUpdateMode.Never));
        }

        void LoadCake()
        {
            cakeList.DataSource = CakeDAO.Instance.GetListCake();
        }
        //Xử lí các button và datagridview
        //button 'add'
        private event EventHandler insertCake;
        public event EventHandler InsertCake
        {
            add { insertCake += value; }
            remove { insertCake -= value; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            int price = int.Parse(txtPrice.Text);
            int category_id = int.Parse(txtCategory_id.Text);
            int amount = int.Parse(txtAmount.Text);
            string place = txtPlace.Text;

            if (CakeDAO.Instance.InsertCake(id, name, price, category_id, amount, place))
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                LoadCake();
                if (insertCake != null)
                    insertCake(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không thêm được sản phẩm");
            }

            txtID.Text = "";
            txtCategory_id.Text = "";
            txtAmount.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtPlace.Text = "";
        }

        //button update
        private event EventHandler updateCake;
        public event EventHandler UpdateCake
        {
            add { updateCake += value; }
            remove { updateCake -= value; }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            int price = int.Parse(txtPrice.Text);
            int category_id = int.Parse(txtCategory_id.Text);
            int amount = int.Parse(txtAmount.Text);
            string place = txtPlace.Text;

            if (CakeDAO.Instance.UpdateCake(id, name, price, category_id, amount, place))
            {
                MessageBox.Show("Sửa thông tin sản phẩm thành công");
                LoadCake();
                if (updateCake != null)
                    updateCake(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không sửa được thông tin sản phẩm này!");
            }

            txtID.Text = "";
            txtCategory_id.Text = "";
            txtAmount.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtPlace.Text = "";
        }
        //button delete, vấn đề khóa ngoại trong bill_infor
        private event EventHandler deleteCake;
        public event EventHandler DeleteCake
        {
            add { deleteCake += value; }
            remove { deleteCake -= value; }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            

            if (CakeDAO.Instance.DeleteCake(id))
            {
                MessageBox.Show("Xóa sản phẩm thành công");
                LoadCake();
                if (deleteCake != null)
                    deleteCake(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không xóa được sản phẩm này!");
            }
        }

        private void lbHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chỉ xóa sản phầm nào mà nó không nằm trong hóa đơn.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
