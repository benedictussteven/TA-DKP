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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button2.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }    
        private void button1_Click(object sender, EventArgs e)
        {
            int pilih1;
            int pilih2;
            int total1 = 0;
            int total2 = 0;
            int total = 0;
            int harga = 0;
            int jumlah = 0;
            pilih1 = comboBox1.SelectedIndex;
            if(comboBox1.SelectedIndex == 0)
            {
                harga = 1950000;
                jumlah = comboBox3.SelectedIndex + 1;
                total1 = harga * jumlah;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                harga = 2700000;
                jumlah = comboBox3.SelectedIndex + 1;
                total1 = harga * jumlah;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                harga = 1800000;
                jumlah = comboBox2.SelectedIndex + 1;
                total1 = harga * jumlah;
            }
            pilih2 = comboBox4.SelectedIndex;
            if (comboBox4.SelectedIndex == 0)
            {
                harga = 2700000;
                jumlah = comboBox6.SelectedIndex + 1;
                total2 = harga * jumlah;
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                harga = 2700000;
                jumlah = comboBox6.SelectedIndex + 1;
                total2 = harga * jumlah;
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                harga = 900000;
                jumlah = comboBox6.SelectedIndex + 1;
                total2 = harga * jumlah;
            }
            total = total1 + total2;
            textBox1.Text ="Total Harga Yang Perlu Dibayarkan Adalah Rp " + total +",00";
            button2.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tagihan Anda Sudah Dikirimkan Ke Email");
            button2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terimakasih Telah Berbelanja Di Toko Kami");
            Form1 f2 = new Form1();
            f2.Show();
            this.Hide();
        }
    }
    }

