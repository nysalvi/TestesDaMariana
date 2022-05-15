using Dominio.ModuloTeste;
using TestesMariana.Infra.Arquivos.Compartilhado;
using Dominio.ModuloQuestao;
using Dominio.ModuloMateria;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;
using Dominio.Compartilhado;

namespace TestesMariana.Infra.Arquivos.ModuloMateria
{
    public class RepositorioMateriaEmArquivo : RepositorioEmArquivoBase<Materia>, IRepositorioMateria
    {
        public RepositorioMateriaEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Materias.Count > 0)
                contador = dataContext.Materias.Max(x => x.Numero);
        }

        public ValidationResult Editar(Materia registro)
        {
            throw new NotImplementedException();
        }

        public override List<Materia> ObterRegistros()
        {
            return dataContext.Materias;
        }

        public override AbstractValidator<Materia> ObterValidador()
        {
            return new ValidadorMateria();
        }       
    }
}
