﻿
/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int num = new Random().Next(100,999);
Console.WriteLine(num);
int rezult = (num/10)%10;
Console.WriteLine(rezult);
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*Сделала строкой, использование чисел не получилось, никак не могу понять как вести отсчет справа, а не слева. Если использовать массив, то не известен размер массива...

Console.Write("Введите цифру: ");
string str = Console.ReadLine ();
if (str.Length<3){
    Console.WriteLine("третьей цифры нет");
}
else{
    Console.WriteLine(str[2]);
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число  ");
int num = int.Parse(Console.ReadLine());
int sat = 6;
int san = 7;
if (num == 6) {
    Console.WriteLine($"{sat} = Да ");
    if (num == 7){
       Console.WriteLine($"{san} = Да "); 
    }
}
else {
    if (num < 5){
        Console.WriteLine($"{num} = Нет ");
    }
    else{
        Console.WriteLine($"{num} = Нет такого дня");
    }
}

