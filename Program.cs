using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Cola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue cola = new Queue();
            string opcion;

            do
            {
                Console.WriteLine("\n  ----- Menú -----");
                Console.WriteLine(" 1 Agregar Cliente");
                Console.WriteLine(" 2 Atender Cliente");
                Console.WriteLine(" 3 Mostrar Fila");
                Console.WriteLine(" 4 Cerrar Programa"); 
                Console.WriteLine("  ----------------");
                Console.Write("-> Elige una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingresa el nombre del cliente: ");
                        object nombre = Console.ReadLine();
                        cola.Enqueue(nombre);
                        Console.WriteLine($"Cliente {nombre} agregado a la cola.");
                        break;
                    case "2":
                        object atendido = cola.Dequeue();
                        if (atendido != null)
                        {
                            Console.WriteLine($"Cliente atendido: {atendido}");
                        }
                        break;
                    case "3":
                        cola.PrintQueue();
                        break;
                    case "4":
                        Console.WriteLine("Cerrando el sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, intenta de nuevo.");
                        break;
                }
            } while (opcion != "4");
        }
    }
}
