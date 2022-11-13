// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int one = 1;

while (one <= n)
{
    if (one % 2 == 0)
    Console.Write($"{one} ");
    one = one +1;
}
    