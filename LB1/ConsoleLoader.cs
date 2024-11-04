namespace LB3
{
    /// <summary>
    /// Класс для индикации
    /// </summary>
    internal class ConsoleLoader
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        private static void Main()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine($"МЕНЮ\n " +
                    $"1 - Запустить расчет\n" +
                    $"Нажмите 2 - Выход из программы");

                var number = Console.ReadLine();

                switch (number)
                {
                    case "1":
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                    case "2":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите 1 или 2");
                        break;

                    }
                }

            }
        }
    }
}
