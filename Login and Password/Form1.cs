using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_and_Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "Anderson Assis" && textBox2.Text == "1234567")
            {
                MessageBox.Show("Bem vindo Anderson Assis!!!");
            }
            else if (textBox1.Text == "Daniele Bastos" && textBox2.Text == "7654321")
            {
                MessageBox.Show("Bem vinda Daniele Bastos!!!");
            }
            else
            {
                MessageBox.Show("Login ou Password Incorreto");
            }
        }
    }
}
