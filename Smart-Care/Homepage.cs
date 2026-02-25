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

        private readonly string cs =
    @"Data Source=BILLAL-HOSSAIN\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";

        private void LoadDoctors(string firstNameFilter = null)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    DoctorId,
                    FirstName + ' ' + LastName AS DoctorName,
                    Speciality,
                    ExperienceYears
                FROM Doctors
                WHERE (@FirstName IS NULL OR FirstName LIKE @FirstName)
                ORDER BY DoctorId DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (string.IsNullOrWhiteSpace(firstNameFilter))
                            cmd.Parameters.AddWithValue("@FirstName", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@FirstName", firstNameFilter.Trim() + "%");

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        doctordatagrid.AutoGenerateColumns = true;
                        doctordatagrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error!! " + ex.Message, "ERROR");
            }
        }

        private void Homepage_Activated(object sender, EventArgs e)
        {
            LoadDoctors();
        }



        private void search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dctrserchbox.Text))
            {
                LoadDoctors();   // empty হলে সব দেখাবে
                return;
            }

            LoadDoctors(dctrserchbox.Text);
            dctrserchbox.Clear();

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

                string connectionString = @"Data Source=BILLAL-HOSSAIN\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string query = @" SELECT  DoctorId,  FirstName + ' ' + LastName AS DoctorName, Gender,   BloodGroup,  Speciality, ExperienceYears,  Mobile,  Email,  Address,  DateOfBirth FROM Doctors  WHERE DoctorId = @DoctorId";

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
            LoadDoctors();
        }


        private void book_Click(object sender, EventArgs e)
        {
            Payment py = new Payment();
            py.Show();
            this.Hide();
        }

        private void doctordatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
