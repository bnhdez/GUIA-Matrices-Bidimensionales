using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            double resultado = 0;
            double prom = 0;
            float[,] ejer = new float[3, 5];
            double[,] tempe = new double[30, 24];
            Console.Title = "Ejercicio 2";
            double[,] ejer2 = new double[3, 5];

            for (int filas = 0; filas < 3; filas++)
            {
                while (n <= 5)
                {
                    for (int columnas = 0; columnas < 5; columnas++)
                    {

                        Console.Write("Ingrese el valor[" + filas + "," + columnas + "]: ");
                        ejer2[filas, columnas] = double.Parse(Console.ReadLine());

                        if ((ejer2[filas, columnas] >= 0.8239) || (ejer2[filas, columnas] <= 0.5977))
                        {
                            Console.WriteLine("Esta fuera de control");
                        }
                        else
                        {
                            Console.WriteLine("Esta bajo control");
                        }
                        resultado = resultado + ejer2[filas, columnas];
                        prom = resultado / 5;
                        n = n + 2;
                    }
                }
            }
            Console.Write("\n");
            Console.Write("Visualice la matriz de la primer pieza");
            Imprimir(ejer2);

            if ((prom >= 0.8239) || (prom <= 0.5977))
            {
                Console.WriteLine("\nEl promedio es " + prom);
                Console.WriteLine("Perdio el control total en promedio");
            }
            else
            {
                Console.WriteLine("\nEl promedio es" + prom);
                Console.WriteLine("Estabilizo el control total");
            }
            segunda(ejer2);

            tercera(ejer2);
        }


        static void Imprimir(double[,] ejer2)
        {
            for (int filas = 0; filas < 3; filas++)
            {
                Console.Write("\n");
                for (int columnas = 0; columnas < 5; columnas++)
                {
                    Console.Write("\t" + ejer2[filas, columnas] + "\t");
                }
            }
        }
        static void segunda(double[,] ejer2)
        {
            int n = 0;
            double resultado = 0;
            double prom = 0;
            float[,] ejer = new float[3, 5];
            double[,] tempe = new double[30, 24];
            Console.Title = "Ejercicio2";
            double[,] ventas2 = new double[3, 5];

            for (int filas = 1; filas < 3; filas++)
            {
                while (n <= 5)
                {
                    for (int columnas = 0; columnas < 5; columnas++)
                    {
                        Console.Write("Ingrese el valor[" + filas + "," + columnas + "]: ");
                        ventas2[filas, columnas] = double.Parse(Console.ReadLine());

                        if ((ventas2[filas, columnas] >= 0.8239) || (ventas2[filas, columnas] <= 0.5977))
                        {
                            Console.WriteLine("Esta fuera de control");
                        }
                        else
                        {
                            Console.WriteLine("Esta bajo control");
                        }
                        resultado = resultado + ventas2[filas, columnas];
                        prom = resultado / 5;
                        n = n + 2;
                    }
                }
            }
            Console.Write("\n");
            Console.Write("Ahora visualicemos la matriz");
            Imprimir(ventas2);

            if ((prom >= 0.8239) || (prom <= 0.5977))
            {
                Console.WriteLine("\nEl promedio de la segunda pieza es de " + prom);
                Console.WriteLine("Perdio el control total en promedio");
            }
            else
            {
                Console.WriteLine("\nEl promedio de la segunda pieza es de " + prom);
                Console.WriteLine("Estabilizo el control total");
            }


        }
        static void Imprimir2(double[,] Ventas)
        {
            for (int filas = 1; filas < 3; filas++)
            {
                Console.Write("\n");
                for (int columnas = 0; columnas < 5; columnas++)
                {
                    Console.Write("\t" + Ventas[filas, columnas] + "\t");

                }
            }
        }
        static void tercera(double[,] Ventas)
        {

            int n = 0;
            double resultado = 0;
            double prome = 0;
            float[,] ventas = new float[3, 5];
            double[,] temperaturas = new double[30, 24];
            Console.Title = "ejer2";
            double[,] ejerc = new double[3, 5];

            for (int filas = 2; filas < 3; filas++)
            {
                while (n <= 5)
                {
                    for (int columnas = 0; columnas < 5; columnas++)
                    {
                        Console.Write("Ingrese el valor  [" + filas + "," + columnas + "]: ");
                        ejerc[filas, columnas] = double.Parse(Console.ReadLine());

                        if ((ejerc[filas, columnas] >= 0.8239) || (ejerc[filas, columnas] <= 0.5977))
                        {
                            Console.WriteLine("Esta fuera de control");
                        }
                        else
                        {
                            Console.WriteLine("Esta bajo control, siga asi");
                        }
                        resultado = resultado + ejerc[filas, columnas];
                        prome = resultado / 5;
                        n = n + 2;
                    }
                }
            }
            Console.Write("\n");
            Console.Write("Ahora visualizamos la matriz");
            Imprimir(ejerc);

            if ((prome >= 0.8239) || (prome <= 0.5977))
            {
                Console.WriteLine("\nEl promedio de la tercera pieza es de " + prome);
                Console.WriteLine("Perdio el control total en promedio");
            }
            else
            {
                Console.WriteLine("\nEl promedio de la tercera pieza es de " + prome);
                Console.WriteLine("Estabilizo el control total");
            }

        }
        static void immprimir3(double[,] Ventas)
        {
            for (int filas = 2; filas < 3; filas++)
            {
                Console.Write("\n");
                for (int columnas = 0; columnas < 5; columnas++)
                {
                    Console.Write("\t" + Ventas[filas, columnas] + "\t");
                }
            }
        }
    }
}
