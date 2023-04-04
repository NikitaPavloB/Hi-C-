// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumDigits(number);
Console.WriteLine($"Сумма цифр числа:{sum}." );

int SumDigits(int num)
{
  if (num < 10)
  {
    return num; 
  }
  else
  {
    int lastDigit = num % 10; 
    int remainingDigits = num / 10; 
    return lastDigit + SumDigits(remainingDigits); 
  }
}

// int SumDigits(int num)
// {
//     if (num == 0) return 0;    //1! = 1  0! = 1
//     else return SumDigits(num / 10) + num % 10;
// }

// Console.Clear();
// Console.WriteLine("Вводим число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = SumDigits(number);
// Console.WriteLine(sum);