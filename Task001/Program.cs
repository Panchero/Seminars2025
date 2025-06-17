/* 
Напишитите программу, которая на вход принимает число
и выдает его квадрат (число умноженное на само себя)

Быстрые комманды для комментрирования:
cmd +/
cmd + k -> cmd + c
cmd + k -> cmd + U 
*/

Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Квадрат числа равен " + a * a);