using System;
using System.Windows.Forms;
using Dominio.ModuloDisciplina;
using FluentValidation.Results;

namespace TestesMariana.ModuloDisciplina
{
    public partial class TelaCadastroDisciplinasForm : Form
    {

        public TelaCadastroDisciplinasForm()
        {
            InitializeComponent();
        }
        private Disciplina disciplina;

        public Func<Disciplina, ValidationResult> GravarRegistro { get; set; }

        public Disciplina Disciplina
        {
            get { return disciplina; }
            set
            {
                disciplina = value;

                maskedTextBoxNumero.Text = disciplina.Numero.ToString();
                textBoxNome.Text = disciplina.Titulo;
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            disciplina.Titulo = textBoxNome.Text;
            disciplina.Numero = int.Parse(maskedTextBoxNumero.Text);

            var resultadoValidacao = GravarRegistro(disciplina);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaMain.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
        private void TelaCadastroContatosForm_Load(object sender, EventArgs e)
        {
            TelaMain.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroContatosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaMain.Instancia.AtualizarRodape("");
        }
    }
}
