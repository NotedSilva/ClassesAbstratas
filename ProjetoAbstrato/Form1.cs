namespace ProjetoAbstrato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // inicio da configuração do botão reajustar
        private void button1_Click(object sender, EventArgs e)
        {
            // definindo os apelidos para minhas classes
            Programador p1 = new Programador();
            Designer d1 = new Designer();
            DesenvolvedorWeb dw1 = new DesenvolvedorWeb();
            // definindo o tipo de atributo
            decimal salario;
            string nome;
            // fazendo a conversão que iremos ver dos atributos
            salario = Convert.ToDecimal(txtSalario.Text);
            nome = txtNome.Text;
            // criamos condições para verificar os radio button e passamos as regras
            if (rbDesenvolvedorWeb.Checked)
            {
                dw1.Salario = salario;
                dw1.Reajustar();
                lblResultado.Text = dw1.Salario.ToString();
            }
            else if (rbProgramador.Checked)
            {
                p1.Salario = salario;
                p1.Reajustar();
                lblResultado.Text = p1.Salario.ToString();
            }
            else
            {
                d1.Salario = salario;
                d1.Reajustar();
                lblResultado.Text = d1.Salario.ToString();
            }
        }
    }
}