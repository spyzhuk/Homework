// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] fillArray (int arrayLength)
{
    int []array = new int[arrayLength];
    Console.WriteLine("Введите значения элементов массива: ");
    for(int i = 0; i<array.Length; i++)
    {  
        Console.Write($" элемент {i+1}: ");
        array[i]= Convert.ToInt32(Console.ReadLine());  
    }
    return array;
}

int arrayLength = 8;
string output = string.Join(", ", fillArray(arrayLength));
Console.WriteLine($"Задан массив из {arrayLength} элементов: [{output}]");

