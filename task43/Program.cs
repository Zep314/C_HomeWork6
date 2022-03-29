// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем или задаются вручную.

using System;

string MySign(double v)  // функция для вывода значения переменной со знаком принудительно
{
    if (v>0)
        return '+'+Convert.ToString(v);
    else
        return Convert.ToString(v);
}

Console.WriteLine("Программа ищет точку пересечения двух прямых вида y=k1*x+b1 и y=k2*x+b2");

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Заданы следующие прямые:");
Console.WriteLine($"y={k1}*x{MySign(b1)}");
Console.WriteLine($"y={k2}*x{MySign(b2)}");
if (k1 == k2)
{
    Console.WriteLine("Решения нет, прямые параллельны.");
}
else
{
    // X для точки пересечения вычисляется так: x = (b2-b1) / (k1 - k2)
    // Y вычисляем подставляя найденный X  в уравнение первой прямой y = k1 * ( (b2-b1) / (k1 - k2) ) + b1
    Console.WriteLine("Прямые пересекаются в точке с координатами:");
    Console.WriteLine($"[ {(b2-b1)/(k1-k2)}, {(k1*(b2-b1)/(k1-k2))+b1} ]");
}
