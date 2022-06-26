/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */


Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int[] FillArray(int[] fillarray)
{
    for (int i = 0; i < fillarray.Length; i++)
    {
        fillarray[i] = new Random().Next(101);
    }
    return fillarray;
}

array = FillArray(array);           
int sum = 0;
for (int i = 1; i < array.Length; i+=2)
{
    sum = sum + array[i];
}

PrintArray(array);

Console.WriteLine(MetodMax(array) - MetodMin(array));
        
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int MetodMin(int[] arr)
{
    int min= arr[0];
  for( int i = 1; i < array.Length; i++)
  {
    if(arr[i]<min)
    {
      min=arr[i];
    }
  }
  return min;
}

int MetodMax(int[] arr)
{
    int max= arr[0];
  for( int i = 1; i < array.Length; i++)
  {
    if(arr[i]>max)
    {
      max=arr[i];
    }
  }
  return max;
}


