// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

bool ValidateInput(int m, int n)
{
    if( m<0 || n<0) 
    {
        Console.Write("Ошибка. Вводите только неотрицательные числа.");
        return false;
    }
    else if ((m>3 && n>5) || (m==4 && n>0))
    {
        Console.Write("Результат слишком велик для отображения.");
        return false;
    }
    else return true;
}

int Acker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Acker(m - 1, 1);
    }
    else return Acker(m - 1, Acker(m, n - 1));
}

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (ValidateInput(m,n)) {Console.Write($"Значение функции Аккермана: {Acker(m, n)} ");}