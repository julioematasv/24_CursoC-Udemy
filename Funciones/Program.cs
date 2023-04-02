using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Show();
            Sumar(5,10);
            Sumar(25, 100);
            Sumar(52, 18);

            int resultado1 = Multiplicar(5, 5);
            Console.WriteLine("El resultado de multiplicar los números es: " + resultado1);
            int resultado2 = Multiplicar(25, 5);
            Console.WriteLine("El resultado de multiplicar los números es: " + resultado2);
            int resultado3 = Multiplicar(8, 5);
            Console.WriteLine("El resultado de multiplicar los números es: " + resultado3);

        }

        static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        static void Sumar(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine("El total de la suma es: " + total);
        }

        static void Show()
        {
            Console.WriteLine("Texto generado en una Funcion");
        }
    }
}
