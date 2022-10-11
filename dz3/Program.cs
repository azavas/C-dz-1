
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



//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*double kyb (int z){
     double res = Math.Pow(z,3);
    return res;
}
 
double n = int.Parse(Console.ReadLine());
int x=1;
while (x<=n) {
    double otvet = kyb (x);
    x++;
Console.WriteLine(otvet);
}
*/
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*string str = Console.ReadLine ();
if (str[0]==str[4]&&str[1]==str[3]){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}  
*/


// Дополнительно. Создание массива из двух массивов. В итоговом массиве должны быть элементы первого и второго массива.[1,2,3] [4,5,6] -> [1,2,3,4,5,6]. Честно подсмотрела на Metanit
/*
string[] first = {"1","2","3","4","5"};
string[] second = {"6","7","8","9","10"};

var result = first.Concat(second);
 
foreach (string s in result)
    Console.WriteLine(s);
*/

