int[] array = new int[10];
double sumOddElement = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100);
    if(i % 2 == 1) sumOddElement += array[i];
     
}
Console.WriteLine($"Массив: [{String.Join(",", array)}]");   
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях в массиве: {sumOddElement}");