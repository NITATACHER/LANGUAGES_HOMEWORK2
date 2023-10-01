/* Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/* int Prompt (string message)
{   
    System.Console.Write(message);
    string value = Console.ReadLine ();
    int result = Convert.ToInt32 (value);
    return result;
}

int num = Prompt("Введите трехзначное число > ");
if (num < 100 || num >= 1000)

{
    Console.WriteLine ("Введено не трехзначное число");
    return;
}

Console.WriteLine($"Введено число '{num}'");
int secondRaz = num / 10 % 10;
Console.WriteLine($"Вторая цифра '{secondRaz}'"); */

/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

/* int Prompt (string message)
{   
    Console.Write(message);
    string value = Console.ReadLine ();
    int result = Convert.ToInt32 (value);
    return result;
}

int ThirdRaz(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

bool NoNum(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int num = Prompt ("Введите число > ");
if (NoNum(num))
{
    Console.WriteLine (ThirdRaz(num));
} */
   
/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

 /* int Prompt (string message)
{   
    Console.Write(message);
    string value = Console.ReadLine ();
    int result = Convert.ToInt32(value);
    return result;
}

bool Weekend (int WeekDay)
{
    if (WeekDay > 5)
    {
        return true;
    }
    return false;
}

bool NotWeekDay (int number)
{
    if (number > 0 && number <= 7)
    {        
        return true;
    }
    Console.WriteLine ("Это не день недели");
    return false;
}

int WeekDay = Prompt ("Введите день недели - ");
if (NotWeekDay(WeekDay))
{
    if (Weekend (WeekDay))
    {
        Console.WriteLine ("Выходной!");
    }
    else
    {
        Console.WriteLine("Рабочий день(");
    }
}  */

