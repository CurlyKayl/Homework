// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int GetNumber(string message)
{
	int result = 0;
	while (true)
	{
		Console.Write(message);
		if (int.TryParse(Console.ReadLine(), out result))
		{
			break;
		}
		else
		{
			Console.WriteLine("Ошибка!");
		}
	}
	return result;
}

int number = GetNumber("Введите число: ");
int num = number;
int sum = 0;

while (number > 0)
{
    sum += number % 10;
    number /= 10;
}

Console.Write($"Сумма цифр числа {num} = {sum}");

