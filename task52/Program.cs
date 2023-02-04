// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix; int n, m, sum;
void ShowMTX()
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
            Console.Write("{0,4}", matrix[i, j]);
        Console.WriteLine();
    }
}
void GetMTX()
{
    for (int i = 0; i < n; i++) 
        for (int j = 0; j < m; j++) 
            matrix[i, j] = new Random().Next(1, 99);
}
void ShowAvrgCols()
{
    Console.Write("Среднее каждого столбца: ");
    for (int i = 0; i < m; i++)
    {
        sum = 0;
        for (int j = 0; j < n; j++)
            sum += matrix[j, i];
        Console.Write("{0,6:0.00}", (double)sum / m);
        // Console.Write(Math.Round(Convert.ToDouble(sum) / m, 2) + " ");
    }
}
void Main()
{
    n = 6; // new Random().Next(3, 10); // int.Parse(Console.ReadLine()!)
    m = 6; // new Random().Next(3, 10); // int.Parse(Console.ReadLine()!)
    matrix = new int[n, m];
    GetMTX(); ShowMTX(); ShowAvrgCols();
}
Main();