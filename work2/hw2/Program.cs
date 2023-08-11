bool numberCheck(int num)
{
    if (num < 100)
        return true;
    else return false;
}

int ThirdDidit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    return num % 10;
}


Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (numberCheck(num))
{
    Console.WriteLine($"У данного числа нет третьей цифры, введите число больше или равное 100");
}
else
{
    int result = ThirdDidit(num);
    Console.WriteLine($"Третьей цифрой числа {num} является {result}");
}

