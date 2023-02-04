// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и 
// замените эти элементы на их квадраты. Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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
int[,] ClonePowMatrix(int[,] mtx)
{
    int[,] copyMtx = (int[,])mtx.Clone();
    for (int row = 0; row < mtx.GetLength(0); row += 2)
    {
        for (int col = 0; col < mtx.GetLength(1); col += 2)
        {
            copyMtx[row, col] = (int)Math.Pow(mtx[row, col], 2);
        }
    }
    return copyMtx;
}
void ShowMatrix(int[,] mtx)
{
    for (int row = 0; row < mtx.GetLength(0); row++)
    {
        for (int col = 0; col < mtx.GetLength(1); col++)
        {
            Console.Write(" {0,5}", mtx[row, col]);
        }
        Console.WriteLine();
    }
}
int m = GetNum("\n\nInput m rows: ");
int n = GetNum("Input n cols: ");
int[,] matrix = GenMatrix(m, n, -100, 100);
int[,] newMatrix = ClonePowMatrix(matrix);
ShowMatrix(matrix);
Console.WriteLine();
ShowMatrix(newMatrix);