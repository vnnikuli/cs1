// задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// 1. Console.WriteLine ("введите пятизначное число");
// int N = Convert.ToInt32 (Console.ReadLine());
// int w1 = N / 10000;
// int q1 = N % 10;
 
// if(w1 == q1)
// {
//     N = N / 10;
//     int w2 = (N / 100) % 10;
//     int q2 = N % 10;
//     if(w2 == q2)
//         Console.WriteLine("Да");
// }
// else Console.WriteLine("Нет");

// Console.WriteLine ("введите пятизначное число");
// int N = Convert.ToInt32 (Console.ReadLine());
// int result = 0;
// while (N<0)
// {
//     result = result * 10 + N % 10;
//     N /=10; 
// }
// if (result == N)
// {
//     Console.Write("полиндром");
// }
// else 
// {
//     Console.Write("не полиндром");
// }

    
//     Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine ("введите координаты точки АN");
// int N1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine ("введите координаты точки Аy");
// int y1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine ("введите координаты точки Аz");
// int z1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine ("введите координаты точки By");
// int N2 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine ("введите координаты точки BN");
// int y2 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine ("введите координаты точки Bz");
// int z2 = Convert.ToInt32 (Console.ReadLine());

// int sum = ((N2-N1)*(N2-N1))+((y1-y2) * (y1-y2) + ((z1-z2) * (z1-z2)));
// double distance = Math.Round(Math.Sqrt(sum),2);

// Console.WriteLine ($"Дистанция равна {distance}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine ("введите N");
// int N = Convert.ToInt32 (Console.ReadLine());

// for (int i=1; i <= N; i++)
//     {
//             Console.WriteLine($"{i * i * i}");
//     }
