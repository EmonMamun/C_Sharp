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
    public partial class SetSchedule : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public SetSchedule()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into SET_SCHEDULE_BASKETBALL_MATCH values (@home, @away, @time, @date)";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@home", textBox1.Text);
            cmd.Parameters.AddWithValue("@away", textBox2.Text);
            cmd.Parameters.AddWithValue("@date", textBox3.Text);
            cmd.Parameters.AddWithValue("@time", textBox4.Text);
            

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

            con.Close();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from SET_SCHEDULE_BASKETBALL_MATCH ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

        void ResetControl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void SetSchedule_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update SET_SCHEDULE_BASKETBALL_MATCH set HOME_TEAM=@home, AWAY_TEAM=@away,MATCH_TIME=@time,MATCH_DATE=@date where HOME_TEAM=@home and AWAY_TEAM= @away";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@home", textBox1.Text);
            cmd.Parameters.AddWithValue("@away", textBox2.Text);
            cmd.Parameters.AddWithValue("@time", textBox4.Text);
            cmd.Parameters.AddWithValue("@date", textBox3.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
               /* MessageBox.Show("Update Successful");*/
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from SET_SCHEDULE_BASKETBALL_MATCH where HOME_TEAM=@home";
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@home", textBox1.Text);
            cmd.Parameters.AddWithValue("@away", textBox2.Text);
            cmd.Parameters.AddWithValue("@time", textBox4.Text);
            cmd.Parameters.AddWithValue("@date", textBox3.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                /*MessageBox.Show("Delete Successful");*/
                BindGridView();
                ResetControl();
            }
            else
            {
                MessageBox.Show("Unsuccessful");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
           
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
