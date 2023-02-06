// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int GetNum(string text)
{
    do
    {
        try
        {
            Console.WriteLine(text);
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод(только цифры)!");
        }
    }
    while (true);
}
int[,] GenerateMatrix(int rows, int cols, int low, int up)
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
            Console.Write(" {0,4}", mtx[row, col]);
        }
        Console.WriteLine();
    }
}
int n = GetNum("Введите кол-во строк: ");
int m = GetNum("Введите кол-во столбцов: ");
int[,] matrix = GenerateMatrix(n, m, -100, 100);
ShowMatrix(matrix);
