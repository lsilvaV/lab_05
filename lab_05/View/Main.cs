using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_05.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = 0;
            int quadrado = 0;

            if (tbxNum.Text.Equals(""))
                    
            {
                MessageBox.Show("Insira um número");
            }
            else 
            {
                num = Convert.ToInt32(tbxNum.Text);
                quadrado = num * num;
                lblResultado.Text = "O número " + num + " ao quadrado é: " + quadrado.ToString();
                tbxNum.Focus();
                tbxNum.SelectAll();
            }

        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                btnCalcular.PerformClick();
            }

            if (e.KeyChar == 12)
            {
                tbxNum.Text = "";
            }

        }
    }
}
