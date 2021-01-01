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

namespace QuanLyTiemBanh.GUI
{
    public partial class frmCategory : Form
    {
        BindingSource categoryList = new BindingSource();
        public frmCategory()
        {
            InitializeComponent();
            dtgvCategory.DataSource = categoryList;
            AddCategoryBinding();
            LoadCategory();
        }
        void AddCategoryBinding()
        {
            txtID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        void LoadCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCake();
        }
        //button 'add'
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;

            if (CategoryDAO.Instance.InsertCategory(id, name))
            {
                MessageBox.Show("Thêm phân loại sản phẩm thành công");
                LoadCategory();
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không thêm được phân loại này!");
            }
            txtID.Text = "";
            txtName.Text = "";
        }

        //button sửa
        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;

            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Sửa loại sản phẩm thành công");
                LoadCategory();
                if (updateCategory != null)
                    updateCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không sửa được phân loại này!");
            }
            txtID.Text = "";
            txtName.Text = "";
        }
        //button delete
        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;

            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa loại sản phẩm thành công");
                LoadCategory();
                if (deleteCategory != null)
                    deleteCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không xóa được phân loại này!");
            }

        }

        private void lbHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chỉ xóa phân loại nào mà sản phẩm thuộc phân loại đó không nằm trong hóa đơn.", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
