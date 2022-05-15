using System.Collections.Generic;
using Dominio.ModuloQuestao;
using TestesMariana.Compartilhado;
using System.Windows.Forms;

namespace TestesMariana.ModuloQuestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();
        }
        public int ObtemNumeroQuestaoSelecionada()
        {
            return dataGridView1.SelecionarNumero<int>();
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Resposta", HeaderText = "Resposta"},
            };

            return colunas;
        }
        public void AtualizarRegistros(List<Questao> questoes)
        {
            dataGridView1.DataSource = questoes;
        }

    }
}
