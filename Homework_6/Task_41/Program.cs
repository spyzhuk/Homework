// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i<array.Length; i++)
    {  
        Console.Write($" число {i+1}: ");
        array[i]= Convert.ToInt32(Console.ReadLine());  
    }
    Console.WriteLine();
    Console.WriteLine($"Введено {array.Length} чисел: [{string.Join(", ", array)}]");
    return array;
}
void CheckPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i]>0) count++;
    }
    Console.Write($"Среди введенных чисел {count} больше нуля.");
}

Console.Write("Задайте количество вводимых чисел: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Введите числа: ");
int[] array = FillArray(length);
CheckPositive(array);
