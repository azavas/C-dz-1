//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
string FillNumbers(int n)
{
    if (n == 1) return n.ToString();
    else
    {
        return (n + " " + FillNumbers(n - 1));
    }
}
Console.WriteLine(FillNumbers(n));
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. С помощью рекурсии!!!

/*Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
int sum = 0;
if (n > m)
{
    Console.WriteLine($"Сумма элементов =  {SumNumbers(n, m)}");
}
else
{
    Console.WriteLine($"Сумма элементов =  {SumNumbers(m, n)}");
}

int SumNumbers(int max, int min)
{
    if (min > max)
    {
        return sum;
    }
    else
    {
        sum = sum + max;
        return (SumNumbers(max - 1, min));
    }
}
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. С помощью рекурсии!!!
/*Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
Console.WriteLine(Akkerman(m, n));
*/
