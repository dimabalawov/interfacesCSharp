using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;


namespace MyArraySpace
{
    public class MyArray : IOutput, ICalc, IOutput2, ICalc2
    {
        int[] arr;
        int len;
        public MyArray() { }
        public MyArray(int len)
        {
            this.arr = new int[len];
            this.len = len;
        }
        public void show()
        {
            foreach (int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public void FillWRandom()
        {
            Random rnd = new Random();
            for (int i = 0; i < len; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
        }
        public int Greater(int valutToComapre)
        {
            int count = 0;
            foreach (int i in arr)
                if (i > valutToComapre)
                    count++;
            return count;
        }
        public int Less(int valutToComapre)
        {
            int count = 0;
            foreach (int i in arr)
                if (i < valutToComapre)
                    count++;
            return count;
        }
        public void showEven()
        {
            foreach (int i in arr)
                if (i % 2 == 0)
                    Console.WriteLine($"{i} ");
            Console.WriteLine();
        }
        public void showOdd()
        {
            foreach (int i in arr)
                if (i % 2 == 1)
                    Console.WriteLine($"{i} ");
            Console.WriteLine();
        }
        public int CountDistinct()
        {
            int count = 0;
            foreach (int i in arr)
            {
                int z = 0;
                foreach (int j in arr)
                    if (i == j)
                        z++;
                if (z == 1) count++;
            }
            return count;
        }
        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int i in arr)
                if (i == valueToCompare) count++;
            return count;
        }
    }
}

