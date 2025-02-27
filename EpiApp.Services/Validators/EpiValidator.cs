using EpiApp.Domain.Entities;
using FluentValidation;

namespace EpiApp.Services.Validators
{
    public class EpiValidator : AbstractValidator<Epi>        
    {
        public EpiValidator() 
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Ca)
                .NotEmpty().WithMessage("Por favor informe o CA do Epi.")
                .NotNull().WithMessage("Por favor informe o CA do Epi.");

            RuleFor(c => c.ValidadeCa)
                .NotEmpty().WithMessage("Por favor informe a validade do CA.")
                .NotNull().WithMessage("Por favor informe a validade do CA.");

            RuleFor(c => c.PrazoTroca)
                .NotEmpty().WithMessage("Por favor informe o prazo de troca do Epi.")
                .NotNull().WithMessage("Por favor informe o prazo de troca do Epi.");

        }
    }
}
