Console.Clear();
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);
if (n > m)
  Console.WriteLine(n);
else if (m > n)
  Console.WriteLine(m);
else
  Console.WriteLine("=");