// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(100,1000);
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


int EvenNumbers(int[] array)
{
	int EvenNum = 0;
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)
		{
			count += 1;
			Console.WriteLine($"Четные числа массива: {array[i]} ");
		}
	}
	Console.WriteLine($"В массиве четных чисел: {count} ");

	return EvenNum;
}

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
			Console.WriteLine("Ошибка! Введите длину массива: ");
		}
	}
	return result;
}


int lengthNumber = GetNumber("Введите длину массива: ");
int[] array = InitArray(lengthNumber);
PrintArray(array);
int even = EvenNumbers(array);
