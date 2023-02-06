// Задача 47. Задайте двумерный массив размером m x n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int GetNumbers(string message)
{
	int result = 0;
	while (true)
	{
		Console.WriteLine(message);

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

double[,] InitMatrix(int rows, int columns)
{
	double[,] matrix = new double[rows, columns];
	Random rnd = new Random();
	for (int m = 0; m < rows; m++)
	{
		for (int n = 0; n < columns; n++)
		{
			matrix[m, n] = rnd.NextDouble();
			double matrixCut = Math.Truncate(matrix * 100) / 100;
		}
	}
	return matrix;
}

void PrintMatrix(double[,] matrix)
{
	for (int m = 0; m < matrix.GetLength(0); m++)
	{
		for (int n = 0; n < matrix.GetLength(1); n++)
		{
			Console.Write($"{matrix[m,n] }");
		}
	}
	Console.WriteLine();
}

int countOfRows = GetNumbers("Введите количество строк в матрице: ");
int countOfColumns = GetNumbers("Введите количество столбцов в матрице: ");
double[,] matrix = InitMatrix(countOfRows, countOfColumns);

PrintMatrix(matrix);