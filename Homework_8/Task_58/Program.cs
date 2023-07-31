// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GenerateMatrix(int m, int n)
{
    int[,] randomMatrix = new int[m,n];
    for (int i = 0; i < randomMatrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randomMatrix.GetLength(1); j++)
        {
            randomMatrix[i,j] = new Random().Next(0, 9+1);
            Console.Write($"{randomMatrix[i,j],4}");
        }
    }
    Console.WriteLine();
    return randomMatrix;
}
void MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    if(matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        int[,] productMatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
        Console.Write("\nРезультат перемножения матриц: \n");
        
        for (int i = 0; i < productMatrix.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < productMatrix.GetLength(1); j++)
            {
                int product = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    product = product + (matrix1[i,k] * matrix2[k,j]);
                }
                productMatrix[i,j] = product;
                Console.Write($"{productMatrix[i,j],5}"); 
            }
        }
    }
    else
    {
        Console.Write("\nОшибка.Число столбцов первой матрицы не равно числу строк второй матрицы.");
    }  
}
// Генерируем две матрицы, подходящие для перемножения.
// (Для возможности перемножения матриц 
// число столбцов первой матрицы 
// одновременно будет числом строк второй матрицы.)
Console.Write("Введите количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов первой матрицы: ");
int cols1AndRows2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов второй матрицы: ");
int cols2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = GenerateMatrix(rows1,cols1AndRows2);
int[,] matrix2 = GenerateMatrix(cols1AndRows2,cols2);

//Перемножаем матрицы.
MultiplyMatrices(matrix1,matrix2);
