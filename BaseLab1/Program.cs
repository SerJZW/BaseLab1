using System;

int x;
int y;
Console.WriteLine("Введите значение для X");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение для Y");
y = Convert.ToInt32(Console.ReadLine());
int c = x;
x = y;
y = c;
x = x - y;
y = x + y;
x = y - x;
Console.WriteLine($"x = {x} y = {y}");

