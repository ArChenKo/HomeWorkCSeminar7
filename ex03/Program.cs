/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
            array[i, j] = new Random().Next(-9,9);
        }
    }
    return array;
}
void PrintArray(double[,] array) // метод вывода на экран массива
{
    Console.WriteLine("______________________________________________________________");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j]< 0)
                Console.Write($"   {array[i, j]} |");
            else
                Console.Write($"    {array[i, j]} |");
        }
        Console.WriteLine();
    }
}
void AvgColomnsArray(double[,] array) // метод вывода на экран среднеарифметических значений в стобцах
{
    double [] sumArray= new double[array.GetLength(1)]; // обявление массива с суммами значений по столбцам
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[j]+=array[i,j];
        }
    }
    Console.WriteLine("______________________________________________________________");
    for (int i = 0; i < sumArray.Length; i++) // цикл с вычислением среднеарифметических и вывода их на экран
    {
        sumArray[i]/=array.GetLength(0);
        string a = String.Format("{0:0.0}",sumArray[i]);
        if(sumArray[i]<0)
            Console.Write($" {a} |");
        else
            Console.Write($"  {a} |");        
    }
}

double[,] array = CreateArray();
PrintArray(array);
AvgColomnsArray(array);
