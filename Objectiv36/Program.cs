int[] array = new int[10];
double oddElement = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100);
    if(i % 2 == 1) oddElement += array[i];
     
}
Console.WriteLine($"Массив: [{String.Join(",", array)}]");   
Console.WriteLine($"Колличество четных чисел в массиве: {oddElement}");