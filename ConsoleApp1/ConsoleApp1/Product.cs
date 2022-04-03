using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Product
    {
        public  void Total(double[] arr)
        {
            int count = default(int);
            int total = default(int);
            foreach (int num in arr)
            {
                count++;
                total += num;
            }
            Console.WriteLine($"Total:{total}\nCount:{count}");
        }
    }
}
