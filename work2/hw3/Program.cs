
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
if (num < 6)
    {
       Console.WriteLine("Будний день");
    }
    else if (num<8)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
         Console.WriteLine("Введите число от 1 до 7");
    }

