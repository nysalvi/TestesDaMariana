using FluentValidation;
using FluentValidation.Validators;

using System;

namespace Dominio.ModuloQuestao
{
   
    public class ValidadorQuestao : AbstractValidator<Questao>
    {       
        public ValidadorQuestao()
        {
            //RuleFor(x => x.Serie)
            //    .NotNull().NotEmpty();

            RuleFor(x => x.Disciplina)                
                .NotNull().NotEmpty();
            
        }

    }
}
