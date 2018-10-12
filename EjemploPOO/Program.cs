using System;
using Classes;

namespace EjemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User();
            Console.WriteLine("Ingrese nombre de usuario: ");
            newUser.setName(Console.ReadLine());
            Console.WriteLine("Ingrese apellido de usuario: ");
            newUser.setLastName(Console.ReadLine());

            Console.WriteLine("Nombre completo del usuario: " + newUser.getFullName());
            

        }
    }
}
