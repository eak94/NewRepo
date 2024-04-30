using LibraryPerson;
using System.Collections.Generic;

namespace Lb1
{
    /// <summary>
    /// класс Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод для ввода в консоль персоны
        /// </summary>
        public static void PersonConsole(PersonList personList)
        {
            Person personConsole = new Person();

            Console.WriteLine("Введите Ваше Имя");
            personConsole.Name = Console.ReadLine();
            Console.WriteLine("Введите Вашу Фамилию");
            personConsole.SecondName = Console.ReadLine();
            Console.WriteLine("Введите Ваш Возраст");
            personConsole.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите Ваш Пол: М - Male (Мужской), " +
                "Ж(F) - Female (Женский)");
            string insertedGender = Console.ReadLine().ToUpper();
            switch (insertedGender)
            {
                case "M":
                case "М":
                case "m":
                case "м":
                    {
                        break;
                    }
                case "F":
                case "Ж":
                case "f":
                case "ж":
                    {
                        personConsole.Gender = Gender.Female;
                        break;
                    }
                default:
                    throw new ArgumentException("Некорректный ввод." +
                        "Введите М или Ж(F)");
            }

            personList.AddPerson(personConsole);
        }


        /// <summary>
        /// Метод для отображения персона на консоли 
        /// </summary>
        /// <param name="person">объект класса Person</param>
        public static void ShowPersonToConsole(Person person)
        {
            Console.Write(person.GetPersonInfo());
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
                Console.WriteLine("\t\t\tМЕНЮ\n" +
                    "1  -  Создать программно два списка " +
                    "персон в каждом из которых по три человека" +
                    "и вывести содержимое на экран\n" +
                    "2  -  Добавить нового человека в первый список\n" +
                    "3  -  Копировать второго человека из первого" +
                    "списка в конец второго списка\n" +
                    "4  -  Удалить второго человека из первого списка\n" +
                    "5  -  Очистить список полностью\n" +
                    "6  -  Ввести персону вручную\n" +
                    "7  -  Метод RandomPerson\n");

                number = Console.ReadLine();

                switch (number)
                {
                    case "1":
                        {
                            //TODO: RSDN+
                            Console.WriteLine("Для тестирования методов" +
                                " программно создано два списка людей.\nВ каждом " +
                                "из списков содержатся записи о трех людях.\nДля отображения" +
                                " нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\n3ab. Вывод содержимого списков:");

                            for (int i = 0; i < 3; i++)
                            {
                                firstlist.AddPerson(RandomPerson.GetRandomPerson());
                                secondlist.AddPerson(RandomPerson.GetRandomPerson());
                            }

                            Console.WriteLine("\nСписок 1\n" +
                              $"\n{firstlist.GetPersonsList()}");

                            Console.WriteLine("\nСписок 2\n" +
                              $"\n{secondlist.GetPersonsList()}");

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 1");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списка 1:");
                            Console.WriteLine("\nСписок 1\n" +
                              $"\n{firstlist.GetPersonsList()}");
                            Console.WriteLine("\nДля просмотра добавления новой" +
                                " персоны нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nДобавление новой персоны в список 1\n");
                            firstlist.AddPerson(new Person("Человек", "Новый", 40, Gender.Male));
                            Console.WriteLine("\nСписок 1\n" +
                              $"\n{firstlist.GetPersonsList()}");
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 2");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списка 2:\n");
                            Console.WriteLine("\nСписок 1\n" +
                               $"\n{firstlist.GetPersonsList()}");
                            Console.WriteLine("Для просмотра копирования второго " +
                                "человека первого списка в конец второго списка нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nКопирование второго человека " +
                                "из первого списка в конец второго списка\n");
                            int index = 1;
                            secondlist.AddPerson(firstlist.IndexPerson(index));
                            Console.WriteLine("\nСписок 2\n" +
                              $"\n{secondlist.GetPersonsList()}");
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 3");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списка 1:\n");
                            Console.WriteLine("\nСписок 1\n" +
                               $"\n{firstlist.GetPersonsList()}");
                            Console.WriteLine("Для просмотра удаления второго" +
                                " человека из первого списка нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nУдаление второго человека из первого списка\n");
                            int indexToDelete = 1;
                            firstlist.DeleteIndexPerson(indexToDelete);
                            Console.WriteLine("\nСписок 1\n" +
                               $"\n{firstlist.GetPersonsList()}");
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 4");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("\n3ab. Вывод содержимого списка 2:\n");
                            Console.WriteLine("\nСписок 2\n" +
                               $"\n{secondlist.GetPersonsList()}");
                            Console.WriteLine("Для просмотра очистки второго " +
                                " списка нажмите Enter");
                            _ = Console.ReadKey();
                            Console.WriteLine("\nОчистка второго списка\n");
                            secondlist.DeleteArrayPerson();
                            Console.WriteLine("\nСодержимое второго списка");
                            Console.WriteLine("\n<Содержимое успешно удалено>");
                            Console.WriteLine("\nСписок 2\n" +
                               $"\n{secondlist.GetPersonsList()}");
                            Console.WriteLine("\nНажмите Enter для выхода из пункта 5");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("\nДля тестирования метода ввода" +
                                " персоны с клавиатуры нажмите Enter");
                            _ = Console.ReadKey();

                            Console.WriteLine("Введите количество персон для" +
                                " формирования списка:");
                            int count = int.Parse(Console.ReadLine());

                            PersonList personList = new PersonList();

                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine($"\nСоздаем персону {i + 1}");
                                PersonConsole(personList);
                            }

                            Console.WriteLine("\nСформированный список\n" +
                                $"\n{personList.GetPersonsList()}");

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 6");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("\nДля тестирования метода " +
                                "RandomPerson нажмите Enter");
                            _ = Console.ReadKey();

                            Console.WriteLine("Введите количество персон для создания:");
                            int count = int.Parse(Console.ReadLine());

                            for (int i = 0; i < count; i++)
                            {
                                Person randomPerson = RandomPerson.GetRandomPerson();
                                firstlist.AddPerson(randomPerson);
                            }
                            Console.WriteLine("\nСформированный список\n" +
                               $"\n{firstlist.GetPersonsList()}");

                            Console.WriteLine("\nНажмите Enter для выхода из пункта 7");
                            _ = Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                    default:
                        Console.WriteLine("Некорректный выбор. Пожалуйста, " +
                            "выберите пункт из меню.");
                        break;
                }
            }
        }
    }
}
