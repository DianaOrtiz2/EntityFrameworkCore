namespace WebApplicationPOO2.Entities
{
    public class Choferes
    {
           
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        
        public DateOnly Fecha { get; set; } 
        public decimal Salario { get; set; }
    }
}