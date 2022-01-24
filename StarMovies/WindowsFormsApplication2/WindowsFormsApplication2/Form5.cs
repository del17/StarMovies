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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == textBox2.Text)
            {
                OleDbConnection con = new OleDbConnection("Provider=MSDAORA; Data Source=XE;User ID=system; Password=system; Unicode=true");
                con.Open();
                string query = "Insert Into CUSTOMER_DETAILS (USERNAME,PASSWORD,CONFIRM_PASSWORD,EMAIL_ID) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text+ "')";
                OleDbDataAdapter oda = new OleDbDataAdapter(query, con);
                oda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sucessfully Registered!");
                this.Hide();
                new Form1().Show();
            }
        }
    }
}
