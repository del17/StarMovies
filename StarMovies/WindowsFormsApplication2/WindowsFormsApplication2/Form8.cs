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
    public partial class Form8 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=MSDAORA; Data source=XE;User ID=system;Password=system;Unicode=True");
       
        public Form8(string value, string type)
        {
            InitializeComponent();
            textBox1.Text = value;
            con.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from seats where type='" + type + "'", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            textBox6.Text = type;
            textBox7.Text = dt.Rows[0][1].ToString();
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            int num = int.Parse(textBox2.Text);
            OleDbDataAdapter oda = new OleDbDataAdapter("Select * from bill where ticket_no='" + num + "'",con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            textBox3.Text = dt.Rows[0][1].ToString();
            textBox4.Text = dt.Rows[0][2].ToString();
            textBox5.Text = dt.Rows[0][3].ToString();
            MessageBox.Show("Collect Ticket");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
