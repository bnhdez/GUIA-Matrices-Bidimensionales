using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] control = new string[7,4];

            Console.WriteLine("Ingrese 'virtual', 'presencial' o 'hibrido' segun el estudiante y semana correspondiente\n");

            //cargar y visualizar una matriz
            for (int estudiante = 0; estudiante < 7; estudiante++) //for para filas
            {
                int asistencia = estudiante + 1;
                for (int semanas = 0; semanas < 4; semanas++) // for interno para columnas
                {
                    int num_semana = semanas + 1;
                    Console.Write("Ingrese el numero de estudiantes correspodientes [Estudiante " + asistencia + ", Semana " + num_semana + "]: ");
                    control[estudiante, semanas] = Console.ReadLine();

                }
            }

            //Visualizacion de matriz con datos ingresados
            Console.WriteLine("\n********************** TABLA DE CONTROL **************************\n");
            Console.WriteLine("\tSEMANA 1\tSEMANA 2\tSEMANA 3\tSEMANA 4");
            for (int estudiante = 0; estudiante < 7; estudiante++)
            {
                for (int semanas = 0; semanas < 4; semanas++)
                {
                    Console.Write("\t" + control[estudiante, semanas] + "\t");
                }
                Console.Write("\n");
            }

            

        }
    }
}
