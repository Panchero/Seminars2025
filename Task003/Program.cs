// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Clear();
Console.Write("Введите номер дня недели: ");
int a;
while (!int.TryParse(Console.ReadLine(), out a)) // Проверка на ввод целого числа
{
    Console.Write("Ошибка ввода! Введите число: "); // сообщение, когда условие не выполняется
}
if (a == 1)
{
    Console.WriteLine("Сегодня понедельник");
}
else if (a == 2)
{
    Console.WriteLine("Сегодня вторник");
}
else if (a == 3)
{
    Console.WriteLine("Сегодня среда");
}
else if (a == 4)
{
    Console.WriteLine("Сегодня четверг");
}
else if (a == 5)
{
    Console.WriteLine("Сегодня пятница");
}
else if (a == 6)
{
    Console.WriteLine("Сегодня суббота");
}
else if (a == 7)
{
    Console.WriteLine("Сегодня воскресенье");
}
else Console.WriteLine("Нет такого дня недели");

//особенность else if если сработало условие, то дальнейшей проверки не будет,
// конкретно тут при if вывдилось в конце сообшения еще и else