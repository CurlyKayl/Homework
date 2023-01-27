// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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
			Console.WriteLine("Ошибка! Введите число: ");
		}
	}

	return result;
}

int number1 = GetNumber("Введите первое число: ");
int number2 = GetNumber("Введите второе число: ");

int GetDegree()
{
	int result = 1;

	for (int i = 0; i < number2; i++)
	{
		result *= number1;
	}
	return result;
}

int deg = GetDegree();

Console.Write($"Число {number1} в степени {number2} = {deg}");

