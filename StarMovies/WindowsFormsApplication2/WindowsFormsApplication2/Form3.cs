using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA; Data Source=XE;User ID=system; Password=system");
        public Form3(string value)
        {
            InitializeComponent();
            textBox3.Text = value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into BILL (movie_name, movie_date, movie_time) values('"  + textBox1.Text + "','" + dateTimePicker1.Text + "','" + 1200 + "')" ;   //check time
            OleDbDataAdapter oda = new OleDbDataAdapter(query, con);
            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            this.Hide();
            new Form7(textBox3.Text).Show();
        }

        private void button2_click(object sender, EventArgs e)
        {

            con.Open();
            string query = "Insert into BILL (movie_name, movie_date, movie_time) values('" + textBox1.Text + "','" + dateTimePicker1.Text + "','" + 2045 + "')";   //check time
            OleDbDataAdapter oda = new OleDbDataAdapter(query, con);
            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            this.Hide();
            new Form7(textBox3.Text).Show();
        }

        private void button3_click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into BILL (movie_name, movie_date, movie_time) values('" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + 1010 + "')";   //check time
            OleDbDataAdapter oda = new OleDbDataAdapter(query, con);
            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            this.Hide();
            new Form7(textBox3.Text).Show();
        }

        private void button4_click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into BILL (movie_name, movie_date, movie_time) values('"  + textBox2.Text + "','" + dateTimePicker1.Text + "','" + 1640 + "')";   //check time
            OleDbDataAdapter oda = new OleDbDataAdapter(query, con);
            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            this.Hide();
            new Form7(textBox3.Text).Show();
        }

        public string HowtoTrainyourDragon { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
