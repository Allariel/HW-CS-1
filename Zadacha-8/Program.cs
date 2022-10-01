// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Корми мне число");
int a = Convert.ToInt32(Console.ReadLine());
//можно вводить отрицательные числа
a = Math.Abs(a);
for (int i = 2; i <= a; i=i+2)
{
    Console.WriteLine(" " + i);
}
