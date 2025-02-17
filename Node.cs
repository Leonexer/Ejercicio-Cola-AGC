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
            Dato = this.Dato;
            Next = this.Next;
        }

        public Node(object Dato)
        {
            Dato = this.Dato;
            Next = null;
        }
    }
}
