// Задача 47. Заполните двумерный массив m×n, случайными вещественными числами.

int n, m, x; double[,] matrix;
x = 10;
while (x > 0)
{
Console.Clear();
double[,] GenMatrix(int rows, int cols, int low, int up)
{
    double[,] mtx = new double[rows, cols];
    for (int row = 0; row < rows; row++)
        for (int col = 0; col < cols; col++)
            mtx[row, col] = new Random().NextDouble() * (up - low) + low;
    return mtx;
}
void ShowMatrix(double[,] mtx)
{
    Console.Write(string.Concat(Enumerable.Repeat("\n", (40-m*2)/2)));
    for (int row = 0; row < mtx.GetLength(0); row++)
    {
        Console.Write(string.Concat(Enumerable.Repeat(" ", (80-n*7)/2)));
        for (int col = 0; col < mtx.GetLength(1); col++)
        {
            Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 16);
            Console.Write("{0,6:0.00}", mtx[row, col]);
        }
        Console.WriteLine();
    }
}
n = new Random().Next(3, 10); // int.Parse(Console.ReadLine()!)
m = new Random().Next(3, 10); // int.Parse(Console.ReadLine()!)
matrix = GenMatrix(n, m, -100, 100);
ShowMatrix(matrix);
x--;
Thread.Sleep(1500);
}