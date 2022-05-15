using FluentValidation;
using FluentValidation.Validators;

using System;

namespace Dominio.ModuloMateria
{
   
    public class ValidadorMateria : AbstractValidator<Materia>
    {       
        public ValidadorMateria()
        {
            RuleFor(x => x.Serie)
                .NotNull().NotEmpty();

            RuleFor(x => x.Disciplina)                
                .NotNull().NotEmpty();
            
        }

    }
}
