// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateMassive(int col)
{
    int[] array = new int[col];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000,1000);
        Console.Write($"{array[i]}  ");
    }
    return array;
}

int SumEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}


Console.WriteLine("Введите количество элементов массива");
int col = Convert.ToInt32(Console.ReadLine());
int[] array = CreateMassive(col);
Console.WriteLine();
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях={SumEven(array)}");
