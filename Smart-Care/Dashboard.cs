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
    public partial class Dashboard : Form
    {

        int userid;
        public Dashboard(int id)
        {
            InitializeComponent();
            userid = id;
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctor_assign newdctr = new doctor_assign();
            newdctr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Smartcare bck = new Smartcare();
            bck.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void bdnurse_Click(object sender, EventArgs e)
        {
            Add_Nurse nrs = new Add_Nurse();
            nrs.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchEmployeeForm emp = new SearchEmployeeForm();
            emp.Show();
            this.Hide();
        }

        private void dbambulance_Click(object sender, EventArgs e)
        {
            Ambulance ambu = new Ambulance();
            ambu.Show();
            this.Hide();
        }
    }
}
