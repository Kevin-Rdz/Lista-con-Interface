using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___Reto_Listas
{
     internal class Node <T>
    {
        internal T data;
        internal Node<T> next;
        internal Node<T> previous;

        internal Node(T data)
        {
            this.data = data;
        }
    }
}
