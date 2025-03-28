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
            desabilitarCampos();
            carregaCombo();
        }

        public double salarioFolha = 0, impostoRenda = 0, salarioliquido = 0;


        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double salarioFolha = 0, impostoRenda = 0, salarioliquido = 0;
            try
            {

                salarioFolha = Convert.ToDouble(txt_SalarioFolha.Text);

                salarioliquido = salarioFolha - impostoRenda;

                if (salarioFolha < 2259.20)
                {
                  txt_SalarioLiquido.Text = txt_SalarioFolha.Text;
                }

                else if (salarioFolha >= 2259.21 && salarioFolha <= 2826.65)
                {
                    impostoRenda = salarioFolha * 7.5 / 100;
                    salarioliquido = (salarioFolha - (impostoRenda));

                }


                else if (salarioFolha >= 2826.66 && salarioFolha <= 3751.05)
                {
                    impostoRenda = salarioFolha * 15 / 100;
                    salarioliquido = (salarioFolha - (impostoRenda));

                }


                else if (salarioFolha >= 3751.06 && salarioFolha <= 4664.68)
                {
                    impostoRenda = salarioFolha * 22.5 / 100;
                    salarioliquido = (salarioFolha - (impostoRenda));

                }


                else if (salarioFolha > 4664.69)

                {
                    impostoRenda = salarioFolha * 27.5 / 100;
                    salarioliquido = (salarioFolha - (impostoRenda));

                }

                if (ckb_PlanoSaude.Checked)
                {
                    salarioliquido = salarioliquido - 200;

                }
                if (cbb_ClubeLazer.SelectedIndex == 0)
                {
                    salarioliquido = salarioliquido - 100;
                }
                if (cbb_ClubeLazer.SelectedIndex == 1)
                {
                    salarioliquido = salarioliquido - 50;
                }
                if (cbb_ClubeLazer.SelectedIndex == 2)
                {
                    salarioliquido = salarioliquido - 30;
                }


                txt_ImpostoRenda.Text = Convert.ToString(impostoRenda);
                txt_SalarioLiquido.Text = Convert.ToString(salarioliquido);
            }
            catch (Exception)
            {
                MessageBox.Show("Inserir o salário",
                    "Messagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        public void limparCampos()
        {
            txt_Salario.Clear();
            ckb_PlanoSaude.Checked = false;
            cbb_ClubeLazer.Text = "";
            txt_SalarioFolha.Clear();
            txt_ImpostoRenda.Clear();
            txt_SalarioLiquido.Clear();

            txt_Salario.Focus();
        }
        public void desabilitarCampos()
        {
            txt_SalarioFolha.Enabled = false;
            txt_ImpostoRenda.Enabled = false;
            txt_SalarioLiquido.Enabled = false;
        }
        public void carregaCombo()
        {
            cbb_ClubeLazer.Items.Add("Clube A");
            cbb_ClubeLazer.Items.Add("Clube B");
            cbb_ClubeLazer.Items.Add("Clube C");
        }

        private void txt_Salario_TextChanged(object sender, EventArgs e)
        {
            txt_SalarioFolha.Text = txt_Salario.Text;
        }


        private void ckb_PlanoSaude_CheckedChanged(object sender, EventArgs e)
        {



        }
    }
}
