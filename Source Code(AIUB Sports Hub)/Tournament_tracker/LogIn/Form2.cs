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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Form3 f3 = new Form3();
            f3.Show();
            this.Hide();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Supervisior_Info.Newform n2 = new Supervisior_Info.Newform();
            n2.Show();
            this.Hide();*/
            Newform n3 = new Newform();
            n3.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            
            Form1 f = new Form1();
            
            f.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Football f1 = new Football();
            f1.Show();
            this.Hide();
        }
    }
}
