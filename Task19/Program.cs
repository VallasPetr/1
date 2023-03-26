// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Первый вариант

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int a = number / 10000;
int b = number % 10;
int c = (number / 1000) % 10;
int d = (number / 10) % 10;
if (number >= 10000 && number <= 99999)
{
    if (a == b && c == d)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    }
}
else
{
    Console.Write("Введено некорректное число");
}

