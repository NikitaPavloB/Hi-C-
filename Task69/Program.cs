// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// // возводит число А в целую степень B с помощью рекурсии.
// // A = 3; B = 5 -> 243 (3⁵)
// // A = 2; B = 3 -> 8
Console.Clear();

Console.WriteLine("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

int result = Exponentiation(NumberA, NumberB);
Console.WriteLine("Результат: " + result);

int Exponentiation(int a, int b)
{
  if (b == 0)
  {
    return 1; // если степень равна нулю, возвращаем 1
  }
  else
  {
    return a * Exponentiation(a, b - 1); // рекурсивно вызываем функцию для степени на 1 меньше и умножаем на число
  }
}
