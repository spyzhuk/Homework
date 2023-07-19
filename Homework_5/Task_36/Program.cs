// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int getUserValue(string prompt)
{
    Console.Write(prompt);
    int userValue = Convert.ToInt32(Console.ReadLine());
    return userValue;
}
int[] generateArray(int minLength, int maxLength, int minValue, int maxValue)
{
    int[] genArray = new int[new Random().Next(minLength,maxLength+1)];
    for (int i = 0; i <genArray.Length; i++)
    {
        genArray[i] = new Random().Next(minValue,maxValue+1);
    }
    Console.WriteLine();
    Console.WriteLine("Сгенерированный массив: [{0}]", string.Join(", ", genArray));
    return genArray;
}
int oddSum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        count = count + array[i];
    }
    return count;
}
int minLength = getUserValue("Задайте минимальную длину массива: ");
int maxLength = getUserValue("Задайте максимальную длину массива: ");
int minValue = getUserValue("Задайте минимум диапазона случайных значений: ");
int maxValue = getUserValue("Задайте максимум диапазона случайных значений: ");
int[] array = generateArray(minLength,maxLength,minValue,maxValue);
Console.Write($"Сумма чисел на нечетных позициях: {oddSum(array)}");