using System;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, Calculemos Circulos");
            // formula para calcular circulos es PI por radio al cuadrado (PI * (radio * radio)).

            const double PI= Math.PI;
            var radio = 0d;
            var resultado = 0d;

            Console.WriteLine("Ingresa el valor del radio:");
            radio = Convert.ToDouble(Console.ReadLine());
            resultado = PI * (radio * radio);

            Console.WriteLine("El área de tú círculo es de: " + resultado);
        }
    }
}
