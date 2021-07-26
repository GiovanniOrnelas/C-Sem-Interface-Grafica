using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Par_ou_Ímpar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            n = Convert.ToInt32(txtNum.Text);

            if (n % 2 == 0)
            {
                lblResultado.Text = "O número " + n.ToString() + " é PAR!";
            }

            else
            {
                lblResultado.Text = "O número " + n.ToString() + " é ÍMPAR!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNum_Click(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            txtNum.Text= "";
            lblResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            txtNum.Focus();
        }
    }
}
