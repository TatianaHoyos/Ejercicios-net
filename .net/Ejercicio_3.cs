using System;

//Un proveedor de computadores ofrece descuento del 10%, si cuesta {6}.000.000
//    o más.Determinar cuánto pagará, con IVA incluido (19%), un cliente cualquiera 
//    por la compra de una computadora.

namespace _net
{
    public class Ejercicio_3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese el precio de la computadora: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            if (precio >= 1000000)
            {
                Console.WriteLine("Tienes un descuento del 10% ");
                double descuento = precio * 0.1;
                double subtotal = precio - descuento;
                double iva = subtotal * 0.19;
                double total = subtotal + iva;

                Console.WriteLine("Su total a pagar es de: " + total + " pesos.");

            }
            else
            {
                double iva = precio * 0.19;
                double total = precio + iva;

                Console.WriteLine("Su total a pagar es de: " + total + " pesos.");
            }

        }
    }
}

