// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GenerateArray(int m, int n)
{
    int[,] randomArray = new int[m,n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = new Random().Next(0,9+1);
            Console.Write($"{randomArray[i,j],4}");
        }
    }
    Console.WriteLine();
    return randomArray;
}
int[] GetRowSumValues(int[,] array)
{
    int[] rowSumValues = new int[array.GetLength(1)];
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
           rowSum = rowSum + array[i,j];    
        } 
        rowSumValues[index] = rowSum;
        index++;     
    }
    return rowSumValues;
}
int GetMinRowNumber(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    { 
        if(array[i] < min) min = array[i];
    }
    return Array.IndexOf(array,min)+1;
}
// Генерируем двумерный массив.
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GenerateArray(rows,columns);

// Получаем одномерный массив из сумм по строкам двумерного массива.
int[] rowSumArray = GetRowSumValues(array);
Console.WriteLine($"\nСуммы значений по строкам: [{string.Join(", ",rowSumArray)}]");

// Получаем номер строки с наименьшей суммой элементов.
Console.Write($"Строка с наименьшей суммой элементов: {GetMinRowNumber(rowSumArray)}");
