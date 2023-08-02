// Задача 64: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumRecursion(int n, int end)
{
  if (n >end) return(n + " " + NumRecursion(n -1, end));
  if (n <end) return(n + " " + NumRecursion(n +1, end));
  else return Convert.ToString(n);
}

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Числа от {n} до 1: {NumRecursion(n,1)}");