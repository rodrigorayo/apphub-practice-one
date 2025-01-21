using AppHub.Domain.Models; // Asegúrate de que este namespace apunta a tu proyecto.
using System.Drawing;
using Xunit;

namespace AppHub.Test.Domain.Models
{
    public class CarroModelTests
    {
        [Fact] // Esto marca que esta es una prueba.
        public void CarroModel_Creation_ShouldInitializeCorrectly()
        {
            // Arrange
            var id = 1;
            var nombre = "Firu";
            var color ="Rojo";
            var precio = 10000;

            // Act
            var carro = new CarroModel { Id = id, Nombre = nombre, Color = color, Precio = precio };

            // Assert
            Assert.Equal(id, carro.Id); // Esto no coincide con `id = 1`.
            Assert.Equal(nombre, carro.Nombre); // Esto no coincide con `name = "Perro"`.
            Assert.Equal(color, carro.Color); // Esto no coincide con `age = 3`.
            Assert.Equal(precio, carro.Precio);

        }
    }
}
