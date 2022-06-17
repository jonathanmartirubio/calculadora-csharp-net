using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.Clases;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        tCalculadora calc = new tCalculadora();

        private void b1_Click(object sender, EventArgs e)
        {
            tbVentana.Text = tbVentana.Text + "1";
            if (calc.Operador != "")
            {
                calc.Valor2 = double.Parse(tbVentana.Text);
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            tbVentana.Text = tbVentana.Text + "2";
            if (calc.Operador != "")
            {
                calc.Valor2 = double.Parse(tbVentana.Text);
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            tbVentana.Text = tbVentana.Text + "3";
            if (calc.Operador != "")
            {
                calc.Valor2 = double.Parse(tbVentana.Text);
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            tbVentana.Text = tbVentana.Text + "4";
            if (calc.Operador != "")
            {
                calc.Valor2 = double.Parse(tbVentana.Text);
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            tbVentana.Text = tbVentana.Text + "5";
            if (calc.Operador != "")
            {
                calc.Valor2 = double.Parse(tbVentana.Text);
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            tbVentana.Text = tbVentana.Text + "6";
            if (calc.Operador != "")
            {
                calc.Valor2 = double.Parse(tbVentana.Text);
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            tbVentana.Text = tbVentana.Text + "7";
            if (calc.Operador != "")
            {
                calc.Valor2 = double.Parse(tbVentana.Text);
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            tbVentana.Text = tbVentana.Text + "8";
            if (calc.Operador != "")
            {
                calc.Valor2 = double.Parse(tbVentana.Text);
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            tbVentana.Text = tbVentana.Text + "9";
            if (calc.Operador != "")
            {
                calc.Valor2 = double.Parse(tbVentana.Text);
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            tbVentana.Text = tbVentana.Text + "0";
            if (calc.Operador != "")
            {
                calc.Valor2 = double.Parse(tbVentana.Text);
            }
        }

        private void bComa_Click(object sender, EventArgs e)
        {
            tbVentana.Text = tbVentana.Text + ",";
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            calc.Valor1 = 0;
            calc.Valor2 = 0;
            calc.Operador = "";
            tbVentana.Clear();
        }
        private void bSumar_Click(object sender, EventArgs e)
        {
            calc.Valor1 = double.Parse(tbVentana.Text);
            calc.Operador = "+";
            tbVentana.Clear();
        }
        private void bRestar_Click(object sender, EventArgs e)
        {
            calc.Valor1 = double.Parse(tbVentana.Text);
            calc.Operador = "-";
            tbVentana.Clear();
        }

        private void bMultiplicar_Click(object sender, EventArgs e)
        {
            calc.Valor1 = double.Parse(tbVentana.Text);
            calc.Operador = "*";
            tbVentana.Clear();
        }

        private void bDividir_Click(object sender, EventArgs e)
        {
            calc.Valor1 = double.Parse(tbVentana.Text);
            calc.Operador = "/";
            tbVentana.Clear();
        }

        private void bResto_Click(object sender, EventArgs e)
        {
            calc.Valor1 = double.Parse(tbVentana.Text);
            calc.Operador = "%";
            tbVentana.Clear();
        }
        private void bAlCuadrado_Click(object sender, EventArgs e)
        {
            calc.Valor1 = double.Parse(tbVentana.Text);
            tbVentana.Text = "^2";
            calc.Operador = "2";
            calc.Valor2 = 2;
        }
        private void bRaiz_Click(object sender, EventArgs e)
        {
            calc.Valor1 = double.Parse(tbVentana.Text);
            tbVentana.Text = "√" + tbVentana.Text;
            calc.Operador = "√";
        }

        private void bResultado_Click(object sender, EventArgs e)
        {
            double resultado;
            
            resultado = calc.Operar();
            tbVentana.Clear();
            tbVentana.Text = resultado.ToString();
            calc.Valor1 = resultado;
        }

    }
}
