/*
* Student ID :1690704067
* Name       :Lap08
* Section    :129D
* No.        :
* Course     : GI113 Computer Programming (GI)
*/
using System.Diagnostics;

namespace Lab08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { -5, -2, -9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ": " + numbers[i]);
            }

            int sum;
            float average;

            sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            average = (float)sum / numbers.Length;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);

            int maximum;
            int minimum;

            maximum = numbers[0];
            minimum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }
            Console.WriteLine("Maximum: " + maximum);
            Console.WriteLine("Minimum: " + minimum);

            System.Array.Sort(numbers);
            foreach (int n in numbers)
            {
                Console.WriteLine("Sorted: " + n);
            }
        }
    }
}
