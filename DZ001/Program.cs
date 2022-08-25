Console.Write("ВВедите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Максиамльное число = " +num1);
}
else
{
    Console.WriteLine("Максиамльное число = " +num2);
}