﻿Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 2 == 0) 
  Console.WriteLine("число является чётным.");
else 
Console.WriteLine("число не является чётным.");