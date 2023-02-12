// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int SumOfNumericRange(int m, int n)
{
    if (m < n)
        return m + SumOfNumericRange(m + 1, n);
    else
        return n;
}

int m = GetNumber("Введите первое число: ");
int n = GetNumber("Введите второе число: ");
if (m > n)
    Console.WriteLine("Первое число должно быть меньше второго.");
else
    Console.WriteLine(SumOfNumericRange(m, n));