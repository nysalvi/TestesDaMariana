using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dominio.ModuloQuestao;
using Dominio.ModuloMateria;
using Dominio.ModuloDisciplina;
using FluentValidation.Results;

namespace TestesMariana.ModuloQuestao
{
    public partial class TelaCadastroQuestaoForm : Form
    {
        public TelaCadastroQuestaoForm()
        {
            InitializeComponent();
        }

        private Questao questao;

        public Func<Questao, ValidationResult> GravarRegistro { get; set; }

        public Questao Questao
        {
            get { return questao; }
            set
            {
                questao = value;

                maskedTextBoxNumero.Text = questao.Numero.ToString();
                comboBoxDisciplina.SelectedItem = questao.Disciplina;
                comboBoxMateria.SelectedItem = questao.Materia;
                textBoxNome.Text = questao.Titulo;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TelaCadastroQuestaoForm_Load(object sender, EventArgs e)
        {
            TelaMain.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroQuestaoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaMain.Instancia.AtualizarRodape("");
        }
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            questao.Titulo = textBoxNome.Text;
            questao.Numero = int.Parse(maskedTextBoxNumero.Text);

            questao.Disciplina = (Disciplina)comboBoxDisciplina.SelectedItem;
            questao.Materia = (Materia)comboBoxMateria.SelectedItem;

            var resultadoValidacao = GravarRegistro(questao);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaMain.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
