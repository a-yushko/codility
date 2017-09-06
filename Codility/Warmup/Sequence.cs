using System;

namespace Assesment.Warmup
{
    static class Sequence
    {
        // print array of 10 million 10-bit integers in a sorted order as fast as possible
        public static void PrintSorted(int[] array)
        {
            int[] keys = new int[1024];
            for (int i = 0; i < 1024; i++)
                keys[i] = 0;

            foreach (var num in array)
                keys[num] = keys[num] + 1;
            // O (N)

            for (int i = 0; i < 1024; i++)
                for (int j = 0; j < keys[i]; j++)
                    Console.Write($"{i} ");
        }
    }
}
