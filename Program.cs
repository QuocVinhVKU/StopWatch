using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng StopWatch
            StopWatch stopWatch = new StopWatch();

            // Mảng chứa 100,000 số
            int[] numbers = new int[100000];
            Random random = new Random();

            // Khởi tạo mảng với các số ngẫu nhiên
            for (int i = 0; i < 100000; i++)
            {
                numbers[i] = random.Next(1, 100000);
            }

            // Sắp xếp mảng và đo thời gian thực thi
            stopWatch.Start();
            SelectionSort(numbers);

            stopWatch.Stop();

            // In ra thời gian thực thi
            Console.WriteLine("Elapsed Time: " + stopWatch.GetElapsedTime() + " milliseconds");

            Console.ReadKey();
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
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
