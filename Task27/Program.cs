// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int MetCount (int n)
{
int count = 0;
while (n>=1)
{
    n = n/10;
    count++;
}
return count;
}
int count = MetCount(n);

int MetResult(int n, int count)
{
    int a = 0;
    for (int i = 1; i <= count; i++)
    {
        a = a + n % 10;
        n = Convert.ToInt32(Math.Floor(Convert.ToDouble(n / 10)));
    }
    return a;
}

Console.WriteLine(MetResult(n,count));
