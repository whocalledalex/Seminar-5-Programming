// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// int[] array = CreateRandomArray(5, 100, 999);
// ShowArray(array);

// int numberOfEven = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//         numberOfEven++;
// }
// Console.WriteLine($"Amount of even numbers is: {numberOfEven}");





// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int[] array = CreateRandomArray(5, -1000, 1000);
// ShowArray(array);

// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if (i%2 == 0)
//     sum = sum + array[i];
// }

// Console.WriteLine($"Sum of uneven position numbers is: {sum}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int[] array = CreateRandomArray(5, 0, 1000);
// ShowArray(array);

// int max = array[1];
// int min = array[1];

// for (int i = 0; i < array.Length; i++)
// {
//     if (max < array[i])
//         max = array[i];
// }

// for (int i = 0; i < array.Length; i++)
// {
//     if (min > array[i])
//         min = array[i];
// }

// Console.WriteLine($"Max number is: {max}");
// Console.WriteLine($"Min number is: {min}");
// Console.WriteLine($"The difference between max and min is: {max - min}");