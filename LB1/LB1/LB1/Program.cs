using LibraryPerson;
namespace LB1
{
    /// <summary>
    /// Основная программа
    /// </summary>
    internal class Program
    {


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

                            int count;

                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Введите количество персон для добавления в список:");
                                    string inputCount = Console.ReadLine();

                                    if (string.IsNullOrWhiteSpace(inputCount))
                                    {
                                        throw new ArgumentException("Поле с количеством персон не может быть пустым. Введите число.");
                                    }

                                    count = int.Parse(inputCount);
                                    break;
                                }
                                catch (ArgumentException exception)
                                {
                                    Console.WriteLine(exception.Message);
                                }
                            }

                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine($"\nСоздаем персону {i + 1}");
                                Person newPerson = AddPersonConsole.PersonConsole();
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
