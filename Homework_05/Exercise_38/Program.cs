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

double[] GetArray(int mas)
{
	double[] arr = new double[mas];
	Random rnd = new Random();
	for (int i = 0; i < mas; i++)
	{
		arr[i] = rnd.NextDouble() * 100;
	}
	return arr;
}


void PrintArray(double[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write($"{arr[i]} ");
	}
	Console.WriteLine();
}


double difference (double[] arr)
{	
	double result = 0;
	double MaxArray = arr.Max();
	double MinArray = arr.Min();
	Console.WriteLine($"Максимальный элемент массива: {MaxArray}");
	Console.WriteLine($"Минимальный элемент массива: {MinArray}");
	result = MaxArray - MinArray;
	return result;
}


int lengthNumber = GetLengthArray("Введите длину массива: ");
double[] array = GetArray(lengthNumber);
PrintArray(array);
double diff = difference(array);

Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {diff}");