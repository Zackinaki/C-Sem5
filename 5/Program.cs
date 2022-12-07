// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11); // [1, 10]
}


void ReleaseArray(int[] array)
{
    int[] resultArray = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
        resultArray[i] = array[i] * array[array.Length - i - 1];
    Console.WriteLine($"[{string.Join(", ", resultArray)}]");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
