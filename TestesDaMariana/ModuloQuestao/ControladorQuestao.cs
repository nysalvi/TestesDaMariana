using TestesMariana.Compartilhado;
using Dominio;
using Dominio.ModuloQuestao;
using Dominio.Compartilhado;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestesMariana.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private readonly IRepositorioQuestao repositorioQuestao;
        private TabelaQuestaoControl tabelaQuestoes;
        public ControladorQuestao(IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioQuestao = repositorioQuestao;
        }

        public override void Inserir()
        {
            TelaCadastroQuestaoForm tela = new TelaCadastroQuestaoForm();
            tela.Questao = new Questao();

            tela.GravarRegistro = repositorioQuestao.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        public override void Editar()
        {
            Questao questaoSelecionada = ObtemQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma questão primeiro",
                "Edição de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroQuestaoForm tela = new TelaCadastroQuestaoForm();

            tela.Questao = questaoSelecionada;

            tela.GravarQuestao = repositorioQuestao.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarQuestoes();
            }
        }

        public override void Excluir()
        {
            Questao questaoSelecionada = ObtemQuestaoSelecionada();

            if (questaoSelecionada == null)
            {
                MessageBox.Show("Selecione uma Questão primeiro",
                "Exclusão de Questões", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a Questão?",
                "Exclusão de Questões", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioQuestao.Excluir(questaoSelecionada);
                CarregarQuestoes();
            }
        }
        public override UserControl ObtemListagem()
        {
            //if (tabelaContatos == null)
            tabelaQuestoes = new TabelaQuestaoControl();

            CarregarQuestoes();

            return tabelaQuestoes;
        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxQuestao();
        }

        private Questao ObtemQuestaoSelecionada()
        {
            var numero = tabelaQuestoes.ObtemNumeroQuestaoSelecionada();

            return repositorioQuestao.SelecionarPorNumero(numero);
        }

        private void CarregarQuestoes()
        {
            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestoes.AtualizarRegistros(questoes);

            
            TelaMain.Instancia.AtualizarRodape($"Visualizando {questoes.Count} questão(ões)");

        }

    }
}
