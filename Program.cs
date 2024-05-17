using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practica_Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear Colas
            Queue miFila = new Queue();
            Console.Write("Ingrese la Cantidad de filas: ");
            int n = int.Parse(Console.ReadLine());
            int tamañoFila = n;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nombre: ");
                miFila.Enqueue(Console.ReadLine());

            }
            Console.WriteLine("<----------------------------------------------------->");
            Console.WriteLine("El cajero atendio a: ");
            while (tamañoFila > 0)
            {
                Console.Write("[" + miFila.Dequeue() + "]");
                tamañoFila--;
            }
            Console.ReadKey();
        }
    }
}
