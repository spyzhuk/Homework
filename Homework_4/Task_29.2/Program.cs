// Задача 29*: 
// Напишите программу, которая задаёт массив 
// из N элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] fillArray (int arrayLength)
{
    int []array = new int[arrayLength];
    for(int i = 0; i<array.Length; i++)
    {  
        array[i]= new Random().Next(-100,100);  
    }
    return array;
}
Console.Write("Введите желаемое количество элементов массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

string output = string.Join(", ", fillArray(arrayLength));
Console.WriteLine($"Массив со случайными значениями из {arrayLength} элементов: [{output}]");
