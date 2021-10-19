using System;
using System.Collections.Generic;

namespace array_prueba
{
    class matriz2d
    {
        static void Main(string[] args)
        {
            Console.WriteLine("array 2d");

            Console.WriteLine("ingrese la cantidad de filas (valor x)");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese la cantidad de columnas (valor y)");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("cantidad de filas: " + a + "\ncantidad de columnas: " + b);

            //iniciar array

            int[,] matriz2d = new int[a, b];

            //llenar cada elemento array

            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {
                    Console.WriteLine("ingrese el numero para llenar el array: ");
                    matriz2d[x, y] = Convert.ToInt32(Console.ReadLine());

                }
            }

            Console.WriteLine("\nmostrar cada elemento del array ");

            //mostrar cada elemento array

            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {
                    Console.Write(matriz2d[x, y] + " ");


                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("\nmostrar negativos ");

            //mostrar negativos

            //contador negativos nx
            int nx = 0;

            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {

                    if (matriz2d[x, y] < 0)
                    {
                        Console.Write(matriz2d[x, y] + " ");
                        nx++;
                    }

                }
                Console.WriteLine(" ");
            }

            Console.WriteLine("\nmostrar total negativos: " + nx);

            Console.WriteLine("\nmostrar positivos ");

            //mostrar positivos

            //contador positivos sx
            int sx = 0;

            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {

                    if (matriz2d[x, y] > 0)
                    {
                        Console.Write(matriz2d[x, y] + " ");
                        sx++;

                    }

                }
            }

            Console.WriteLine("\nel total de positivos es: " + sx);

            Console.WriteLine("\nmostrar ceros ");

            //mostrar ceros
            //contador ceros gx

            int gx = 0;

            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {

                    if (matriz2d[x, y] == 0)
                    {
                        Console.Write(matriz2d[x, y] + " ");
                        gx++;
                    }

                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("\ntotal ceros" + gx);
        }
    }
}
