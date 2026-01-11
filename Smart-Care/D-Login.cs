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
    public partial class D_Login : Form
    {
        public D_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aloginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(dctruser.Text.Trim(), out id))
                {
                    MessageBox.Show("ID must be a number!");
                    return;
                }

                string cs = @"Data Source=BILLAL\SQLEXPRESS;Initial Catalog=SmartBD;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string sql3 = "SELECT COUNT(1) FROM Doctors WHERE DoctorId = @DoctorId AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(sql3, con))
                    {
                        cmd.Parameters.AddWithValue("@DoctorId", id);
                        cmd.Parameters.AddWithValue("@Password", dctrpass.Text.Trim());

                        int found = Convert.ToInt32(cmd.ExecuteScalar());

                        if (found == 1)
                        {
                            Doctor_login newdctr = new Doctor_login();
                            newdctr.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID or password!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void D_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
