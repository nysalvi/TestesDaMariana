using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestesMariana.Compartilhado;
using Dominio;
using Dominio.ModuloMateria;


namespace TestesMariana.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private readonly IRepositorioMateria repositorioMaterias;
        private TabelaMateriaControl tabelaMaterias;
        public ControladorMateria(IRepositorioMateria repositorioMateria)
        {
            this.repositorioMaterias = repositorioMateria;
        }

        public override void Inserir()
        {
            TelaCadastroMateriasForm tela = new TelaCadastroMateriasForm();
            tela.Materia = new Materia();

            tela.GravarRegistro = repositorioMaterias.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        public override void Editar()
        {
            Materia materiaSelecionada = ObtemMateriaSelecionada();

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Selecione uma matéria primeiro",
                "Edição de Disciplinas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroMateriasForm tela = new TelaCadastroMateriasForm();

            tela.Materia = materiaSelecionada;

            tela.GravarRegistro = repositorioMaterias.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarMaterias();
            }
        }

        public override void Excluir()
        {
            Materia disciplinaSelecionada = ObtemMateriaSelecionada();

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show("Selecione uma Materia primeiro",
                "Exclusão de Materias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a Materia?",
                "Exclusão de Materias", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioMaterias.Excluir(disciplinaSelecionada);
                CarregarMaterias();
            }
        }
        public override UserControl ObtemListagem()
        {
            //if (tabelaContatos == null)
            tabelaMaterias = new TabelaMateriaControl();

            CarregarMaterias();

            return tabelaMaterias;
        }

        public override ConfiguracaoToolBoxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolBoxMateria();
        }

        private Materia ObtemMateriaSelecionada()
        {
            var numero = tabelaMaterias.ObtemNumeroMateriaSelecionada();

            return repositorioMaterias.SelecionarPorNumero(numero);
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMaterias.SelecionarTodos();

            tabelaMaterias.AtualizarRegistros(materias);

            TelaMain.Instancia.AtualizarRodape($"Visualizando {materias.Count} matéria(s)");

        }
    }
}
