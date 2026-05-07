int[] num = {5, 4, 5, 3, 4};

int max_num = num[0];

for (int i = 1; i < num.Length; i++)
{
    if (num[i] > max_num)
    {
        max_num = num[i];
    }
}
Console.WriteLine($"макс элемент: {max_num}");
