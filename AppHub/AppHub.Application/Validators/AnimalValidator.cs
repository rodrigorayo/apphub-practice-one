using AppHub.Domain.Dtos;
using FluentValidation;

namespace AppHub.Application.Validators
{
    public class AnimalValidator : AbstractValidator<AnimalDto>
    {
        public AnimalValidator()
        {
            // El nombre no puede estar vacío y debe tener al menos 3 letras.
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El nombre del animal es obligatorio.")
                .MinimumLength(3).WithMessage("El nombre debe tener al menos 3 caracteres.");

            // La edad debe ser mayor a 0.
            RuleFor(x => x.Edad)
                .GreaterThan(0).WithMessage("La edad debe ser mayor a 0.");
        }
    }
}
