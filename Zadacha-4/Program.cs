//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Дай мне три числа!");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double max = a;
if ((a==b) & (a==c) & (b==c))
{
    Console.WriteLine("Все числа равны");
}  
else
{


if (max<b)
{
    max=b;
}  
if (max<c)
{
    max = c;
}
Console.WriteLine("Max = " + max);
}
