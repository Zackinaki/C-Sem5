// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// task 31


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9, 9]
}


void ReleaseArray(int[] array)
{
    int sumNegative = 0, sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPositive += array[i];
        else
            sumNegative += array[i];
    }
    Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
    Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);

