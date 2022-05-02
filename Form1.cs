using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula53_Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
      

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string funcionario = txtColaborador.Text;
            double salario = double.Parse(txtSalarioBruto.Text);


            if (rdnCLT.Checked)
            {

                double desconto = salario * 0.06;
                double descontoInss = salario * 0.08;
                double liquido = salario - desconto - descontoInss;

             txtResultado.Text = "O Salário líquido é: " + liquido;
            }
            
        }

        private void rdnPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnPJ.Checked)
            {
                string funcionario = txtColaborador.Text;
                double salario = double.Parse(txtSalarioBruto.Text);
                double desconto = salario * 0.06;
                double liquido = salario - desconto;
                txtResultado.Text = "O Salário é: " + liquido;
            }
        }

        private void rdnFree_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnFree.Checked)
            {
                double salario = double.Parse(txtSalarioBruto.Text);

                double valor = double.Parse(txtSalarioBruto.Text);
                double bonus = valor * 0.085;
                double liquido = salario + bonus;

                txtResultado.Text = "O Salário bonificado é: " + liquido;
            }
        }
    }
}
