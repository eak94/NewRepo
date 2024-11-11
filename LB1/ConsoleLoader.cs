using Model;

namespace LB3
{
    /// <summary>
    /// Основная программа
    /// </summary>
    internal class ConsoleLoader
    {
        /// <summary>
        /// Главный метод программы
        /// </summary>
        private static void Main()
        {
            while (true)
            {

                Console.WriteLine($"МЕНЮ\n" +
                    $"\n1 - Начать расчет каллорий,\n" +
                           $"2 - Выйти из программы\n");

                bool isParsed = short.TryParse(Console.ReadLine(),
                    out short action);

                if (!isParsed)
                {
                    Console.WriteLine("Некорректный ввод. " +
                        "Необходимо выбрать цифру из пункта МЕНЮ");
                }
                switch (action)
                {
                    case 1:
                        {
                            ReadExerciseFromConsole.AddExercise();
                            break;
                        }
                    case 2:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Выберите только из пунктов МЕНЮ");
                            break;
                        }
                }
            }
        }
    }
}


