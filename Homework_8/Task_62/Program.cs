// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

bool ValidateMatrix(int[,] matrix)
{
    if(matrix.GetLength(0) == matrix.GetLength(1)) return true;
    else
    {
        Console.Write("Ошибка. Количество строк не равно количеству столбцов.");
        return false;
    }
}
void FillMatrix(int[,] matrix)
{
    int i = 0;
    int j = 0;
    int filler = 1;
    while(filler <= matrix.GetLength(0) * matrix.GetLength(1))
    {   
        matrix[i,j] = filler;
        filler++; 

        // Движение по индексам массива.

        if (i <= j + 1 && i + j < matrix.GetLength(1)-1) j++; //вправо
    
        else if (i < j && i + j >= matrix.GetLength(0)-1) i++; //вниз
    
        else if (i >= j && i + j > matrix.GetLength(1)-1) j--; //влево

        else i--; //вверх  
    }
}
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows,columns];

if (ValidateMatrix(matrix)) 
{
    FillMatrix(matrix);
    PrintMatrix(matrix);
}
