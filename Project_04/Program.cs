/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами.
Напишите программу,которая покажет
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

int NumberPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
           sum++;
        }
    }
    return sum;
}

int[] array = new int[4];
array = NewArray(array);
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
System.Console.WriteLine("Колличество положительных чисел: " + NumberPositive(array));