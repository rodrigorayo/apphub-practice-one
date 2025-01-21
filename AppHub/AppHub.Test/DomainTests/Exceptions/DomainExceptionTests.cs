using AppHub.Domain.Exceptions;
using Xunit;

namespace AppHub.Tests.Domain.Exceptions
{
    public class DomainExceptionTests
    {
        [Fact]
        public void DomainException_ShouldHaveCorrectMessage()
        {
            // Arrange
            var message = "Error de dominio";

            // Act
            var exception = new DomainException(message);

            // Assert
            Assert.Equal(message, exception.Message);
        }
    }
}
