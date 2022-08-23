double[] differenceArrayElement = new double[5];

for (int i = 0; i < differenceArrayElement.Length; i++)
{
    differenceArrayElement[i] = new Random().Next(100);
}
Console.WriteLine($"Массив: [{String.Join(",", differenceArrayElement)}]");

double max = differenceArrayElement[0];
double min = differenceArrayElement[0];

for (int i = 0; i < differenceArrayElement.Length; i++)
{
    if(differenceArrayElement[i] > max) max = differenceArrayElement[i];
    if(differenceArrayElement[i] < min) min = differenceArrayElement[i];
}
double difference = max - min;
Console.WriteLine($"Разница между минимальным {min} и максимальным {max} элементом массива: {difference}");