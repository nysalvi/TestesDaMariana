﻿using Dominio.ModuloTeste;
using TestesMariana.Infra.Arquivos.Compartilhado;
using Dominio.ModuloQuestao;
using Dominio.ModuloMateria;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;
using Dominio.ModuloDisciplina;

namespace TestesMariana.Infra.Arquivos.ModuloDisciplina
{
    public class RepositorioDisciplinaEmArquivo : RepositorioEmArquivoBase<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplinaEmArquivo(DataContext dataContext) : base(dataContext)
        {
            if (dataContext.Materias.Count > 0)
                contador = dataContext.Materias.Max(x => x.Numero);
        }

        public ValidationResult Editar(Disciplina registro)
        {
            throw new NotImplementedException();
        }

        public override List<Disciplina> ObterRegistros()
        {
            return dataContext.Disciplinas;
        }

        public override AbstractValidator<Disciplina> ObterValidador()
        {
            return new ValidadorDisciplina();
        }       
    }
}
