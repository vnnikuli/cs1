// Задайте массив заполненный случайными  положительными трехзначными числами. Напишите программу , 
// которая покажет количства четных чисел в массиве 
// [345, 897, 568, 234] -> 2

// Console.WriteLine("введите число B");
// int size = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int [] array = new int [size];
//     for(int i = 0; i<array.Length; i++)
//     {
//         array[i]=new Random().Next(100,1000);
//         Console.Write (array[i] + " ");
//     }
//     for(int i = 0; i<array.Length; i++)
//     {
//         if (array[i]%2 == 0)
//         {
//             sum++;
//         }
//     }
//     Console.Write($"{sum}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int sumUneven = 0;
// int [] array = new int [4];
//     for(int i=0; i<array.Length; i++)
//     {
//         array [i] = new Random().Next(-10,30);
//         Console.Write (array[i] + " ");
//     }
//     for(int i=0; i<array.Length; i++)
//     {
//         if (i%2 != 0)
//         {
//             sumUneven = sumUneven + array[i];
//         }
//     }
// Console.WriteLine("");
// Console.WriteLine($"{sumUneven}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i=0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000) / 100);
    }
}
void PrintArray(double[]numbers)
{
    Console.Write("[ ");
    for (int i = 0; i <numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i <numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max=numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"раздница между минимальным и максимальным значением = {max-min}");
