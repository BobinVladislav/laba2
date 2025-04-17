namespace laba2
{
    internal class Sort
    {
        static int[] Merge(int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];  // общий массив 
            int i = 0, j = 0, k = 0;
            while (a.Length > i && b.Length > j) // массивы не пустые 
                if (a[i] <= b[j])            // минимальный элемент 
                    result[k++] = a[i++];    // из left в result 
                else result[k++] = b[j++];   // из right в result 
            while (a.Length > i)        // массив right - пустой 
                result[k++] = a[i++];   // остаток left в result 
            while (b.Length > j)        // массив left - пустой 
                result[k++] = b[j++];   // остаток right в result 
            return result;              // возвращаем общий массив 
        }
       public static int[] MergeSort(int[] m, int left, int right)
        {
            if (left >= right)               // реально left == right 
            {
                int[] result = { m[left] };  // новый массив 
                return result;
            }
            else
            {
                int mid = (left + right) >> 1;    // индекс сред. элемента 
                int[] a = MergeSort(m, left, mid);  // сорт. левой части 
                int[] b = MergeSort(m, mid + 1, right);  // сорт. правой части 
                return Merge(a, b);    // слияние массивов a и b 
            }
        }
    }
}
