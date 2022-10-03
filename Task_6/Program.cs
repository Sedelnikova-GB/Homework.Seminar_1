// Напишите программу, которая на вход принимает число и выдает, является ли число четным
// (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine()!);
if (x%2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}