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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
            this.Close();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }
    }
}
