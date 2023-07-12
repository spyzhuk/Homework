// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool validateValue (int value)
{
    string input = Convert.ToString(value);
    if (input.Length >5 || input.Length <5)
    {
        Console.Write("Ошибка. Введено не пятизначное число.");
        return false;
    }
    return true;
}

int reverseValue (int value)
{ 
    int remainder = 0;
    int reversed = 0;
    while (value!=0)
    {
        remainder = value%10;
        reversed = reversed*10 +remainder;
        value = value/10;
    }
        return reversed;
}
 
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (validateValue(number))
{
    if (reverseValue(number) == number) Console.Write("Введенное число является палиндромом.");
    else Console.Write("Введенное число НЕ является палиндромом.");
}

