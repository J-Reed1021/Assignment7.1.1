namespace Assignment7._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 57, 29, 80, 26, 34 };
            SelectionSort(arr);
            Console.WriteLine("Sorted array");
            printArray(arr);
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.WriteLine(arr[i] + " ");
            Console.WriteLine();

        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            int lastElement = n-1;

            //Outer loop points to dividing line between sorted and unsorted
            for (int i = 0; i < lastElement; ++i)
            {
                //Find minimum element in unsorted portion
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }



                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        
        }
    }
}
