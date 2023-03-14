// Напишите программу, которая выводит случайное трёхзначное число и
//  удаляет вторую цифру этого числа. 
//  456 -> 46 
//  782 -> 72 
//  918 -> 98

int number = new Random().Next(10,1000);
Console.WriteLine($"Случайное число из отрезка 10 - 999 -> {number}"); 

// int firstDigit = number/100;
// int thirdDigit = number%10;
// int result = firstDigit*10 + thirdDigit;
// Console.WriteLine($"Двузначное число -> {result}");

// Второй вариант

int maxDigit = MaxDigit(number); // Вот сюда возвращает значение
Console.WriteLine($"Двузначное число -> {maxDigit}");
int MaxDigit(int num) // num = number, значение number перердаются в num
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit*10 + thirdDigit;
    return result; // возвращает знвчение в MaxDigit
}
