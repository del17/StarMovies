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
    public partial class Form2 : Form
    {
        public Form2(string value)
        {
            InitializeComponent();
            textBox1.Text = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3(textBox1.Text).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4(textBox1.Text).Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form9(textBox1.Text).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form6(textBox1.Text).Show();
        }
    }
}
