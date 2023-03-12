// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine ("Введите число A");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("Введите число B");
double B = Convert.ToDouble(Console.ReadLine());

void MetPow (double A, double B)
{
// double res = Math.Pow(A, B);
double res = 1;
for (int i = 1; i<=B; i++) res=res*A;
Console.WriteLine($"А в степени В = {res}");
}
MetPow(A,B);