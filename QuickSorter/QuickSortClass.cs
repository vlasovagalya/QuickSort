using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSorter
{
    public class QuickSortClass
    {
        public static void QuickSort(int a, int[] array)
        {
            int startIndex = 0;
            int endIndex = array.Length - 1;
            QuickSort(array, startIndex, endIndex);
        }

        public static void QuickSort(int a, int b, int c)
        {
            throw new NotImplementedException();
        }

        public static void QuickSort(int[] array, int start, int end)
        {
            int Partition()
            {
                int key = array[end];
                int i = start - 1;
                for (int j = start; j < end; j++)
                {
                    if (array[j] <= key) Swap(ref array[++i], ref array[j]);
                }
                Swap(ref array[++i], ref array[end]);
                return i;
            }

            if (start < end)
            {
                int key = Partition();
                QuickSort(array, start, key - 1);
                QuickSort(array, key + 1, end);
            }
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public static void QuickSort(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}
