using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Fluxo
{
    public partial class frmFluxoCaixa : Form
    {
        public double salario;
        public frmFluxoCaixa()
        {
            InitializeComponent();
        }

        public void salarioFolha()
        {
            double salario, planoSaude = 200, resultadoCom = 0, resultadoSem;

            salario = Convert.ToDouble(txt_Salario.Text);

            if (ckb_PlanoSaude.Checked)
            {
                resultadoCom = salario - planoSaude;
                txt_SalarioFolha.Text = Convert.ToString(resultadoCom);
            }
            else
            {
                resultadoSem = salario;
                txt_SalarioFolha.Text = Convert.ToString(resultadoSem);
            }

           
            
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            salarioFolha();
        }
    }
}
