 // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Напишите число: ");
int FerstNumber = Convert.ToInt32(Console.ReadLine());
int SecondNumber = 1;
int i = SecondNumber;
while (i < FerstNumber + 1)
{
    Console.Write(i + " ");
    i++;
}