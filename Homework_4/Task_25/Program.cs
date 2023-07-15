// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int poweredNumber (int number, int power)
{
    int powered = 1;
    for (int i = 1; i<=power; i++)
    {
        powered = powered*number;
    }
    return powered;
}
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write($"{numberA} в степени {numberB}: {poweredNumber(numberA,numberB)}");