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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void account_Click(object sender, EventArgs e)
        {
            Smartcare home = new Smartcare();
            home.Show();
            this.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=BILLAL\SQLEXPRESS;Initial Catalog=SmartBD;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string query = "SELECT DoctorId ,  FirstName  + ' ' + LastName AS DoctorName,    Speciality,    ExperienceYears FROM Doctors WHERE FirstName LIKE @FirstName";
                SqlCommand sq2 = new SqlCommand(query, con);
                sq2.Parameters.AddWithValue("@FirstName", dctrserchbox.Text.Trim() + "%");

                SqlDataAdapter sda = new SqlDataAdapter(sq2);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    doctordatagrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Matching Data Found");
                }

                con.Close();
                dctrserchbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error!! " + ex.Message, "ERROR");
            }

        }

        private void viewprofile_Click(object sender, EventArgs e)
        {
            try
            {
                if (doctordatagrid.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a doctor first!");
                    return;
                }

                int doctorId = Convert.ToInt32(doctordatagrid.SelectedRows[0].Cells["DoctorId"].Value);

                string connectionString = @"Data Source=BILLAL\SQLEXPRESS;Initial Catalog=SmartBD;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string query = @" SELECT  DoctorId,  FirstName,  LastName, Gender,   BloodGroup,  Speciality, ExperienceYears,  Mobile,  Email,  Address,  DateOfBirth FROM Doctors  WHERE DoctorId = @DoctorId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    doctordatagrid.AutoGenerateColumns = true;
                    doctordatagrid.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Doctor profile not found!");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error!! " + ex.Message, "ERROR");
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void book_Click(object sender, EventArgs e)
        {
            Appointment ap = new Appointment();
            ap.Show();
            this.Close();
        }
    }
}
