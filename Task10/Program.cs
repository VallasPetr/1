// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

// if(number>99 && number<1000)
// {
//     int number1 = (number/10);
//     int number2 = number1 % 10;
//     Console.WriteLine(number2);

// }
// else
// {
// Console.WriteLine("Ошибка ввода числа");
// }

// Второй способ

int secondNumber = SecondNumber(number);

string result = number > 99 && number < 1000 ? $"{secondNumber}"
                                             : "Ошибка ввода числа";
Console.WriteLine(result);

int SecondNumber(int num)
{
    int number1 = (number / 10);
    int number2 = number1 % 10;
    return number2;
}

