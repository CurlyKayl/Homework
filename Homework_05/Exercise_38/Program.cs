// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int GetLengthArray(string message)
{
	int result = 0;
	while (true)
	{
		Console.Write(message);
		if (int.TryParse(Console.ReadLine(), out result))
		{
			break;
		}
		else Console.WriteLine("Error!!!");
	}
	return result;
}

int[] GetArray(int mas)
{
	int[] arr = new int[mas];
	Random rnd = new Random();
	for (int i = 0; i < mas; i++)
	{
		arr[i] = rnd.Next(1, 101);
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

int difference (int[] arr)
{	
	int result = 0;
	int MaxArray = arr.Max();
	int MinArray = arr.Min();
	Console.WriteLine($"Максимальный элемент массива: {MaxArray}");
	Console.WriteLine($"Минимальный элемент массива: {MinArray}");
	result = MaxArray - MinArray;
	return result;
}

int lengthNumber = GetLengthArray("Введите длину массива: ");
int[] array = GetArray(lengthNumber);
PrintArray(array);
int diff = difference(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {diff}");