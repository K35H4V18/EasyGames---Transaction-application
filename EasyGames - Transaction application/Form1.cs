using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EasyGames___Transaction_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-F8NMFSV3;Initial Catalog=TransactionApplication;Integrated Security=True");

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string ConnectionString = "Data Source=LAPTOP-F8NMFSV3;Initial Catalog=TransactionApplication;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);

                con.Open();

                String Query = "Select * from [Transaction] where ClientID = 1";
                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                dataGridView1.DataSource = table;

                con.Close();
            }

            else if (radioButton2.Checked)
            {
                string ConnectionString = "Data Source=LAPTOP-F8NMFSV3;Initial Catalog=TransactionApplication;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);

                con.Open();

                String Query = "Select * from [Transaction] where ClientID = 3";
                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                dataGridView1.DataSource = table;

                con.Close();
            }

            else if (radioButton3.Checked)
            {
                string ConnectionString = "Data Source=LAPTOP-F8NMFSV3;Initial Catalog=TransactionApplication;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);

                con.Open();

                String Query = "Select * from [Transaction] where ClientID = 2";
                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                dataGridView1.DataSource = table;

                con.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string ConnectionString = "Data Source=LAPTOP-F8NMFSV3;Initial Catalog=TransactionApplication;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string UpdatedComment = textBox1.Text;
            
            if (radioButton1.Checked)
            { 
                string Query = "UPDATE [Transaction] set Comment = '" + UpdatedComment + "' where ClientID = 1";

                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                dataGridView1.DataSource = table;

                con.Close();
            }
            else if (radioButton2.Checked)
            {
                string Query = "UPDATE [Transaction] set Comment = '" + UpdatedComment + "' where ClientID = 3";

                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                dataGridView1.DataSource = table;

                con.Close();
            }
            else if (radioButton3.Checked)
            {
                string Query = "UPDATE [Transaction] set Comment = '" + UpdatedComment + "' where ClientID = 2";

                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                dataGridView1.DataSource = table;

                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enter_Transaction enter = new Enter_Transaction();
            enter.Show();
        }
    }
}