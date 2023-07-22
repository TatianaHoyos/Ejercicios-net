//.Determinar el precio de un pasaje de ida y vuelta por avión, conociendo la
//  distancia a recorrer y sabiendo que que esta es superior a 1.000 km, la línea
//  aérea le hace un descuento del 30%. El precio por kilómetro es de 0.

using System;
namespace _net
{
    public class Ejercicio_4
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la distancia en kilómetros a recorrer: ");
            double distanciaKm = Convert.ToDouble(Console.ReadLine());

            double preciotiquete = distanciaKm * 150;

            if (distanciaKm > 1000)
            {
                Console.WriteLine("Tienes un descuento del 30% en su tiquete");

                double descuento = preciotiquete * 0.3;
                double totaltiquete = preciotiquete - descuento;
                Console.WriteLine("Su total a pagar es de: " + totaltiquete + " pesos.");
            }
            else
            {
                Console.WriteLine("El precio total de su viaje es " + preciotiquete + " pesos");

            }

        }
    }
}

