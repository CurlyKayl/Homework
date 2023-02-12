// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int GetNumber(string message)
{
	int result = 0;
	while (true)
	{
		Console.Write(message);

		if (int.TryParse(Console.ReadLine(), out result) && result > 0)
		{
			break;
		}
			else
		{
		Console.WriteLine("Ошибка. Не корректный ввод. Повторите ввод.");
		}
	}	
	return result;
}

int Accerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (n > 0 && m == 0)
        return Accerman(n - 1, 1);
    else
        return Accerman(n - 1, Accerman(n, m - 1));
}

int n = GetNumber("Введите первый аргумент: ");
int m = GetNumber("Введите второй аргумент: ");
Console.WriteLine($"A({n},{m}) = {Accerman(n, m)}");