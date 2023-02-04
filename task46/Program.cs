// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}
int[,] GenMatrix(int rows, int cols, int low, int up)
{
    int[,] mtx = new int[rows, cols];
    for (int row = 0; row < rows; row++)
    {
        for (int col = 0; col < cols; col++)
        {
            mtx[row, col] = new Random().Next(low, up + 1);
        }
    }
    return mtx;
}
void ShowMatrix(int[,] mtx)
{
    for (int row = 0; row < mtx.GetLength(0); row++)
    {
        for (int col = 0; col < mtx.GetLength(1); col++)
        {
            Console.Write(" {0,3}", mtx[row, col]);
        }
        Console.WriteLine();
    }
}
int m = GetNum("Input n(m) rows: ");
int n = GetNum("Input m(n) cols: ");
int[,] matrix = GenMatrix(m, n, -100, 100);
ShowMatrix(matrix);
