// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строчек");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int [,] number=new int [n,m];
int sum=0;

FillArrayRandomNumber (number);
PrintArray (number);
MinSumArray(number);
Console.WriteLine ();
for (int i = 0; i < number.GetLength(0); i++)
{
    for (int j = 0; j < number.GetLength(1); j++)
    {
        Console.Write(number [i,j]);
    }
}
void FillArrayRandomNumber(int[,]array)
{
    for (int i=0; i<array.GetLength (0);i++)
    {
        for (int j=0; j<array.GetLength (1);j++)
        {
            array[i,j]=new Random().Next(10);
        }
    }
 }  
void PrintArray(int[,]array)
 {
    for(int i=0;i<array.GetLength(0);i++)
    {
        Console.Write ("[");
        for (int j=0; j<array.GetLength(1); j++)
        {
           Console.Write (array[i,j]+" "); 
        }
        Console.Write ("]");
        Console.WriteLine (" ");
    }
 } 

void MinSumArray(int[,]array);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1)-1; j++)
    {
        array[i,j]=new Random().Next(10);
        sum +=array[i,j];
    }
    Console.Write(array[i,j];+ ' ');
}
Console.WriteLine(MinSumArray (sum array[i,j]<min sum array[i,j]));




//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("Введите количество строчек");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int [,] number=new int [n,m];
FillArrayRandomNumber (number);
SortLineArray(number);
PrintArray (number);
Console.WriteLine ();
//for (int i = 0; i < number.GetLength(0); i++)
//{
//    for (int j = 0; j < number.GetLength(1); j++)
//   {
//        Console.Write(number [i,j]);
//    }
//}
void FillArrayRandomNumber(int[,]array)
{
    for (int i=0; i<array.GetLength (0);i++)
    {
        for (int j=0; j<array.GetLength (1);j++)
        {
            array[i,j]=new Random().Next(10);
        }
    }
 }  
void PrintArray(int[,]array)
 {
    for(int i=0;i<array.GetLength(0);i++)
    {
        Console.Write ("[");
        for (int j=0; j<array.GetLength(1); j++)
        {
           Console.Write (array[i,j]+" "); 
        }
        Console.Write ("]");
        Console.WriteLine (" ");
    }
 }
void SortLineArray(int[,]array)
 {
    for (int i=0; i<array.GetLength (0);i++)
    {
        for (int j=0; j<array.GetLength (1);j++)
        {
            for (int a=0; a<array.GetLength (1)-1; a++)
            {
               if (array [i,a]< array [i,a+1])
               {
                int temp=array [i,a+1];
                array [i,a+1]=array [i,a];
                array [i,a]=temp;
               }
            }
        }
    
    }
 }

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
int [,]array1=new int [2,2];
{
     for (int i=0; i<array1.GetLength (0);i++)
     {
        for (int j=0; j<array1.GetLength (1);j++)
        {
            array1[i,j]=new Random().Next(10);
            Console.Write(array1[i,j]+"");
        }
         Console.WriteLine();
     }
}
Console.WriteLine("_____");

int [,]array2=new int [2,2];
{
     for (int i=0; i<array2.GetLength (0);i++)
     {
        for (int j=0; j<array2.GetLength (1);j++)
        {
            array2[i,j]=new Random().Next(10);
            Console.Write(array2[i,j]+"");
        }
         Console.WriteLine();
     }
}
Console.WriteLine("_____");

int [,]array3=new int [2,2];
{
     for (int i=0; i<array3.GetLength (0);i++)
     {
        for (int j=0; j<array3.GetLength (1);j++)
        {
            int sum=0;
            for (int a=0; a<array1.GetLength(1);a++)
            {
                sum+=array1 [i,a]*array2[a,j];
            }
            Console.Write ((array3[i,j]=sum)+"");
        }
         Console.WriteLine();
     }
}

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int [,,]array3D=new int [2,2,2];
FillArray (array3D);
PrintIndex (array3D);

void PrintIndex (int[,,]arr)
{
     for (int i=0; i<array3D.GetLength (0);i++)
     {
        for (int j=0; j<array3D.GetLength (1);j++)
        {
            Console.WriteLine ();
            for (int a=0; a<array3D.GetLength(2);a++) 
            {
                Console.Write($"{array3D[i,j,a]}({i},{j},{a})");
            }
        }
     }
}
void FillArray (int[,,]arr)
{
    int count=10;
     for (int i=0; i<arr.GetLength (0);i++)
     {
        for (int j=0; j<arr.GetLength (1);j++)
        {
            for (int a=0; a<arr.GetLength (2);a++)            
        {
            arr[a,i,j]+=count;
            count=3;   
        }
        }
    }
}    

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int [,]array=new int [4,4];
int count=0;
int i=0;
int j=0;

for(j=0;j<array.GetLength(1);j++)
{
    array [i,j]=1+count;
    count++;
}
j=3;
for(i=0;i<array.GetLength(0);i++)
{
    array [i,j]=1+count;
    count++;
}
i=3;
for(j=2;j>=0;j-=1)
{
    array [i,j]=1+count;
    count++;
}
j=0;
for(i=2;i>=1;i-=1)
{
    array [i,j]=1+count;
    count++;
}
i=1;
for(j=1;j<=2;j++)
{
    array [i,j]=1+count;
    count++;
}
i=2;
for(j=2;j>=1;j-=1)
{
    array [i,j]=1+count;
    count++;
}
for(i=0;i<array.GetLength(0);i++)
{
    for (j=0; j<array.GetLength(1);j++)
    {
        Console.Write (array[i,j]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");

