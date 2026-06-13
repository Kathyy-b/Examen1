namespace Examen1_POO.EstructurasDeControl
{
    public class Ejercicio2
    {
        public ejercicio2()
        {
            decimal saldo = 7500.00m;

            string categoría;
            string mensaje;

            if (saldo < 1000)
            {
                categoría = "Básico";
                mensaje = "Abra un CDT para mejorar su categoría.";
            }
            else if (saldo >= 1000 && saldo <= 4999)
            {
                categoría = "Plata";
                mensaje = "Tiene acceso a tarjeta de débito sin comisión.";
            }
            else if (saldo >= 5000 && saldo <= 19999)
            {
                categoría = "Oro";
                mensaje = "¡Felicidades! Accede a tasas preferenciales.";
            }
            else
            {
                categoría = "Platino";
                mensaje = "¡Cliente VIP! Accede a todos los beneficios del banco.";
            }

            Console.WriteLine($"Saldo: L. {saldo:N2}");
            Console.WriteLine($"Categoría asignada: {categoría}");
            Console.WriteLine(mensaje);
        }
    }
}