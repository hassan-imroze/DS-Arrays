﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicArrayPrint();
            Console.WriteLine();

            ArrayClassExcercise();
            
            Console.ReadKey();
        }

        static void BasicArrayPrint()
        {
            int[] array = new int[3];
            array[2] = 11;
            Console.WriteLine("Printing all items");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(string.Format("{0},",array[i]));
            }

        }

        static void ArrayClassExcercise()
        {
            GenericArray<int> numbers = new GenericArray<int>(length: 3);
            numbers.Print();
            numbers.Insert(4);
            numbers.Insert(2);
            numbers.Insert(12);
            numbers.Insert(10);
            numbers.Print();
            Console.WriteLine(numbers.IndexOf(12));
            Console.WriteLine(numbers.IndexOf(100));
            numbers.RemoveAt(2);
            numbers.Print();
        }
    }
}
