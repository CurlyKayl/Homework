// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int GetNumbers(string message)
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

int[,] InitMatrix(int rows, int columns)
{
	int[,] matrix = new int[rows, columns];
	Random rnd = new Random();
	for (int i = 0; i < rows; i++)
	{
		for (int j = 0; j < columns; j++)
		{
			matrix[i,j] = rnd.Next(1, 10);
		}
	}
	return matrix;
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write($"{matrix[i, j]} ");
		}
		Console.WriteLine();
	}
}

void GetMediumColumns(int[,] matrix)
{
	double colmed = 0;
	Console.Write("Среднее арифметическое каждого столбца матрицы: ");

	for (int j = 0; j < matrix.GetLength(1); j++)
	{	
		colmed = 0;
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			colmed += matrix[i, j];
		}
		Console.Write($"{colmed / matrix.GetLength(0)}; ");
	}
	Console.WriteLine();
}

int rows = GetNumbers("Введите количество строк в матрице: ");
int columns = GetNumbers("Введите количество столбцов в матрице:");
int[,] randmatrix = InitMatrix(rows, columns);
PrintMatrix(randmatrix);
GetMediumColumns(randmatrix);