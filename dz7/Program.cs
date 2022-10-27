//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*Random rnd = new Random();
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(rnd.Next(-10, 10) / 10.0);
        }

    }

}

double[,] matrix = new double[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.Вариант с листом

/*void FillList(List<List<double>> mylist)
{
    for (int i = 0; i < 3; i++)
    {
        int a = new Random().Next(-3, 3);
        mylist.Add(new List<double>());
        for (int j = 0; j < 4; j++)
            mylist[i].Add(Math.Round(new Random().NextDouble() * a, 1));
    }
}

void PrintList(List<List<double>> mylist)
{
    for (int i = 0; i < mylist.Count; i++)
    {
        for (int j = 0; j < mylist[i].Count; j++)
            Console.Write(mylist[i][j] + " ");
        Console.WriteLine();
    }

}
List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*void FillList(List<List<double>> mylist)
{
    for (int i = 0; i < 5; i++)
    {
        mylist.Add(new List<double>());
        for (int j = 0; j < 5; j++)
            //mylist[i].Add(Math.Round(new Random().NextDouble() * 5));
            mylist[i].Add(new Random().NextDouble() * 5);
    }
}

void PrintList(List<List<double>> mylist)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
            Console.Write(mylist[i][j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SearchPozition(List<List<double>> mylist)
{
    Console.WriteLine("Введите позиции элементов: ");
    int i = int.Parse(Console.ReadLine());
    int j = int.Parse(Console.ReadLine());

    if (i <= 4 && j <= 4)
        Console.Write($"Значение элемента массива -> {mylist[i][j]}");

    else
    {
        Console.WriteLine($"{i} {j} -> такого числа в массиве нет ");
    }
}


List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers);
SearchPozition(numbers);
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void Average(int[,] matr)
{

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)

        {
            sum = sum + matr[i, j];

        }
        sum = Math.Round(sum / matr.GetLength(0), 1);
        Console.Write(sum + " ");
    }
}
int[,] matrix = new int[3, 4];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Average(matrix);
*/