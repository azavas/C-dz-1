﻿
// Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*double dist (int x1, int y1,int z1, int x2, int y2, int z2){
    double res = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)); 
    return res;
}
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
double otvet = dist (x1,y1,z1,x2,y2,z2);
Console.WriteLine(otvet);
*/



//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

/*double kvadr (int z){
     double res = Math.Pow(z,2);
    return res;
}
 
double n = int.Parse(Console.ReadLine());
int x=1;
while (x<=n) {
    double otvet = kvadr (x);
    x++;
Console.WriteLine(otvet);
}
*/

/int[] num = new int[5];

if (
    //while (i<num.Length){
    Console.Write($"Введите {i} число массива: ");  
    num[i] = int.Parse(Console.ReadLine());
    i++;
