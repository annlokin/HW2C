// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}
bool Validate(int number)
{
    if (number>= 100)
    {
        return true;
    }
    System.Console.WriteLine("В этом числе нет третьей цифры");
    return false;
}   
int ThirdDigit(int number)
{
    while (number < 999)
    {
        number/=10;
    }
    return (number % 10);
}
int number = Prompt("Введите число");
if (Validate(number))
{
    System.Console.WriteLine($"Третья цифра числа {number} равна {ThirdDigit(number)}");
}
