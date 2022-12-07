//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10); // [-9, 9]
}


string ReleaseArray(int[] array, int k)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == k)
            return "yes";
    }
    return "no";
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Введите число, которое нужно найти в массиве: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, k));
