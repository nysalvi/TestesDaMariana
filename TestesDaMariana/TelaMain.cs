using System.Windows.Forms;
using System;
using System.Collections.Generic;


namespace TestesDaMariana
{
    public partial class TelaMain : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
        private DataContext contextoDados;

        public TelaMain(DataContext contextData)
        {
            Instancia = this;

            toolStripStatusLabelRodape.Text = string.Empty;
            toolStripLabelTipoCadastro.Text = string.Empty;

            this.contextoDados = contextData;

            InitializeComponent();

            InicializarRepositorios();
        }
        public static TelaPrincipalForm Instancia
        {
            get;
            private set;
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }



        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButtonInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void toolStripButtonExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void toolStripButtonPDF_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemDisclina_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void toolStripMenuItemTeste_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void toolStripMenuItemMatéria_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal((ToolStripMenuItem)sender);
        }

        private void InicializarRepositorios()
        {
            var repositorioDisciplina = new RepositorioDisciplinaEmArquivo(contextoDados);
            var repositorioMateria = new RepositorioMateriaEmArquivo(contextoDados);
            var repositorioTeste = new RepositorioTesteEmArquivo(contextoDados);

            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Disciplina", new ControladorDisciplina(repositorioDisciplina));
            controladores.Add("Materia", new ControladorMateria(repositorioMateria));
            controladores.Add("Teste", new ControladorTeste(repositorioTeste));
        }

        private void ConfigurarTelaPrincipal(ToolStripMenuItem opcaoSelecionada)
        {
            var tipo = opcaoSelecionada.Text;

            controlador = controladores[tipo];

            ConfigurarToolbox();

            ConfigurarListagem();
        }
        private void ConfigurarToolbox()
        {
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();

            if (configuracao != null)
            {
                toolbox.Enabled = true;

                labelTipoCadastro.Text = configuracao.TipoCadastro;

                ConfigurarTooltips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }
        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            panelMain.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            panelMain.Controls.Add(listagemControl);
        }
        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            toolStripButtonInserir.Enabled = configuracao.InserirHabilitado;
            toolStripButtonEditar.Enabled = configuracao.EditarHabilitado;
            toolStripButtonExcluir.Enabled = configuracao.ExcluirHabilitado;
            toolStripButtonPDF.Enabled = configuracao.PDFHabilitado;
        }
        private void ConfigurarTooltips(ConfiguracaoToolboxBase configuracao)
        {
            toolStripButtonInserir.ToolTipText = configuracao.TooltipInserir;
            toolStripButtonEditar.ToolTipText = configuracao.TooltipEditar;
            toolStripButtonExcluir.ToolTipText = configuracao.TooltipExcluir;
            toolStripButtonPDF.ToolTipText = configuracao.TooltipPDF;
        }
    }
}
