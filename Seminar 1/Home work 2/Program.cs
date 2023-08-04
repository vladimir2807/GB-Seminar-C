 
using System.Drawing;
// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.



// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Напишите число a: ");
int FerstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение числа b: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение числа c: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

int max = FerstNumber;
if (SecondNumber > max)
{
    max = SecondNumber;
}
if (ThirdNumber > max)
{
    max = ThirdNumber;
}
Console.WriteLine("Max " + max);