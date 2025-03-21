namespace Calculadora
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lbl_Num1 = new System.Windows.Forms.Label();
            this.lbl_Num2 = new System.Windows.Forms.Label();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.txt_Resposta = new System.Windows.Forms.TextBox();
            this.lbl_Resposta = new System.Windows.Forms.Label();
            this.gpbOperacao = new System.Windows.Forms.GroupBox();
            this.rdb_Soma = new System.Windows.Forms.RadioButton();
            this.rdb_Subtracao = new System.Windows.Forms.RadioButton();
            this.rdb_Multiplicacao = new System.Windows.Forms.RadioButton();
            this.rdb_Divisao = new System.Windows.Forms.RadioButton();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.gpbOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Num1
            // 
            this.lbl_Num1.AutoSize = true;
            this.lbl_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Num1.Location = new System.Drawing.Point(30, 39);
            this.lbl_Num1.Name = "lbl_Num1";
            this.lbl_Num1.Size = new System.Drawing.Size(78, 20);
            this.lbl_Num1.TabIndex = 1;
            this.lbl_Num1.Text = "Número 1";
            // 
            // lbl_Num2
            // 
            this.lbl_Num2.AutoSize = true;
            this.lbl_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Num2.Location = new System.Drawing.Point(30, 103);
            this.lbl_Num2.Name = "lbl_Num2";
            this.lbl_Num2.Size = new System.Drawing.Size(78, 20);
            this.lbl_Num2.TabIndex = 2;
            this.lbl_Num2.Text = "Número 2";
            // 
            // txt_Num1
            // 
            this.txt_Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num1.Location = new System.Drawing.Point(34, 62);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(187, 26);
            this.txt_Num1.TabIndex = 0;
            // 
            // txt_Num2
            // 
            this.txt_Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Num2.Location = new System.Drawing.Point(34, 126);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(187, 26);
            this.txt_Num2.TabIndex = 1;
            // 
            // txt_Resposta
            // 
            this.txt_Resposta.Enabled = false;
            this.txt_Resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Resposta.Location = new System.Drawing.Point(34, 194);
            this.txt_Resposta.Name = "txt_Resposta";
            this.txt_Resposta.Size = new System.Drawing.Size(187, 26);
            this.txt_Resposta.TabIndex = 3;
            // 
            // lbl_Resposta
            // 
            this.lbl_Resposta.AutoSize = true;
            this.lbl_Resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resposta.Location = new System.Drawing.Point(30, 171);
            this.lbl_Resposta.Name = "lbl_Resposta";
            this.lbl_Resposta.Size = new System.Drawing.Size(78, 20);
            this.lbl_Resposta.TabIndex = 5;
            this.lbl_Resposta.Text = "Resposta";
            // 
            // gpbOperacao
            // 
            this.gpbOperacao.Controls.Add(this.rdb_Divisao);
            this.gpbOperacao.Controls.Add(this.rdb_Multiplicacao);
            this.gpbOperacao.Controls.Add(this.rdb_Subtracao);
            this.gpbOperacao.Controls.Add(this.rdb_Soma);
            this.gpbOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperacao.Location = new System.Drawing.Point(246, 39);
            this.gpbOperacao.Name = "gpbOperacao";
            this.gpbOperacao.Size = new System.Drawing.Size(246, 179);
            this.gpbOperacao.TabIndex = 7;
            this.gpbOperacao.TabStop = false;
            this.gpbOperacao.Text = "Operacões";
            // 
            // rdb_Soma
            // 
            this.rdb_Soma.AutoSize = true;
            this.rdb_Soma.Location = new System.Drawing.Point(6, 19);
            this.rdb_Soma.Name = "rdb_Soma";
            this.rdb_Soma.Size = new System.Drawing.Size(69, 24);
            this.rdb_Soma.TabIndex = 0;
            this.rdb_Soma.TabStop = true;
            this.rdb_Soma.Text = "Soma";
            this.rdb_Soma.UseVisualStyleBackColor = true;
            // 
            // rdb_Subtracao
            // 
            this.rdb_Subtracao.AutoSize = true;
            this.rdb_Subtracao.Location = new System.Drawing.Point(6, 58);
            this.rdb_Subtracao.Name = "rdb_Subtracao";
            this.rdb_Subtracao.Size = new System.Drawing.Size(101, 24);
            this.rdb_Subtracao.TabIndex = 1;
            this.rdb_Subtracao.TabStop = true;
            this.rdb_Subtracao.Text = "Subtração";
            this.rdb_Subtracao.UseVisualStyleBackColor = true;
            // 
            // rdb_Multiplicacao
            // 
            this.rdb_Multiplicacao.AutoSize = true;
            this.rdb_Multiplicacao.Location = new System.Drawing.Point(6, 92);
            this.rdb_Multiplicacao.Name = "rdb_Multiplicacao";
            this.rdb_Multiplicacao.Size = new System.Drawing.Size(118, 24);
            this.rdb_Multiplicacao.TabIndex = 2;
            this.rdb_Multiplicacao.TabStop = true;
            this.rdb_Multiplicacao.Text = "Multiplicação";
            this.rdb_Multiplicacao.UseVisualStyleBackColor = true;
            // 
            // rdb_Divisao
            // 
            this.rdb_Divisao.AutoSize = true;
            this.rdb_Divisao.Location = new System.Drawing.Point(6, 128);
            this.rdb_Divisao.Name = "rdb_Divisao";
            this.rdb_Divisao.Size = new System.Drawing.Size(78, 24);
            this.rdb_Divisao.TabIndex = 3;
            this.rdb_Divisao.TabStop = true;
            this.rdb_Divisao.Text = "Divisão";
            this.rdb_Divisao.UseVisualStyleBackColor = true;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Image = ((System.Drawing.Image)(resources.GetObject("btn_Calcular.Image")));
            this.btn_Calcular.Location = new System.Drawing.Point(644, 39);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(144, 46);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "&Calcular";
            this.btn_Calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Calcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Calcular.UseVisualStyleBackColor = true;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpar.Image")));
            this.btn_Limpar.Location = new System.Drawing.Point(644, 110);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(144, 45);
            this.btn_Limpar.TabIndex = 9;
            this.btn_Limpar.Text = "&Limpar";
            this.btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Image")));
            this.btn_Sair.Location = new System.Drawing.Point(644, 176);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(144, 44);
            this.btn_Sair.TabIndex = 10;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.gpbOperacao);
            this.Controls.Add(this.txt_Resposta);
            this.Controls.Add(this.lbl_Resposta);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.lbl_Num2);
            this.Controls.Add(this.lbl_Num1);
            this.Name = "frmCalculadora";
            this.Text = "frmCalculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.gpbOperacao.ResumeLayout(false);
            this.gpbOperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Num1;
        private System.Windows.Forms.Label lbl_Num2;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox txt_Resposta;
        private System.Windows.Forms.Label lbl_Resposta;
        private System.Windows.Forms.GroupBox gpbOperacao;
        private System.Windows.Forms.RadioButton rdb_Divisao;
        private System.Windows.Forms.RadioButton rdb_Multiplicacao;
        private System.Windows.Forms.RadioButton rdb_Subtracao;
        private System.Windows.Forms.RadioButton rdb_Soma;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Sair;
    }
}