using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    public partial class BasketballStudent : Form
    {
        public BasketballStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Apply a1 = new Apply();
            a1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeeSchedule see1 = new SeeSchedule();
            see1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeeResult r1 = new SeeResult();
            r1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            student s2 = new student();
            s2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
