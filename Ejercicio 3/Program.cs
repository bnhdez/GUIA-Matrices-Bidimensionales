using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] control = new double[3,4];
            //cargar y visualizar una matriz
            for (int tipo_clase = 0; tipo_clase < 3; tipo_clase++) //for para filas
            {
                for (int semanas = 0; semanas < 4; semanas++) // for interno para columnas
                {
                    Console.Write("Ingrese el valor de la posición [" + tipo_clase + "," + semanas + "]: ");
                    control[tipo_clase, semanas] = int.Parse(Console.ReadLine());

                }
            }

            for (int tipo_clase = 0; tipo_clase < 3; tipo_clase++)
            {
                Console.Write("\n");
                for (int semanas = 0; semanas < 4; semanas++)
                {
                    Console.Write("\t" + control[tipo_clase, semanas] + "\t");
                }
            }



        }
    }
}
