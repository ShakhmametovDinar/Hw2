// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int TwoNum(int num1)
{
    int first = num1 / 10;
    int second = first % 10;

    return second;
}
Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int newNum = TwoNum(num1);

Console.WriteLine(newNum);


// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThreeNum(int num2)
{
    while(num2 > 1000)
    {
        num2 = num2 / 10;
    }

    int sot = num2 % 10;

    return sot;
}

Console.Write("Input a number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(99 < num2)
{

    int newNum1 = ThreeNum(num2);
    Console.WriteLine(newNum1);
}
else
{
    Console.WriteLine("Третьей цифры нету");
}





// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool NumWeekend(int week1)
{
    if(week1 == 6)
    {
        return true;
    }
    else
    {
        if(week1 == 7)
        {
            return true;
        }
    else
        {
            return false;
        }
    }

}

Console.Write("Input a number week: ");
int week1 = Convert.ToInt32(Console.ReadLine());

bool newNum2 = NumWeekend(week1);

Console.WriteLine(newNum2);



