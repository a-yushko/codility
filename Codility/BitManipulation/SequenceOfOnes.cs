using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Assesment.BitManipulation
{
    public static class SequenceOfOnes
    {
        public static int CountSequence(int num)
        {
            if (num == 0)
                return 1;
            int start = 0;
            int length = CountOnes(num, start);
            int size = GetSize(num);
            for (int i = 0; i < size; i++)
            {
                if (CheckBit(num, i))
                    continue;
                var count = CountOnes(FlipBit(num, i), start);
                if (count > length)
                    length = count;
                start = i;
            }
            return length;
        }
        private static int GetSize(int num)
        {
            int size = Marshal.SizeOf(num) * 8;
            for (int i = 0; i < size; i++)
            {
                if (CheckBit(num, size - 1 - i))
                    return size - i;
            }
            return 1;
        }
        private static bool CheckBit(int num, int i)
        {
            return (num & (1 << i)) != 0;
        }
        private static int FlipBit(int num, int i)
        {
            return num ^ (1 << i);
        }
        private static int CountOnes(int num, int start)
        {
            int length = 0;
            int count = 0;
            for (int i = start; i < GetSize(num); i++)
            {
                if (!CheckBit(num, i))
                {
                    if (length < count)
                        length = count;
                    count = 0;
                }
                else
                    count++;
            }
            if (length < count)
                length = count;
            return length;
        }
    }
}
