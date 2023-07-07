// Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number<1 | number>7)
{
    Console.WriteLine("Ошибка. Введите число от 1 до 7.");
}
else if (number ==7 | number ==6)
{
    Console.WriteLine("Это выходной день!");
}
else
{
    Console.WriteLine("Это не выходной день!");
}