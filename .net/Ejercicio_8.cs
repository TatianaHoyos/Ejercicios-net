// Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la tarde) //Desarrollar un programa que permita almacenar los sueldos de los empleados agrupados por turno.
//Imprimir los sueldos de cada turno y sumar los suedos total mañana y total tarde. utilizar Array.
using System;
using System.Linq;

namespace _net
{
    public class Ejercicio_8
    {
        static void Main(string[] args)
        {

            double[] sueldoManana = new double[4];

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Ingresar sueldo " + i + " del turno de la mañana: ");
                sueldoManana[i - 1] = Convert.ToDouble(Console.ReadLine());
            }
            double[] sueldoTarde = new double[4];


            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Ingresar sueldo " + i + " del turno de la tarde: ");
                sueldoTarde[i - 1] = Convert.ToDouble(Console.ReadLine());
            }


            Console.WriteLine("Total Sueldos de la mañana: " + sueldoManana.Sum());

            for (int i = 0; i < sueldoManana.Length; i++)
            {
                Console.WriteLine("sueldo " + (i + 1) + ": " + sueldoManana[i]);
            }

            Console.WriteLine("Total Sueldos de la tarde " + sueldoTarde.Sum());

            for (int i = 0; i < sueldoTarde.Length; i++)
            {
                Console.WriteLine("sueldo " + (i + 1) + ": " + sueldoTarde[i]);
            }

        }
    }
}

