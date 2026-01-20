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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            LoadRoleComboBox();
        }

        private void LoadRoleComboBox()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Security Guard");
            cmbRole.Items.Add("Receptionist");
            cmbRole.Items.Add("Ward Boy");
            cmbRole.Items.Add("Cleaning Staff");
            cmbRole.Items.Add("Ambulance Driver");
            cmbRole.Items.Add("Canteen Worker");
            cmbRole.Items.Add("Mortician");
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Others");
            cmbMaritalStatus.Items.Add("Unmarried");
            cmbMaritalStatus.Items.Add("Married");
            cmbBloodGroup.Items.Add("A+");
            cmbBloodGroup.Items.Add("A-");
            cmbBloodGroup.Items.Add("B+");
            cmbBloodGroup.Items.Add("B-");
            cmbBloodGroup.Items.Add("AB+");
            cmbBloodGroup.Items.Add("AB-");
            cmbBloodGroup.Items.Add("O+");
            cmbBloodGroup.Items.Add("O-");


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Please enter a valid numeric Employee ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(cmbRole.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please fill all required fields (Name, Role, Email)");
                return;
            }

            try
            {
                string connStr = @"Data Source=BILLAL\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connStr);
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Employees(EmployeeID, EmployeeName, EmployeeRole, EmployeeEmail, MaritalStatus, Gender, BloodGroup,  DateOfBirth, DateOfJoining) " +
                    "VALUES(@ID,@Name,@Role,@Email, @MaritalStatus, @Gender, @BloodGroup, @DOB,@DOJ)", con);

                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", cmbRole.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@MaritalStatus", cmbMaritalStatus.Text);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@BloodGroup", cmbBloodGroup.Text);
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@DOJ", dtpDOJ.Value);


                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            cmbRole.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            cmbMaritalStatus.SelectedIndex = -1;
            cmbBloodGroup.SelectedIndex = -1;
            txtEmail.Clear();
            dtpDOB.Value = DateTime.Now;
            dtpDOJ.Value = DateTime.Now;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SearchEmployeeForm searchForm = new SearchEmployeeForm();
            searchForm.Show();
            this.Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
