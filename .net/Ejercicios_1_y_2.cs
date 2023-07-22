
//1. Dadas las 3 notas de un aprendiz, calcule la definitiva de la asignatura si la
//primera nota tiene un valor del 20%, la segunda del 30% y la última del 50%.
//el usuario debera ingresar 3 asignaturas y sus calificaciones.
//que me diga si aprueba o no aprueba, aprueba con 3 en adelante.
//solo me dejara escribir numero de 1 a 5.

//El usuario debera ingresar 3 asignaturas y al final se mostrara si gano o perdio el trimestre

using System;

namespace _net
{
    class Ejercicios_1_y_2
    {
        static void Main(string[] args)
        {
            string[] asignaturas = new string[3];
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Ingrese el nombre de la asignatura " + i + " :");
                asignaturas[i - 1] = Console.ReadLine();

            }

            double[] notas = new double[3];
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Ingrese notas de la asignatura : " + asignaturas[i - 1]);


                Console.WriteLine("Ingrese la nota número uno: (1-5)");
                double nota1 = Convert.ToDouble(Console.ReadLine());

                while ((nota1 < 1) | (nota1 > 5))
                {
                    Console.WriteLine("La nota no es válida");
                    Console.WriteLine("Ingrese la nota número uno: (1-5)");
                    nota1 = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Ingrese la nota número dos: (1-5)");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                while ((nota2 < 1) | (nota2 > 5))
                {
                    Console.WriteLine("La nota no es válida");
                    Console.WriteLine("Ingrese la nota número dos: (1-5)");
                    nota2 = Convert.ToDouble(Console.ReadLine());
                }

                Console.WriteLine("Ingrese la nota número tres: (1-5)");
                double nota3 = Convert.ToDouble(Console.ReadLine());

                while ((nota3 < 1) | (nota3 > 5))
                {
                    Console.WriteLine("La nota no es válida");
                    Console.WriteLine("Ingrese la nota número tres: (1-5)");
                    nota3 = Convert.ToDouble(Console.ReadLine());
                }

                double definitiva = (nota1 * 0.2) + (nota2 * 0.3) + (nota3 * 0.5);
                Console.WriteLine("La nota definitiva es: " + definitiva);
                notas[i - 1] = definitiva;

                if (definitiva >= 3)
                {
                    Console.WriteLine("El aprendiz ha aprobado la asignatura");
                }
                else
                {
                    Console.WriteLine("El aprendiz no ha aprobado la asignatura.");
                }
                Console.ReadLine();
            }

            double promedioTrimestre = (notas[0] + notas[1] + notas[2]) / 3;
            Console.WriteLine("el promedio del trimestre fue " + promedioTrimestre);
            Console.ReadKey();

            if (promedioTrimestre >= 3)
            {
                Console.WriteLine("El aprendiz ha aprobado el trimestre");
               
            }
            else
            {
                Console.WriteLine("El aprendiz no ha aprobado el trimestre.");
            }
            Console.ReadKey();

        }
    }
}

