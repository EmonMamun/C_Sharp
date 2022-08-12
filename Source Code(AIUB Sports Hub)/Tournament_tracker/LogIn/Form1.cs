using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace LogIn
{
    public partial class Form1 : Form
    {
        //CS configuration System
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        


        public Form1()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                /*string a = "SUPERVISOR";*/
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from LOGIN_TABLE_DETAILS where USERNAME= @user and PASS= @pass";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    con.Close();
                    string a = "SUPERVISOR";

                    SqlConnection con2 = new SqlConnection(cs);
                    string query2 = "select * from LOGIN_TABLE_DETAILS where USERNAME= @user and PASS= @pass and CATAGORY= @ab";
                    SqlCommand cmd2 = new SqlCommand(query2, con2);
                    
                    cmd2.Parameters.AddWithValue("@user", textBox1.Text);
                    cmd2.Parameters.AddWithValue("@pass", textBox2.Text);
                    cmd2.Parameters.AddWithValue("@ab", a);


                    con2.Open();
                    SqlDataReader dr2 = cmd2.ExecuteReader();

                    if (dr2.HasRows== true)
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        student s2 = new student();
                        s2.Show();
                        this.Hide();
                    }
                    con2.Close();

                    /* MessageBox.Show("LogIn Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                    /*Form2 f2 = new Form2();
                    f2.Show();*/
                }
                else
                {
                    MessageBox.Show("LogIn Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*BasketballStudent s2 = new BasketballStudent();
                    s2.Show();*/
                }


                con.Close();

            }

            else
            {
                MessageBox.Show("please fill up boh fields", "failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            Boolean status = checkBox1.Checked;

            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                case false:
                    textBox2.UseSystemPasswordChar = true;
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
