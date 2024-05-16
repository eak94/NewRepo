using LibraryPerson;
namespace LB1
{
    /// <summary>
    /// Основная программа
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// Метод для вывода информации об объектах
        /// </summary>
        /// <param name="person">Объект класса персон</param>
        public void PrintPeople(Person person)
        {
            Console.Write(person.GetInfo());
        }

        /// <summary>
        /// Метод для ввода информации о персоне через консоль
        /// </summary>
        /// <returns>Объект класса персон, предствляющий персону которая введена через консоль</returns>
        public static Person AddPersonConsole()
        {
            Person person = new Person();
            bool inputValid = false;
            bool nameValid = false;
            bool secondNameValid = false;
            bool ageValid = false;
            bool genderValid = false;

            do
            {
                try
                {
                    if (!nameValid)
                    {
                        Console.WriteLine("Введите Имя:");
                        string name = Console.ReadLine();
                        person.Name = name;
                        nameValid = true;
                    }

                    if (nameValid && !secondNameValid)
                    {
                        Console.WriteLine("Введите Фамилию:");
                        string secondName = Console.ReadLine();
                        person.SecondName = secondName;
                        secondNameValid = true;
                    }

                    if (nameValid && secondNameValid && !ageValid)
                    {
                        Console.WriteLine("Введите Возраст:");
                        int age = Convert.ToInt32(Console.ReadLine());
                        person.Age = age;
                        ageValid = true;
                    }

                    if (nameValid && secondNameValid && ageValid && !genderValid)
                    {
                        Console.WriteLine("Укажите пол: М(M) - Male (мужской)," +
                            "Ж(F) - Female (женский)");
                        string insertedGender = Console.ReadLine().ToUpper();
                        switch (insertedGender)
                        {
                            case "M":
                            case "m":
                            case "М":
                            case "м":
                                {
                                    break;
                                }
                            case "F":
                            case "f":
                            case "Ж":
                            case "ж":
                                {
                                    person.Gender = Gender.Female;
                                    genderValid = true;
                                    break;
                                }
                            default:
                                {
                                    throw new ArgumentException("Неправильно указан пол.\n");
                                }
                        }
                    }

                    if (nameValid && secondNameValid && ageValid && genderValid)
                    {
                        inputValid = true;
                    }
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine("Ошибка: " + exception.Message);

                    if (nameValid && secondNameValid && ageValid)
                    {
                        genderValid = false;
                    }
                    else if (nameValid && secondNameValid)
                    {
                        ageValid = false;
                    }
                    else if (nameValid)
                    {
                        secondNameValid = false;
                    }
                    else
                    {
                        nameValid = false;
                    }
                }
            } while (!inputValid);

            return person;
        }

        /// <summary>
        /// Основная программа
        /// </summary>
        public static void Main()
        {
            PersonList firstlist = new PersonList();
            PersonList secondlist = new PersonList();

            string number;

            while (true)
            {
                //TODO: RSDN+
                Console.WriteLine("МЕНЮ\n" +
                    "1  -  Создание программно двух списков персон в каждом " +
                    "из которых по три человека+вывести содержимое на экран\n" +
                    "2  -  Добавить нового челока в первый список\n" +
                    "3  -  Копирование второго человека из первого списка " +
                    "в конец второго списка\n" +
                    "4  -  Удаление второго человека из первого списка\n" +
                    "5  -  Очистить список полностью\n" +
                    "6  -  Ввести персону вручную\n" +
                    "7  -  RandomPerson\n");

                number = Console.ReadLine();

                switch (number)
                {
                    case "1":
                        {
                            Console.WriteLine("Для тестирования методов программно " +
                                "создано два списка людей.\n" + "В каждом из списков содержатся" +
                                " записи о трех людях.\n\nДля отображения нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nВывод содержимого списков:");

                            for (int i = 0; i < 3; i++)
                            {
                                firstlist.AddPerson(RandomPerson.GetRandomPerson());
                                secondlist.AddPerson(RandomPerson.GetRandomPerson());
                            }

                            Console.WriteLine($"\nСписок 1\n{firstlist.GetPersonsList()}");

                            Console.WriteLine($"Список 2\n{secondlist.GetPersonsList()}");

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 1");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine("\nДобавить нового челока в первый список:");
                            for (int i = 0; i < 3; i++)
                            {
                                firstlist.AddPerson(RandomPerson.GetRandomPerson());
                            }
                            Console.WriteLine($"\nСписок 1\n{firstlist.GetPersonsList()}");

                            Console.WriteLine("Для просмотра добавления новой персоны нажмите Enter");
                            _ = Console.ReadKey();

                            firstlist.AddPerson(new Person("Новый", "Человек", 40, Gender.Male));

                            Console.WriteLine($"\nСписок 1\n{firstlist.GetPersonsList()}");

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 2");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("\nКопирование второго человека из" +
                                " первого списка в конец второго списка:\n");
                            for (int i = 0; i < 3; i++)
                            {
                                firstlist.AddPerson(RandomPerson.GetRandomPerson());
                                secondlist.AddPerson(RandomPerson.GetRandomPerson());
                            }

                            Console.WriteLine("Для просмотра копирования второго человека" +
                                " первого списка в конец второго списка нажмите Enter\n");

                            Console.WriteLine($"Список 1\n{firstlist.GetPersonsList()}");
                            _ = Console.ReadKey();

                            int index = 1;

                            secondlist.AddPerson(firstlist.IndexPerson(index));
                            Console.WriteLine($"Список 2\n{secondlist.GetPersonsList()}");

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 3");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("\nУдаление второго человека из первого списка:\n");
                            for (int i = 0; i < 3; i++)
                            {
                                firstlist.AddPerson(RandomPerson.GetRandomPerson());
                                secondlist.AddPerson(RandomPerson.GetRandomPerson());
                            }
                            Console.WriteLine($"\nСписок 1\n{firstlist.GetPersonsList()}");

                            Console.WriteLine("Для просмотра удаления второго " +
                                "человека из первого списка нажмите Enter");
                            _ = Console.ReadKey();

                            Console.WriteLine("\nУдаление второго человека из первого списка");
                            int indexToDelete = 1;
                            firstlist.DeleteIndexPerson(indexToDelete);
                            Console.WriteLine($"\nСписок 1\n{firstlist.GetPersonsList()}");

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 4");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("\nОчистить список полностью\n");
                            for (int i = 0; i < 3; i++)
                            {
                                firstlist.AddPerson(RandomPerson.GetRandomPerson());
                                secondlist.AddPerson(RandomPerson.GetRandomPerson());
                            }
                            Console.WriteLine("Для просмотра содержимого списков 1 и 2 нажмите Enter");
                            Console.WriteLine($"\nСписок 1\n{firstlist.GetPersonsList()}");
                            Console.WriteLine($"\nСписок 2\n{secondlist.GetPersonsList()}");

                            Console.WriteLine("Для просмотра очистки второго списка нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nОчистка второго списка\n");
                            secondlist.DeleteArrayPerson();

                            Console.WriteLine("\nСодержимое списка 2");
                            Console.WriteLine("\n<Содержимое успешно удалено>");
                            Console.WriteLine($"\nСписок 2\n{secondlist.GetPersonsList()}");

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 5");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("\nДля тестирования метода ввода персоны" +
                                " с клавиатуры нажмите Enter");
                            _ = Console.ReadKey();

                            Console.WriteLine("Введите количество персон для добавления в список:");
                            int count = int.Parse(Console.ReadLine());

                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine($"\nСоздаем персону {i + 1}");
                                Person newPerson = AddPersonConsole();
                                firstlist.AddPerson(newPerson);
                            }

                            Console.WriteLine($"\nНовый список\n{firstlist.GetPersonsList()}");

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 6");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("\nДля тестирования метода RandomPerson нажмите Enter");
                            _ = Console.ReadKey();

                            Console.WriteLine("Введите количество персон для создания:");
                            int count = int.Parse(Console.ReadLine());

                            for (int i = 0; i < count; i++)
                            {
                                Person randomPerson = RandomPerson.GetRandomPerson();
                                firstlist.AddPerson(randomPerson);
                            }
                            Console.WriteLine($"\nСписок 1\n{firstlist.GetPersonsList()}");

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 7");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    default:
                        Console.WriteLine("Некорректный выбор. Пожалуйста, выберите пункт из меню.");
                        break;
                }
            }
        }

    }
}
