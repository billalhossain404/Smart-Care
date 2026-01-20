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

namespace Smart_Care
{
    public partial class AllEmployeesForm : Form
    {
        public AllEmployeesForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            string connectionString = @"Data Source=BILLAL\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = @"SELECT 
                            EmployeeID,
                            EmployeeName,
                            EmployeeRole,
                            EmployeeEmail,
                            MaritalStatus,
                            Gender,
                            BloodGroup,
                            DateOfBirth,
                            DateOfJoining
                         FROM Employees";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgvEmployees.DataSource = dt;

            con.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SearchEmployeeForm searchForm = new SearchEmployeeForm();
            searchForm.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee addForm = new AddEmployee();
            addForm.Show();
            this.Hide();
        }

        private void AllEmployeesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
