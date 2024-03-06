using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// Основная программа
        /// </summary>
        private static void Main()
        {
            Console.WriteLine
                ("Для тестирования методов автоматически создано два списка людей.\n " +
                "В каждом из списков содержатся записи о трех людях.\n " +
                "Для продолжения нажмите Enter для отображения\n");
            _ = Console.ReadKey();
            Person[] firstPeopleArray = FirstPersonDenerator();
            PrintPeopleArray(firstPeopleArray);
            _ = Console.ReadKey();
            Person[] secondPeopleArray = SecondPersonDenerator();
            PrintPeopleArray(secondPeopleArray);
        }

        /// <summary>
        /// Метод по создания 1 списка персон для тестов
        /// </summary>
        public static Person[] FirstPersonDenerator()
        {
            Person[] peopleArray1 = new Person[3];

            peopleArray1[0] = new Person("Николай", "Иванов", 15, Gender.Male);
            peopleArray1[1] = new Person("Валерия", "Ващенко", 35, Gender.Female);
            peopleArray1[2] = new Person("Имератор", "Невероятный", 154, Gender.Undefined);

            return peopleArray1;
        }

        /// <summary>
        /// Метод по создания 2 списка персон для тестов
        /// </summary>
        public static Person[] SecondPersonDenerator()
        {
            Person[] peopleArray2 = new Person[3];

            peopleArray2[0] = new Person("Анастасия", "Подкорытова", 14, Gender.Female);
            peopleArray2[1] = new Person("Иван", "Иванов", 25, Gender.Male);
            peopleArray2[2] = new Person("Екатерина", "Горбачева", 53, Gender.Female);

            return peopleArray2;
        }

        /// <summary>
        /// Метод для отображения содержимого массивов
        /// </summary>
        /// <param name="peopleArray">Массив</param>
        public static void PrintPeopleArray(Person[] peopleArray)
        {
            foreach (var person in peopleArray)
            {
                Console.WriteLine($"Имя: {person.Name}, Фамилия: {person.SecondName}, Возраст: {person.Age}, Пол: {person.Gender}");
            }
        }
    }
}
