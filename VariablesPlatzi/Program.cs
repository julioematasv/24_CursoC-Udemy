﻿using System;

namespace VariablesPlatzi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que calcula el área de un rectángulo.
            var ladoA = 1.1;
            var ladoB = 1.1;
            var resultado = 1.1;

            Console.WriteLine("Calcula el área de un rectángulo");
            Console.WriteLine("Ingrese el valor del lado A:");
            ladoA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del lado B:");
            ladoB = Convert.ToDouble(Console.ReadLine());
            resultado = Convert.ToDouble(ladoA * ladoB);
            Console.WriteLine("El lado A es: " + ladoA + " y el lado B es: " + ladoB);
            Console.WriteLine("El resultado es: ");
            Console.WriteLine(resultado);
        }
    }
}
