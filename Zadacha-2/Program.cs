//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Дай мне два числа!");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
if (a<b)
{
    Console.WriteLine("Число b = " + b + " больше числа a = " + a);
}  
if (a>b)
{
    Console.WriteLine("Число a = " + a + " больше числа b = " + b);
}  
if (a==b)
{
    Console.WriteLine("Числа равны");
}
