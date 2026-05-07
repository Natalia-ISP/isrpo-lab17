static int Sum(int a, int b)
{
    return a + b;
}
static int Sub(int a, int b)
{
    return a - b;
}
static int Mul(int a, int b)
{
    return a * b;
}

static int Divv(int a, int b)
{
    if (b == 0)
    {
        Console.WriteLine("деление на 0 не");
        return 0;
    }
    return a / b;
}

Console.WriteLine("1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("(+, -, *, /) или exit: ");
string znak = Console.ReadLine();

if (znak == "exit")
    return;

int result = 0;
bool ok = true;

if (znak == "+")
{
    result = Sum(num1, num2);
}
else if (znak == "-")
{
    result = Sub(num1, num2);
}
else if (znak == "*")
{
    result = Mul(num1, num2);
}
else if (znak == "/")
{
    result = Divv(num1, num2);
}
else
{
    Console.WriteLine("ашибка");
    ok = false;
}

if (ok)
    Console.WriteLine($"результат: {result}");
