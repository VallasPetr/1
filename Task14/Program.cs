// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
// Первый способ 

// int a = number;
// if(number % 7 == 0 && number %23 == 0)

// {
//     Console.Write("КРАТНО");
// }
// else
// {
//     Console.Write("НЕ КРАТНО");
// }

// Второй способ

bool checkNumber = CheckNumber(number);
Console.WriteLine(checkNumber ? "КРАТНО" : "НЕ КРАТНО");
bool CheckNumber(int num)

{
    return num % 7 == 0 && num % 23 == 0;
}