namespace AppHub.Domain.Dtos
{
    public record CarroDto
    (
        int Id,
        string Nombre,
        string Color,
        double Precio,
        DateTime CreateAt,
        DateTime UpdatedAt
    );
}
