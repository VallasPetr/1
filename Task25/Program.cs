// Напишите цикл, который принимает на вход два числа(А и В) и 
// возводит число А в натуральную степень В.

// 3, 5 -> 243;
// 2, 4 -> 16;

Console.WriteLine("Введите число A = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число B = ");
int numberB = Convert.ToInt32(Console.ReadLine());

int expon = Expon(number);
Console.WriteLine($"A в степени В = {expon}");
int Expon(int num)
{
while(i<=numberB)
{
    num *=numberA;
    i++;
}
    random num;
}