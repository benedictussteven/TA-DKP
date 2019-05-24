using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "steven" && textBox2.Text == "123456")
                {
                    MessageBox.Show("Login Berhasil");
                    this.Hide();
                    Form3 f2 = new Form3();
                    f2.Show();
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("Username Tidak Boleh Kosong");
                    textBox2.Text = String.Empty;
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Password Tidak Boleh Kosong");
                    textBox1.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Login Gagal");
                    textBox1.Text = String.Empty;
                    textBox2.Text = String.Empty;
                }                               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
