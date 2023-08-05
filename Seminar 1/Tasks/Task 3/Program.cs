//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница


Console.WriteLine("Введите номер дня недели:");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (Number == 2)
{
    Console.WriteLine("Вторник");
}
else if (Number == 3)
{
    Console.WriteLine("Среда");
}
else if (Number == 4)
{
    Console.WriteLine("Четверг");
}
else if (Number == 5)
{
    Console.WriteLine("Пятница");
}
else if (Number == 6)
{
    Console.WriteLine("Суббота");
}
else if (Number == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("В неделе всего 7 дней");
}