// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}
int daynumber = Prompt("Введите номер дня недели");
if (daynumber >= 1 && daynumber <= 5)
{
    System.Console.WriteLine($"{daynumber} - рабочий день недели");
}
else if (daynumber >= 8)
{
    System.Console.WriteLine($"{daynumber} - нет такого дня недели, введите от 1 до 7");
}
else
System.Console.WriteLine($"{daynumber} - выходной день недели");

