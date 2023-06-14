// - коммит одной строки
/*
shtehe
eytjy
ejytjej*/

// быстрый коммит (комманд слеш)

// Напишите программу, которая на вход принимает число и выдаёт его квадрат

Console.Write("Ведите число: ");
int number = int.Parse(Console.ReadLine()!);

// Mat
int sqr = number * number;

Console.WriteLine ($"Квадрат данного числа равен = {sqr} (Математически)");

//  с помощью библиотеки Math
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine ($"Квадрат данного числа равен = {sqr1} (Библиотека)");