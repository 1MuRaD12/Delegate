using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            double[] arr = { 5, 6, 4, 7, 10, 20, 30 };
            Action<double[]> action = product.Total;
            action(arr);

        }

    }
}
