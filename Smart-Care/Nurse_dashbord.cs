using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Smart_Care
{
    public partial class Nurse_dashbord : Form
    {
        public Nurse_dashbord()
        {
            InitializeComponent();
        }

        private readonly string cs =
    @"Data Source=BILLAL\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=True;TrustServerCertificate=True";

        private void LoadDoctorsForNurse()
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
                    ExperienceYears,
                    Mobile,
                    Email
                FROM Doctors
                ORDER BY DoctorId DESC";

                    using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        See_Doctor_List.AutoGenerateColumns = true;
                        See_Doctor_List.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load Error: " + ex.Message, "ERROR");
            }
        }

        private void Nurse_dashbord_Load(object sender, EventArgs e)
        {
            LoadDoctorsForNurse();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nurse_info n_info = new Nurse_info();
            n_info.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nurse_login logout = new Nurse_login();
            logout.Show();
            this.Hide();
        }
    }
}
