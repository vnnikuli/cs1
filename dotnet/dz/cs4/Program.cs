// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("введите число A");
// int numA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите число B");
// int numB = Convert.ToInt32(Console.ReadLine());
// int numC = numA;
// int i = 2;
// while(i<=numB)
// {
//     numA = numA * numC;
//     i++;
// }

//     Console.WriteLine($"{numA}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// void addition(int num)
// {
//     int i = 0;
//     int sum = 0;
//     int num2 = 0;
//     while(num>0)
//     {
//         num2 = num % 10;
//         num = num/10;
//         sum = sum + num2;
//         Console.WriteLine($"{sum}");
//         i++;
//     }  
// }
// addition(452);
// Console.WriteLine();
// addition(82);
// Console.WriteLine();
// addition(9012);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] arrey = new int [8];
int A = new Random().Next(1, 10);
void Random(int[]arrey)
{
    for(int i = 0; i<arrey.Length; i++)
    {
        arrey[i]=new Random().Next(0,10);
    }
}
void Print(int[]arrey)
{
    for(int i = 0; i<arrey.Length; i++)
    {
        Console.Write(arrey[i]);
    }
}
Random(arrey);
Print(arrey);
