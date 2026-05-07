Console.WriteLine("определение оценки по баллам");
Console.WriteLine("введите баллы");

int score = Convert.ToInt32(Console.ReadLine());

string grade;
int numericGrade;

if (score >= 91 && score <= 100)
{
    grade = "отлично";
    numericGrade = 5;
}
else if (score >= 71 && score < 90)
{
    grade = "хорошо";
    numericGrade = 4;
}
else if (score >= 51 && score < 70)
{
    grade = "удовлетворительно";
    numericGrade = 3;
}
else if (score >= 0 && score < 50)
{
    grade = "неудовлетворительно";
    numericGrade = 2;
}
else
{
    grade = "ошибка";
    numericGrade = 0;
    Console.WriteLine("ошибка: баллы должны быть от 0 до 100");
    return;
}

Console.WriteLine("результат");
Console.WriteLine($"баллы: {score}");
Console.WriteLine($"оценка: {grade} ({numericGrade})");