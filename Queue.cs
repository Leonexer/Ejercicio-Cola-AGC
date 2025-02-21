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
        private Node Head = null;
        private Node Tail = null;

        public Queue()
        {
            this.Head = null;
            this.Tail = null;
        }
        public bool CheckQueueEmpty()
        {
            return Tail == null;
        }
        public void Enqueue(object Cliente)
        {
            if (CheckQueueEmpty())
            {
                Tail = Head = new Node(Cliente);
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
            Object DequeuedObject = Head.Dato;
            Head = Head.Next;
            if (Head == null)
            {
                Tail = null;
            }
            return DequeuedObject;
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
                Console.WriteLine("Posición en la cola: " + i +  " -> Cliente " + current.Dato);
                current = current.Next;
                i++;

            }
        }

    }
}
