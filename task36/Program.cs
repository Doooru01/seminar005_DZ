// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] GetRandomArray(int lengthArray)
{
int[] array = new int[lengthArray];
for(int i = 0; i < array.Length; i++)
{
array[i] = Random.Shared.Next(-100, 101);
}
return array;
}

Console.WriteLine("Введите длинну массива");
int lengthArray = Convert.ToInt32(Console.ReadLine());
int [] array = GetRandomArray(lengthArray);
int sum = 0;
for(int i = 1; i < array.Length; i=i+2)
{
sum += array[i];
}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Cуммa элементов, стоящих на нечётных позициях = {sum}");