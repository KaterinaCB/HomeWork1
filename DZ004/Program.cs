﻿Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

for (i=1 ; i<N ; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}