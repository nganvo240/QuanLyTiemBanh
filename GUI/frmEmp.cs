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
    public partial class frmEmp : Form
    {
        BindingSource empList = new BindingSource();
        public frmEmp()
        {
            InitializeComponent();
            dtgvEmp.DataSource = empList;
            AddAccountBinding();
            LoadEmployee();
        }
        private void frmEmp_Load(object sender, EventArgs e)
        {
            
        }
        void AddAccountBinding()
        {
            // mấy cái textbox
            txtID.DataBindings.Add(new Binding("Text", dtgvEmp.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dtgvEmp.DataSource, "name", true, DataSourceUpdateMode.Never));
            txtAddress.DataBindings.Add(new Binding("Text", dtgvEmp.DataSource, "address", true, DataSourceUpdateMode.Never));
            txtPosition.DataBindings.Add(new Binding("Text", dtgvEmp.DataSource, "position", true, DataSourceUpdateMode.Never));
            txtPhone.DataBindings.Add(new Binding("Text", dtgvEmp.DataSource, "PhoneNumber", true, DataSourceUpdateMode.Never));
            txtSex.DataBindings.Add(new Binding("Text", dtgvEmp.DataSource, "sex", true, DataSourceUpdateMode.Never));
            txtSalary.DataBindings.Add(new Binding("Text", dtgvEmp.DataSource, "salary", true, DataSourceUpdateMode.Never));
            txtStatus.DataBindings.Add(new Binding("Text", dtgvEmp.DataSource, "status", true, DataSourceUpdateMode.Never));
        }
        void LoadEmployee()
        {
            empList.DataSource = EmployeeDAO.Instance.GetListEmployee();
        }
        private void frmAccount_Load(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        // Xử lý Add
        private event EventHandler insertEmp;
        public event EventHandler InsertEmp
        {
            add { insertEmp += value; }
            remove { insertEmp -= value; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            string Name = txtName.Text;
            string Address = txtAddress.Text;
            string Position = txtPosition.Text;
            int Salary = int.Parse(txtSalary.Text);
            string Phone = txtPhone.Text;
            string Sex = txtSex.Text;
            int Status = int.Parse(txtStatus.Text);

            if (EmployeeDAO.Instance.InsertEmployee(ID, Name, Address, Phone, Sex, Position, Salary, Status))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadEmployee();
                if (insertEmp != null)
                    insertEmp(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không thêm được tài khoản");
            }
        }
        private event EventHandler updateEmp;
        public event EventHandler UpdateEmp
        {
            add { updateEmp += value; }
            remove { updateEmp -= value; }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            string Name = txtName.Text;
            string Address = txtAddress.Text;
            string Phone = txtPhone.Text;
            string Sex = txtSex.Text;
            string Position = txtPosition.Text;
            int Salary = int.Parse(txtSalary.Text);
            int Status = int.Parse(txtStatus.Text);

            if (EmployeeDAO.Instance.UpdateEmployee(ID, Name, Address, Phone, Sex, Position, Salary, Status))
            {
                MessageBox.Show("Sửa tài khoản thành công");
                LoadEmployee();
                if (updateEmp != null)
                    updateEmp(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không sửa được tài khoản");
            }
        }
        private event EventHandler deleteEmp;
        public event EventHandler DeleteEmp
        {
            add { deleteEmp += value; }
            remove { deleteEmp -= value; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            if (EmployeeDAO.Instance.DeleteEmployee(ID))
            {
                MessageBox.Show("Xóa tài khoản thành công");    
                LoadEmployee();
                if (deleteEmp != null)
                    deleteEmp(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Lỗi! Không xóa được tài khoản");
            }
        }
    }
}
