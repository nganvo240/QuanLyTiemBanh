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
    public partial class frmEmp : Form
    {
        BindingSource employeeList = new BindingSource();
        public frmEmp()
        {
            InitializeComponent();
        }
        private void frmEmp_Load(object sender, EventArgs e)
        {
            dtgvEmp.DataSource = employeeList;
            AddAccountBinding();
            LoadEmployee();
        }
        void AddAccountBinding()
        {
            // mấy cái textbox
        }
        void LoadEmployee()
        {
            employeeList.DataSource = EmployeeDAO.Instance.GetListEmployee();
        }

        
    }
}
