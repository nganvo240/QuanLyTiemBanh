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
                MessageBox.Show("Thêm loại sản phẩm thành công");
                LoadCategory();
                if (insertCategory != null)
                    insertCategory(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không thêm được loại sản phẩm này!");
            }
        }
    }
}
