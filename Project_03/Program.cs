/*Задача 38:
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.
[3, 7, 22, 2, 78] -> 76
*/

int[] array = new int[4];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(-99, 100);
    }
int max = array[0];
int min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];

    if (array[i] < min)
        min = array[i];
}
int sum = max - min;
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
System.Console.WriteLine("Максимальное число: " + max);
System.Console.WriteLine("Минимальное число: " + min);
System.Console.WriteLine("Разница между числами: " + sum );