using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Cola
{
    internal class Node
    {
        public Node Next;
        public object Dato;
        public Node(object Dato, Node Next)
        {
            this.Dato = Dato;
            this.Next = Next;
        }

        public Node(object Dato)
        {
            this.Dato = Dato;
            Next = null;
        }
    }
}
