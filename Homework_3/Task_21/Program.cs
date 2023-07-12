// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int enterValue (string prompt)
{
    Console.Write($"Введите координату точки {prompt}");
    int value = Convert.ToInt32(Console.ReadLine());
    
    return value;
}

int xA = enterValue("A по оси x: "),
    yA = enterValue("A по оси y: "),
    zA = enterValue("A по оси z: ");

Console.WriteLine();

int xB = enterValue("B по оси x: "),
    yB = enterValue("B по оси y: "),
    zB = enterValue("B по оси z: ");

Console.WriteLine();

double distance = Math.Sqrt(Math.Pow((xA - xB),2) + Math.Pow((yA - yB),2) + Math.Pow((zA - zB),2));
Console.Write($"Расстояние между точками равно: {Math.Round(distance,2)}");