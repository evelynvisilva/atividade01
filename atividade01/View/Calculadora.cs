using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade01.View
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt16(tbx_Valor1.Text);  
            int valor2 = Convert.ToInt16(tbx_Valor2.Text);
            int soma = valor1 + valor2;
            txt_resultado.Text = soma.ToString();
        }
    }
}
