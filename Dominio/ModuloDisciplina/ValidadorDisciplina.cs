using FluentValidation;
using FluentValidation.Validators;

using System;

namespace Dominio.ModuloDisciplina
{
   
    public class ValidadorDisciplina : AbstractValidator<Disciplina>
    {       
        public ValidadorDisciplina()
        {
            RuleFor(x => x.Serie)
                .NotNull().NotEmpty();

            RuleFor(x => x.Disciplina)                
                .NotNull().NotEmpty();
            
        }

    }
}
