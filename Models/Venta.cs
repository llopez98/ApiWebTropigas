namespace PruebaTropigasAPI.Models
{
    public class Venta
    {
        public string ID { get; set; }
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public string Usuario { get; set; }
        public Boolean Enviado { get; set; }
    }
}
