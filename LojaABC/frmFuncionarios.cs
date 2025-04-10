using MosaicoSolutions.ViaCep;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


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
        public frmFuncionarios(string descricao)
        {
            InitializeComponent();
            desabilitadarCampos();
            txtNome.Text = descricao;
            habilitadoCampospesquisar();
            pesquisarNome(txtNome.Text);
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
            abrir.ShowDialog();
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
            txtBairro.Enabled = false;
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
            txtBairro.Enabled = true;
            cbbUF.Enabled = true;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;
        }
        private void habilitadoCampospesquisar()
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
            txtBairro.Enabled = true;
            cbbUF.Enabled = true;

            btnNovo.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCadastrar.Enabled = false;
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

            rbtFeminino.Enabled = false;
            rbtMasculino.Enabled = false;
            rbtNaoDesejoInformar.Enabled = false;

            txtLografouro.Clear();
            mskCEP.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            cbbUF.Text = "";

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = true;
            btnLimpar.Enabled = true;

            btnNovo.Enabled = false;
            txtNome.Focus();
        }
        

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitadoCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpandoCampos();
        }
        public void pesquisarNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbFuncionarios where nome = @nome;";
            comm.CommandType = CommandType.Text;
 
            comm.Parameters.Clear();
            comm.Parameters.Add("nome",MySqlDbType.VarChar, 100).Value = nome;
            comm.Connection = Conectado.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mskCPF.Text = DR.GetString(3);
            mskCelular.Text = DR.GetString(4);
            dtpDataNascimento.Value = DR.GetDateTime(5);
            string sexo = DR.GetString(6);
            if (sexo == "F")
            {
                rbtFeminino.Checked = true;
            }
            if (sexo == "M")
            {
                rbtMasculino.Checked = true;
            }
            if (sexo == "N")
            {
                rbtNaoDesejoInformar.Checked = true;
            }

            txtLografouro.Text = DR.GetString(7);
            mskCEP.Text = DR.GetString(8);
            txtNumero.Text = DR.GetString(9);
            txtComplemento.Text = DR.GetString(10);
            txtBairro.Text = DR.GetString(11);
            txtCidade.Text = DR.GetString(12);
            cbbUF.Text = DR.GetString(13);

            Conectado.fechaConexao();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") ||
                txtEmail.Text.Equals("") ||
                mskCPF.Text.Equals("   .   .   -") ||
                mskCelular.Text.Equals("     -") ||
                txtLografouro.Text.Equals("") ||
                mskCEP.Text.Equals("") ||
                txtNumero.Text.Equals("") ||
                txtComplemento.Text.Equals("") ||
                txtCidade.Text.Equals("") ||
                txtBairro.Text.Equals("") ||
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
                if (cadastrarFuncionarios() == 1)
                {

                    MessageBox.Show("Cadastrado com sucesso",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    desabilitadarCampos();
                    limpandoCampos();
                    btnCadastrar.Enabled = true;
                    btnNovo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar");
                }
            }
        }
        public int cadastrarFuncionarios()
        {
            MySqlCommand conec = new MySqlCommand();
            conec.CommandText = "insert into tbFuncionarios(nome,email,cpf,dataNasc,telCel,sexo,logradouro,cep, numero,complemento, bairro, cidade,uf)values(@nome,@email,@cpf,@dataNasc,@telCel,@sexo,@logradouro,@cep,@numero,@complemento,@bairro,@cidade,@uf);";
            conec.CommandType = CommandType.Text;

            conec.Parameters.Clear();
            conec.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = txtNome.Text;
            conec.Parameters.Add("@email",MySqlDbType.VarChar,100).Value = txtEmail.Text;
            conec.Parameters.Add("@cpf",MySqlDbType.VarChar,14).Value = mskCPF.Text;
            conec.Parameters.Add("@dataNasc",MySqlDbType.Date).Value = dtpDataNascimento.Text;
            conec.Parameters.Add("@telCel",MySqlDbType.VarChar,10).Value = mskCelular.Text;
            if(rbtMasculino.Checked)
            {
                conec.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "M";
            }
            if (rbtFeminino.Checked)
            {
                conec.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "F";
            }
            if (rbtNaoDesejoInformar.Checked)
            {
                conec.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "N";
            }

            conec.Parameters.Add("@logradouro",MySqlDbType.VarChar,100).Value = txtLografouro.Text;
            conec.Parameters.Add("@cep",MySqlDbType.VarChar,9).Value = mskCEP.Text;
            conec.Parameters.Add("@numero",MySqlDbType.VarChar,10).Value = txtNumero.Text;
            conec.Parameters.Add("@complemento",MySqlDbType.VarChar,100).Value = txtComplemento.Text;
            conec.Parameters.Add("@bairro",MySqlDbType.VarChar,100).Value = txtBairro.Text;
            conec.Parameters.Add("@cidade",MySqlDbType.VarChar,100).Value = txtCidade.Text;
            conec.Parameters.Add("@uf",MySqlDbType.VarChar,2).Value = cbbUF.Text;

            conec.Connection = Conectado.obterConexao();
            int resp = conec.ExecuteNonQuery();
           
            Conectado.fechaConexao();
            return resp;

        }
        public void buscarCEP(string CEP)
        {
            var viaCEPService = ViaCepService.Default();
            try
            {


                var endereco = viaCEPService.ObterEndereco(CEP);

                txtLografouro.Text = endereco.Logradouro;
                txtComplemento.Text = endereco.Complemento;
                txtCidade.Text = endereco.Localidade;
                txtBairro.Text = endereco.Bairro;
                cbbUF.Text = endereco.UF;
            }
            catch(Exception) 
            {
                MessageBox.Show("Insire o CEP válido",
                    "Messagem do sitema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                mskCEP.Focus();
                mskCEP.Clear();
            }
        }

        private void mskCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buscarCEP(mskCEP.Text);
                txtNumero.Focus();
            }
        }


        private void gpbEndereco_Enter(object sender, EventArgs e)
        {

        }
        // alterando registros
        public int alterarFuncionario(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbFuncionarios set nome = @nome,email = @email,cpf = @cpf, dataNasc = @dataNasc,telCel = @telCel,sexo = @sexo,logradouro = @logradouro,cep = @cep, numero = @numero,complemento = @complemento,bairro = @bairro,cidade = @cidade, uf = @uf where codFunc = @codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            comm.Parameters.Add("@dataNasc", MySqlDbType.Date).Value = dtpDataNascimento.Text;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 10).Value = mskCelular.Text;
            if (rbtMasculino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "M";
            }
            if (rbtFeminino.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "F";
            }
            if (rbtNaoDesejoInformar.Checked)
            {
                comm.Parameters.Add("@sexo", MySqlDbType.VarChar, 1).Value = "N";
            }

            comm.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = txtLografouro.Text;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = mskCEP.Text;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = txtNumero.Text;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 100).Value = txtComplemento.Text;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
            comm.Parameters.Add("@uf", MySqlDbType.VarChar, 2).Value = cbbUF.Text; 
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codFunc;

            comm.Connection = Conectado.obterConexao();
            int resp = comm.ExecuteNonQuery();

            Conectado.fechaConexao();
            return resp;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals("") ||
              txtEmail.Text.Equals("") ||
              mskCPF.Text.Equals("   .   .   -") ||
              mskCelular.Text.Equals("     -") ||
              txtLografouro.Text.Equals("") ||
              mskCEP.Text.Equals("") ||
              txtNumero.Text.Equals("") ||
              txtComplemento.Text.Equals("") ||
              txtCidade.Text.Equals("") ||
              txtBairro.Text.Equals("") ||
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
                if (alterarFuncionario(Convert.ToInt32(txtCodigo.Text)) == 1)
                {

                    MessageBox.Show("Alterado com sucesso",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
                    desabilitadarCampos();
                    limpandoCampos();
                    btnCadastrar.Enabled = true;
                    btnNovo.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao alterar");
                }
            }
        }
        // Excluir registros
        public int excluirFuncionarios(int codFunc)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbFuncionarios where codFunc = codFunc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conectado.obterConexao();

            comm.Parameters.Clear();
            comm.Parameters.Add("@codFunc", MySqlDbType.Int32).Value = codFunc;

            int resp = comm.ExecuteNonQuery();
            Conectado.fechaConexao();
            return resp;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir",
                "Messagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if(result == DialogResult.Yes)
            {
                excluirFuncionarios(Convert.ToInt32(txtCodigo.Text));
                limpandoCampos();
            }
            else
            {

            }
            
           
        }
    }
}
