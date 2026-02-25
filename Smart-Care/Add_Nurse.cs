using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Care
{
    public partial class Add_Nurse : Form
    {
        public Add_Nurse()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            DialogResult result = MessageBox.Show(
                "Do you want to add a nurse in this organization?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Collect Data
                string fname = textBox6.Text;
                string lname = textBox5.Text;
                string email = textBox4.Text;
                string phone = textBox3.Text;
                string password = textBox2.Text;
                string gender = radioButton1.Checked ? "Male" : "Female";
                string dept = comboBox1.SelectedItem.ToString();
                string shift = comboBox2.SelectedItem.ToString();
                string designation = comboBox3.SelectedItem.ToString();
                int experience = int.Parse(textBox1.Text);

                string connectionString = @"Data Source=Data Source=BILLAL-HOSSAIN\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO nurse_info (FirstName, LastName, Email, Phone, Password, Gender, Department, Shift, Designation, Experience, CreatedOn) " +
                                   "VALUES (@FirstName, @LastName, @Email, @Phone, @Password, @Gender, @Department, @Shift, @Designation, @Experience, @CreatedOn)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", fname);
                        cmd.Parameters.AddWithValue("@LastName", lname);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Department", dept);
                        cmd.Parameters.AddWithValue("@Shift", shift);
                        cmd.Parameters.AddWithValue("@Designation", designation);
                        cmd.Parameters.AddWithValue("@Experience", experience);
                        cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);

                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show(
                                "Nurse added to our organization!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            ClearForm();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(
                                "Database Error! " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Operation cancelled.",
                    "Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Nurse_Load(object sender, EventArgs e)
        {
            // Password hide
            textBox2.UseSystemPasswordChar = true;

            // Department ComboBox
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("ICU");
            comboBox1.Items.Add("Emergency");
            comboBox1.Items.Add("General Ward");
            comboBox1.Items.Add("Surgery");

            // Shift ComboBox
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Items.Add("Morning");
            comboBox2.Items.Add("Evening");
            comboBox2.Items.Add("Night");

            // Designation ComboBox
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.Items.Add("Senior Nurse");
            comboBox3.Items.Add("Staff Nurse");
        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard g_dsh = new Dashboard();
            g_dsh.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //show password textbox

            // Show/Hide password
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private bool ValidateForm()
        {
            // First Name
            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("First Name is required");
                textBox6.Focus();
                return false;
            }

            // Last Name
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Last Name is required");
                textBox5.Focus();
                return false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Email is required");
                textBox4.Focus();
                return false;
            }

            if (!Regex.IsMatch(textBox4.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid Email Format");
                textBox4.Focus();
                return false;
            }

            // Phone
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Phone Number is required");
                textBox3.Focus();
                return false;
            }

            if (!Regex.IsMatch(textBox3.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Phone number must be exactly 11 digits");
                textBox3.Focus();
                return false;
            }

            // Password
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Password is required");
                textBox2.Focus();
                return false;
            }

            if (textBox2.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters");
                textBox2.Focus();
                return false;
            }

            // Gender
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please select Gender");
                return false;
            }

            // Department
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Department");
                comboBox1.Focus();
                return false;
            }

            // Shift
            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Shift");
                comboBox2.Focus();
                return false;
            }

            // Designation
            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Designation");
                comboBox3.Focus();
                return false;
            }

            // Experience
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Experience is required");
                textBox1.Focus();
                return false;
            }

            if (!int.TryParse(textBox1.Text, out int exp) || exp < 0)
            {
                MessageBox.Show("Experience must be a valid number (0 or more)");
                textBox1.Focus();
                return false;
            }

            return true; // ALL OK
        }

        //clear form 

        private void ClearForm()
        {
            textBox6.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            checkBox1.Checked = false;
        }


    }
}
