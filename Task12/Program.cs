//  Напишите программу, которая будет принимать на вход два числа
//  и выводить, является ли первое число кратным второму. 
//  Если число 1 не кратно числу 2, то программа выводит остаток от деление.
//  34, 5 -> не кратно, остаток 4 
//  16, 4 -> кратно

Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Первый способ
// if(number1%number2==0)
// {
//     Console.Write("КРАТНО");
// }
// else
// {
//     int number3 = number1%number2;
//     Console.WriteLine($"НЕ КРАТНО {number3} ");
// }

// Второй способ
int multiple = Multiple(number1, number2);
string resultEnd = multiple==0
                             ?"КРАТНО"
                             :$"НЕ КРАТНО {multiple} ";
Console.WriteLine(resultEnd);

int Multiple(int num1, int num2)
{
    int result = num1 % num2;
    return result;
}