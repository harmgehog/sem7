// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив: 1 4 7 2
                        // 5 9 2 3
                        // 8 4 2 4         17 -> такого числа в массиве нет
/* не явное условие задачи, поэтому делаю двумя вариантами, по индексам 1,7 и число 17 */
Console.Clear();
int n, m, val; string rslt; int[,] matrix;
void GenMatrix()
{
    matrix = new int[n, m];
    for (int row = 0; row < n; row++)
        for (int col = 0; col < m; col++)
            matrix[row, col] = new Random().Next(-99, 100);
}
void SearchAndCheck()
{
    // foreach (int[] item in matrix) if (item.Contains(17)) rslt = "Есть";
    // if (matrix.GetLength(0) < first || matrix.GetLength(1) < secnd) rslt2 = "Есть";
    for (int row = 0; row < n; row++)
        for (int col = 0; col < m; col++)
            if (matrix[row, col] == val) rslt = $"Число {val} в матрице.";
    rslt = $"Числа {val} в матрице нет.";
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
n = new Random().Next(3, 10);
// Console.Write("Введи n: "); int.Parse(Console.ReadLine()!)
m = new Random().Next(3, 10);
// Console.Write("Введи m: "); int.Parse(Console.ReadLine()!)
GenMatrix();
val = new Random().Next(10, 99);
// Console.Write("Введи число(10,99): "); int.Parse(Console.ReadLine()!)
SearchAndCheck();
