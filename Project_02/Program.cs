/*
Задача 38:
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3, 7, 22, 2, 78] -> 76
*/

//ПРОГРАММА БЕЗ СЧЁТА РАЗНИЦЫ!!! ПРОГРАММА СО СЧЁТОМ РАЗНИЦЫ ПОД НОМЕРОМ _03 !!!

int[] array = new int[4];
int [] NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}
int GetMaxNumbers(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}
int GetMinNumbers(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

array = NewArray(array);
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
System.Console.WriteLine("Максимальное число: " + GetMaxNumbers(array));
System.Console.WriteLine("Минимальное число: " + GetMinNumbers(array));