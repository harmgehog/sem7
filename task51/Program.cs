// Задача 51. cумма чисел главной диагонали

int sov, n, m; int[,] matrix;
int[,] GenMatrix(int rows, int cols, int low, int up)
{
    int[,] mtx = new int[rows, cols];
    for (int row = 0; row < rows; row++)
        for (int col = 0; col < cols; col++)
            mtx[row, col] = new Random().Next(low, up + 1);
    return mtx;
}
void SumOfDiagonal(int[,] mtx)
{
    sov = 0;
    int size = mtx.GetLength(0);
    if (mtx.GetLength(0) > mtx.GetLength(1))
        size = mtx.GetLength(1);
    for (int row = 0; row < size; row++)
        sov += mtx[row, row];
}
void ShowMatrix(int[,] mtx)
{
    for (int row = 0; row < mtx.GetLength(0); row++)
    {
        for (int col = 0; col < mtx.GetLength(1); col++)
        {
            Console.Write("{0,3}", mtx[row, col]);
        }
        Console.WriteLine();
    }
}
n = new Random().Next(3, 10); // int.Parse(Console.ReadLine()!)
m = new Random().Next(3, 10); // int.Parse(Console.ReadLine()!)
matrix = GenMatrix(n, m, -10, 10);
ShowMatrix(matrix);
SumOfDiagonal(matrix);
Console.WriteLine(sov);