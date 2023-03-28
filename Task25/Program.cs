// Напишите цикл, который принимает на вход два числа(А и В) и 
// возводит число А в натуральную степень В.

// 3, 5 -> 243;
// 2, 4 -> 16;

Console.Write("Введите число A = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число B = ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberB>0)
{
int multiply = Multiply(numberA); // int numA = numberA;
Console.WriteLine($"A в степени B = {multiply}");
int Multiply(int numA)
{
for (int i = 1; numberB > i; i++)
{
    int multiply = numA * numberA;
    numA = multiply;
}
return numA;
}
}
else
{
    Console.WriteLine("Число B введено некорректно");
}





// int expon = Expon(num);


