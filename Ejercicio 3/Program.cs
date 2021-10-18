using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] control = new double[4, 7];
            //cargar y visualizar una matriz
            for (int tipo_clase = 0; tipo_clase < 4; tipo_clase++) //for para filas
            {
                for (int semanas = 0; semanas < 7; semanas++) // for interno para columnas
                {
                    Console.Write("Ingrese el valor de la posición [" + tipo_clase + "," + semanas + "]: ");
                    control[tipo_clase, semanas] = int.Parse(Console.ReadLine());

                }
            }

            for (int tipo_clase = 0; tipo_clase < 4; tipo_clase++)
            {
                Console.Write("\n");
                for (int semanas = 0; semanas < 7; semanas++)
                {
                    Console.Write("\t" + control[tipo_clase, semanas] + "\t");
                }
            }



        }
    }
}
