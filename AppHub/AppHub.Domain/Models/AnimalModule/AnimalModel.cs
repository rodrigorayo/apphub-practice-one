namespace AppHub.Domain.Models
{
    public class AnimalModel : BaseModel
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; } // Ejemplo: "Perro", "Gato"
        public int Edad { get; set; }

        public bool EsMayor()
        {
            return Edad > 5; // Si el animal tiene más de 5 años, es considerado mayor
        }
    }
}
