// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();

int[] array = CreateArrayRndInt(5,1,9);
PrintArray(array);
ArrayReverse(array);
Console.WriteLine();
PrintArray(array);

ArrayReverse(array);
Console.WriteLine();
PrintArray(array);

int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] array = new int[size];
  Random random = new Random();

  for (int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(min, max + 1);
  }

  return array;
}

void PrintArray(int[] arr)
{
  Console.WriteLine("[{0}]", string.Join(", ", arr));
}

void ArrayReverse(int[] arr)
{
  for (int i = 0; i < arr.Length / 2; i++)
  {
    int temp = arr[i];
    arr[i] = arr[arr.Length - 1 - i];
    arr[arr.Length - 1 - i] = temp;

  }
}