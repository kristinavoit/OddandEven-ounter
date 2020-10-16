using System;

namespace OddandEvenСounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count the number of even and odd integers in the range specified by the user

            Console.WriteLine("Укажите начальное значение в диапазоне чисел для подсчета четных и нечетных чисел");
            int firstValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Укажите конечное значение в диапазоне чисел для подсчета четных и нечетных чисел");
            int secondValue = int.Parse(Console.ReadLine());
            int counterEven = 0; //even number counter
            int counterOdd = 0; //odd number counter
            while (firstValue < secondValue) {
                firstValue++;
                if (firstValue % 2 == 0)
                    counterEven++;
                else
                    counterOdd++;
            }
            Console.WriteLine("Четных целых чисел " + counterEven);
            Console.WriteLine("Нечетных целых чисел " + counterOdd);
        }
    }
}
