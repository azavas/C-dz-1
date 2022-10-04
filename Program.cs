/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1>num2){
    Console.WriteLine($"{num1} = max ");
}
else{
    Console.WriteLine($"{num2} = max ");
}
*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите три числа: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
if (num1>num2){
        if (num1>num3) {
            Console.WriteLine($"{num1} = max ");    
        }
        else{
            Console.WriteLine($"{num3} = max ");
        }
}
else{
        if (num2>num3) {
            Console.WriteLine($"{num2} = max ");
        }
        else{
            Console.WriteLine($"{num3} = max ");
        }
}
*/

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result;
int div = Math.DivRem(num, 2, out result);
if (result == 0) {
    Console.WriteLine($"{num} = четное ");
}
else {
    Console.WriteLine($"{num} = нечетное");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int M = 2;
while (M<=N)
{
    Console.Write(M.ToString()+" ");
    M+=2;
}


