using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var text1 = Convert.ToInt32(textBox1.Text);
            if (text1 > 10000)
            {
                label2.Text = "insufficient funds";
                label2.Show();
            }
            else
            {
                new Form5().Show();
                this.Hide();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
