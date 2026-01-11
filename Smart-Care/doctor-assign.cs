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
    public partial class doctor_assign : Form
    {
        string conn = @"Data Source=BILLAL\SQLEXPRESS;Initial Catalog=SmartBD;Integrated Security=True;TrustServerCertificate=True";
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

        private void doctor_assign_Load(object sender, EventArgs e)
        {
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

                SqlCommand cmd = new SqlCommand("INSERT INTO Doctors(Password, FirstName, LastName, DateOfBirth, Gender, BloodGroup, Speciality, ExperienceYears, Mobile, Email, Address) VALUES (@password, @FirstName, @LastName, @DateOfBirth, @Gender, @BloodGroup, @Speciality, @ExperienceYears, @Mobile, @Email, @Address)", con);
               
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

                //int newDoctorId = (int)cmd.ExecuteScalar();
                //dctrid.Text = newDoctorId.ToString();

                cmd.ExecuteNonQuery();

                //MessageBox.Show($"Doctor Saved Successfully ID: {newDoctorId}");

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
                    cmd.Parameters.AddWithValue("@Id", dctrid.Text);

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
            SqlConnection con = new SqlConnection(conn);
            string query = "SELECT * FROM Doctors";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            doctordatagrid.AutoGenerateColumns = true;
            doctordatagrid.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
