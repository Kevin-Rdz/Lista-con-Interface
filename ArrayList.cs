using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2___Reto_Listas
{
    internal class ArrayList<T> : List<T>
    {

        private const int DEFAULT_SIZE = 2;
        internal T[] array;
        internal int size;
        public ArrayList()
        {
            array = new T[DEFAULT_SIZE];
        }
        public ArrayList(int size)
        {
            array = new T[size];
        }
        public void addAtTail(T data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }
            array[size] = data;
            size++;

        }
        public void addAtFront(T data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }
            if (size >= 0)
            {
                Console.Write(array, 0, array, 1, size);
            }
            array[0] = data;
            size++;
        }

        public void remove(int index)
        {
            remove(index, array);
        }

        public void remove(int index, T[] array)
        {
            if (index < 0 || index >= size)
            {
                return;
            }
            if (size - 1 - index >= 0)
            {
                Console.WriteLine(array, index + 1, array, index, size - 1 - index);
            }
            array[size - 1] = default(T);
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = default(T);
            }
            size = 0;
        }
        public void setAt(int index, T data)
        {
            if (index >= 0 && index > size)
            {
                array[index] = data;
            }

        }
        public T getAt(int index)
        {
            return index >= 0 && index < size ? array[index] : default(T);
        }
        public Iterator<T> getIterator()
        {
            return new ArrayListIterator<T>(this);
        }
        public int getSize()
        {
            return size;
        }
        private void increaseArraySize()
        {
            T[] newArray = new T[array.Length * 2];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;


        }
    }
}
