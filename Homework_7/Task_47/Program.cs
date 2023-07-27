// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int GetUserValue(string prompt)
{
    Console.Write($"{prompt}");
    int userValue = Convert.ToInt32(Console.ReadLine());
    return userValue;
}
void GenerateArray(int m, int n, int minRange, int maxRange)
{
    double[,] randomArray = new double[m,n];
    for (int i = 0; i < randomArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < randomArray.GetLength(1); j++)
        {
            randomArray[i,j] = 
            minRange + new Random().NextDouble()*(maxRange - minRange);

            Console.Write($"{randomArray[i,j],5:0.0}");
        }
    }
    Console.WriteLine();
}
int rows = GetUserValue("Введите количество строк массива: "),
    columns = GetUserValue("Введите количество столбцов массива: "),
    minRange = GetUserValue("Введите минимум диапазона случайных значений: "),
    maxRange = GetUserValue("Введите максимум диапазона случайных значений: ");

GenerateArray(rows,columns,minRange,maxRange);




