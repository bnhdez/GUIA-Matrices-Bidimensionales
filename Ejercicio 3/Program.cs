using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] control = new double[3,4];

            Console.WriteLine("Ingrese los valores segun corresponde a la semana y el tipo de asistencia correspondiente");
            Console.WriteLine("Tipo de asistencia 1: SOLO VIRTUAL");
            Console.WriteLine("Tipo de asistencia 2: SOLO PRESENCIAL");
            Console.WriteLine("Tipo de asistencia 3: HIBRIDA\n");
            //cargar y visualizar una matriz
            for (int tipo_clase = 0; tipo_clase < 3; tipo_clase++) //for para filas
            {
                int asistencia = tipo_clase + 1;
                for (int semanas = 0; semanas < 4; semanas++) // for interno para columnas
                {
                    int num_semana = semanas + 1;
                    Console.Write("Ingrese el numero de estudiantes correspodientes [Tipo de asistencia " + asistencia + ", Semana " + num_semana + "]: ");
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
