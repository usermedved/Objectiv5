int[] array = new int[10];
int evenNumber = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if(array[i] % 2 ==0)
    {
        evenNumber++;
    } 
   }
Console.WriteLine($"Массив: [{String.Join(",", array)}]");   
Console.WriteLine($"Колличество четных чисел в массиве: {evenNumber}");