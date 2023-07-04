// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Ведите число больше 1: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int i = 1;

Console.WriteLine($"Четные числа от 1 до {userNumber}: ");
for(i=1;i<=userNumber;i+=1)
{
    if(i%2 ==0)
    {
        Console.Write($" {i}");
    }
}

if (userNumber<=1)
{
    Console.Write("Введено число меньше или равное 1. Введите другое число.");
}