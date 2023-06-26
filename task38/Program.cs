// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] array = {3.22, 4.2, 1.15, 77.15, 65.2, 57.8, 1.01, 99.1};
double max = array [0];
double min = array [0];
for(int i = 1; i < array.Length; i++)
{
    if(max < array[i])
    {
        max = array [i];
    }
    else if (min > array[i])
    {
        min = array [i];
    }
}
double result = max - min;
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива. = {result:f2}");