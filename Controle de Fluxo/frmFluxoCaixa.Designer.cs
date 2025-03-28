namespace Controle_de_Fluxo
{
    partial class frmFluxoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFluxoCaixa));
            this.dtp_DataFolha = new System.Windows.Forms.DateTimePicker();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.txt_Salario = new System.Windows.Forms.TextBox();
            this.ckb_PlanoSaude = new System.Windows.Forms.CheckBox();
            this.cbb_ClubeLazer = new System.Windows.Forms.ComboBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_SalarioFolha = new System.Windows.Forms.TextBox();
            this.lbl_SalarioFolha = new System.Windows.Forms.Label();
            this.txt_ImpostoRenda = new System.Windows.Forms.TextBox();
            this.lbl_ImpostoRenda = new System.Windows.Forms.Label();
            this.txt_SalarioLiquido = new System.Windows.Forms.TextBox();
            this.lbl_SalarioLiquido = new System.Windows.Forms.Label();
            this.lbl_DataFolha = new System.Windows.Forms.Label();
            this.lbl_Clubelazer = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_DataFolha
            // 
            this.dtp_DataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DataFolha.Location = new System.Drawing.Point(44, 86);
            this.dtp_DataFolha.Name = "dtp_DataFolha";
            this.dtp_DataFolha.Size = new System.Drawing.Size(89, 22);
            this.dtp_DataFolha.TabIndex = 0;
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salario.Location = new System.Drawing.Point(40, 131);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(50, 16);
            this.lbl_Salario.TabIndex = 1;
            this.lbl_Salario.Text = "Salário";
            // 
            // txt_Salario
            // 
            this.txt_Salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Salario.Location = new System.Drawing.Point(43, 147);
            this.txt_Salario.Name = "txt_Salario";
            this.txt_Salario.Size = new System.Drawing.Size(219, 22);
            this.txt_Salario.TabIndex = 1;
            this.txt_Salario.TextChanged += new System.EventHandler(this.txt_Salario_TextChanged);
            // 
            // ckb_PlanoSaude
            // 
            this.ckb_PlanoSaude.AutoSize = true;
            this.ckb_PlanoSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_PlanoSaude.Location = new System.Drawing.Point(43, 190);
            this.ckb_PlanoSaude.Name = "ckb_PlanoSaude";
            this.ckb_PlanoSaude.Size = new System.Drawing.Size(123, 20);
            this.ckb_PlanoSaude.TabIndex = 3;
            this.ckb_PlanoSaude.Text = "Plano de Saúde";
            this.ckb_PlanoSaude.UseVisualStyleBackColor = true;
            this.ckb_PlanoSaude.CheckedChanged += new System.EventHandler(this.ckb_PlanoSaude_CheckedChanged);
            // 
            // cbb_ClubeLazer
            // 
            this.cbb_ClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ClubeLazer.FormattingEnabled = true;
            this.cbb_ClubeLazer.Location = new System.Drawing.Point(43, 246);
            this.cbb_ClubeLazer.Name = "cbb_ClubeLazer";
            this.cbb_ClubeLazer.Size = new System.Drawing.Size(219, 24);
            this.cbb_ClubeLazer.TabIndex = 2;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Image = ((System.Drawing.Image)(resources.GetObject("btn_Calcular.Image")));
            this.btn_Calcular.Location = new System.Drawing.Point(522, 236);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(168, 43);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Calcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_SalarioFolha
            // 
            this.txt_SalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SalarioFolha.Location = new System.Drawing.Point(522, 107);
            this.txt_SalarioFolha.Name = "txt_SalarioFolha";
            this.txt_SalarioFolha.Size = new System.Drawing.Size(219, 22);
            this.txt_SalarioFolha.TabIndex = 3;
            // 
            // lbl_SalarioFolha
            // 
            this.lbl_SalarioFolha.AutoSize = true;
            this.lbl_SalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalarioFolha.Location = new System.Drawing.Point(398, 107);
            this.lbl_SalarioFolha.Name = "lbl_SalarioFolha";
            this.lbl_SalarioFolha.Size = new System.Drawing.Size(87, 16);
            this.lbl_SalarioFolha.TabIndex = 6;
            this.lbl_SalarioFolha.Text = "Salário Folha";
            // 
            // txt_ImpostoRenda
            // 
            this.txt_ImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ImpostoRenda.Location = new System.Drawing.Point(522, 145);
            this.txt_ImpostoRenda.Name = "txt_ImpostoRenda";
            this.txt_ImpostoRenda.Size = new System.Drawing.Size(219, 22);
            this.txt_ImpostoRenda.TabIndex = 4;
            // 
            // lbl_ImpostoRenda
            // 
            this.lbl_ImpostoRenda.AutoSize = true;
            this.lbl_ImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImpostoRenda.Location = new System.Drawing.Point(398, 148);
            this.lbl_ImpostoRenda.Name = "lbl_ImpostoRenda";
            this.lbl_ImpostoRenda.Size = new System.Drawing.Size(118, 16);
            this.lbl_ImpostoRenda.TabIndex = 8;
            this.lbl_ImpostoRenda.Text = "Imposto de Renda";
            // 
            // txt_SalarioLiquido
            // 
            this.txt_SalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SalarioLiquido.Location = new System.Drawing.Point(522, 184);
            this.txt_SalarioLiquido.Name = "txt_SalarioLiquido";
            this.txt_SalarioLiquido.Size = new System.Drawing.Size(219, 22);
            this.txt_SalarioLiquido.TabIndex = 5;
            // 
            // lbl_SalarioLiquido
            // 
            this.lbl_SalarioLiquido.AutoSize = true;
            this.lbl_SalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalarioLiquido.Location = new System.Drawing.Point(398, 190);
            this.lbl_SalarioLiquido.Name = "lbl_SalarioLiquido";
            this.lbl_SalarioLiquido.Size = new System.Drawing.Size(97, 16);
            this.lbl_SalarioLiquido.TabIndex = 10;
            this.lbl_SalarioLiquido.Text = "Salário Liquido";
            // 
            // lbl_DataFolha
            // 
            this.lbl_DataFolha.AutoSize = true;
            this.lbl_DataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataFolha.Location = new System.Drawing.Point(40, 67);
            this.lbl_DataFolha.Name = "lbl_DataFolha";
            this.lbl_DataFolha.Size = new System.Drawing.Size(92, 16);
            this.lbl_DataFolha.TabIndex = 12;
            this.lbl_DataFolha.Text = "Data da Folha";
            // 
            // lbl_Clubelazer
            // 
            this.lbl_Clubelazer.AutoSize = true;
            this.lbl_Clubelazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clubelazer.Location = new System.Drawing.Point(40, 230);
            this.lbl_Clubelazer.Name = "lbl_Clubelazer";
            this.lbl_Clubelazer.Size = new System.Drawing.Size(93, 16);
            this.lbl_Clubelazer.TabIndex = 13;
            this.lbl_Clubelazer.Text = "Clube de lazer";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpar.Image")));
            this.btn_Limpar.Location = new System.Drawing.Point(522, 301);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(168, 43);
            this.btn_Limpar.TabIndex = 14;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Image")));
            this.btn_Sair.Location = new System.Drawing.Point(522, 364);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(168, 43);
            this.btn_Sair.TabIndex = 15;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.lbl_Clubelazer);
            this.Controls.Add(this.lbl_DataFolha);
            this.Controls.Add(this.txt_SalarioLiquido);
            this.Controls.Add(this.lbl_SalarioLiquido);
            this.Controls.Add(this.txt_ImpostoRenda);
            this.Controls.Add(this.lbl_ImpostoRenda);
            this.Controls.Add(this.txt_SalarioFolha);
            this.Controls.Add(this.lbl_SalarioFolha);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.cbb_ClubeLazer);
            this.Controls.Add(this.ckb_PlanoSaude);
            this.Controls.Add(this.txt_Salario);
            this.Controls.Add(this.lbl_Salario);
            this.Controls.Add(this.dtp_DataFolha);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFluxoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_DataFolha;
        private System.Windows.Forms.Label lbl_Salario;
        private System.Windows.Forms.TextBox txt_Salario;
        private System.Windows.Forms.CheckBox ckb_PlanoSaude;
        private System.Windows.Forms.ComboBox cbb_ClubeLazer;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_SalarioFolha;
        private System.Windows.Forms.Label lbl_SalarioFolha;
        private System.Windows.Forms.TextBox txt_ImpostoRenda;
        private System.Windows.Forms.Label lbl_ImpostoRenda;
        private System.Windows.Forms.TextBox txt_SalarioLiquido;
        private System.Windows.Forms.Label lbl_SalarioLiquido;
        private System.Windows.Forms.Label lbl_DataFolha;
        private System.Windows.Forms.Label lbl_Clubelazer;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Sair;
    }
}