using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] control = new int[3,4];

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

            //Visualizacion de matriz con datos ingresados
            Console.WriteLine("\n********************** TABLA DE CONTROL **************************\n");
            Console.WriteLine("\tSEMANA 1\tSEMANA 2\tSEMANA 3\tSEMANA 4");
            for (int tipo_clase = 0; tipo_clase < 3; tipo_clase++)
            {
                for (int semanas = 0; semanas < 4; semanas++)
                {
                    Console.Write("\t" + control[tipo_clase, semanas] + "\t");
                }
                Console.Write("\n");
            }

            //resultados
            int total_virtual, total_presencial, total_hibridos;
            total_virtual = control[0, 0] + control[0, 1] + control[0, 2] + control[0, 3];
            total_presencial = control[1, 0] + control[1, 1] + control[1, 2] + control[1, 3];
            total_hibridos = control[2, 0] + control[2, 1] + control[2, 2] + control[2, 3];
            //imprimimos
            Console.WriteLine("\nNumero de estudiantes que recibieron las clases unicamente de manera virtual es de: " + total_virtual);
            Console.WriteLine("Numero de estudiantes que recibieron las clases unicamente de manera presencial es de: " + total_presencial);
            Console.WriteLine("Numero de estudiantes que recibieron las clases de manera hibrida es de: " + total_hibridos);

        }
    }
}
