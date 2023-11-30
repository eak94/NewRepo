//Вывод сообщения в консоль
Console.WriteLine("Определите размерность матрицы");
Console.WriteLine("Введите n");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
int n = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
Console.WriteLine("Введите m");
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
int m = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
int[,] matrix = new int[n, m];
Console.WriteLine("Введите элементы матрицы(ввод элементов построчный)");
//Цикл для ввода элементов матрицы
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
        matrix[i, j] = int.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
    }
    // вывод пустой строки чтобы выйти из формирования матрицы для наглядности
    Console.WriteLine();
}
// очищаем консоль
Console.Clear();

Console.WriteLine("Введенная вами матрица");
// Цикл для сведения введеных элементов матрицы к виду nxm
for (int i = 0; i < n; i++)
{ 
    for (int j = 0; j < m; j++)
    {
        Console.Write("{0:0.0}\t", matrix[i, j]);
    }
    // вывод пустой строки чтобы выйти из формирования матрицы для наглядности
    Console.WriteLine();
}
// ввод счетчиков 
int sum = 0;
// Цикл для поиска масимального значения по строчно
for (int i = 0; i < n; i++)
{
    int max = matrix[i, 0];
    for (int j = 0; j < m; j++)
    {
        if (matrix[i, j] >= max)
        {
            max = matrix[i, j];
        }
    }
    // вычисления суммы максимальных значений 
    sum += max;
}

Console.WriteLine($"Сумма наибольших значений строк {sum}");
