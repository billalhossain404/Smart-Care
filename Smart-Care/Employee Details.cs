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
    public partial class EmployeeDetailsForm : Form
    {
        string connStr = @"Data Source=BILLAL-HOSSAIN\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";

        int employeeID;
        public EmployeeDetailsForm(int id)
        {
            InitializeComponent();
            employeeID = id;
            txtID.ReadOnly = true;
            txtName.ReadOnly = true;
            txtRole.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtBloodGroup.ReadOnly = true;
            txtGender.ReadOnly = true;
            txtMaritalStatus.ReadOnly = true;
            dtpDOB.Enabled = false;
            dtpDOJ.Enabled = false;
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                string connStr = @"Data Source=BILLAL-HOSSAIN\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connStr);
                con.Open();

                string query = "SELECT * FROM Employees WHERE EmployeeID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", employeeID);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    txtID.Text = dt.Rows[0]["EmployeeID"].ToString();
                    txtName.Text = dt.Rows[0]["EmployeeName"].ToString();
                    txtRole.Text = dt.Rows[0]["EmployeeRole"].ToString();
                    txtEmail.Text = dt.Rows[0]["EmployeeEmail"].ToString();
                    txtBloodGroup.Text = dt.Rows[0]["EmployeeEmail"].ToString();
                    txtGender.Text = dt.Rows[0]["Gender"].ToString();
                    txtMaritalStatus.Text = dt.Rows[0]["MaritalStatus"].ToString();

                    dtpDOB.Value = Convert.ToDateTime(dt.Rows[0]["DateOfBirth"]);
                    dtpDOJ.Value = Convert.ToDateTime(dt.Rows[0]["DateOfJoining"]);
                }

                else
                {
                    MessageBox.Show("Employee not found!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee addForm = new AddEmployee();
            addForm.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = @"Data Source=BILLAL-HOSSAIN\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connStr);
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", employeeID);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Employee Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SearchEmployeeForm searchForm = new SearchEmployeeForm();
            searchForm.Show();
            this.Close();
        }

        private void EmployeeDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
