using AppHub.Application.Providers;
using AppHub.Domain.Models;
using AppHub.Domain.Repositories.Modules.CarroModule;
using AppHub.Application.Exceptions;
using AppHub.Application.Exceptions.CarroExceptions;

namespace AppHub.Application.Services
{
    public class CarroService
    {
        private readonly ICarroRepository _carroRepository;
        private readonly DateProvider _dateProvider;

        public CarroService(ICarroRepository carroRepository, DateProvider dateProvider)
        {
            _carroRepository = carroRepository;
            _dateProvider = dateProvider;
        }

        public async Task SaveAsync(CarroModel carro)
        {
            if (carro.Id == 0)
            {
                carro.CreatedAt = _dateProvider.GetCurrentDateUtc();
            }
            else
            {
                carro.UpdatedAt = _dateProvider.GetCurrentDateUtc();
            }

            await _carroRepository.AddAsync(carro);
        }

        public async Task<IEnumerable<CarroModel>> GetAllAsync()
        {
            return await _carroRepository.GetAllAsync();
        }

        public async Task<CarroModel> GetByIdAsync(int id)
        {
            var carro = await _carroRepository.GetByIdAsync(id);
            if (carro == null)
            {
                throw new NullCarroException(id);
            }

            return carro;
        }

        public async Task DeleteByIdAsync(int id)
        {
            var carro = await _carroRepository.GetByIdAsync(id);
            if (carro == null)
            {
                throw new NullCarroException(id);
            }

            await _carroRepository.DeleteAsync(carro); // Ahora es asincrónico.
        }
    }
}
