using Model;

namespace LB3
{
    /// <summary>
    /// Класс для добавления упражнения по
    /// которому необходимо посчитать кол-во каллорий
    /// </summary>
    public class ReadExerciseFromConsole
    {

        /// <summary>
        /// Константа степени округления числа.
        /// </summary>
        public const int RoundNumber = 3;


        /// <summary>
        /// Метод для провери введенного числа
        /// </summary>
        /// <param name="number">число</param>
        /// <returns></returns>
        private static double CheckNumber(string number)
        {
            if (number.Contains('.'))
            {
                number = number.Replace('.', ',');
            }

            bool isParsed = double.TryParse(number,
                        out double checkNumber);

            if (!isParsed)
            {
                throw new ArgumentException("Нужно ввести число");
            }

            return checkNumber;
        }


        /// <summary>
        /// Метод для добавления параметров по выбраннмым упражениям 
        /// </summary>
        /// <exception cref="ArgumentException">ошибка ввода</exception>
        public static void AddExercise()
        {
            ExerciseBase exercise = new Running();

            Action actionExercise = new Action(() =>
            {
                Console.WriteLine($"\nВыберете из списка упражнение: " +
                    $"\n1 - Бег\n" +
                    $"2 - Плавание\n" +
                    $"3 - Жим гантелей");

                _ = int.TryParse(Console.ReadLine(), out int what);

                switch (what)
                {
                    case 1:
                        {
                            exercise = new Running();
                            break;
                        }
                    case 2:
                        {
                            exercise = new Swimming();
                            break;
                        }
                    case 3:
                        {
                            exercise = new WeightLifting();
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException
                            ("Такого вида упражнений нет в списке." +
                            "\nПопробуйте еще раз.");
                        }
                }
            });

            var actionRunning = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите ваш вес: ");
                    Running running = (Running)exercise;
                    running.WeightPerson = CheckNumber(Console.ReadLine());

                }), "Ваш вес"),

                (new Action(() =>
                {
                    //сюда добавить выбор минуты, часы, секунды (додумать)
                    Console.Write("Выберите единицы измерения времени: " +
                        "1 - Час" +
                        "2 - Минуты" +
                        "3 - Секунды");
                    Console.Write("Введите продолжительность вашей тренировки: ");
                    Running running = (Running)exercise;
                    running.Time = CheckNumber(Console.ReadLine());

                }), "Время тренировки"),


               (new Action(() =>
                       {
                           Console.Write("Выберите темп тренировки:" +
                               "1 - Медленный ()" +
                               "2 - Умеренный ()" +
                               "3 - Быстрый ()");
                           Running running = (Running)exercise;
                           running.Intensity = CheckNumber(Console.ReadLine());

                       }), "Интенсивность тренировки"),

                       (new Action(() =>
                       {
                           Console.Write("Количество сожженых каллорий:");
                           Running running = (Running)exercise;
                           Console.WriteLine($"Количество сожженых каллорий: " +
                               $"{Math.Round(exercise.CalculateCalories, RoundNumber)}\n");
                           Console.WriteLine("Нажмите любую кнопку для продолжения");
                           _ = Console.ReadKey();
                           Console.WriteLine(" ");

                       }), "Количество сожженых каллорий")
                   };

            var actionSwimming = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите ваш вес: ");
                    Swimming swimming = (Swimming)exercise;
                    swimming.WeightPerson = CheckNumber(Console.ReadLine());

                }), "Ваш вес"),

                (new Action(() =>
                {
                    //сюда добавить выбор минуты, часы, секунды (додумать)
                    Console.Write("Выберите единицы измерения времени: " +
                        "1 - Час" +
                        "2 - Минуты" +
                        "3 - Секунды");
                    Console.Write("Введите продолжительность вашей тренировки: ");
                    Swimming swimming = (Swimming)exercise;
                    swimming.Time = CheckNumber(Console.ReadLine());

                }), "Время тренировки"),


               (new Action(() =>
                       {
                           Console.Write("Введите вашу дистанцию");
                           Swimming swimming = (Swimming)exercise;
                           swimming.Distance = CheckNumber(Console.ReadLine());

                       }), "Дистанция"),

                (new Action(() =>
                {
                           Console.Write("Выберите стиль плавания:" +
                               "1 - Брасс" +
                               "2 - Кроль-умеренный" +
                               "3 - Кроль-быстрый" +
                               "4 - На спине" +
                               "5 - Дельфин");
                           Swimming swimming = (Swimming)exercise;
                           swimming.Style = Console.ReadLine();

                       }), "Стиль плавания"),

                (new Action(() =>
                       {
                           Console.Write("Количество сожженых каллорий:");
                           Swimming swimming = (Swimming)exercise;
                           Console.WriteLine($"Количество сожженых каллорий: " +
                               $"{Math.Round(exercise.CalculateCalories, RoundNumber)}\n");
                           Console.WriteLine("Нажмите любую кнопку для продолжения");
                           _ = Console.ReadKey();
                           Console.WriteLine(" ");

                       }), "Количество сожженых каллорий")
            };

            var actionWeightLifting = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите ваш вес: ");
                    WeightLifting weightLifting = (WeightLifting)exercise;
                    weightLifting.WeightPerson = CheckNumber(Console.ReadLine());

                }), "Ваш вес"),

                (new Action(() =>
                       {
                           Console.Write("Введите максимальный рабочий вес: ");
                           WeightLifting weightLifting = (WeightLifting)exercise;
                           weightLifting.MaxWeight = CheckNumber(Console.ReadLine());

                       }), "Максимальный рабочий вес"),

                (new Action(() =>
                {
                    //сюда добавить выбор минуты, часы, секунды (додумать)
                    Console.Write("Выберите единицы измерения времени: " +
                        "1 - Час" +
                        "2 - Минуты" +
                        "3 - Секунды");
                    Console.Write("Введите продолжительность вашей тренировки: ");
                    WeightLifting weightLifting = (WeightLifting)exercise;
                    weightLifting.Time = CheckNumber(Console.ReadLine());

                }), "Время тренировки"),


               (new Action(() =>
                       {
                           Console.Write("Введите рабочий вес: ");
                           WeightLifting weightLifting = (WeightLifting)exercise;
                           weightLifting.WorkingWeight = CheckNumber(Console.ReadLine());

                       }), "Рабочий вес"),


                (new Action(() =>
                       {
                           Console.Write("Количество сожженых каллорий:");
                           WeightLifting weightLifting = (WeightLifting)exercise;
                           Console.WriteLine($"Количество сожженых каллорий: " +
                               $"{Math.Round(exercise.CalculateCalories, RoundNumber)}\n");
                           Console.WriteLine("Нажмите любую кнопку для продолжения");
                           _ = Console.ReadKey();
                           Console.WriteLine(" ");

                       }), "Количество сожженых каллорий")
            };


            ActionHandler(actionExercise);

            var figureActionDictionary = new Dictionary<Type, List<(Action, string)>>
            {
                {typeof(Running), actionRunning }
            };

            foreach (var action in figureActionDictionary[exercise.GetType()])
            {
                ActionHandler(action.Item1);
            }
        }

        /// <summary>
        /// Метод использования Action
        /// </summary>
        /// <param name="action"></param>
        /// <param name="propertyName"></param>
        private static void ActionHandler(Action action)
        {

            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (ArgumentException exception)
                {

                    Console.WriteLine(exception.Message);

                }
            }
        }
    }
}

