// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив: 1 4 7 2
// 5 9 2 3
// 8 4 2 4         17 -> такого числа в массиве нет
/* не явное условие задачи, поэтому делаю двумя вариантами, по индексам 1,7 и число 17 */
Console.Clear();
int n, m, val; int[,] matrix;
void GenMatrix()
{
    matrix = new int[n, m];
    for (int row = 0; row < n; row++)
        for (int col = 0; col < m; col++)
            matrix[row, col] = new Random().Next(10, 20);
}
void ShowMatrix()
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(" {0,3}", matrix[row, col]);
        }
        Console.WriteLine();
    }
}
void SearchAndCheck()
{
    // foreach (int[] item in matrix) if (item.Contains(17)) rslt = "Есть"; // первый способ
    // if (matrix.GetLength(0) < first || matrix.GetLength(1) < secnd) rslt2 = "Есть"; // второй
    bool flag = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (matrix[i, j] == val)
                flag = true;
    string rslt = flag ? $"Число {val} в матрице." : $"Числа {val} в матрице нет.";
    int first = val / 10; int secnd = val % 10; // 1 и 2 цифры
    try
    {
        Console.WriteLine(@$"
        По индексам {first}, {secnd} есть число:{matrix[first, secnd]}
        " + rslt);
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine(@$"
        Индексы {first}, {secnd} выходят за рамки матрицы.
        " + rslt);
    }
}
n = new Random().Next(9, 10);
// Console.Write("Введи n: "); int.Parse(Console.ReadLine()!)
m = new Random().Next(9, 10);
// Console.Write("Введи m: "); int.Parse(Console.ReadLine()!)
GenMatrix();
ShowMatrix();
val = new Random().Next(10, 20);
// Console.Write("Введи число(10,99): "); int.Parse(Console.ReadLine()!)
SearchAndCheck();
