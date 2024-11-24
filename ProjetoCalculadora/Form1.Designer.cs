namespace ProjetoCalculadora
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            txtResultado = new TextBox();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnZero = new Button();
            btnVirgula = new Button();
            btnResultado = new Button();
            btnSoma = new Button();
            btnSubtracao = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnLimpar = new Button();
            lblOperador = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.HighlightText;
            txtResultado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(11, 10);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(278, 34);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(11, 55);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(65, 53);
            btnUm.TabIndex = 1;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(82, 55);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(65, 53);
            btnDois.TabIndex = 2;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(153, 55);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(65, 53);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(11, 114);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(65, 53);
            btnQuatro.TabIndex = 4;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(82, 114);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(65, 53);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(153, 114);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(65, 53);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(11, 173);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(65, 53);
            btnSete.TabIndex = 7;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(82, 173);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(65, 53);
            btnOito.TabIndex = 8;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(153, 173);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(65, 53);
            btnNove.TabIndex = 9;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(82, 232);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(65, 53);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnVirgula.ForeColor = Color.Red;
            btnVirgula.Location = new Point(11, 232);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(65, 53);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnResultado
            // 
            btnResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResultado.ForeColor = Color.Black;
            btnResultado.Location = new Point(153, 232);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(65, 53);
            btnResultado.TabIndex = 12;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnSoma.ForeColor = Color.Red;
            btnSoma.Location = new Point(224, 55);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(65, 53);
            btnSoma.TabIndex = 13;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnSubtracao.ForeColor = Color.Red;
            btnSubtracao.Location = new Point(224, 114);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(65, 53);
            btnSubtracao.TabIndex = 14;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnDivisao.ForeColor = Color.Red;
            btnDivisao.Location = new Point(224, 173);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(65, 53);
            btnDivisao.TabIndex = 15;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold);
            btnMultiplicacao.ForeColor = Color.Red;
            btnMultiplicacao.Location = new Point(224, 232);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(65, 53);
            btnMultiplicacao.TabIndex = 16;
            btnMultiplicacao.Text = "*";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(82, 294);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(136, 38);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOperador.Location = new Point(23, 16);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(0, 28);
            lblOperador.TabIndex = 25;
            lblOperador.Click += label1_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(301, 344);
            Controls.Add(lblOperador);
            Controls.Add(btnLimpar);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSoma);
            Controls.Add(btnResultado);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(txtResultado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculadora";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnZero;
        private Button btnVirgula;
        private Button btnResultado;
        private Button btnSoma;
        private Button btnSubtracao;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnLimpar;
        private Label lblOperador;
    }
}
