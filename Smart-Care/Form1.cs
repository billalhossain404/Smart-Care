using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Care
{
    public partial class Smartcare : Form
    {
        public Smartcare()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_login admin = new admin_login();
            admin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            D_Login doctorlogin = new D_Login();
            doctorlogin.Show();
            this.Hide();
        }

        private void bck_Click(object sender, EventArgs e)
        {
            Homepage bck = new Homepage();
            bck.Show();
            this.Hide();
        }

        private void Smartcare_Load(object sender, EventArgs e)
        {

        }

        private void Mnurse_Click(object sender, EventArgs e)
        {
            Nurse_login nrslog = new Nurse_login();
            nrslog.Show();
            this.Hide();
        }
    }
}
