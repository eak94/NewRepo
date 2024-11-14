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
                throw new ArgumentException("Необходимо ввести число");
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
                     Console.Write("Введите ваш вес (кг): ");
                     Running running = (Running)exercise;
                     running.WeightPerson = CheckNumber(Console.ReadLine());
                }), "Вес"),

                (new Action(() =>
                {
                     Console.Write("Введите продолжительность вашей тренировки (ч):");
                     Running running = (Running)exercise;
                     running.Time = CheckNumber(Console.ReadLine());
                }), "Продолжительность тренировки"),


                (new Action(() =>
                       {
                           Console.Write("Введите дистанцию (км):");
                           Running running = (Running)exercise;
                           running.Distance = CheckNumber(Console.ReadLine());

                       }), "Дистанция"),

            (new Action(() =>
                       {
                           Running running = (Running)exercise;
                           Console.WriteLine($"Количество сожженых каллорий: " +
                               $"{Math.Round(exercise.CalculateCalories, RoundNumber)}\n");
                           Console.WriteLine("Нажмите любую кнопку для продолжения");
                           _ = Console.ReadKey();
                           Console.WriteLine(" ");

                       }), "")
            };

            var actionSwimming = new List<(Action, string)>
            {
                (new Action(() =>
                {
                     Console.Write("Введите ваш вес (кг): ");
                     Swimming swimming = (Swimming)exercise;
                     swimming.WeightPerson = CheckNumber(Console.ReadLine());
                }), "Вес"),

                (new Action(() =>
                {
                     Console.Write("Введите продолжительность вашей тренировки (ч):");
                     Swimming swimming = (Swimming)exercise;
                     swimming.Time = CheckNumber(Console.ReadLine());
                }), "Продолжительность тренировки"),

                (new Action(() =>
                       {
                           Console.Write("Введите вашу дистанцию (м): ");
                           Swimming swimming = (Swimming)exercise;
                           swimming.Distance = CheckNumber(Console.ReadLine());

                       }), "Дистанция"),

                (new Action(() =>
                {
                           Console.Write("Выберите стиль плавания:\n" +
                               "1 - Брасс\n" +
                               "2 - Кроль-умеренный\n" +
                               "3 - Кроль-быстрый\n" +
                               "4 - На спине\n" +
                               "5 - Дельфин\n");
                           Swimming swimming = (Swimming)exercise;
                           if (int.TryParse(Console.ReadLine(), out int styleChoice))
                           {
                               switch (styleChoice)
                                       {
                                           case 1:
                                               swimming.Style = 1;
                                               break;
                                           case 2:
                                               swimming.Style = 2;
                                               break;
                                           case 3:
                                               swimming.Style = 3;
                                               break;
                                           case 4:
                                               swimming.Style = 4;
                                               break;
                                           case 5:
                                               swimming.Style = 5;
                                               break;
                                           default:
                                               Console.WriteLine("Некорректный ввод стиля.");
                                               break;
                                       }
                           }
                }), "Стиль плавания"),

                (new Action(() =>
                       {
                           Swimming swimming = (Swimming)exercise;
                           Console.WriteLine($"Количество сожженых каллорий: " +
                               $"{Math.Round(exercise.CalculateCalories, RoundNumber)}\n");
                           Console.WriteLine("Нажмите любую кнопку для продолжения");
                           _ = Console.ReadKey();
                           Console.WriteLine(" ");

                       }), "")
            };

            var actionWeightLifting = new List<(Action, string)>
            {
                (new Action(() =>
                {
                     Console.Write("Введите ваш вес (кг): ");
                     WeightLifting weightLifting = (WeightLifting)exercise;
                     weightLifting.WeightPerson = CheckNumber(Console.ReadLine());
                }), "Вес"),

                (new Action(() =>
                {
                     Console.Write("Введите продолжительность вашей тренировки (ч):");
                     WeightLifting weightLifting = (WeightLifting)exercise;
                     weightLifting.Time = CheckNumber(Console.ReadLine());
                }), "Продолжительность тренировки"),

                (new Action(() =>
                       {
                           Console.Write("Введите ваш максимальный рабочий вес: ");
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
                           WeightLifting weightLifting = (WeightLifting)exercise;
                           Console.WriteLine($"Количество сожженых каллорий: " +
                               $"{Math.Round(exercise.CalculateCalories, RoundNumber)}\n");
                           Console.WriteLine("Нажмите любую кнопку для продолжения");
                           _ = Console.ReadKey();
                           Console.WriteLine(" ");

                       }), "")
            };
            ActionHandler(actionExercise);

            var figureActionDictionary = new Dictionary<Type, List<(Action, string)>>
            {
                {typeof(Running), actionRunning },
                {typeof(Swimming), actionSwimming },
                {typeof(WeightLifting), actionWeightLifting }
            };

            foreach (var action in figureActionDictionary[exercise.GetType()])
            {
                ActionHandler(action.Item1);
            }
        }

        /// <summary>
        /// Метод использования Action
        /// </summary>
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




