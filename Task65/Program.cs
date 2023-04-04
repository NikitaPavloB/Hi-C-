// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.Clear();

Console.WriteLine("Введите целое положительное число M: ");
int NumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N: ");
int NumberN = Convert.ToInt32(Console.ReadLine());
PrintNaturalNumbers(NumberM, NumberN);

void PrintNaturalNumbers(int m, int n)
{
  if (m == n)
  {
    Console.Write(m + " ");
    
  }
  else if (m < n)
  {
    PrintNaturalNumbers(m, n - 1);
    Console.Write(n + " ");
  }
  else
  {
    Console.Write(m + " ");
    PrintNaturalNumbers(m - 1, n);
  }
}
