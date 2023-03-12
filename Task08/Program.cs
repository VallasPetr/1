// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// Example:
// 5 -> 2, 4 
// 8 -> 2, 4, 6, 8

Console.Write("Введите натуральное число ");
int number = Convert.ToInt32(Console.ReadLine());
if(number>=2)
for(int i = 2; i<= number; i+=2)
{
    Console.Write(i + " ");
}
else
{
Console.Write($"В число {number} не входит ни одно чётное число, либо оно не является натуральным");
}