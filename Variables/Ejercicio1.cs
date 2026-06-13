namespace Examen1_POO.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreProducto = "Fertilizante NPK";
            decimal precioPorKg = 35.75m;
            int cantidadKg = 12;
            decimal descuentoPorcentaje = 10m;

            decimal subtotal = precioPorKg * cantidadKg;
            decimal descuento = subtotal * descuentoPorcentaje / 100;
            decimal totalFinal = subtotal - descuento;

            Console.WriteLine("---Tienda de insumos AgroCopan---");
            Console.WriteLine("--- Factura AgroCopan ---");
            Console.WriteLine($"Producto   : {nombreProducto}");
            Console.WriteLine($"Cantidad   : {cantidadKg} kg");
            Console.WriteLine($"Precio/kg  : L. {precioPorKg:F2}");
            Console.WriteLine($"Subtotal   : L. {subtotal:F2}");
            Console.WriteLine($"Descuento  : L. {descuento:F2}");
            Console.WriteLine($"Total      : L. {totalFinal:F2}");
        }
    }
}