//Pedir un número de 0 a 99 y mostrarlo escrito.Por ejemplo, para 56 mostrar: cincuenta y seis.
//Pista: separar las unidades y las decenas. (unidades = num % 10; decenas = num / 10).
using System;
namespace _net
{
    public class Ejercicio_6
    {
        static void Main(string[] args)
        {
            string[] unidades = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
            string[] decenas = { "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

            Console.WriteLine("Ingrese un número del 0 al 99: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int unidad = numero % 10;
            int decena = numero / 10 - 2;

            if ((numero < 0) || (numero > 99))
            {
                Console.WriteLine("Número fuera del rango válido");

            }
            else if (numero < 20)
            {
                Console.WriteLine(unidades[numero]);

            }
            if (unidad == 0)
            {
                Console.WriteLine(decenas[decena]);
            }
            else
            {
                Console.WriteLine(decenas[decena] + " y " + unidades[unidad]);
            }
        }
    }
}

