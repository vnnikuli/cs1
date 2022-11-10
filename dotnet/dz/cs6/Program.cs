// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("введите число");
// var M = Convert.ToInt32(Console.ReadLine());
// var sum = 0;
// var[] array = new var[M];
// for (var i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 10);
//     Console.Write(array[i] + " ");
// }
// for (var j = 0; j < array.Length; j++)
// {
//     if(array[j] > 0)
//     {
//         sum=sum+1;
//     }
// }
// Console.WriteLine($"числе больше ноля {sum}");
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());


var x = (b2 - b1) / (k1 - k2);
var y = k1 * (b2 - b1) / (k1 - k2) + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Пересечение в точке: ({x};{y})");
