/* 
Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
*/

Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b)
{
    Console.WriteLine("Да");
}
else Console.WriteLine("нет");

// Console.WriteLine(Math.Pow (5, 3)); первое - число, которое хотим возвести, второе - степнь, в которую хотим возвести
