// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    while (number >= 1000)
    {
        number = number/10;
    }

Console.WriteLine($"Третья цифра числа: {number%10}"); 
}

if (number < 100)
{
   Console.WriteLine("Ошибка. Третьей цифры нет. "); 
}


// Решение с конвертацией в строку:

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string convertedNumber = Convert.ToString(number);

// if (convertedNumber.Length >2)
// {
//     Console.WriteLine($"Третья цифра числа: {convertedNumber[2]}");
// }
// else
// {
//     Console.WriteLine("Ошибка.Третьей цифры нет.");
// }
