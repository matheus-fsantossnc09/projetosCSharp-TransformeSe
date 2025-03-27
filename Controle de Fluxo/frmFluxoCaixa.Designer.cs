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
            this.SuspendLayout();
            // 
            // dtp_DataFolha
            // 
            this.dtp_DataFolha.Location = new System.Drawing.Point(32, 83);
            this.dtp_DataFolha.Name = "dtp_DataFolha";
            this.dtp_DataFolha.Size = new System.Drawing.Size(214, 20);
            this.dtp_DataFolha.TabIndex = 0;
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Location = new System.Drawing.Point(29, 131);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(39, 13);
            this.lbl_Salario.TabIndex = 1;
            this.lbl_Salario.Text = "Salário";
            // 
            // txt_Salario
            // 
            this.txt_Salario.Location = new System.Drawing.Point(32, 147);
            this.txt_Salario.Name = "txt_Salario";
            this.txt_Salario.Size = new System.Drawing.Size(219, 20);
            this.txt_Salario.TabIndex = 2;
            // 
            // ckb_PlanoSaude
            // 
            this.ckb_PlanoSaude.AutoSize = true;
            this.ckb_PlanoSaude.Location = new System.Drawing.Point(32, 207);
            this.ckb_PlanoSaude.Name = "ckb_PlanoSaude";
            this.ckb_PlanoSaude.Size = new System.Drawing.Size(102, 17);
            this.ckb_PlanoSaude.TabIndex = 3;
            this.ckb_PlanoSaude.Text = "Plano de Saúde";
            this.ckb_PlanoSaude.UseVisualStyleBackColor = true;
            // 
            // cbb_ClubeLazer
            // 
            this.cbb_ClubeLazer.FormattingEnabled = true;
            this.cbb_ClubeLazer.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbb_ClubeLazer.Location = new System.Drawing.Point(32, 289);
            this.cbb_ClubeLazer.Name = "cbb_ClubeLazer";
            this.cbb_ClubeLazer.Size = new System.Drawing.Size(219, 21);
            this.cbb_ClubeLazer.TabIndex = 4;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(487, 12);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(168, 43);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_SalarioFolha
            // 
            this.txt_SalarioFolha.Location = new System.Drawing.Point(487, 107);
            this.txt_SalarioFolha.Name = "txt_SalarioFolha";
            this.txt_SalarioFolha.Size = new System.Drawing.Size(219, 20);
            this.txt_SalarioFolha.TabIndex = 7;
            // 
            // lbl_SalarioFolha
            // 
            this.lbl_SalarioFolha.AutoSize = true;
            this.lbl_SalarioFolha.Location = new System.Drawing.Point(387, 107);
            this.lbl_SalarioFolha.Name = "lbl_SalarioFolha";
            this.lbl_SalarioFolha.Size = new System.Drawing.Size(68, 13);
            this.lbl_SalarioFolha.TabIndex = 6;
            this.lbl_SalarioFolha.Text = "Salário Folha";
            // 
            // txt_ImpostoRenda
            // 
            this.txt_ImpostoRenda.Location = new System.Drawing.Point(487, 145);
            this.txt_ImpostoRenda.Name = "txt_ImpostoRenda";
            this.txt_ImpostoRenda.Size = new System.Drawing.Size(219, 20);
            this.txt_ImpostoRenda.TabIndex = 9;
            // 
            // lbl_ImpostoRenda
            // 
            this.lbl_ImpostoRenda.AutoSize = true;
            this.lbl_ImpostoRenda.Location = new System.Drawing.Point(387, 148);
            this.lbl_ImpostoRenda.Name = "lbl_ImpostoRenda";
            this.lbl_ImpostoRenda.Size = new System.Drawing.Size(94, 13);
            this.lbl_ImpostoRenda.TabIndex = 8;
            this.lbl_ImpostoRenda.Text = "Imposto de Renda";
            // 
            // txt_SalarioLiquido
            // 
            this.txt_SalarioLiquido.Location = new System.Drawing.Point(487, 183);
            this.txt_SalarioLiquido.Name = "txt_SalarioLiquido";
            this.txt_SalarioLiquido.Size = new System.Drawing.Size(219, 20);
            this.txt_SalarioLiquido.TabIndex = 11;
            // 
            // lbl_SalarioLiquido
            // 
            this.lbl_SalarioLiquido.AutoSize = true;
            this.lbl_SalarioLiquido.Location = new System.Drawing.Point(387, 190);
            this.lbl_SalarioLiquido.Name = "lbl_SalarioLiquido";
            this.lbl_SalarioLiquido.Size = new System.Drawing.Size(76, 13);
            this.lbl_SalarioLiquido.TabIndex = 10;
            this.lbl_SalarioLiquido.Text = "Salário Liquido";
            // 
            // lbl_DataFolha
            // 
            this.lbl_DataFolha.AutoSize = true;
            this.lbl_DataFolha.Location = new System.Drawing.Point(29, 67);
            this.lbl_DataFolha.Name = "lbl_DataFolha";
            this.lbl_DataFolha.Size = new System.Drawing.Size(74, 13);
            this.lbl_DataFolha.TabIndex = 12;
            this.lbl_DataFolha.Text = "Data da Folha";
            // 
            // lbl_Clubelazer
            // 
            this.lbl_Clubelazer.AutoSize = true;
            this.lbl_Clubelazer.Location = new System.Drawing.Point(29, 273);
            this.lbl_Clubelazer.Name = "lbl_Clubelazer";
            this.lbl_Clubelazer.Size = new System.Drawing.Size(74, 13);
            this.lbl_Clubelazer.TabIndex = 13;
            this.lbl_Clubelazer.Text = "Clube de lazer";
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}