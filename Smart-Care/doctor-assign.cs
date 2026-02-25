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
    public partial class doctor_assign : Form
    {

        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string conn = @"Data Source=BILLAL-HOSSAIN\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
        public doctor_assign()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            dctrid.Clear();
            dfirstname.Clear();
            dlastnaeme.Clear();
            dctrpassword.Clear();
            spec.Clear();
            dmobile.Clear();
            demail.Clear();
            daddress.Clear();

            dateTimePicker.Value = DateTime.Today;
            dgender.SelectedIndex = -1;
            dblood.SelectedIndex = -1;
            dexp.SelectedIndex = -1;
        }

        public bool validate()
        {
            if (string.IsNullOrWhiteSpace(dfirstname.Text) ||
                string.IsNullOrWhiteSpace(dlastnaeme.Text) ||
                string.IsNullOrWhiteSpace(dctrpassword.Text) ||
                string.IsNullOrWhiteSpace(spec.Text) ||
                string.IsNullOrWhiteSpace(dmobile.Text) ||
                string.IsNullOrWhiteSpace(daddress.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker.Text) ||
                string.IsNullOrWhiteSpace(dgender.Text) ||
                string.IsNullOrWhiteSpace(dblood.Text) ||
                string.IsNullOrWhiteSpace(dexp.Text) ||
                Regex.IsMatch(demail.Text, pattern) == false)
            {
                return false;
            }
            return true;

        }

        private void doctor_assign_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            dgender.Items.Add("Male");
            dgender.Items.Add("Female");
            dgender.Items.Add("Other");

            dblood.Items.Add("A+");
            dblood.Items.Add("A-");
            dblood.Items.Add("B+");
            dblood.Items.Add("B-");
            dblood.Items.Add("AB+");
            dblood.Items.Add("AB-");
            dblood.Items.Add("O+");
            dblood.Items.Add("O-");

            dgender.SelectedIndex = -1;
            dblood.SelectedIndex = -1;
            dexp.SelectedIndex = -1;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Dashboard bck = new Dashboard();
            bck.Show();
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dfirstname.Text) ||
               string.IsNullOrWhiteSpace(dlastnaeme.Text))
            {
                MessageBox.Show("First Name and Last Name are required");
                return;
            }

            SqlConnection con = new SqlConnection(conn);
            con.Open();

            if (dgender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Gender");
                return;
            }

            if (dblood.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Blood Group");
                return;
            }

            if (!int.TryParse(dexp.Text, out int experience))
            {
                MessageBox.Show("Experience must be a number");
                return;
            }

            try
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Doctors(Password, FirstName, LastName, DateOfBirth, Gender, BloodGroup, Speciality, ExperienceYears, Mobile, Email, Address) VALUES (@Password, @FirstName, @LastName, @DateOfBirth, @Gender, @BloodGroup, @Speciality, @ExperienceYears, @Mobile, @Email, @Address)", con);
               
                cmd.Parameters.AddWithValue("@Password", dctrpassword.Text);
                cmd.Parameters.AddWithValue("@FirstName", dfirstname.Text);
                cmd.Parameters.AddWithValue("@LastName", dlastnaeme.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@Gender", dgender.Text);
                cmd.Parameters.AddWithValue("@BloodGroup", dblood.Text);
                cmd.Parameters.AddWithValue("@Speciality", spec.Text);
                cmd.Parameters.AddWithValue("@ExperienceYears",Convert.ToInt32(dexp.Text));
                cmd.Parameters.AddWithValue("@Mobile", dmobile.Text);
                cmd.Parameters.AddWithValue("@Email", demail.Text);
                cmd.Parameters.AddWithValue("@Address", daddress.Text);


                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            LoadDoctors();
            clearAll();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dctrid.Text == "") return;

            if (MessageBox.Show("Are you sure?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string query = "DELETE FROM Doctors WHERE DoctorId=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(dctrid.Text));
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Doctor Deleted");
                LoadDoctors();
                clearAll();
            }

        }

        private void LoadDoctors()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    string query = "SELECT * FROM Doctors";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    doctordatagrid.AutoGenerateColumns = true;
                    doctordatagrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message);
            }

            clearAll();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    string connectionString = @"Data Source=BILLAL-HOSSAIN\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    string query = "UPDATE Doctors SET Password=@Password, FirstName=@FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender, BloodGroup=@BloodGroup, Speciality = @Speciality, ExperienceYears=@ExperienceYears,Mobile =@Mobile, Email=@Email,Address=@Address WHERE DoctorId=@DoctorId ";
                    SqlCommand sq3 = new SqlCommand(query, con);
                    sq3.Parameters.AddWithValue("@DoctorId", Convert.ToInt32(dctrid.Text));
                    sq3.Parameters.AddWithValue("@Password", dctrpassword.Text);
                    sq3.Parameters.AddWithValue("@FirstName", dfirstname.Text);
                    sq3.Parameters.AddWithValue("@LastName", dlastnaeme.Text);
                    sq3.Parameters.AddWithValue("@DateOfBirth", dateTimePicker.Value.Date);
                    sq3.Parameters.AddWithValue("@Gender", dgender.Text);
                    sq3.Parameters.AddWithValue("@BloodGroup", dblood.Text);
                    sq3.Parameters.AddWithValue("@Speciality", spec.Text);
                    sq3.Parameters.AddWithValue("@ExperienceYears", Convert.ToInt32(dexp.Text));
                    sq3.Parameters.AddWithValue("@Mobile", dmobile.Text);
                    sq3.Parameters.AddWithValue("@Email", demail.Text);
                    sq3.Parameters.AddWithValue("@Address", daddress.Text);
                    sq3.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();
                    LoadDoctors();
                }
                catch (Exception)
                {
                    MessageBox.Show("Update Error!!", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Update Error!!", "ERROR");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }






        private void LoadDoctors(string firstNameFilter = null)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conn))
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














        private void doctordatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = doctordatagrid.Rows[e.RowIndex];

                dctrid.Text = row.Cells["DoctorId"].Value.ToString();
                dctrpassword.Text = row.Cells["Password"].Value.ToString();
                dfirstname.Text = row.Cells["FirstName"].Value.ToString();
                dlastnaeme.Text = row.Cells["LastName"].Value.ToString();
                dateTimePicker.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                dgender.Text = row.Cells["Gender"].Value.ToString();
                dblood.Text = row.Cells["BloodGroup"].Value.ToString();
                spec.Text = row.Cells["Speciality"].Value.ToString();
                dexp.Text = row.Cells["ExperienceYears"].Value.ToString();
                dmobile.Text = row.Cells["Mobile"].Value.ToString();
                demail.Text = row.Cells["Email"].Value.ToString();
                daddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Dashboard bck = new Dashboard();
            bck.Show();
            this.Hide();
        }
    }
}
