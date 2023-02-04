// Задача 52. Задайте матрицу из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int n, m, sum; int[][] matrix; // двухступенчатый вместо двумерного

void ShowAvrgCols()
{
    Console.Write("Среднее каждого столбца: ");
    for (int i = 0; i < m; i++)
    {
        sum = 0;
        for (int j = 0; j < n; j++)
            sum += matrix[j][i];
        Console.Write("{0,6:0.00}", (double)sum / m);
    }
}
void ShowMTX()
{
    foreach (int[] item in matrix)
    {
        for (int j = 0; j < item.Length; j++)
            Console.Write("{0,4}", item[j]);
        Console.WriteLine();
    }
}
void GetMTX()
{
    matrix = Enumerable.Range(0, n).Select(r =>
        Enumerable.Range(0, m).Select(c => new Random().Next(1, 99)).ToArray()).ToArray();
}
void Main()
{
    n = 6; // new Random().Next(3, 10); // int.Parse(Console.ReadLine()!)
    m = 6; // new Random().Next(3, 10); // int.Parse(Console.ReadLine()!)
    GetMTX(); ShowMTX(); ShowAvrgCols();
}
Main();