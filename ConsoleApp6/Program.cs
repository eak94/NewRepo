//Вывод сообщения в консоль
Console.WriteLine("Введите длину массива");
//Вывод сообщения в консоль
int length = int.Parse(Console.ReadLine());
int[] number;
number = new int[length];
Console.WriteLine($"Введите {length} элементов массива");
// Заполнение массива значениями
for (int i = 0; i < number.Length; i++)
{
    // добавлен комментарий
    number[i] = int.Parse(Console.ReadLine()); 
}
// счетчики для поиска максимального и минимального значения в массиве
float min = number[0]; 
float max = number[0];
// цикл для поиска максимального и минимального значения в массиве
for (int i = 1; i < number.Length; i++)
{ 
    if (min > number[i])
    {
        min = number[i];
    }
    else 
    {
        max = number[i];
    }
}
// счетчики для вычисления суммы и количества чисел 
float sum = 0;
float count = 0; 
for (int i = 0; i < number.Length; i++)
{
    sum += number[i];
    count +=1;
}
//сумма без учета масимального и минимального значения
float summa = sum - max - min;
// вычисление среднеарифметического значения
float average =summa / (count - 2);
//Вывод сообщения в консоль
Console.WriteLine($"Минимальный элемент массива {min}");
Console.WriteLine($"Максимальный элемент массива {max}");
Console.WriteLine($"Среднее арифметическое введенных чисел без учета минимального и максимального элемента массива: {Math.Round(average, 2)}");
Console.ReadKey();