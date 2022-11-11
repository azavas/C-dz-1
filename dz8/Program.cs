//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Decrease(int[,] arr)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}

int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
Decrease(array);
PrintArray(array);
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumLine(int[,] arr)
{
    int temp = 0;
    int stroka = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        temp = temp + arr[0, i];
    }
    for (int j = 1; j < arr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[j, i];
        }

        if (sum < temp)
        {
            temp = sum;
            stroka = j;
        }
    }
    Console.WriteLine($"\n{stroka + 1} строкa с наименьшей суммой ({temp}) элементов ");
}
int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);
SumLine(array);
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray2(int[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            arr2[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray2(int[,] arr2)
{

    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            Console.Write(arr2[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Proizvedenie(int[,] arr,int[,] arr2,int[,] rezultArray){
for (int i = 0; i < rezultArray.GetLength(0); i++)
  {
    for (int j = 0; j < rezultArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < arr.GetLength(1); k++)
      {
        sum =sum+ arr[i,k] * arr2[k,j];
      }
      rezultArray[i,j] = sum;
    }
  }
}

int[,] array = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] rezultArray = new int[2, 2];


FillArray(array);
PrintArray(array);
FillArray2(array2);
PrintArray2(array2);


Proizvedenie(array,array2,rezultArray);
PrintArray(rezultArray);
*/

//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void FillArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(10, 99);
            }
        }
    }
}
void PrintArray(int[,,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
        {
            Console.Write(arr[i,j,k] + " " + "("+ i+","+j+","+k+")");
        }
        Console.WriteLine();
    }
  
}
Console.WriteLine();
}

int[,,] array = new int[2, 2, 2];

FillArray(array);
PrintArray(array);