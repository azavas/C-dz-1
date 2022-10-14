//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.
/*
void step(int A, int B){
    if(A<0||B<0){        
       Console.WriteLine("Отрицательные числа");
         }
    else {
    double res = Math.Pow(A,B);
    Console.WriteLine(res);
    }
}
Console.WriteLine("Введите число 1 ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int B = int.Parse(Console.ReadLine());

step (A,B);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*int N = int.Parse(Console.ReadLine());
int sum = 0;
    while (N > 0)
        {sum=sum+N%10;
        N=N/10;
              
        }
 Console.WriteLine(sum);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы задаются рандомно. Итоговый массив должен содержать в себе суммы цифр числа. Т.е. необходимо подсчитывать суммы цифр чисел и записывать их в новый массив.
/*int[] array1 = new int [8];
void FillArray(int[] N)
{
    int length = N.Length;
    int index = 0;
    while (index<length)
    {
       N[index] = new Random().Next (1,100);
        
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position< count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}
void SelectionSort(int[]N){
    int el=0;
    foreach(var index in N) {
    int ind = index;
    int sum = 0;
    while (ind>0) {
       sum=sum+ind%10;
       ind=ind/10;     
    }
    array1[el]=sum;
    el++;
    }
}
 


int[] array = new int [8];

FillArray(array);
PrintArray(array);
Console.WriteLine();

SelectionSort(array);
PrintArray(array1);
*/
// Дополнительно. Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем все остальные.
// В примере задачи сделано простой перестановкой, а в условии, что сначала идут нули а массив сдвигается. Сделала через сдвиг


/*int[] arr = {1,3,8,1,2,6,9,7,8,0,5,0,-5};  
void PrintArray(int[] array) 
{
    int count = array.Length;  

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
   int first = 0;
   int el;
     for(int i = 0; i < array.Length - 1; i++) 
   {    
    if(array[i]==0){
        first = i;
        while (first!=0) {
            el=array[first-1];
            array[first-1] = array[first];
            array [first]= el;
            first--;
        }
       
    }
  
    }
  
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/

// Преобразовать массив так, чтобы сначала шли нулевые элементы, а затем все остальные.
//-1 -3 -1 -3 -1 0 -4 -2 -> 0 -3 -1 -3 -1 -1 -4 -2
// Решение задачи по примеру. Перестановка

int[] arr = {1,3,8,1,2,6,9,7,8,0,5,0,-5};  
void PrintArray(int[] array) 
{
    int count = array.Length;  

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
     int el;
     int first =0;
     for(int i = 0; i < array.Length - 1; i++) 
   {    
    if(array[i]==0){
            el=array[i];
            array[i] = array[first];
            array [first]= el;
            first ++;
        }
       
    }
  
    }
  


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


