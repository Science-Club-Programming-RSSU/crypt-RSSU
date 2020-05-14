using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool onoff = false;
        Random r = new Random();
        int value;

        public void crypt(bool encryption = true) 
        {
            string text = textBox1.Text;
            textBox1.Clear();
            int number = Convert.ToInt32(textBox2.Text);

            for (int i = 0; i < text.Length; i++)
                textBox1.Text += encryption ? (char)(text[i] + number) : (char)(text[i] - number);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                crypt();
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) 
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value = r.Next();
            textBox2.Text = value.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            value = r.Next();
            textBox2.Text = value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                crypt(false);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
