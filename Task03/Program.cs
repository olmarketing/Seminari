﻿// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели: ");
int week = Convert.ToInt32(Console.ReadLine());

if (week == 1) 
Console.WriteLine("Понедельник");
else if (week == 2) 
Console.WriteLine("Вторник");
else if (week == 3) 
Console.WriteLine("Среда");
else if (week == 4) 
Console.WriteLine("Четверг");
else if (week == 5) 
Console.WriteLine("Пятница");
else if (week == 6) 
Console.WriteLine("Суббота");
else if (week == 7) 
Console.WriteLine("Воскресенье");

else 
Console.WriteLine("В неделе всего 7 дней");


