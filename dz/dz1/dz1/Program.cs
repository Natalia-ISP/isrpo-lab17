Console.Write("введите вес: ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.Write("введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());
double IMT = weight / (height*height);
if (IMT < 18.5)
{
    Console.WriteLine("Недостаточный вес");
    Console.WriteLine("Нужно есть больше");
}
else if (IMT < 24.9)
{
    Console.WriteLine("Нормальный вес");
    Console.WriteLine("Все нормально");
}
else if (IMT < 29.9)
{
    Console.WriteLine("Избыточный вес");
    Console.WriteLine("Нужно есть меньше");
}
else
{
    Console.WriteLine("Ожирение");
    Console.WriteLine("Нужно есть меньше");
}