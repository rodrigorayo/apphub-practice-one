using AppHub.Domain.Models;
using AppHub.Domain.Repositories.Modules.AnimalModule;
using AppHub.Application.Validators;
using AppHub.Application.Exceptions;

namespace AppHub.Application.Services.AnimalModule
{
    public class AnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public async Task<IEnumerable<AnimalModel>> GetAllAsync()
        {
            return await _animalRepository.GetAllAsync();
        }

        public async Task<AnimalModel> GetByIdAsync(int id)
        {
            var animal = await _animalRepository.GetByIdAsync(id);
            if (animal == null)
                throw new ApplicationException("Animal no encontrado.");
            return animal;
        }

        public async Task SaveAsync(AnimalModel animal)
        {
            var validator = new AnimalValidator();
            var validationResult = validator.Validate(animal);

            if (!validationResult.IsValid)
            {
                throw new ApplicationException(
                    string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage))
                );
            }

            if (animal.Id == 0)
            {
                await _animalRepository.AddAsync(animal);
            }
            else
            {
                _animalRepository.Update(animal);
            }
        }

        public async Task DeleteByIdAsync(int id)
        {
            var animal = await _animalRepository.GetByIdAsync(id);
            if (animal == null)
                throw new ApplicationException("Animal no encontrado.");
            _animalRepository.Delete(animal);
        }
    }
}
