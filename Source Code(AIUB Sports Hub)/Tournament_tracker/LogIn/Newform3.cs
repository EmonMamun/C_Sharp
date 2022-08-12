﻿using System;
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

    public partial class Newform3 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Newform3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "insert into SET_SCHEDULE values (@home, @away, @date, @time)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@home", textBox1.Text);
            cmd.Parameters.AddWithValue("@away", textBox2.Text);
            cmd.Parameters.AddWithValue("@time", textBox4.Text);
            cmd.Parameters.AddWithValue("@date", textBox3.Text);
            con.Open();
           
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                /*MessageBox.Show("Successful");*/
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }

        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from SET_SCHEDULE ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection(cs);
             string query = "delete from SET_SCHEDULE where HOME_TEAM = @home";
             SqlCommand cmd = new SqlCommand(query, con);
              cmd.Parameters.AddWithValue("@home", textBox1.Text);
              cmd.Parameters.AddWithValue("@away", textBox2.Text);
              cmd.Parameters.AddWithValue("@time", textBox4.Text);
              cmd.Parameters.AddWithValue("@date", textBox3.Text);
              con.Open();
             int a = cmd.ExecuteNonQuery();
             if(a>0)
             {
             
             BindGridView();
            ResetControl();
             }
            else
            {
              MessageBox.Show("Unsuccessful");
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            /*textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*Form1 f = new Form1();
            f.Show();
            this.Hide();*/

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            Newform n1 = new Newform();
            n1.Show();
            this.Hide();

        }
    }
}
