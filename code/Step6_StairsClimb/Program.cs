Console.WriteLine("подъем по лестнице");

Console.Write("на какой этаж нужно подняться?: ");
int targetFloor = Convert.ToInt32(Console.ReadLine());

int currentFloor = 1;
Console.WriteLine("начинаем подъем!");

while (currentFloor < targetFloor)
{
    currentFloor++;
    Console.WriteLine($"поднялись на {currentFloor}-й этаж");
}
Console.WriteLine($"вы достигли {targetFloor}-го этажа");
Console.WriteLine("конец программы");