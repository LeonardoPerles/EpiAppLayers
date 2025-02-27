using EpiApp.Domain.Entities;
using FluentValidation;

namespace EpiApp.Services.Validators
{
    public class SetorValidator : AbstractValidator<Setor>
    {
        public SetorValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome")
                .NotNull().WithMessage("Por favor informe o nome.");

        }
    }
}
