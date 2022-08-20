int[] result = new int[10];
int evenNumber = 0;
for (int i = 0; i < result.Length; i++)
{
    result[i] = new Random().Next(100, 1000);
    if(result[i] % 2 ==0)
    {
        evenNumber++;
    } 
   }
Console.WriteLine($"Массив: [{String.Join(",", result)}]");   
Console.WriteLine($"Колличество четных чисел в массиве: {evenNumber}");