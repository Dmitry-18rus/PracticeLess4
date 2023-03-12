﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int [] array = new int [8];
FullArray(array);
PrintArray(array);

void FullArray (int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(-100,101);  
    }
}

void PrintArray (int []array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
Console.WriteLine();
}

