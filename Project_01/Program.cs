/*
Задача 36:
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}

int SumNegative(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] array = new int[4];
array = NewArray(array);
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
System.Console.WriteLine("Сумма элементов на нечётных позициях: " + SumNegative(array));