namespace ProjetoCalculadora
{
    public partial class Calculadora : Form
    {
        private decimal Valor { get; set; }
        private decimal Resultado { get; set; }
        private Operador OperacaoSelecionada { get; set; }

        enum Operador
        {
            Adicao,
            Subtracao,
            Divisao,
            Multiplicacao
        }
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 1;
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 2;

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 3;

        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 4;

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 5;

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 6;

        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 7;

        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 8;

        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 9;

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += 0;

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(",") && (txtResultado.Text != ""))
            {
                txtResultado.Text += ",";
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDecimal(txtResultado.Text);
            OperacaoSelecionada = Operador.Adicao;
            lblOperador.Text = "+";
            txtResultado.Text = "";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDecimal(txtResultado.Text);
            OperacaoSelecionada = Operador.Subtracao;
            lblOperador.Text = "+";
            txtResultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDecimal(txtResultado.Text);
            OperacaoSelecionada = Operador.Divisao;
            lblOperador.Text = "÷";
            txtResultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Valor = Convert.ToDecimal(txtResultado.Text);
            OperacaoSelecionada = Operador.Multiplicacao;
            txtResultado.Text = "";
            lblOperador.Text = "x";
            txtResultado.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperador.Text = "";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operador.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;

                case Operador.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;

                case Operador.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;

                case Operador.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;

            }
            txtResultado.Text = "";
            txtResultado.Text = Resultado.ToString();
        }
    }
}
