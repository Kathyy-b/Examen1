namespace Examen1_POO.Ciclos
{
    public class Ejercicio3
    {
        public Ejercicio3()
        {
            int numeroTabla;
            int limite;

            Console.Write("Ingrese el número de la tabla: ");

            if (!int.TryParse(Console.ReadLine(), out numeroTabla))
            {
                Console.WriteLine("numero invalido.");
                return;
            }

            Console.Write("Ingrese el limite: ");

            if (!int.TryParse(Console.ReadLine(), out limite))
            {
                Console.WriteLine("Limite invalido.");
                return;
            }

            if (numeroTabla <= 0)
            {
                Console.WriteLine("El numero de tabla debe ser mayor a cero.");
                return;
            }

            Console.WriteLine($"\nTabla de multiplicar del {numeroTabla}");
            Console.WriteLine("==========================");

            for (int i = 1; i <= limite; i++)
            {
                Console.WriteLine($"{numeroTabla} x {i} = {numeroTabla * i}");
            }
        }
    }
}