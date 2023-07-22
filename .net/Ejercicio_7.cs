
//Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar por consola si
//se trata de un vocal o una consonante.
using System;
namespace _net
{
    public class Ejercicio_7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una letra del abecedario (a-z): ");
            string letra = Convert.ToString(Console.ReadLine());

            letra = letra.ToLower();

            if ((letra == "a") || (letra == "e") || (letra == "i") || (letra == "o") || (letra == "u"))
            {
                Console.WriteLine("La letra: " + letra + " es una vocal.");
            }
            else
            {
                Console.WriteLine("La letra: " + letra + " es una consonante.");
            }
        }
    }
}

