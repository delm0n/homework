using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ArraySort
    {
        public ArraySort() //конструктор
        {
        }
        public int[] a;
        private static void swap(ref int x, ref int y)
        {
            int temp = x; x = y; y = temp;
        }
        public void SelectSort(int[] a, ref int sr, ref int obm)
        {
            int max;
            int length = a.Length;
            for (int i = 0; i < length - 1; i++)
            {
                max = i;
                for (int j = i + 1; j < length; j++)
                {
                    sr++;
                    if (a[j] > a[max])
                    {
                        max = j;
                    }
                }

                sr++;
                if (max != i)
                {
                    swap(ref a[i], ref a[max]);
                    obm++;
                }
            }
        }
        public void InsertSort(int[] a, ref int sr, ref int obm)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int cur = a[i];
                int j = i;
                while (j > 0 && cur > a[j - 1])
                {
                    sr++;
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = cur;
            }
            sr++;
        }
        public void BubbleSort(int[] a, ref int sr, ref int obm)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    sr++;
                    if (a[j] < a[j + 1])
                    {

                        swap(ref a[j], ref a[j + 1]);
                        obm++;
                    }
                }
            }
        }
        public void BubbleSortRecur(int[] a, ref int sr, ref int obm)
        {
            {
                int i = 0;
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    sr++;
                    if (a[j] < a[j + 1])
                    {
                        swap(ref a[j], ref a[j + 1]);
                        obm++;
                        i++;
                    }
                }
                if (i == 0)
                    return;
                else
                    BubbleSortRecur(a, ref sr, ref obm);
            }
        }
        public void QuickSorting(int[] a, int first, int last, ref int sr, ref int obm)
        {
            int p = a[(last+first) / 2];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (a[i] > p && i < last) { ++i; sr++; }
                while (a[j] < p && j > first) { --j; sr++; }
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    ++i; --j; obm++;
                }
            }
            if (j > first) QuickSorting(a, first, j, ref sr, ref obm);
            if (i < last) QuickSorting(a, i, last, ref sr, ref obm);
            
        }
    
}
}
