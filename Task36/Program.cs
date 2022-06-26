/* Задача 36: Задайте одномерный массив, заполненный случайными 
   числами. Найдите сумму элементов, стоящих на нечётных позициях.
   [3, 7, 23, 12] -> 19
   [-4, -6, 89, 6] -> 0    
*/

int[] array = new int[4];
int[] FillArray(int[] fillarray)
{
  for (int i=0; i<fillarray.Length; i++)
  {
    fillarray [i] = new Random().Next(100);
  }
  return fillarray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.WriteLine();
}

array = FillArray(array);
PrintArray(array);

int summa = 0;
for (int i = 1; i < array.Length; i += 2)
{
    summa += array[i];
}
Console.WriteLine($"Сумма чисел на нечётных позициях = {summa}");