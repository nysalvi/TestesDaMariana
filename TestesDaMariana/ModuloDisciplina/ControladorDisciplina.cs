using TestesDaMariana.Compartilhado;
using Dominio;
using Dominio.ModuloDisciplina;
using Dominio.Compartilhado;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestesDaMariana.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private readonly IRepositorioDisciplina repositorioDisciplinas;
        private TabelaDisciplinaControl tabelaDisciplinas;
        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplinas = repositorioDisciplina;
        }

        public override void Inserir()
        {
            TelaCadastroDisciplinasForm tela = new TelaCadastroDisciplinasForm();
            tela.Disciplina = new Disciplina();

            tela.GravarRegistro = repositorioDisciplinas.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }

        public override void Editar()
        {
            Disciplina disciplinaSelecionada = ObtemDisciplinaSelecionado();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma disciplina primeiro",
                "Edição de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroDisciplinasForm tela = new TelaCadastroDisciplinasForm();

            tela.Disciplina = disciplinaSelecionada;

            tela.GravarRegistro = repositorioDisciplinas.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarDisciplinas();
            }
        }

        public override void Excluir()
        {
            Disciplina disciplinaSelecionada = ObtemDisciplinaSelecionado();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma Disciplina primeiro",
                "Exclusão de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a Disciplina?",
                "Exclusão de Disciplinas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioDisciplinas.Excluir(disciplinaSelecionada);
                CarregarDisciplinas();
            }
        }
        public override UserControl ObtemListagem()
        {
            //if (tabelaContatos == null)
            tabelaDisciplinas = new TabelaDisciplinaControl();

            CarregarDisciplinas();

            return tabelaDisciplinas;
        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxDisciplina();
        }

        private Disciplina ObtemDisciplinaSelecionado()
        {
            var numero = tabelaDisciplinas.ObtemNumeroDisciplinaSelecionada();

            return repositorioDisciplinas.SelecionarPorNumero(numero);
        }

        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplinas.SelecionarTodos();

            tabelaDisciplinas.AtualizarRegistros(disciplinas);

            TelaMain.Instancia.AtualizarRodape($"Visualizando {disciplinas.Count} contato(s)");

        }
    }
}
