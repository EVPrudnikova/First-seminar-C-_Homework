Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Index = 1;

while (Index < number)
{
    if (Index % 2 == 0)
    {
        Console.Write(Index + ", ");
    }
Index++;
}
