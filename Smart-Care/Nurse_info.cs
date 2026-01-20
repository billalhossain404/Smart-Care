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
    public partial class Nurse_info : Form
    {
        public Nurse_info()
        {
            InitializeComponent();
        }

        private void Nurse_info_Load(object sender, EventArgs e)
        {
            SetPlaceholder(textBox10, "First Name");
            SetPlaceholder(textBox11, "Password");

            label13.Visible = false;

            comboBox1.Items.Add("FirstName");
            comboBox1.Items.Add("LastName");
            comboBox1.Items.Add("Email");
            comboBox1.Items.Add("Phone");
            comboBox1.Items.Add("Password");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void LoadNurseData()
        {
            // 🌟 Get Inputs
            string firstName = textBox10.Text.Trim();
            string password = textBox11.Text.Trim();

            // 🌟 Validation checks
            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Please enter First Name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🌟 DB Connection String
            string connStr = @"Data Source=BILLAL\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connStr))
            {
                // 🌟 SQL query
                string query = "SELECT FirstName, LastName, Email, Phone, Gender, Department, Shift, Designation, Experience FROM nurse_info WHERE FirstName=@FirstName AND Password=@Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // 🌟 Display data in textboxes
                            textBox1.Text = reader["FirstName"].ToString();
                            textBox2.Text = reader["LastName"].ToString();
                            textBox3.Text = reader["Email"].ToString();
                            textBox4.Text = reader["Phone"].ToString();
                            textBox5.Text = reader["Gender"].ToString();
                            textBox6.Text = reader["Department"].ToString();
                            textBox7.Text = reader["Shift"].ToString();
                            textBox8.Text = reader["Designation"].ToString();
                            textBox9.Text = reader["Experience"].ToString();

                            // 🌟 Welcome text update
                            // label1 = static “Welcome”
                            // label13 = dynamic last name
                            label13.Visible = true;
                            label13.Text = reader["LastName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Name or Password!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            LoadNurseData();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //select combobox
            // first name , last name , email , phone and password 

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Load data first before editing!");
                return;
            }

            string selectedField = comboBox1.SelectedItem.ToString();

            switch (selectedField)
            {
                case "FirstName": textBox12.Text = textBox1.Text; break;
                case "LastName": textBox12.Text = textBox2.Text; break;
                case "Email": textBox12.Text = textBox3.Text; break;
                case "Phone": textBox12.Text = textBox4.Text; break;
                case "Password": textBox12.Text = ""; break; // security purpose
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetPlaceholder(TextBox txt, string placeholder)
        {
            txt.ForeColor = Color.Gray;
            txt.Text = placeholder;

            txt.Enter += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                    if (txt == textBox11) txt.UseSystemPasswordChar = true; // password hide
                }
            };

            txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.ForeColor = Color.Gray;
                    txt.Text = placeholder;
                    if (txt == textBox11) txt.UseSystemPasswordChar = false;
                }
            };
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // confirm change

            string selectedField = comboBox1.SelectedItem?.ToString();
            string newValue = textBox12.Text.Trim();
            string email = textBox3.Text.Trim(); // update match using email

            if (selectedField == null)
            {
                MessageBox.Show("Select field to update!");
                return;
            }

            if (string.IsNullOrWhiteSpace(newValue))
            {
                MessageBox.Show("Enter new value!");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email missing! Load data first.");
                return;
            }

            string connStr = @"Data Source=BILLAL\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = $"UPDATE nurse_info SET {selectedField}=@newValue WHERE Email=@Email";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@newValue", newValue);
                    cmd.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show($"{selectedField} updated successfully!", "Success");

                            // 🔹 If password was updated, set textbox11 to new password
                            if (selectedField == "Password")
                                textBox11.Text = newValue;

                            LoadNurseData();
                        }
                        else
                        {
                            MessageBox.Show("Update failed!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nurse_login logout = new Nurse_login();
            logout.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nurse_info n_info = new Nurse_info();
            n_info.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
