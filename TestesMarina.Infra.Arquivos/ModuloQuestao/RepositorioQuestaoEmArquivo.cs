using Dominio.ModuloTeste;
using TestesMariana.Infra.Arquivos.Compartilhado;
using Dominio.ModuloQuestao;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;
using Dominio.Compartilhado;

namespace TestesMariana.Infra.Arquivos.ModuloQuestao
{
    public class RepositorioQuestaoEmArquivo : RepositorioEmArquivoBase<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestaoEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Questoes.Count > 0)
                contador = dataContext.Questoes.Max(x => x.Numero);
        }

        public ValidationResult Editar(Questao registro)
        {
            throw new NotImplementedException();
        }

        public override List<Questao> ObterRegistros()
        {
            return dataContext.Questoes;
        }

        public override AbstractValidator<Questao> ObterValidador()
        {
            return new ValidadorQuestao();
        }       
    }
}
