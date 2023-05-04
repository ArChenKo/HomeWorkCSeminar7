/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

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
            else if (array[i, j]< 10 && array[i, j]>=0)
                Console.Write($"  {array[i, j]} | ");
            else
                Console.Write($" {array[i, j]} | ");
        }
        Console.WriteLine();
    }
}
void FindNumber(double [,] array)
{
    int findRow=Parametr("Введите искому строку: ")-1;
    int findColumn=Parametr("Введите искомый столбец: ")-1;
    if(findRow<array.GetLength(0) && findColumn<array.GetLength(1))
        Console.WriteLine(array[findRow,findColumn]);
    else
        Console.WriteLine("Искомого значения в массиве нет.");
}

double[,] array = CreateArray();
PrintArray(array);
FindNumber(array);