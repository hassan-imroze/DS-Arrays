using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Arrays
{
    public class GenericArray<T>
    {
        private T[] array;
        private int count;

        public int Count { get { return count; } }


        public GenericArray(int length)
        {
            array = new T[length]; 
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public void Insert(T item)
        {
            if(count == array.Length)
            {
                var tempArray = new T[count * 2];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = array[i];
                }
                array = tempArray;
            }

            array[count++] = item;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            for (int i = index; i < count; i++)
            {
                array[i] = array[i + 1];
            }
            count--;

        }

        public int IndexOf(T item)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if(array[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        

    }
}
