using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double Ent1, Ent2, Result;

        private void txtEntrada1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEntrada2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
           
            Ent1 = Convert.ToDouble(txtEntrada1.Text);
            Ent2 = Convert.ToDouble(txtEntrada2.Text);

            Result = Ent1 + Ent2;

            Resultado.Text = Result.ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Ent1 = Convert.ToDouble(txtEntrada1.Text);
            Ent2 = Convert.ToDouble(txtEntrada2.Text);

            Result = Ent1 - Ent2;

            Resultado.Text = Result.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Ent1 = Convert.ToDouble(txtEntrada1.Text);
            Ent2 = Convert.ToDouble(txtEntrada2.Text);

            Result = Ent1 / Ent2;

            Resultado.Text = Result.ToString();

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Ent1 = Convert.ToDouble(txtEntrada1.Text);
            Ent2 = Convert.ToDouble(txtEntrada2.Text);

            Result = Ent1 * Ent2;

            Resultado.Text = Result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
