
//Calcular e imprimir el salario de un empleado, teniendo en cuenta que si el 
//    salario bruto es igual o superior a .000.000, debe hacerse una retención
//    del 10%, si el salario es inferior, la retención será del 3%.
using System;
namespace _net
{
    public class Ejercicio_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el salario bruto del empleado: ");
            double salarioBruto = Convert.ToDouble(Console.ReadLine());

            if (salarioBruto >= 2000000)
            {

                double retencion = salarioBruto * 0.1;
                double salario = salarioBruto - retencion;
                Console.WriteLine("Tiene una retención del 10% de tu salario. Su salario actual es de: " + salario + " pesos.");

            }
            else
            {
                double retencion = salarioBruto * 0.03;
                double salario = salarioBruto - retencion;
                Console.WriteLine("Tiene una retención del 3% de tu salario. Su salario actual es de: " + salario + " pesos.");
            }

        }
    }
}

