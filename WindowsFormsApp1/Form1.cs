using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();

            textBox1.PasswordChar = '*';
            textBox1.MaxLength = 4;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;
            MessageBox.Show("Thank you for banking with us");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory + '/' + "atm.txt";
            if (!File.Exists(path)) {

                File.CreateText(path);
                MessageBox.Show("f");
            }
            { 
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("MANDELA");

        } 
                var text1 = Convert.ToInt32(textBox1.Text);
                if (text1 == 1234 || text1 == 6666)
                {
                   
                    new Form2().Show();
                    this.Hide();
                }
                else
                {
                    label3.Text = "You have entered a wrong pin";
                    label3.Show();
                }
               if (text1 == 1234)
                {
                    label1.Text = "WELCOME MR MANDELA";
                    label1.Show();

                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch)&& ch != 8)
            {
                e.Handled = true;
            }

        }

        private void ATM_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
