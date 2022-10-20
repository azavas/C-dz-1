
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*int[] CreateMas(int M){
  int[] arr = new int[M];
    for(int i=0;i<M;i++)  
arr[i] = int.Parse(Console.ReadLine());
return arr;
}

void summa(int[]arr){
        int sum=0;
            for(int i = 0; i < arr.Length; i++){
                if(arr[i]>0){
                sum++;
                }
        }
        
           Console.WriteLine($"Количество положительных чисел = {sum}");
       
        
}
Console.Write("Введите числа: ");
int[] array = new int[3];
array = CreateMas(3);

summa(array);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*double b1 = double.Parse(Console.ReadLine());
double k1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double x,y;


if((k1==k2)&&(b1==b2)){
   Console.WriteLine("Совпадают");
}
else if(k1==k2){
    Console.WriteLine("Параллельны");
}
else {
    x=(b2-b1)/(k1-k2);
    y=(k1*(b2-b1))/(k1-k2)+b1;
    Console.WriteLine(x+" "+y);
}

*/
//4: Заполнить двумерный массив следующим образом. 
/*int n =int.Parse(Console.ReadLine());
int [,] matr = new int [n,n];
int b=1;
for(int i =0; i<matr.GetLength(0); i++){
    for(int j =0; j<matr.GetLength(1); j++){
        if (j<=i){
         matr[i,j] = j+1;  
        }
    else{
        matr[i,j] = i+1; 
    }  
        Console.Write(matr[i,j] + " ");    
    }
    Console.WriteLine();
}
 */

//Дано действительное положительное число a и целое неотрицательное число n. 
//Вычислите an не используя циклы, возведение в степень через ** и функцию math.pow(), а используя рекуррентное соотношение an=a⋅an-1.
int n =int.Parse(Console.ReadLine());
double a =double.Parse(Console.ReadLine());


double power( double a, int n ){
    if(n == 1) return a; 
    //else  (n==0) return 1;
    for(int i=2; i==n; i++){
        double 
    }

}




    

