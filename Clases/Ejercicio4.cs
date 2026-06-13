namespace Examen1_POO.Clases
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Producto(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public string ObtenerInfo()
        {
            return $"{Nombre} -- Precio: L. {Precio:F2} -- Stock: {Stock} unidades";
        }
        