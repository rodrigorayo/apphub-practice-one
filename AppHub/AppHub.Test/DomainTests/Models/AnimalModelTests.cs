using AppHub.Domain.Models; // Asegúrate de que este namespace apunta a tu proyecto.
using Xunit;

namespace AppHub.Test.Domain.Models
{
    public class AnimalModelTests
    {
        [Fact] // Esto marca que esta es una prueba.
        public void AnimalModel_Creation_ShouldInitializeCorrectly()
        {
            // Arrange
            var id = 1;
            var nombre = "Firu";
            var edad = 5;
            string tipo = "Perro";

            // Act
            var animal = new AnimalModel { Id = id, Nombre = nombre, Edad = edad, Tipo = tipo };

            // Assert
            Assert.Equal(id, animal.Id); // Esto no coincide con `id = 1`.
            Assert.Equal(nombre, animal.Nombre); // Esto no coincide con `name = "Perro"`.
            Assert.Equal(edad, animal.Edad); // Esto no coincide con `age = 3`.
            Assert.Equal(tipo, animal.Tipo);

        }
    }
}
