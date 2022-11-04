Console.WriteLine("введите первое число ");
int q = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите встороe число");
int z = Convert.ToInt32(Console.ReadLine());

int max = q;
if(a>max) max = q;
if(z>max) max = z;

Console.WriteLine ($"максимальное {max}");