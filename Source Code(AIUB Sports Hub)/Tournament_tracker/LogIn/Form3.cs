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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayerRecruit p1 = new PlayerRecruit();
            p1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetSchedule s1 = new SetSchedule();
            s1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PublishResult p1 = new PublishResult();
            p1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.Show();
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

