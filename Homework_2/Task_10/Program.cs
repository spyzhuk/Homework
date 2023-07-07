// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное трехзначное число: {number}");

int secondDigit = number/10%10;
Console.WriteLine($"Вторая цифра числа: {secondDigit}");

// Решение с конвертацией в строку:

// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number>=100 && number<=1000)
// {
//     string convertedNumber = Convert.ToString(number);
//     Console.WriteLine($"Вторая цифра введенного числа: {convertedNumber[1]}"); 
// }
// else
// {
//     Console.WriteLine("Ошибка. Введите трехзначное число.");
// }