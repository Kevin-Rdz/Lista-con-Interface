using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___Reto_Listas
{
    internal class ArrayListIterator<T> : Iterator<T>
    {
        private ArrayList<T> arrayList;
        internal int currentItem;
        public ArrayListIterator(ArrayList<T> arrayList)
        {
            this.arrayList = arrayList;
        }
        public Boolean hasNext()
        {
            return currentItem < arrayList.getSize();
        }
        public T next()
        {
            T data = arrayList.getAt(currentItem);
            currentItem++;
            return data;
        }
    }
}