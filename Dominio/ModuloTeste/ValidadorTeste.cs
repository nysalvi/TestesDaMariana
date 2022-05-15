using FluentValidation;
using FluentValidation.Validators;

using System;

namespace Dominio.ModuloTeste
{
   
    public class ValidadorTeste : AbstractValidator<Teste>
    {       
        public ValidadorTeste()
        {
            //RuleFor(x => x.Serie)
            //   .NotNull().NotEmpty();

            RuleFor(x => x.Disciplina)                
                .NotNull().NotEmpty();
            
        }

    }
}
