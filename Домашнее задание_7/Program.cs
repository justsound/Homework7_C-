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
    // row = ReadInt("Введите начало промежутка, в котором будут задаваться числа в массиве: ");
    // column = ReadInt("Введите конец промежутка, в котором будут задаваться числа в массиве: ");
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

