Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number % 10;

if(a >= 100||a <=999)
{
    Console.WriteLine("Последняя цифра: " + a);
}