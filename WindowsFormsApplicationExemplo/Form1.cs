using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationExemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ("".Equals(textBox1.Text))
            {
                label2.Text = "Por favor insira seu nome";
                label2.ForeColor = Color.Red;
            }
            else
            {
                label2.Text = "Olá, seja bem vindo: " + textBox1.Text;
                label2.ForeColor = Color.Navy;
            }
        }
    }
}
