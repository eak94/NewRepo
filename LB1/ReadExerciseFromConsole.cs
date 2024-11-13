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

            Console.Write("Введите ваш вес: ");
            exercise.WeightPerson = CheckNumber(Console.ReadLine());

            Console.Write("Выберите единицы измерения времени вашей тренировки: " +
                        "1 - Час" +
                        "2 - Минуты" +
                        "3 - Секунды");

            _ = int.TryParse(Console.ReadLine(), out int timeUnitChoice);

            switch (timeUnitChoice)
            {
                case 1:
                    exercise.TimeUnit = TimeUnit.Hours;
                    break;
                case 2:
                    exercise.TimeUnit = TimeUnit.Minutes;
                    break;
                case 3:
                    exercise.TimeUnit = TimeUnit.Seconds;
                    break;
                default:
                    throw new ArgumentException
                        ("Некорректный выбор единиц измерения времени.");
            }

            Console.Write("Введите продолжительность вашей тренировки: ");
            double timeValue = CheckNumber(Console.ReadLine());

            switch (exercise.TimeUnit)
            {
                case TimeUnit.Hours:
                    exercise.Time = timeValue;
                    Console.Write(exercise.Time);
                    break;
                case TimeUnit.Minutes:
                    exercise.Time = timeValue / 60;
                    Console.Write(exercise.Time);
                    break;
                case TimeUnit.Seconds:
                    exercise.Time = timeValue / 3600;
                    Console.Write(exercise.Time);
                    break;
                default:
                    break;
            }

            var actionRunning = new List<(Action, string)>
            {
               (new Action(() =>
                       {
                           Console.Write("Выберите интенсивность тренировки:" +
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
                           Console.Write("Введите максимальный рабочий вес: ");
                           WeightLifting weightLifting = (WeightLifting)exercise;
                           weightLifting.MaxWeight = CheckNumber(Console.ReadLine());

                       }), "Максимальный рабочий вес"),

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

