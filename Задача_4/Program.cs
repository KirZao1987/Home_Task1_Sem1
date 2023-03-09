Console.Clear();
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int p = int.Parse(Console.ReadLine()!);
int max = n;
if (m > max) {
  max = m;
}
if (p > max) {
  max = p;
}
Console.WriteLine("Максимальное число: " + max);