int SummaCifr(int n)
{
    if (n == 0) return 0;
    return (n % 10) + SummaCifr(n / 10);
}

int Delitel(int a, int b)
{
    return b == 0 ? a : Delitel(b, a % b);
}

void Bashni(int n, char s, char v, char p)
{
    if (n == 0) return;

    Bashni(n - 1, s, p, v);
    Console.WriteLine($"Диск {n}: {s} -> {v}");
    Bashni(n - 1, p, v, s);
}

Console.Write("1. Введите число для суммы цифр: ");
int chislo = int.Parse(Console.ReadLine());
Console.WriteLine($"Результат: {SummaCifr(Math.Abs(chislo))}\n");

Console.Write("2. Введите первое число для НОД: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"НОД: {Delitel(a, b)}\n");

Console.Write("3. Введите количество дисков: ");
int diski = int.Parse(Console.ReadLine());

if (diski > 0)
{
    Bashni(diski, 'A', 'C', 'B');
    Console.WriteLine($"Всего шагов: {Math.Pow(2, diski) - 1}");
}
else
{
    Console.WriteLine("Количество дисков должно быть больше 0");
}