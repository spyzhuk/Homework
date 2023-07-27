
// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetUserValue(string prompt)
{
    Console.Write($"{prompt}");
    int userValue = Convert.ToInt32(Console.ReadLine());
    return userValue;
}
int[,] GenerateArray(int m, int n)
{
    Console.WriteLine("\nСгенерирован двумерный массив: ");
    int[,] randomArray = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < n; j++)
        {
            randomArray[i,j] = new Random().Next(0, 9+1);
            Console.Write($" {randomArray[i,j],4}");
        }
    }
    Console.WriteLine();
    return randomArray;
}
void ColumnArithMean(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double columnSum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            columnSum = columnSum + array[i,j];   
        }
        Console.WriteLine("Среднее арифметическое столбца {0}: {1}",
        j+1,Math.Round(columnSum/array.GetLength(0),2));
    }
}
int rows = GetUserValue("Введите количество строк массива: ");
int columns = GetUserValue("Введите количество столбцов массива: ");
int[,] array = GenerateArray(rows,columns);

Console.WriteLine();
ColumnArithMean(array);

