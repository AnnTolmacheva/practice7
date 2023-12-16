using System;

class Program
{
    static void Main()
    {
        // Задаем значения M и N
        int M = 1;
        int N = 10;

        // Вызываем функцию для вывода чисел от M до N
        PrintNaturalNumbers(M, N);
    }

    // Функция для вывода натуральных чисел от M до N
    static void PrintNaturalNumbers(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start); // Вывод текущего числа
            PrintNaturalNumbers(start + 1, end); // Рекурсивный вызов для следующего числа
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        int m = 2;
        int n = 1;

        int result = AckermannFunction(m, n);

        Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n} равен {result}");
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        // Вызываем функцию для вывода элементов массива, начиная с конца
        PrintArrayReverse(array, array.Length - 1);
    }

    // Функция для вывода элементов массива, начиная с конца
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]); // Вывод текущего элемента
            PrintArrayReverse(arr, index - 1); // Рекурсивный вызов для предыдущего элемента
        }
    }
}