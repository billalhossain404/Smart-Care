using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Smart_Care
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_account_create adcrt = new admin_account_create();
            adcrt.Show();
            this.Hide();

        }

        private void aloginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(alogid.Text.Trim(), out id))
                {
                    MessageBox.Show("ID must be a number!");
                    return;
                }

                string cs = @"Data Source=BILLAL-HOSSAIN\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();

                    string sql = "SELECT COUNT(1) FROM Admin_assign WHERE AdminId = @AdminId AND AdPassword = @AdPassword";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@AdminId", id);
                        cmd.Parameters.AddWithValue("@AdPassword", alogpass.Text.Trim());

                        int found = Convert.ToInt32(cmd.ExecuteScalar());

                        if (found == 1)
                        {
                            Dashboard db = new Dashboard(id);
                            db.Show();
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


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_login_Load(object sender, EventArgs e)
        {

        }
    }
}
