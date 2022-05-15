using Dominio.ModuloTeste;
using TestesMariana.Infra.Arquivos.Compartilhado;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;
using Dominio.Compartilhado;

namespace TestesMariana.Infra.Arquivos.ModuloTeste
{
    public class RepositorioTesteEmArquivo : RepositorioEmArquivoBase<Teste>, IRepositorioTeste
    {
        public RepositorioTesteEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Testes.Count > 0)
                contador = dataContext.Testes.Max(x => x.Numero);
        }

        public ValidationResult Editar(Teste registro)
        {
            throw new NotImplementedException();
        }

        public override List<Teste> ObterRegistros()
        {
            return dataContext.Testes;
        }

        public override AbstractValidator<Teste> ObterValidador()
        {
            return new ValidadorTeste();
        }       
    }
}
