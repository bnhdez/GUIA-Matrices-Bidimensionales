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
                int num_estudiante = estudiante + 1;
                for (int semanas = 0; semanas < 4; semanas++) // for interno para columnas
                {
                    int num_semana = semanas + 1;
                    Console.Write("[Estudiante " + num_estudiante + ", Semana " + num_semana + "]: ");
                    control[estudiante, semanas] = Console.ReadLine();

                }
            }

            //Visualizacion de matriz con datos ingresados
            Console.WriteLine("\n********************** TABLA DE CONTROL *****************************\n");
            Console.WriteLine("\tSEMANA 1\tSEMANA 2\tSEMANA 3\tSEMANA 4");
            for (int estudiante = 0; estudiante < 7; estudiante++)
            {
                for (int semanas = 0; semanas < 4; semanas++)
                {
                    Console.Write("\t" + control[estudiante, semanas] + "\t");
                }
                Console.Write("\n");
            }

            //conteo de asistencias
            int ctrl_vrtl = 0, ctrl_presencial = 0, ctrl_hibrid = 0;
            //estudiante 1
            if ((control[0,0] == "virtual") && (control[0,1] == "virtual") && (control[0, 2] == "virtual") && (control[0, 3] == "virtual"))
            {
                ctrl_vrtl = ctrl_vrtl + 1;
            }
            else if ((control[0, 0] == "presencial") && (control[0, 1] == "presencial") && (control[0, 2] == "presencial") && (control[0, 3] == "presencial"))
            {
                ctrl_presencial = ctrl_presencial + 1;
            }
            else
            {
                ctrl_hibrid = ctrl_hibrid + 1;
            }
            //estudiante 2
            if ((control[1, 0] == "virtual") && (control[1, 1] == "virtual") && (control[1, 2] == "virtual") && (control[1, 3] == "virtual"))
            {
                ctrl_vrtl = ctrl_vrtl + 1;
            }
            else if ((control[1, 0] == "presencial") && (control[1, 1] == "presencial") && (control[1, 2] == "presencial") && (control[1, 3] == "presencial"))
            {
                ctrl_presencial = ctrl_presencial + 1;
            }
            else
            {
                ctrl_hibrid = ctrl_hibrid + 1;
            }
            //estudiante 3
            if ((control[2, 0] == "virtual") && (control[2, 1] == "virtual") && (control[2, 2] == "virtual") && (control[2, 3] == "virtual"))
            {
                ctrl_vrtl = ctrl_vrtl + 1;
            }
            else if ((control[2, 0] == "presencial") && (control[2, 1] == "presencial") && (control[2, 2] == "presencial") && (control[2, 3] == "presencial"))
            {
                ctrl_presencial = ctrl_presencial + 1;
            }
            else
            {
                ctrl_hibrid = ctrl_hibrid + 1;
            }
            //estudiante 4
            if ((control[3, 0] == "virtual") && (control[3, 1] == "virtual") && (control[3, 2] == "virtual") && (control[3, 3] == "virtual"))
            {
                ctrl_vrtl = ctrl_vrtl + 1;
            }
            else if ((control[3, 0] == "presencial") && (control[3, 1] == "presencial") && (control[3, 2] == "presencial") && (control[3, 3] == "presencial"))
            {
                ctrl_presencial = ctrl_presencial + 1;
            }
            else
            {
                ctrl_hibrid = ctrl_hibrid + 1;
            }
            //estudiante 5
            if ((control[4, 0] == "virtual") && (control[4, 1] == "virtual") && (control[4, 2] == "virtual") && (control[4, 3] == "virtual"))
            {
                ctrl_vrtl = ctrl_vrtl + 1;
            }
            else if ((control[4, 0] == "presencial") && (control[4, 1] == "presencial") && (control[4, 2] == "presencial") && (control[4, 3] == "presencial"))
            {
                ctrl_presencial = ctrl_presencial + 1;
            }
            else
            {
                ctrl_hibrid = ctrl_hibrid + 1;
            }
            //estudiante 6
            if ((control[5, 0] == "virtual") && (control[5, 1] == "virtual") && (control[5, 2] == "virtual") && (control[5, 3] == "virtual"))
            {
                ctrl_vrtl = ctrl_vrtl + 1;
            }
            else if ((control[5, 0] == "presencial") && (control[5, 1] == "presencial") && (control[5, 2] == "presencial") && (control[5, 3] == "presencial"))
            {
                ctrl_presencial = ctrl_presencial + 1;
            }
            else
            {
                ctrl_hibrid = ctrl_hibrid + 1;
            }
            //estudiante 7
            if ((control[6, 0] == "virtual") && (control[6, 1] == "virtual") && (control[6, 2] == "virtual") && (control[6, 3] == "virtual"))
            {
                ctrl_vrtl = ctrl_vrtl + 1;
            }
            else if ((control[6, 0] == "presencial") && (control[6, 1] == "presencial") && (control[6, 2] == "presencial") && (control[6, 3] == "presencial"))
            {
                ctrl_presencial = ctrl_presencial + 1;
            }
            else
            {
                ctrl_hibrid = ctrl_hibrid + 1;
            }

            //imprimimos resultados de control
            Console.WriteLine("\n**********************************************************************\n");
            Console.WriteLine("\nNumero de estudiantes que recibieron las clases unicamente de manera virtual: " + ctrl_vrtl);
            Console.WriteLine("Numero de estudiantes que recibieron las clases unicamente de manera presencial: " + ctrl_presencial);
            Console.WriteLine("Numero de estudiantes que recibieron las clases unicamente de manera hibrida: " + ctrl_hibrid);
        }
    }
}
