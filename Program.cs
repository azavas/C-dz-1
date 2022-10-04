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

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int M = 2;
while (M<=N)
{
    Console.Write(M.ToString()+" ");
    M+=2;
}
*/

//Задача повышенной сложности Напишите программу.Какая сумма элементов массива больше – с первого до элемента с номером К или от элемента с номером К+1 до последнего.
//На вход подается массив чисел. Затем вводится переменная K. На выход программа должна вывести или "Первая часть" или "Вторая часть"
//Например, при вводе массива [8 11 15 8 9 10] и числа 3. Программа должна вывести 1 часть, так как 42 больше, чем 19.

int[] num = new int[8];
int i=0;
while (i<num.Length){
    Console.Write($"Введите {i} число массива: ");  
    num[i] = int.Parse(Console.ReadLine());
    i++;
}
Console.Write("Введите число K: ");
int K = int.Parse(Console.ReadLine());
i=0;
int sum1=0;
while (i<=K){
    sum1=sum1+num[i];
    i++;
}
i=K+1;
int sum2=0;
while (i<num.Length){
    sum2=sum2+num[i];
    i++;
}
if (sum1<sum2) {
    Console.WriteLine($"{sum2} = Вторая часть ");
}
else {
    Console.WriteLine($"{sum1} = Первая часть ");
}
