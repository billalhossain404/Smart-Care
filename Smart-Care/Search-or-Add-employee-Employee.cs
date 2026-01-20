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
    public partial class SearchEmployeeForm : Form
    {
        public SearchEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int employeeID;
            if (!int.TryParse(txtEmployeeID.Text, out employeeID))
            {
                MessageBox.Show("Please enter a valid Employee ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
            {
                MessageBox.Show("Please enter Employee Name");
                return;
            }

            string connStr = @"Data Source=BILLAL\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connStr);
            con.Open();

            string query = "SELECT * FROM Employees WHERE EmployeeID=@ID AND EmployeeName=@Name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", employeeID);
            cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text.Trim());

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                EmployeeDetailsForm details = new EmployeeDetailsForm(employeeID);
                details.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Employee not found!");
            }

            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee addForm = new AddEmployee();
            addForm.Show();
            this.Hide();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            AllEmployeesForm employeesForm = new AllEmployeesForm();
            employeesForm.Show();
            this.Hide();
        }

        private void SearchEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard bck = new Dashboard();
            bck.Show();
            this.Hide();
        }
    }
}
