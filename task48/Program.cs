// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
            mtx[row, col] = row + col;
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
int m = GetNum("\n\nInput m rows: ");
int n = GetNum("Input n cols: ");
int[,] matrix = GenMatrix(m, n, -100, 100);
ShowMatrix(matrix);
