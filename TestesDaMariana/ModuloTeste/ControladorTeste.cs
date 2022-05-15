
using System.Collections.Generic;
using Dominio.ModuloTeste;
using TestesMariana.Compartilhado;
using System.Windows.Forms;


namespace TestesMariana.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private readonly IRepositorioTeste repositorioTestes;
        private TabelaTesteControl tabelaTestes;
        public ControladorTeste(IRepositorioTeste repositorioTestes)
        {
            this.repositorioTestes = repositorioTestes;
        }

        public override void Inserir()
        {
            TelaCadastroTestesForm tela = new TelaCadastroTestesForm();
            tela.Teste = new Teste();

            tela.GravarTeste = repositorioTestes.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }

        public override void Editar()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();
            
            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um teste primeiro",
                "Edição de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroTestesForm tela = new TelaCadastroTestesForm();

            tela.Teste = testeSelecionado;

            tela.GravarTeste = repositorioTestes.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTestes();
            }
        }

        public override void Excluir()
        {
            Teste testeSelecionado = ObtemTesteSelecionado();

            if (testeSelecionado == null)
            {
                MessageBox.Show("Selecione um Teste primeiro",
                "Exclusão de Testes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir os Testes?",
                "Exclusão de Testes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTestes.Excluir(testeSelecionado);
                CarregarTestes();
            }
        }
        public override UserControl ObtemListagem()
        {
            //if (tabelaContatos == null)
            tabelaTestes = new TabelaTesteControl();

            CarregarTestes();

            return tabelaTestes;
        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxTeste();
        }

        private Teste ObtemTesteSelecionado()
        {
            var numero = tabelaTestes.ObtemNumeroTesteSelecionado();

            return repositorioTestes.SelecionarPorNumero(numero);
        }

        private void CarregarTestes()
        {
            List<Teste> testes = repositorioTestes.SelecionarTodos();

            tabelaTestes.AtualizarRegistros(testes);


            TelaMain.Instancia.AtualizarRodape($"Visualizando {testes.Count} teste(s)");

        }
    }
}
