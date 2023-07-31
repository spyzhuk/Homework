// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

 void FillArray3D (int[,,] array3D)
 {
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            int z = 0;
            while ( z < array3D.GetLength(2))
            {
                int value = new Random().Next(10,100);
                if (CheckRepeat(array3D,value)) continue;
                array3D[x, y, z] = value;
                z++;
            }
        }
    }
 }
// Проверяем значения на соответствие уже существующим.
bool CheckRepeat(int[,,] array3D, int value)
{
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
              if (array3D[x, y, z] == value) return true; 
            }
        }
    }
    return false;
}
void PrintArray3D(int[,,] array3D)
{
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
              Console.Write($"{array3D[x, y, z],4} ({x},{y},{z})"); 
            }
            Console.WriteLine();
        }
    }  
}
Console.Write("Введите значение x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = new int[x,y,z];

FillArray3D(array3D);
Console.WriteLine();
PrintArray3D(array3D);
