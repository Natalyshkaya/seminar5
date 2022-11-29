// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] CreateMassive(int col)
{
    int[] array = new int[col];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write($"{array[i]}  ");
    }
    return array;
}

int AmountEven(int[] array)
{
    int coant = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            coant++;
        }
    }
    return coant;
}


Console.WriteLine("Введите количество элементов массива");
int col = Convert.ToInt32(Console.ReadLine());
int[] array = CreateMassive(col);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве={AmountEven(array)}");