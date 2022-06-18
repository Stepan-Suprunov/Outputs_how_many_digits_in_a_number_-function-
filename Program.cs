// Выдаёт колличество цифр в числе.

int Func(int num)
{
    int quantity = 0;
    for (; num >= 1; quantity++)
    {
        num = num/10;
    }
    return quantity;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

if (num == 0)
{
    Console.WriteLine("Колличество цифр в числе: 1");
}
else if (num < 0)
{
    num = num * -1;
    Console.WriteLine("Колличество цифр в числе: " + Func(num));
}
else
{
Console.WriteLine("Колличество цифр в числе: " + Func(num));
}
