﻿

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * -1;

while (negativeN <= N)
{
    Console.Write(negativeN +" ");
    negativeN++;
}