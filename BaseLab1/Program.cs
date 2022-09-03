using System;

int x, y;
Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ ДЛЯ X ->");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ ДЛЯ Y ->");
y = Convert.ToInt32(Console.ReadLine());
//int c = x;
//x = y;
//y = c;
x = x - y;
y = x + y;
x = y - x;
Console.WriteLine($"x = {x}, y = {y}");