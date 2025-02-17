using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Cola
{
    internal class Queue
    {
        Node Head;
        Node Tail;

        public bool CheckQueueEmpty()
        {
            return Tail == null;
        }
        public void Enqueue(object Cliente)
        {
            if (CheckQueueEmpty())
            {
                Head = Tail = new Node(Cliente);
            }
            else
            {
                Tail = Tail.Next = new Node(Cliente);
            }
        }

        public Object Dequeue()
        {
            if (CheckQueueEmpty())
            {
                Console.WriteLine("No hay clientes Chato.");
                return null;
            }
            else
            {
                object DequeuedObject = Head;
                Head = Head.Next;
                return DequeuedObject;
            }
        }

        public void PrintQueue()
        {
            int i = 1;
            Node current = Head;
            if (CheckQueueEmpty())
            {
                Console.WriteLine("La cola esta vacía");
            }
            while (current != null)
            {
                Console.Write("Posición en la cola: " + i +  " -> Cliente " + current.Dato);
                current = current.Next;
                i++;

            }
        }

    }
}
