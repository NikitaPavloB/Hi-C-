﻿// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 100 && number <=999)
{
int numberLast = number % 10;

Console.WriteLine($"Последнее цифра трехзначного числа {numberLast}");
}
else 
{
  Console.WriteLine("Введите пожалуйста трехзначное число!");
}