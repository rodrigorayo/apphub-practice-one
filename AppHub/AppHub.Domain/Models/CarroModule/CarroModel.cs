namespace AppHub.Domain.Models
{
    public class CarroModel : BaseModel
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public double Precio { get; set; }

        public double CalcularImpuesto()
        {
            return Precio * 0.15; // Impuesto del 15% sobre el precio del carro
        }
    }
}
