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
    public partial class Doctor_login : Form
    {
        string conn = @"Data Source=BILLAL\SQLEXPRESS;Initial Catalog=SmartBD;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        int loggedDoctorId; 
        public Doctor_login(int doctorId)
        {
            InitializeComponent();
            loggedDoctorId = doctorId;

        }

        private void ShowLoggedDoctorInfo()
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;

            try
            {
                con = new SqlConnection(conn);
                con.Open();

                string query = @"  SELECT   FirstName + ' ' + LastName AS DoctorName, Speciality FROM Doctors  WHERE DoctorId = @DoctorId";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DoctorId", loggedDoctorId);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    drname.Text = dr["DoctorName"].ToString();
                    drsep.Text = dr["Speciality"].ToString();
                }
                else
                {
                    drname.Text = "Unknown Doctor";
                    drsep.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error!! " + ex.Message, "ERROR");
            }
            finally
            {
                if (dr != null) dr.Close();
                if (con != null) con.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Doctor_login_Load(object sender, EventArgs e)
        {
            if (loggedDoctorId > 0)
            {
                ShowLoggedDoctorInfo();
            }

        }

        private void dctrname_Click(object sender, EventArgs e)
        {

        }
    }
}
