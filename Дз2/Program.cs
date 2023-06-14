// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 
// 2, 3, 7 -> 7 
// 44 5 78 -> 78 
// 22 3 9 -> 22

Console.Write("Ведите первое число: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Ведите второе число: ");
int n1 = int.Parse(Console.ReadLine()!);

Console.Write("Ведите третье число: ");
int n2 = int.Parse(Console.ReadLine()!);


if(n > n1)
{
    if(n > n2) 
    {
    Console.WriteLine("первое число больше");
    }
    else
    {
    Console.WriteLine("третье число больше");
    }
}
else
{
    if(n1 > n2) 
    {
    Console.WriteLine("первое второе больше");
    }
    else
    {
    Console.WriteLine("третье число больше");
    }
}