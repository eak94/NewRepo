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
                           $"2 - Выйти из программы\n" +
                           $"3 - Справка\n");

                bool isParsed = short.TryParse(Console.ReadLine(),
                    out short action);

                if (!isParsed)
                {
                    Console.WriteLine("Некорректный ввод. " +
                        "\nПопробуйте еще раз. Необходимо выбрать из пункта МЕНЮ.\n");
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
                    case 3:
                        {
                            Console.WriteLine("Выберете тип упражения для которого вам интересно " +
                                "посмотреть как рассчитываются каллории");
                            Console.WriteLine($"\nВыберете из списка упражнение: " +
                                $"\n1 - Бег\n" +
                                $"2 - Плавание\n" +
                                $"3 - Жим гантелей");

                            _ = int.TryParse(Console.ReadLine(), out int what);

                            switch (what)
                            {
                                case 1:
                                    {
                                        Console.WriteLine(" Метаболический эквивалент(MET) для жима штанги составляет примерно 3-6 MET\r\n " +
                                            "       //в зависимости от интенсивности тренировки.Для силовых тренировок,\r\n     " +
                                            "   //таких как жим штанги, можно использовать значение около 5 MET\r\n      " +
                                            "  //для умеренной интенсивности.\r\n      " +
                                            "  //- Легкие веса, медленный темп: около 3-4 MET\r\n    " +
                                            "    //- Умеренные веса: около 5 MET\r\n     " +
                                            "   //- Тяжелые веса: около 6 MET\r\n\r\n        " +
                                            "//Допустим, ваш вес составляет 70 кг, вы делаете жим штанги с умеренными\r\n     " +
                                            "   //весами(MET = 5), и ваша тренировка занимает 10 минут(или 0.167 часа)\r\n\r\n   " +
                                            "     //Калории = 5 *70*0.167 = 58.5");
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("");
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("");
                                        break;
                                    }
                                default:
                                    {
                                        throw new ArgumentException
                                        ("Такого вида упражнений нет в списке." +
                                        "\nПопробуйте еще раз.");
                                    }
                            }
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Такого пункта нет в МЕНЮ. Попробуйте еще раз.\n");
                            break;
                        }
                }
            }
        }
    }
}


