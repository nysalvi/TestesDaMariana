using System;
using Dominio.ModuloTeste;
using Dominio.ModuloDisciplina;
using Dominio.ModuloMateria;
using FluentValidation.Results;
using System.Windows.Forms;

namespace TestesMariana.ModuloTeste
{
    public partial class TelaCadastroTestesForm : Form
    {
        public TelaCadastroTestesForm()
        {
            InitializeComponent();
        }
        private Teste teste;

        public Func<Teste, ValidationResult> GravarTeste { get; set; }

        public Teste Teste
        {
            get { return teste; }
            set
            {
                teste = value;

                maskedTextBoxNumero.Text = teste.Numero.ToString();
                textBoxNome.Text = teste.Titulo;
                maskedTextBoxData.Text = teste.Data.ToString();
                comboBoxDisciplina.SelectedItem = teste.Disciplina;
                comboBoxMateria.SelectedItem = teste.Materia;
                maskedTextBoxQuantidade.Text = teste.NQuestoes.ToString();
            }
        }

        private void btnGravar_Click(object sender, System.EventArgs e)
        {
            teste.Numero = int.Parse(maskedTextBoxNumero.Text);
            teste.Titulo = textBoxNome.Text;
            teste.Disciplina = (Disciplina)comboBoxDisciplina.SelectedItem;
            teste.Data = DateTime.Parse(maskedTextBoxData.Text);
            teste.Materia = (Materia)comboBoxMateria.SelectedItem;
            teste.NQuestoes = int.Parse(maskedTextBoxQuantidade.Text);

            var resultadoValidacao = GravarTeste(teste);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaMain.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
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

