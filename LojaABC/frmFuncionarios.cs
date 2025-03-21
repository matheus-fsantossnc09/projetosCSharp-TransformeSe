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

namespace LojaABC
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmFuncionarios()
        {
            InitializeComponent();
            desabilitadarCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal voltar = new frmMenuPrincipal();
            voltar.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abrir = new frmPesquisarFuncionarios();
            abrir.Show();
            this.Hide();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void desabilitadarCampos()
        {
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            mskCPF.Enabled = false;
            dtpDataNascimento.Enabled = false;
            mskCelular.Enabled = false;
            gpbSexo.Enabled = false;

            txtLografouro.Enabled = false;
            mskCEP.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtCidade.Enabled = false;
            txtEstado.Enabled = false;
            cbbUF.Enabled = false;

            btnNovo.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = false;
            btnLimpar.Enabled = false;
        }
        private void habilitadoCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            mskCPF.Enabled = true;
            dtpDataNascimento.Enabled = true;
            mskCelular.Enabled = true;
            gpbSexo.Enabled = true;

            txtLografouro.Enabled = true;
            mskCEP.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtCidade.Enabled = true;
            txtEstado.Enabled = true;
            cbbUF.Enabled = true;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;
        }
        private void limpandoCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mskCPF.Clear();
            dtpDataNascimento.Text = "";
            mskCelular.Clear();
            gpbSexo.Text = "";

            txtLografouro.Clear();
            mskCEP.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            cbbUF.Text = "";

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitadoCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpandoCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") ||
                txtEmail.Text.Equals("")||
                mskCPF.Text.Equals("   .   .   -")||
                mskCelular.Text.Equals("     -")||
                txtLografouro.Text.Equals("")||
                mskCEP.Text.Equals("")||
                txtNumero.Text.Equals("")||
                txtComplemento.Text.Equals("")||
                txtCidade.Text.Equals("")||
                txtEstado.Text.Equals("")||
                cbbUF.Text.Equals(""))
            {
                MessageBox.Show("Favor preencha tudo !!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Cadastrado com sucesso",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                desabilitadarCampos();
            }
            
            
        }
    }
}
