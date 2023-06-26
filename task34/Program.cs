// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] GetRandomArray(int lengthArray)
{
int[] array = new int[lengthArray];
for(int i = 0; i < array.Length; i++)
{
array[i] = Random.Shared.Next(100, 1000);
}
return array;
}

Console.WriteLine("Введите длинну массива");
int lengthArray = Convert.ToInt32(Console.ReadLine());
int [] array = GetRandomArray(lengthArray);
int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        sum++;
    }
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Количество чётных чисел в массиве = {sum}");