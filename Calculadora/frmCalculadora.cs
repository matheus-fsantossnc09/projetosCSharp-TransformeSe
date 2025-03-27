using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       public void LimparCampos()
        {
            txt_Num1.Clear();
            txt_Num2.Clear();
            txt_Resposta.Clear();
            rdb_Soma.Checked = false;
            rdb_Subtracao.Checked = false;
            rdb_Multiplicacao.Checked = false;
            rdb_Divisao.Checked = false;
            txt_Num1.Focus();

        }


        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //declarando as variáveis
            double num1, num2, resultado = 0;

            try
            {
                // inicializar as variáveis
                num1 = Convert.ToDouble(txt_Num1.Text);
                num2 = Convert.ToDouble(txt_Num2.Text);

                //criando a estrutura de decisão

                if (rdb_Soma.Checked == false && rdb_Subtracao.Checked == false &&
                    rdb_Multiplicacao.Checked == false && rdb_Divisao.Checked == false)
                {
                    MessageBox.Show("Por favor insirir um operador.",
                   "Messagem do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                    LimparCampos();
                }
                else
                {

                    if (rdb_Soma.Checked)
                    {
                        resultado = num1 + num2;

                    }
                    if (rdb_Subtracao.Checked)
                    {
                        resultado = num1 - num2;
                    }
                    if (rdb_Multiplicacao.Checked)
                    {
                        resultado = num1 * num2;
                    }
                    if (rdb_Divisao.Checked)
                    {

                        if (num2 == 0)
                        {
                            MessageBox.Show("Impossível dividir por zero",
                                "menasgem do sisitema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                            LimparCampos();

                        }
                        else
                        {
                            resultado = num1 / num2;
                        }
                    }
                }

                txt_Resposta.Text = Convert.ToString(resultado);
            }
            catch (Exception)
            {
               
                MessageBox.Show("Por favor insirir valores válidos.",
                    "Messagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                LimparCampos();
                
            }
          
        }
    }
}
