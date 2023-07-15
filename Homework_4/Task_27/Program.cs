// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int numLength(int num)
{
    int length = 0;
    if(num<0) num = num*(-1);
    while (num>0)
    {
        length = length+1;
        num = num/10;
    }
    return length;
}
int numSum(int num, int length)
{
    int sum = 0;
    if(num<0) num = num*(-1);
    for (int i = 1; i <= length; i++)
    {
        sum = sum + num%10;
        num = num/10;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма цифр введенного числа: {numSum(num,numLength(num))}");
