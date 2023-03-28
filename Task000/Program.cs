// Возведение числа в степень


Console.Write("Введите число A = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число B = ");
int numberB = Convert.ToInt32(Console.ReadLine());
int numA = numberA;
for (int i = 1; numberB > i; i++)
{
    int multiply = numA * numberA;
    numA = multiply;
}

Console.WriteLine($"Число А в степени B = {numA}");





