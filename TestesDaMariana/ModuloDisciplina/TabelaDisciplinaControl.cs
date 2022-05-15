using System;
using System.Collections.Generic;

using Dominio.ModuloDisciplina;
using TestesMariana.Compartilhado;
using System.Windows.Forms;

namespace TestesMariana.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();
        }
        public int ObtemNumeroDisciplinaSelecionada()
        {
            return dataGridView1.SelecionarNumero<int>();
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
            };

            return colunas;
        }
        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            dataGridView1.DataSource = disciplinas;
        }
    }
}
