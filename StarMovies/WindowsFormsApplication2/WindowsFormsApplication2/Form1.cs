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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSDAORA; Data source=XE;User ID=system;Password=system;Unicode=True");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from customer_details where username='" + textBox1.Text + "'and password= '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                MessageBox.Show("Welcome " +textBox1.Text+ "!");
                new Form2(textBox1.Text).Show();
            }
            else
            {
                MessageBox.Show("Incorrect");
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Register now");
            new Form5().Show();
        }
    }
}
