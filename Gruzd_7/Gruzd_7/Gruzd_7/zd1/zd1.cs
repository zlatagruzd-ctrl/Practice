namespace Gruzd_7
{
    public class zd1
    {
        public static void zd()
        {
            int[] numbers = { 5, 2, 9, 1, 7 };

            BubbleSort bubble = new BubbleSort();
            QuickSort quick = new QuickSort();

           
            SortMethod sortBubble = bubble.Sort;
            SortMethod sortQuick = quick.Sort;

            Console.WriteLine("Исходный массив: " + string.Join(", ", numbers));

            
            int[] bubbleResult = sortBubble(numbers);
            Console.WriteLine("BubbleSort: " + string.Join(", ", bubbleResult));

           
            int[] quickResult = sortQuick(numbers);
            Console.WriteLine("QuickSort: " + string.Join(", ", quickResult));
        }
    }
}