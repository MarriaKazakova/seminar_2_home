int SecondDigit(int num)
{
    int SecondDigit = (num % 100 - num % 10) / 10;
    return SecondDigit;
}

int num = new Random().Next(100, 1000);
int result = SecondDigit(num);
Console.WriteLine($"Наше число {num} ");
Console.WriteLine($"Вторая цифра числа {num} это {result}");


