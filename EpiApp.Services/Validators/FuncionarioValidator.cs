using EpiApp.Domain.Entities;
using FluentValidation;

namespace EpiApp.Services.Validators
{
    public class FuncionarioValidator : AbstractValidator<Funcionario>
    {
        public FuncionarioValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome do Funcionário.")
                .NotNull().WithMessage("Por favor informe o nome do Funcionário.");

            RuleFor(c => c.Documento)
                .NotEmpty().WithMessage("Por favor informe um documento do Funcionário.")
                .NotNull().WithMessage("Por favor informe um documento do Funcionário.");

            RuleFor(c => c.DataNascimento)
                .NotEmpty().WithMessage("Por favor informe a data de nascimento do Funcionário.")
                .NotNull().WithMessage("Por favor informe a data de nascimento do Funcionário.");

            RuleFor(c => c.Ativo)
                .NotEmpty().WithMessage("Por favor informe a situação atual do Funcionário.")
                .NotNull().WithMessage("Por favor informe a situação atual do Funcionário.");
        }
    }
}
