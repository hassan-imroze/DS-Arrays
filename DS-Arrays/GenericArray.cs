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

        public GenericArray(int length)
        {
            array = new T[length]; 
        }

        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
}
