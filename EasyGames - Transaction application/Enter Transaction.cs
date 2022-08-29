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
    public partial class Enter_Transaction : Form
    {
        public Enter_Transaction()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string ConnectionString = "Data Source=LAPTOP-F8NMFSV3;Initial Catalog=TransactionApplication;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            int Amount;
            Amount = int.Parse(textBox1.Text);
            string Comment = textBox2.Text;

            //ClientID 1

            if ((radioButton1.Checked) && (radioButton4.Checked))
            {
                     string Query = "Insert into [Transaction] values ('" + textBox1 + "',1,1,'" + textBox2 + "')";

                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                con.Close();
   
            }
            else if ((radioButton1.Checked) && (radioButton5.Checked))
            {
                string Query = "Insert into [Transaction] values ('" + textBox1 + "',2,1,'" + textBox2 + "')";

                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                con.Close();
            }

            //ClientID 3

            else if ((radioButton2.Checked) && (radioButton4.Checked))
            {
                string Query = "Insert into [Transaction] values ('" + textBox1 + "',1,3,'" + textBox2 + "')";

                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                con.Close();
            }
            else if ((radioButton2.Checked) && (radioButton5.Checked))
            {
                string Query = "Insert into [Transaction] values ('" + textBox1 + "',2,3,'" + textBox2 + "')";

                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                con.Close();
            }


            //ClientID 2

            else if ((radioButton3.Checked) && (radioButton4.Checked))
            { 
                string Query = "Insert into [Transaction] values ('" + textBox1 + "',1,2,'" + textBox2 + "')";

                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                con.Close();
            }

            else if ((radioButton3.Checked) && (radioButton5.Checked))
            {
                string Query = "Insert into [Transaction] values ('" + textBox1 + "',2,2,'" + textBox2 + "')";

                SqlCommand cmd = new SqlCommand(Query, con);

                var reader = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);

                con.Close();
            }

                }
            }
        }