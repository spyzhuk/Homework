// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRecursion(int m, int n)
{
    if (m <n) return m + SumRecursion(m +1, n);
    if (m >n) return m + SumRecursion(m -1, n);
    else return m;
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма элементов от {m} до {n} = {SumRecursion(m, n)}");