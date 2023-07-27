// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
            randomArray[i,j] = new Random().Next(-99, 99+1);
            Console.Write($"{randomArray[i,j],4}");
        }
    }
    Console.WriteLine();
    return randomArray;
}
void CheckPositionValue(int[,] array, int numberRow, int numberCol)
{
    if(numberRow <= array.GetLength(0) && numberCol <= array.GetLength(1)) 
    {
        Console.Write("Значение элемента с индексом [{0},{1}]: {2}",
        numberRow-1,numberCol-1,array[numberRow-1,numberCol-1]);
    }   
    else Console.Write("Элемент с такой позицией не найден.");
}   

// Генерируем массив.
int rows = GetUserValue("Введите количество строк массива: ");
int columns = GetUserValue("Введите количество столбцов массива: ");
int[,] array = GenerateArray(rows,columns);

// Возврат значения по позиции в массиве.
int numberRow = GetUserValue("\nВведите номер строки в позиции числа: ");
int numberCol = GetUserValue("Введите номер столбца в позиции числа: ");
CheckPositionValue(array,numberRow,numberCol);