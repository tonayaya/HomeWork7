// Задача 50: Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine($"Задача 50:");

Console.WriteLine ("Введите число строк: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите число стодбцов: ");
int n = Convert.ToInt32 (Console.ReadLine());
int[,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next (-10, 10);
        Console.Write (array[i,j]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Введите строку элемента: ");
int row = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите столбец элемента: ");
int column = Convert.ToInt32 (Console.ReadLine());
if (row < m && column < n) Console.WriteLine ("Элемент массива с такими позициями существует: "+array[row,column]);
else Console.WriteLine ("Элемент массива с такими позициями не существует");