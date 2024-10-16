using LibraryPerson;

namespace LB1
{
    public class AddPersonConsole
    {
        /// <summary>
        /// Метод для вывода информации об объектах
        /// </summary>
        /// <param name="person"> Объект класса персон </param>
        public void PrintPeople(PersonBase person)
        {
            Console.Write(person.GetInfo());
        }

        /// <summary>
        /// Метод для ввода информации о персоне через консоль
        /// </summary>
        /// <returns> Объект класса персон, предствляющий персону которая введена через консоль </returns>
        public static PersonBase PersonConsole()
        {
            PersonBase person = new Adult();

            var validationActions = new List<Action>()
            {
                new Action(() =>
                    {
                        Console.WriteLine("Введите Имя:");
                        person.Name = Console.ReadLine();
                    }),
                new Action(() =>
                    {
                        Console.WriteLine("Введите Фамилию:");
                        person.SecondName = Console.ReadLine();
                    }),
                new Action(() =>
                    {
                        Console.WriteLine("Введите Возраст:");
                        string ageInput = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(ageInput))
                        {
                            throw new ArgumentException("Поле не может быть пустым. Введите число.");
                        }

                        person.Age = int.TryParse(ageInput, out var age)
                            ? age
                            : throw new ArgumentException("Некорректный ввод. Введите целое число.");
                    }),
                new Action(() =>
                    {
                        Console.WriteLine("Укажите пол: М(M) - Male (мужской)," +
                                    "Ж(F) - Female (женский)");
                        string insertedGender = Console.ReadLine().ToUpper();

                        if (string.IsNullOrWhiteSpace(insertedGender))
                        {
                            throw new ArgumentException("Поле не может быть пустым. Введите M или F.");
                        }

                        switch (insertedGender)
                        {
                            case "M":
                            case "М":
                            {
                                person.Gender = Gender.Male;
                                break;
                            }
                            case "F":
                            case "Ж":
                            {
                                person.Gender = Gender.Female;
                                break;
                            }
                            default:
                            {
                                throw new ArgumentException("Неправильно указан пол.\n");
                            }
                        }
                    })
            };

            foreach (var action in validationActions)
            {
                ActionHander(action);
            }

            return person;
        }

        /// <summary>
        /// Метод обработки возможных исключений.
        /// </summary>
        /// <param name="action"> Действие </param>
        private static void ActionHander(Action action)
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
                    Console.WriteLine($"Ошибка: {exception.Message}");
                }
            }
        }
    }
}
