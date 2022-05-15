using System.Collections.Generic;
using Dominio.ModuloTeste;
using System.Windows.Forms;
using TestesMariana.Compartilhado;

namespace TestesMariana.ModuloTeste
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();
        }
        public int ObtemNumeroTesteSelecionado()
        {
            return dataGridView1.SelecionarNumero<int>();
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Titulo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Recuperacao", HeaderText = "Recuperacao"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade Questoes", HeaderText = "Quantidade Questoes"},

            };

            return colunas;
        }
        public void AtualizarRegistros(List<Teste> testes)
        {
            dataGridView1.DataSource = testes;
        }
    }
}
