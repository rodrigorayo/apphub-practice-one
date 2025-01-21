using AppHub.Domain.Dtos;
using FluentValidation;

namespace AppHub.Application.Validators
{
    public class CarroValidator : AbstractValidator<CarroDto>
    {
        public CarroValidator()
        {
            // El color no puede estar vacío.
            RuleFor(x => x.Color)
                .NotEmpty().WithMessage("El color del carro es obligatorio.");

            // El precio debe ser mayor a 0.
            RuleFor(x => x.Precio)
                .GreaterThan(0).WithMessage("El precio debe ser mayor a 0.");
        }
    }
}
