using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form7 : Form
    {
        public Form7(string value)
        {
            InitializeComponent();
            textBox1.Text = value;
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void gold(object sender, EventArgs e)
        {
            this.Hide();
            new Form8(textBox1.Text,"GOLD").Show();
        }

        private void silver(object sender, EventArgs e)
        {
            this.Hide();
            new Form8(textBox1.Text,"SILVER").Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
        }

        private void gallerie(object sender, EventArgs e)
        {
            this.Hide();
            new Form8(textBox1.Text, "GALLERIE").Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
