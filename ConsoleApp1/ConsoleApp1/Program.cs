using ClassLibrary1;

namespace ConsoleApp1
{
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
                //TODO: RSDN
                Console.WriteLine("МЕНЮ\n" +
                    "1  -  Создание программно двух списков персон в каждом из которых по три человека+вывести содержимое на экран\n" +
                    "2  -  Добавить нового челока в первый список\n" +
                    "3  -  Копирование второго человека из первого списка в конец второго списка\n" +
                    "4  -  Удаление второго человека из первого списка\n" +
                    "5  -  Очистить список полностью\n" +
                    "6  -  Ввести персону вручную\n" +
                    "7  -  RandomPerson\n");

                number = Console.ReadLine();

                switch (number)
                {
                    case "1":
                        {
                            //TODO: RSDN
                            Console.WriteLine("Для тестирования методов программно создано два списка людей.\n" +
                    "В каждом из списков содержатся записи о трех людях.\n" +
                    "Для отображения нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\n3ab. Вывод содержимого списков:");

                            for (int i = 0; i < 3; i++)
                            {
                                firstlist.AddPerson(RandomPerson.GetRandomPerson());
                                secondlist.AddPerson(RandomPerson.GetRandomPerson());
                            }

                            Console.WriteLine("\nСписок 1");
                            firstlist.PrintPeople();

                            Console.WriteLine("\nСписок 2");
                            secondlist.PrintPeople();

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 1");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списка 1:\n");
                            firstlist.PrintPeople();
                            Console.WriteLine("\nДля просмотра добавления новой персоны нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nДобавление новой персоны в список 1\n");
                            firstlist.AddPerson(new Person("Новый", "Человек", 40, Gender.Male));
                            firstlist.PrintPeople();
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 2");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списка 2:\n");
                            firstlist.PrintPeople();
                            Console.WriteLine("Для просмотра копирования второго человека первого списка в конец второго списка нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nКопирование второго человека из первого списка в конец второго списка\n");
                            int index = 1;
                            secondlist.AddPerson(firstlist.IndexPerson(index));
                            secondlist.PrintPeople();
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 3");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списка 1:\n");
                            firstlist.PrintPeople();
                            Console.WriteLine("Для просмотра удаления второго человека из первого списка нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nУдаление второго человека из первого списка\n");
                            int indexToDelete = 1;
                            secondlist.DeleteIndexPerson(indexToDelete);
                            secondlist.PrintPeople();
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 4");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списка 2:\n");
                            secondlist.PrintPeople();
                            Console.WriteLine("Для просмотра очистки второго списка нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nОчистка второго списка\n");
                            secondlist.DeleteArrayPerson();
                            Console.WriteLine("\nСодержимое второго списка");
                            Console.WriteLine("\nСодержимое успешно удалено");
                            secondlist.PrintPeople();
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 5");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("\nДля тестирования метода ввода персоны с клавиатуры нажмите Enter");
                            _ = Console.ReadKey();

                            Console.WriteLine("Введите количество персон для добавления в список 1:");
                            int count = int.Parse(Console.ReadLine());

                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine($"\nСоздаем персону {i + 1}");
                                _ = AddPersonConsole.PersonConsole(firstlist);
                            }

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
                            firstlist.PrintPeople();
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
