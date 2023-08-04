 
// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Напишите число a: ");
int FerstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение числа b: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FerstNumber < SecondNumber)
{
    Console.WriteLine("Min " + FerstNumber);  
    Console.WriteLine("Max " + SecondNumber);
}
else 
{
    Console.WriteLine("Min " + SecondNumber);
    Console.WriteLine("Max " + FerstNumber);    
}