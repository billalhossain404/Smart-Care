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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Smart_Care
{
    public partial class admin_account_create : Form
    {

        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        public admin_account_create()
        {
            InitializeComponent();
            getuserid();
        }

        public void getuserid()
        {
            try
            {
                string connectionString = @"Data Source=BILLAL-HOSSAIN\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(AdminId AS INT)),0)+1 FROM Admin_assign", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                id.Text = dt.Rows[0][0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error", ex.Message);
            }
        }
        private void resetfield()
        {
            getuserid();
            aname.Clear();
            apass.Clear();
            aage.Clear();
            aemail.Clear();
        }
        public bool validate()
        {
            if (string.IsNullOrWhiteSpace(id.Text) ||
                string.IsNullOrWhiteSpace(aname.Text) ||
                string.IsNullOrWhiteSpace(apass.Text) ||
                string.IsNullOrWhiteSpace(aage.Text) ||
                string.IsNullOrWhiteSpace(aemail.Text) ||
                Regex.IsMatch(aemail.Text, pattern) == false)
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_login back = new admin_login();
            back.Show();
            this.Hide();
        }

        private void signup_userid_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validate() == true)
            {
                try
                {
                    getuserid();
                    SqlConnection con = new SqlConnection(@"Data Source=BILLAL-HOSSAIN\SQLEXPRESS;Initial Catalog=SmartCare;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
                    con.Open();
                    SqlCommand sq2 = new SqlCommand("INSERT INTO Admin_assign (AdName, AdPassword, Age, Email) VALUES (@AdName, @AdPassword, @Age, @Email)", con);
                    // sq2.Parameters.AddWithValue("@ID", int.Parse(id.Text));
                    sq2.Parameters.AddWithValue("@AdName", aname.Text);
                    sq2.Parameters.AddWithValue("@AdPassword", Convert.ToInt32(apass.Text));
                    sq2.Parameters.AddWithValue("@Age", int.Parse(aage.Text));
                    sq2.Parameters.AddWithValue("@Email", aemail.Text);
                    sq2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Registered Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetfield();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields and Email form.", "Validation Error");
            }
        }

        private void admin_account_create_Load(object sender, EventArgs e)
        {

        }
    }
}
