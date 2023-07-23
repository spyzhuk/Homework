// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetUserValue(string prompt)
{
    Console.Write($"Введите для прямой {prompt}");
    double userValue = Convert.ToDouble(Console.ReadLine());
    return userValue;
}
void Intersection(double b1, double k1, double b2, double k2)
{ 
    if (k1 == k2) // Равные значения k в любом случае делают прямые непересекающимися.
    {
        Console.Write("\nЗаданные прямые не пересекаются.\n");
    }
    else
    {
        double x = (b2-b1)/(k1-k2);
        double y = k1*x + b1;
        Console.Write($"\nТочка пересечения заданных прямых: ({x:0.0}; {y:0.0})\n");
    }
}
double b1 = GetUserValue("1 значение b1: "),
       k1 = GetUserValue("1 значение k1: "),
       b2 = GetUserValue("2 значение b2: "),
       k2 = GetUserValue("2 значение k2: ");

Intersection(b1,k1,b2,k2);
