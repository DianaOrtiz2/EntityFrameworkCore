namespace WebApplicationPOO2.Models
{
    public class ChoferesModel
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        
        public DateOnly Fecha { get; set; } 
        public decimal Salario { get; set; }
    }
}


