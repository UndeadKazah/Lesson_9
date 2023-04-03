Console.Write("Введите значение M:");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:");
int y = Convert.ToInt32(Console.ReadLine());

int akkerman(int x, int y)
{
    if (x == 0) return y + 1;
    else if (y == 0) return akkerman(x - 1, 1);
    else return akkerman(x - 1, akkerman(x, y - 1));
}

Console.Write($"Результат функции Аккермана равен {akkerman(x, y)} ");
