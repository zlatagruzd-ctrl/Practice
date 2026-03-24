namespace Gruzd_7
{
   
    public delegate int[] SortMethod(int[] array);

    
    public class BubbleSort
    {
        public int[] Sort(int[] array)
        {
            int[] arr = (int[])array.Clone();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }
    }

    // Класс с быстрой сортировкой
    public class QuickSort
    {
        public int[] Sort(int[] array)
        {
            int[] arr = (int[])array.Clone();
            Quick(arr, 0, arr.Length - 1);
            return arr;
        }

        private void Quick(int[] arr, int left, int right)
        {
            int i = left, j = right;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j) Quick(arr, left, j);
            if (i < right) Quick(arr, i, right);
        }
    }
}