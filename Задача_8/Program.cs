Console.Clear();
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Чётные числа от 1 до n: ");
for (int i = 2; i <= n; i += 2)
Console.Write(i + " ");
