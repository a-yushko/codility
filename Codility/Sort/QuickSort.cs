using System.Diagnostics;

namespace Assesment.Sort
{
    public static class QuickSort
    {
        public static void Sort(ref int[] array)
        {
            Sort(ref array, 0, array.Length - 1);
        }

        private static void Sort(ref int[] array, int left, int right)
        {
            Debug.WriteLine($"qs({left},{right})");
            int index = Partition(ref array, left, right);
            if (left < index - 1)
                Sort(ref array, left, index - 1);
            if (index < right)
                Sort(ref array, index, right);
        }

        private static int Partition(ref int[] array, int left, int right)
        {
            int pivot = array[(left + right) / 2];
            while (left <= right)
            {
                while (array[left] < pivot)
                    left++;
                while (array[right] > pivot)
                    right--;
                if (left <= right)
                {
                    Swap(ref array[left], ref array[right]);
                    left++;
                    right--;
                }
            }
            return left;
        }
        private static void Swap(ref int left, ref int right)
        {
            if (left == right)
                return;
            var temp = left;
            left = right;
            right = temp;
        }
    }
}
