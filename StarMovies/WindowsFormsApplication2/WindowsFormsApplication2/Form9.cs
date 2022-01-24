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
    public partial class Form9 : Form
    {
        public Form9(string value)
        {
            InitializeComponent();
            textBox1.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                OleDbConnection con = new OleDbConnection("Provider=MSDAORA; Data source=XE;User ID=system;Password=system;Unicode=True");
                con.Open();
                int num = int.Parse(textBox2.Text);
                string query = "Delete from bill where ticket_no='" + num + "'";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                DialogResult dr = MessageBox.Show("Do you want to delete the entry?", "Yes?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    oda.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Successfully Cancelled the Ticket");
                }
                    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=MSDAORA; Data source=XE;User ID=system;Password=system;Unicode=True");
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from Bill", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2(textBox1.Text).Show();
        }
    }
}
