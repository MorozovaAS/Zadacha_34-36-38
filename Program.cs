// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void Zadacha1()
{
    int[] CreatorArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 999);
        }
        return array;
    }
    // int[] NumberArray(int[] array)
    // {
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         array[i]*=-1;
    //     }
    //     return array;
    // }
    int FindingEvenNumbers(int[] array)
    {
        int even = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                even += 1;
            }
        }
        return even;
    }

    int[] array = CreatorArray(8);
    Console.WriteLine(String.Join(" ", array));
    Console.WriteLine("Количество четных элементов в массиве равно: " + FindingEvenNumbers(array));
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void Zadacha2()
{
    int[] CreatorArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-10, 11);
        }
        return array;
    }

    int SumOfOddNumbers(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum = sum + array[i];
            }
        }
        return sum;
    }

    int[] array = CreatorArray(4);
    Console.WriteLine(String.Join(" ", array));
    Console.WriteLine("Сумма элементов в массиве, стоящих на нечётных позициях, равна: " + SumOfOddNumbers(array));
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void Zadacha3()
{
    int[] CreatorArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 100);
        }
        return array;
    }

    int DifferenceBetweenMaxAndMin(int[] array)
    {
        int max = array[0];
        int min = array[0];
        int difference = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            else if (array[i] < min)
            {
                min = array[i];
            }
        }
        difference = max - min;
        return difference;
    }

    int[] array = CreatorArray(4);
    Console.WriteLine(String.Join(" ", array));
    Console.WriteLine("Разница между максимальным и минимальным элементами массива равна: " + DifferenceBetweenMaxAndMin(array));
}
