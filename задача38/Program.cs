// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.



double[] CreateMassive(int col)
{
    double[] array = new double[col];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,10);
        Console.Write($"{array[i]}  ");
    }
    return array;
}

double DifMaxMin(double[] array)
{
    double max = array[1];
    double min =array[1];
    double dif = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    dif = max - min;
    Console.WriteLine($"Максимальный элемент в массиве={max}");
    Console.WriteLine($"Минимальный элемент в массиве={min}");
    return dif;
}


Console.WriteLine("Введите количество элементов массива");
int col = Convert.ToInt32(Console.ReadLine());
double[] array = CreateMassive(col);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным числами в массиве={DifMaxMin(array)}");
