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
    public partial class FootballStudent : Form
    {
        public FootballStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            student f1 = new student();
            f1.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FootballApply f1 = new FootballApply();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeeScheduleFootball f1 = new SeeScheduleFootball();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FootballSeeResult f1 = new FootballSeeResult();
            f1.Show();
            this.Hide();
        }
    }
}
