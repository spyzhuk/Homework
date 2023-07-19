// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] genThreeDigitArray(int minUserLength, int maxUserLength)
{
    int[] genArray = new int[new Random().Next(minUserLength,maxUserLength)];
    for (int i = 0; i <genArray.Length; i++)
    {
        genArray[i] = new Random().Next(100,1000);
    }
    Console.WriteLine("Сгенерированный массив: [{0}]",string.Join(", ", genArray));
    return genArray;
}
int evenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) count = count+1;
    }
    return count;
}

Console.Write("Задайте минимальное количество элементов массива: ");
int minUserLength = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте максимальное количество элементов массива: ");
int maxUserLength = Convert.ToInt32(Console.ReadLine());

int[] array = genThreeDigitArray(minUserLength,maxUserLength);
Console.Write($"Количество четных чисел в массиве: {evenCount(array)}");