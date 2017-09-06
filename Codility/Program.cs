using System;
using Assesment.Warmup;

namespace Assesment
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10000;
            var array = new int[length];
            var random = new Random();
            for (int i = 0; i < length; i++)
                array[i] = random.Next(1024);
            Sequence.PrintSorted(array);
            Console.ReadKey();
        }
    }
}
