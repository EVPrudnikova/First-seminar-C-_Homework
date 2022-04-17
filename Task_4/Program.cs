Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int Max = numberA;

if (numberB > Max) Max = numberB;
if (numberC > Max) Max = numberC;

Console.WriteLine("Максимальное число: " + Max);