namespace AppHub.Domain.Dtos
{
    public record AnimalDto
    (
        int Id,
        string Nombre,
        string Tipo, // Por ejemplo: "Perro" o "Gato"
        int Edad,
        DateTime CreateAt,
        DateTime UpdatedAt
    );
}
