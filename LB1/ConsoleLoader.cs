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

                Console.WriteLine($"Меню\n " +
                    $"1 - Запустить расчет" +
                          $"\nНажмите 2 - если хотите выйти из программы");

            }
        }
    }
}
