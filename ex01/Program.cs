// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Parametr(string message)
{
    Console.Write(message);
    int value= int.Parse(Console.ReadLine()!);
    return value;
}
double[,] CreateArray()
{
    int rows=Parametr("Введите количество строк: ");
    int colomns=Parametr("Введите количество столбцов: ");
    double[,] array = new double[rows, colomns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99,99);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    Console.WriteLine("_________________________");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j]<= -10)
                Console.Write($"{array[i, j]} | ");
            else if (array[i, j]< 10 && array[i, j]>0)
                Console.Write($"  {array[i, j]} | ");
            else
                Console.Write($" {array[i, j]} | ");
        }
        Console.WriteLine();
    }
}

double[,] array = CreateArray();
PrintArray(array);
Console.WriteLine();