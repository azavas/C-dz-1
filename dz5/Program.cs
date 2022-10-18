// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*int[] CreateMas(int n){             
    
    int[] arr = new int[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().Next(100,999);
    return arr;
}
void Print(int[]arr){
    Console.WriteLine(String.Join(" ",arr));
    Console.WriteLine("\n");
}
void summa(int[]arr){
        int rezult=0;
            for(int i = 0; i < arr.Length; i++){
            int div = arr[i]%2;
          
            if(div==0){
                rezult++;
            }
        }
        
           Console.WriteLine(rezult);
       
        
}
int[] array = new int[10];
array = CreateMas(10);
Print(array);
summa(array);

*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*int[] CreateMas(int n){             
    
    int[] arr = new int[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().Next(1,20);
    return arr;
}
void Print(int[]arr){
    Console.WriteLine(String.Join(" ",arr));
    Console.WriteLine("\n");
}

void summa(int[]arr){
        int sum=0;
            for(int i = 0; i < arr.Length; i++){
            int div = arr[i]%2;
            if(div!=0){
                sum=sum + arr[i];
                }
        }
        
           Console.WriteLine(sum);
       
        
}

int[] array = new int[10];
array = CreateMas(10);
Print(array);
summa(array);

*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*double[] CreateMas(int n){             
    
    double[] arr = new double[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().NextDouble()*100;
    return arr;
}
void Print(double[]arr){
    Console.WriteLine(String.Join(" ",arr));
    Console.WriteLine("\n");
}

void razniza(double[]arr){
    double max=arr[0];
    double min=arr[0];
    double Diff = 0;
    for(int i = 1; i < arr.Length; i++){
       
        if(arr[i] >= max){
            max=arr[i];
        }
        else if (arr[i]<=min) {
            min=arr[i];
        }
        
    }        
   
   Console.WriteLine(max);
   Console.WriteLine(min);

    Diff  = max-min;

    Console.WriteLine(Diff);
}


double[] array = new double[10];
array = CreateMas(10);
Print(array);
razniza(array);
*/

//Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. Обновите список только при первом вхождении числа 20.

int[] CreateMas(int n){             
    
    int[] arr = new int[n];
    for(int i=0;i<n;i++)
        arr[i]=new Random().Next(1,30);
    return arr;
}
void Print(int[]arr){
    Console.WriteLine(String.Join(" ",arr));
    Console.WriteLine("\n");
}

int [] poisk(int[] arr, int k){
    
    for(int i = 0; i < arr.Length; i++)
    if (arr[i]==k){
                arr[i] = 200;
              
        break;
    }
  return arr;
}
int[] array = new int[10];
array = CreateMas(10);
Print(array);
poisk(array,20);
Print(array);

