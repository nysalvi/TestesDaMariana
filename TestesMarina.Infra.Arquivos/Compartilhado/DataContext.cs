
using System.Collections.Generic;
using System.Linq;

using Dominio.Compartilhado;
using Dominio.ModuloAlternativa;
using Dominio.ModuloDisciplina;
using Dominio.ModuloMateria;
using Dominio.ModuloQuestao;
using Dominio.ModuloTeste;
using eAgenda.Infra.Arquivos;

namespace TestesMariana.Infra.Arquivos.Compartilhado
{
    public class DataContext
    {
        private readonly ISerializador serializador;

        public DataContext()
        {
            Materias = new List<Materia>();

            Disciplinas = new List<Disciplina>();

            Questoes = new List<Questao>();

            Testes = new List<Teste>();
        }

        public DataContext(ISerializador serializador) : this()
        {
            this.serializador = serializador;

            CarregarDados();
        }

        public List<Materia> Materias { get; set; }

        public List<Disciplina> Disciplinas { get; set; }

        public List<Questao> Questoes { get; set; }

        public List<Teste> Testes { get; set; }

        public void GravarDados()
        {
            serializador.GravarDadosEmArquivo(this);
        }

        private void CarregarDados()
        {
            var ctx = serializador.CarregarDadosDoArquivo();

            if (ctx.Materias.Any())
                this.Materias.AddRange(ctx.Materias);

            if (ctx.Disciplinas.Any())
                this.Disciplinas.AddRange(ctx.Disciplinas);

            if (ctx.Questoes.Any())
                this.Questoes.AddRange(ctx.Questoes);

            if (ctx.Testes.Any())
                this.Testes.AddRange(ctx.Testes);
        }
    }
}
