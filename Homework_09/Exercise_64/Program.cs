// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

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

void Numbers(int num)
{
    if (num > 1)
    {
        Console.Write($"{num}, ");
        Numbers(num - 1);
    }
    else
        Console.WriteLine(1);
}


int num = GetNumber("Введите целое положительное число: ");
Numbers(num);
//Console.WriteLine(StringOfNumbers(num));