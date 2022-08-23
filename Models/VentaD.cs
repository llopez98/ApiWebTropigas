namespace PruebaTropigasAPI.Models
{
    public class VentaD
    {
        public string ID { get; set; }
        public int Renglon { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public Boolean Enviado { get; set; }
    }
}
