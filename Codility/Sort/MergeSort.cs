using System.Diagnostics;

namespace Assesment.Sort
{
    public static class MergeSort
    {
        public static void Sort(ref int[] array)
        {
            int[] helper = new int[array.Length];
            Sort(ref array, ref helper, 0, array.Length - 1);
        }
        private static void Sort(ref int[] array, ref int[] helper, int low, int high)
        {
            if (low < high)
            {
                Debug.Write($"ms({low},{high}) ");
                for (int i = low; i <= high; i++) Debug.Write($"{array[i]}"); Debug.WriteLine("");
                int mid = (low + high) / 2;
                Sort(ref array, ref helper, low, mid);
                Sort(ref array, ref helper, mid + 1, high);
                Merge(ref array, ref helper, low, mid, high);
            }
        }
        private static void Merge(ref int[] array, ref int[] helper, int low, int mid, int high)
        {
            for (int i = low; i <= high; i++)
                helper[i] = array[i];
            int helperLeft = low;
            int helperRight = mid + 1;
            int current = low;
            while(helperLeft <= mid && helperRight <= high)
            {
                if (helper[helperLeft] <= helper[helperRight])
                {
                    array[current] = helper[helperLeft];
                    helperLeft++;
                }
                else
                {
                    array[current] = helper[helperRight];
                    helperRight++;
                }
                current++;
            }
            int remainder = mid - helperLeft;
            for (int i = 0; i <= remainder; i++)
                array[current + i] = helper[helperLeft + i];
        }
    }
}
