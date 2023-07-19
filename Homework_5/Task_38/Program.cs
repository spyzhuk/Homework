// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] generateArray(int length, double minRange, double maxRange)
{
    double[] genArray = new double[length];
    for (int i = 0; i <genArray.Length; i++)
    {
        // Пояснение к формуле:
        //---------------------------------------------------------------------------------- 
        // Метод Random.NextDouble возвращает случайное число с плавающей запятой, 
        // которое больше или равно 0,0 и меньше 1,0.
        // Для получения числа больше 1,0 в желаемом диапазоне:
        //----------------------------------------------------------------------------------
        // 1. Умножим число на разницу между максимальным и минимальным значением диапазона,
        //    чтобы результат был ниже максимального значения диапазона.
        //----------------------------------------------------------------------------------
        // 2. Добавим к полученному числу минимальное значение диапазона,
        //    чтобы результат был выше минимального значения диапазона.
        //----------------------------------------------------------------------------------
        // 3. Форматирование: округлим полученное число до второго знака после запятой.
        genArray[i] = Math.Round((minRange + new Random().NextDouble() * (maxRange - minRange)),2);
    }
    Console.WriteLine();
    Console.WriteLine("Сгенерированный массив: [{0}]", string.Join("  ", genArray));
    return genArray;
}
void maxMinDiff(double[] genArray)
{
    double min = genArray[0];
    double max = genArray[0];
    for (int i = 0; i <genArray.Length; i++)
    {
        if (max<genArray[i]) max = genArray[i];
        if (min>genArray[i]) min = genArray[i];
    }
    double diff = Math.Round(max-min,2);
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементами: {max} - {min} = {diff}");
}

Console.Write("Задайте количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте минимум диапазона случайных значений: ");
double minRange = Convert.ToDouble(Console.ReadLine());

Console.Write("Задайте максимум диапазона случайных значений: ");
double maxRange = Convert.ToDouble(Console.ReadLine());

double[] array = generateArray(length,minRange,maxRange);
maxMinDiff(array);
