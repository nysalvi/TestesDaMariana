using System;
using System.Collections.Generic;

using Dominio.ModuloMateria;
using TestesMariana.Compartilhado;
using System.Windows.Forms;

namespace TestesMariana.ModuloMateria
{
    public partial class TabelaMateriaControl : UserControl
    {
        public TabelaMateriaControl()
        {
            InitializeComponent();
        }
        public int ObtemNumeroMateriaSelecionada()
        {
            return dataGridView1.SelecionarNumero<int>();
        }
        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Disciplina", HeaderText = "Disciplina"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Serie", HeaderText = "Série"},
            };

            return colunas;
        }
        public void AtualizarRegistros(List<Materia> materias)
        {
            dataGridView1.DataSource = materias;
        }
    }
}
