Random random = new Random();
int a = random.Next(1, 101);
int n = 0;

Console.WriteLine("угадайте число от 1 до 100: ");
int b = 0;

while (b != a)
{
    Console.Write("введите число: ");
    b = Convert.ToInt32(Console.ReadLine());
    n++;
    if (b > a)
    {
        Console.WriteLine("число меньше");
    }
    else if (b < a)
    {
        Console.WriteLine("число больше");
    }
}
Console.WriteLine("вы угадали");
Console.WriteLine($"попыток: {n}");