namespace Componentes
{
    partial class frmComponentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponentes));
            this.gpbComponentes = new System.Windows.Forms.GroupBox();
            this.pcbImagens = new System.Windows.Forms.PictureBox();
            this.ckbBanana = new System.Windows.Forms.CheckBox();
            this.ckbMesa = new System.Windows.Forms.CheckBox();
            this.ckbComputador = new System.Windows.Forms.CheckBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.ckbLivros = new System.Windows.Forms.CheckBox();
            this.cbbListaNome = new System.Windows.Forms.ComboBox();
            this.lblListarNome = new System.Windows.Forms.Label();
            this.ltbListarProdutos = new System.Windows.Forms.ListBox();
            this.lbl_ListarProdutos = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbComponentes
            // 
            this.gpbComponentes.Controls.Add(this.btnSair);
            this.gpbComponentes.Controls.Add(this.btnLimpar);
            this.gpbComponentes.Controls.Add(this.btnCarregar);
            this.gpbComponentes.Controls.Add(this.pcbImagens);
            this.gpbComponentes.Controls.Add(this.ckbBanana);
            this.gpbComponentes.Controls.Add(this.ckbMesa);
            this.gpbComponentes.Controls.Add(this.ckbComputador);
            this.gpbComponentes.Controls.Add(this.lblEscolha);
            this.gpbComponentes.Controls.Add(this.ckbLivros);
            this.gpbComponentes.Controls.Add(this.cbbListaNome);
            this.gpbComponentes.Controls.Add(this.lblListarNome);
            this.gpbComponentes.Controls.Add(this.ltbListarProdutos);
            this.gpbComponentes.Controls.Add(this.lbl_ListarProdutos);
            this.gpbComponentes.Controls.Add(this.txtNome);
            this.gpbComponentes.Controls.Add(this.lblNome);
            this.gpbComponentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComponentes.Location = new System.Drawing.Point(22, 12);
            this.gpbComponentes.Name = "gpbComponentes";
            this.gpbComponentes.Size = new System.Drawing.Size(750, 537);
            this.gpbComponentes.TabIndex = 0;
            this.gpbComponentes.TabStop = false;
            this.gpbComponentes.Text = "Componentes";
            // 
            // pcbImagens
            // 
            this.pcbImagens.Location = new System.Drawing.Point(255, 237);
            this.pcbImagens.Name = "pcbImagens";
            this.pcbImagens.Size = new System.Drawing.Size(322, 126);
            this.pcbImagens.TabIndex = 8;
            this.pcbImagens.TabStop = false;
            this.pcbImagens.Click += new System.EventHandler(this.pcbImagens_Click);
            // 
            // ckbBanana
            // 
            this.ckbBanana.AutoSize = true;
            this.ckbBanana.Location = new System.Drawing.Point(44, 342);
            this.ckbBanana.Name = "ckbBanana";
            this.ckbBanana.Size = new System.Drawing.Size(77, 22);
            this.ckbBanana.TabIndex = 7;
            this.ckbBanana.Text = "Banana";
            this.ckbBanana.UseVisualStyleBackColor = true;
            this.ckbBanana.CheckedChanged += new System.EventHandler(this.ckbBanana_CheckedChanged);
            // 
            // ckbMesa
            // 
            this.ckbMesa.AutoSize = true;
            this.ckbMesa.Location = new System.Drawing.Point(44, 314);
            this.ckbMesa.Name = "ckbMesa";
            this.ckbMesa.Size = new System.Drawing.Size(64, 22);
            this.ckbMesa.TabIndex = 6;
            this.ckbMesa.Text = "Mesa";
            this.ckbMesa.UseVisualStyleBackColor = true;
            this.ckbMesa.CheckedChanged += new System.EventHandler(this.ckbMesa_CheckedChanged);
            // 
            // ckbComputador
            // 
            this.ckbComputador.AutoSize = true;
            this.ckbComputador.Location = new System.Drawing.Point(44, 286);
            this.ckbComputador.Name = "ckbComputador";
            this.ckbComputador.Size = new System.Drawing.Size(110, 22);
            this.ckbComputador.TabIndex = 5;
            this.ckbComputador.Text = "Computador";
            this.ckbComputador.UseVisualStyleBackColor = true;
            this.ckbComputador.CheckedChanged += new System.EventHandler(this.ckbComputador_CheckedChanged);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(41, 237);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(62, 18);
            this.lblEscolha.TabIndex = 7;
            this.lblEscolha.Text = "Escolha";
            // 
            // ckbLivros
            // 
            this.ckbLivros.AutoSize = true;
            this.ckbLivros.Location = new System.Drawing.Point(44, 258);
            this.ckbLivros.Name = "ckbLivros";
            this.ckbLivros.Size = new System.Drawing.Size(67, 22);
            this.ckbLivros.TabIndex = 4;
            this.ckbLivros.Text = "Livros";
            this.ckbLivros.UseVisualStyleBackColor = true;
            this.ckbLivros.CheckedChanged += new System.EventHandler(this.ckbLivros_CheckedChanged);
            // 
            // cbbListaNome
            // 
            this.cbbListaNome.FormattingEnabled = true;
            this.cbbListaNome.Location = new System.Drawing.Point(44, 174);
            this.cbbListaNome.Name = "cbbListaNome";
            this.cbbListaNome.Size = new System.Drawing.Size(189, 26);
            this.cbbListaNome.TabIndex = 2;
            // 
            // lblListarNome
            // 
            this.lblListarNome.AutoSize = true;
            this.lblListarNome.Location = new System.Drawing.Point(41, 153);
            this.lblListarNome.Name = "lblListarNome";
            this.lblListarNome.Size = new System.Drawing.Size(89, 18);
            this.lblListarNome.TabIndex = 4;
            this.lblListarNome.Text = "Listar Nome";
            // 
            // ltbListarProdutos
            // 
            this.ltbListarProdutos.FormattingEnabled = true;
            this.ltbListarProdutos.ItemHeight = 18;
            this.ltbListarProdutos.Location = new System.Drawing.Point(255, 86);
            this.ltbListarProdutos.Name = "ltbListarProdutos";
            this.ltbListarProdutos.Size = new System.Drawing.Size(322, 130);
            this.ltbListarProdutos.TabIndex = 3;
            // 
            // lbl_ListarProdutos
            // 
            this.lbl_ListarProdutos.AutoSize = true;
            this.lbl_ListarProdutos.Location = new System.Drawing.Point(256, 65);
            this.lbl_ListarProdutos.Name = "lbl_ListarProdutos";
            this.lbl_ListarProdutos.Size = new System.Drawing.Size(109, 18);
            this.lbl_ListarProdutos.TabIndex = 2;
            this.lbl_ListarProdutos.Text = "Listar Produtos";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(44, 86);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(189, 24);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(41, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(451, 391);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(126, 41);
            this.btnCarregar.TabIndex = 9;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(451, 440);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(126, 41);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(451, 490);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(126, 41);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmComponentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbComponentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmComponentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComponentes";
            this.gpbComponentes.ResumeLayout(false);
            this.gpbComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbComponentes;
        private System.Windows.Forms.CheckBox ckbBanana;
        private System.Windows.Forms.CheckBox ckbMesa;
        private System.Windows.Forms.CheckBox ckbComputador;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.CheckBox ckbLivros;
        private System.Windows.Forms.ComboBox cbbListaNome;
        private System.Windows.Forms.Label lblListarNome;
        private System.Windows.Forms.ListBox ltbListarProdutos;
        private System.Windows.Forms.Label lbl_ListarProdutos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbImagens;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCarregar;
    }
}