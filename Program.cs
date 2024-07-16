// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;

// Задача 1.
//
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 7 == 0 && n % 23 == 0)
//     Console.WriteLine("True");
// else
//     Console.WriteLine("False");

//Задача 2.
//
// double x = Convert.ToDouble(Console.ReadLine());
// double y = Convert.ToDouble(Console.ReadLine());
// if (x>0)
// {
//     if (y>0)
//         Console.WriteLine("I");
//     else
//         Console.WriteLine("IV"); 
// }
// else
// {
//     if (y>0)
//         Console.WriteLine("II");
//     else
//         Console.WriteLine("III"); 
// }


//Задача 3.
//
// int n = Convert.ToInt32(Console.ReadLine());
// int dec = n/10;
// int unit = n%10;
// if (dec > unit)
//     Console.WriteLine(dec);
// else
//     Console.WriteLine(unit);

//Задача 4.
//
// int n = Convert.ToInt32(Console.ReadLine());
// while (n > 9)
// {
//     Console.Write(n % 10 + ", ");
//     n = n / 10;
// }
// Console.Write(n % 10);

//Задача 4.1
//
// while (0 == 0)
// {
//     string? str = Console.ReadLine();
//     if (str == "q")
//         break;
//     int n = Convert.ToInt32(str);
//     int a = 0;
//     while (n > 0)
//     {
//         a += n % 10;
//         n = n / 10;    
//     }
//     if (a % 2 == 0)
//         break;
// }

//Задача 4.2
//
// void Main()
// {
//     int arraySize = ReadInt("Введите размер массива: ");
//     int[] array = GenerateArray(arraySize);
//     PrintArray(array);
//     Console.WriteLine(CountEven(array));
// }

// int CountEven(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//     if (arr[i] % 2 == 0)
//         count++;
//     }
//     return count;
// }

// void PrintArray(int[] arrayForPrint)
// {
//     for (int i = 0; i < arrayForPrint.Length; i++)
//         System.Console.Write(arrayForPrint[i] + " ");
//     System.Console.WriteLine();
// }

// int[] GenerateArray(int size)
// {
//     int[] tempArray = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < tempArray.Length; i++)
//         tempArray[i] = rand.Next(100, 999);
//     return tempArray;
// }

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine()); // 13
// }
// Main();

//Задача 4.3
//
void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize);
    PrintArray(array);
    PrintAntiArray(array);
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
        System.Console.Write(arrayForPrint[i] + " ");
    System.Console.WriteLine();
}

void PrintAntiArray(int[] arrayForPrint)
{
    for (int i = arrayForPrint.Length-1; i >= 0; i--)
        System.Console.Write(arrayForPrint[i] + " ");
    System.Console.WriteLine();
}

int[] GenerateArray(int size)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(100, 999);
    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine()); // 13
}
Main();
