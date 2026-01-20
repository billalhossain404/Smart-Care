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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage db = new Homepage();
            db.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bill_summary bl = new bill_summary();
            bl.Show();
            this.Hide();
        }
    }
}
