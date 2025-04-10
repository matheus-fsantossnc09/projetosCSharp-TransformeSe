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
using MySql.Data.MySqlClient;

namespace LojaABC
{
    public partial class frmPesquisarFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();

        }
        public void limparCampos()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            btnLimpar.Enabled = false;
            btnPesquisar.Enabled = false;
            txtDescricao.Enabled = false;
            txtDescricao.Clear();
            ltbPesquisar.Items.Clear();
            txtDescricao.Focus();
        }
        public void limparCamposPesquisar()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            btnLimpar.Enabled = false;
            btnPesquisar.Enabled = false;
            txtDescricao.Enabled = false;
            txtDescricao.Clear();
            txtDescricao.Focus();
        }
        public void desabilitarCampos()
        {
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Focus();
        }


        private void frmPesquisarFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        // criando o método para pesquisar por código
        public void pesquisarCodigo(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios where codFunc = @codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codigo;
            comm.Connection = Conectado.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbPesquisar.Items.Add(DR.GetString(0));

            Conectado.fechaConexao();
        }
        public void pesquisarNome(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbFuncionarios where nome like '%"+descricao+"%';";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = descricao;

            comm.Connection = Conectado.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while(DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(0));
            }

            Conectado.fechaConexao();
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           
            /* ltbPesquisar.Items.Clear();
             ltbPesquisar.Items.Add(txtDescricao.Text);
             limparCamposPesquisar();*/
            if(rdbCodigo.Checked)
            {
                pesquisarCodigo(Convert.ToInt32(txtDescricao.Text));
            }
            if (rdbNome.Checked)
            {
                pesquisarNome(txtDescricao.Text);
            }

        }


        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }


        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            habilitarCampos();
        }
        public void habilitarCampos()
        {
            txtDescricao.Enabled = true;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            txtDescricao.Focus();
        }
       

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {

            string descricao = ltbPesquisar.SelectedItem.ToString();

            frmFuncionarios abrir = new frmFuncionarios(descricao);
            abrir.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmFuncionarios abrir = new frmFuncionarios();
            abrir.Show();
            this.Hide();
        }
    }
}
