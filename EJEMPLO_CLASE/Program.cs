using System;
using System.Collections.Generic;
using Classes;

namespace EJEMPLO_CLASE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Áreas de figuras geométricas: ");

            Console.WriteLine("A continuación ingrese el radio del círculo: ");
            Circulo c = new Circulo(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("El perímetro del círculo es: " + c.getPerimetro());
            Console.WriteLine("El área del círculo es: " + c.getArea());

            Console.WriteLine("A continuación ingrese la base del rectángulo: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("A continuación ingrese la altura del rectángulo: ");
            int a = Int32.Parse(Console.ReadLine());
            Rectangulo r = new Rectangulo(b,a);
            Console.WriteLine("El Perímetro del rectángulo es: " + r.getPerimetro());
            Console.WriteLine("El Área del rectángulo es: " + r.getArea());


            
        }
    }
}
