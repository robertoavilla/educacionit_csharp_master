﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            // FORMA 1
            // asignando valores al array al mismo tiempo que se declara,
            // la lista de valores debe ir encerrada entre llaves
            string[] VECTOR = { "LORENA", "ESTEBAN", "ARIEL" };
            byte K = 0;
            for (K = 0; K <= 2; K++)
            {
                Console.WriteLine(VECTOR[K]);
            }
            Console.WriteLine();
            // FORMA 2
            // declarar primero la variable que contendrá el array,
            // asignar valores al array al mismo tiempo que se instancia
            // la lista de valores debe ir encerrada entre llaves
            int[] MILISTA = null;
            MILISTA = new int[] { 15, 20, 30, 10, 50, 60, 10, 150, 69 };
            for (K = 0; K <= MILISTA.Length - 1; K++)
            {
                Console.WriteLine(MILISTA[K]);
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();

        }
    }
}
