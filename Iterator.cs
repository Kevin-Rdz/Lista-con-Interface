using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___Reto_Listas
{
    internal interface Iterator<T>
    {
        internal Boolean hasNext();
        internal T next();
    }
}
