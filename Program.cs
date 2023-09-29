using System;
using System.Text;
using System.Linq;

namespace hw3
{
    /*
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть елементи масиву, розділені пробілами: ");
            string input = Console.ReadLine();
            int[] array = ParseInput(input);

            if (array == null)
            {
                Console.WriteLine("Помилка: Некоректний ввід.");
                return;
            }

            int evenCount = CountEvenNumbers(array);
            int oddCount = CountOddNumbers(array);
            int uniqueCount = CountUniqueNumbers(array);

            Console.WriteLine($"Кількість парних чисел: {evenCount}");
            Console.WriteLine($"Кількість непарних чисел: {oddCount}");
            Console.WriteLine($"Кількість унікальних чисел: {uniqueCount}");
        }

        static int[] ParseInput(string input)
        {
            try
            {
                int[] array = input.Split(' ').Select(int.Parse).ToArray();
                return array;
            }
            catch (FormatException)
            {
                return null;
            }
        }

        static int CountEvenNumbers(int[] array)
        {
            return array.Count(x => x % 2 == 0);
        }

        static int CountOddNumbers(int[] array)
        {
            return array.Count(x => x % 2 != 0);
        }

        static int CountUniqueNumbers(int[] array)
        {
            return array.Distinct().Count();
        }
    }
    */
    class Program
    {
        static void Main()
        {
            Console.Write("Введіть кількість рядків: ");
            int numRows = int.Parse(Console.ReadLine());

            Console.Write("Введіть кількість стовпців: ");
            int numCols = int.Parse(Console.ReadLine());

            int[,] array = new int[numRows, numCols];

            // Введення елементів масиву
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write($"Введіть елемент [{i},{j}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int min = FindMinValue(array);
            int max = FindMaxValue(array);

            Console.WriteLine($"Мінімальне значення: {min}");
            Console.WriteLine($"Максимальне значення: {max}");
        }

        static int FindMinValue(int[,] array)
        {
            int min = array[0, 0];

            foreach (int value in array)
            {
                if (value < min)
                    min = value;
            }

            return min;
        }

        static int FindMaxValue(int[,] array)
        {
            int max = array[0, 0];

            foreach (int value in array)
            {
                if (value > max)
                    max = value;
            }

            return max;
        }

    }
}