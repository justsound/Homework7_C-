Console.Clear();

// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

int[,] CreateMatrix(int row, int column)
{
    Random rnd = new Random();
    int[,] matr = new int[row, column];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(-10, 10);

        }
    }
    return matr;
}

void SortMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1 - j; k++)
            {
                if (matr[i, k] > matr[i, k + 1])
                {
                    int tmp = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = tmp;
                }
            }
        }
    }
}

int[,] matrix = CreateMatrix(ReadInt("Введите количество строк в массиве: "),
ReadInt("Введите количество столбцов в массиве: "));
PrintMatrix(matrix);
Console.WriteLine();

/* SortMatrix(matrix);
PrintMatrix(matrix); */

//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
/* 
if (matrix.GetLength(0) != matrix.GetLength(1)) Console.WriteLine("Невозможно поменять столбцы и строки. Матрица не квадратная");

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[j,i]} ");
        }
        Console.WriteLine();
    }
 }
    
ChangeMatrix(matrix);
 */

//В прямоугольной матрице найти строку с наименьшей суммой элементов.

int[] FindRowSum(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sum[i] = sum[i] + matrix[i, j];
    }
    return sum;
}

int[] sum = FindRowSum(matrix);
Console.WriteLine(string.Join(", ", sum));
Console.WriteLine();
void FindMin(int[] matrix)
{
    int min = matrix[0];
    int pos = 0;
    for (int i = 1; i< matrix.Length; i ++)
    {
        if (matrix[i] < min) 
        {
            min = matrix[i];
            pos = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой {pos + 1}, ее сумма = {min}.");
}
FindMin(sum);