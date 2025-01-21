using AppHub.Application.Providers;
using AppHub.Domain.Models;
using AppHub.Application.Exceptions;
using AppHub.Domain.Repositories.Modules;

namespace AppHub.Application.Services.AnimalModule
{
    public class AnimalService
    {
        private readonly IAnimalRepository _animalRepository;
        private readonly DateProvider _dateProvider;

        public AnimalService(IAnimalRepository animalRepository, DateProvider dateProvider)
        {
            _animalRepository = animalRepository;
            _dateProvider = dateProvider;
        }

        public async Task SaveAsync(AnimalModel animal)
        {
            if (animal.Id == 0)
            {
                animal.CreatedAt = _dateProvider.GetCurrentDateUtc();
            }
            else
            {
                animal.UpdatedAt = _dateProvider.GetCurrentDateUtc();
            }

            await _animalRepository.AddAsync(animal);
        }

        public async Task<IEnumerable<AnimalModel>> GetAllAsync()
        {
            return await _animalRepository.GetAllAsync();
        }

        public async Task<AnimalModel> GetByIdAsync(int id)
        {
            var animal = await _animalRepository.GetByIdAsync(id);
            if (animal == null)
            {
                throw new NullAnimalException(id);
            }

            return animal;
        }

        public async Task DeleteByIdAsync(int id)
        {
            var animal = await _animalRepository.GetByIdAsync(id);
            if (animal == null)
            {
                throw new NullAnimalException(id);
            }

            await _animalRepository.DeleteAsync(animal); // Ahora es asincrónico.
        }
    }
}
