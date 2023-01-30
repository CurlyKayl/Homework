// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int GetNumber(string mes)
{
	int result = 0;
	while (true)
	{
		Console.Write(mes);
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


int[] GetArray(int mas)
{
	int[] arr = new int[mas];
	Random rnd = new Random();

	for (int i = 0; i < mas; i++)
	{
		arr[i] = rnd.Next(-1000, 1001);
	}
	return arr;
}

void PrintArray(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write($"{arr[i]} ");
	}
	Console.WriteLine();
}


int SumNotEven(int[] array)
{
	int sum = 0;
	int index = 0;
	for (int i = 1; i < array.Length; i += 2)
	{
		sum += array[i];
		index = array[i];
		Console.WriteLine($"Нечетные элементы массива: {index}");
	}
	Console.WriteLine($"Сумма элементов с нечетными индексами массива: {sum}");

	return sum;
}

int lengthNumber = GetNumber("Введите длину массива: ");
int[] array = GetArray(lengthNumber);
PrintArray(array);
int sum = SumNotEven(array);