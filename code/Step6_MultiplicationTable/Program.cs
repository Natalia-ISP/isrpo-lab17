Console.WriteLine("таблица умножения");
Console.Write("введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"таблица умножения для {number}");

for (int i = 1; i <= 10; i++)
{
    int result = number * i;
    Console.WriteLine($"{number} x {i} = {result}");
}
Console.WriteLine("конец программы");