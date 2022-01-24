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
    public partial class Form6 : Form
    {
        public Form6(string value)
        {
            InitializeComponent();
            textBox2.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSDAORA; Data source=XE;User ID=system;Password=system;Unicode=True");
            con.Open();
            string query = "Update customer_details set email_id='" + textBox3.Text + "'where username='"+textBox2.Text+"'";
            OleDbDataAdapter oda = new OleDbDataAdapter(query, con);
            oda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated Customer Details");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSDAORA; Data source=XE;User ID=system;Password=system;Unicode=True");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from customer_details", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2(textBox2.Text).Show();
        }
    }
}
