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
            PersonListDenerator(list1);
        }
        /// <summary>
        /// Метод по создания 2 списков персон для тестов
        /// </summary>
        /// <param name="list1">1 список</param>
        public void PersonListDenerator(PersonList list1)
        {
            Console.WriteLine("Создано 2 списка персон");

            Person first = new Person("Николай", "Иванов", 15, Gender.Male);
            Person second = new Person("Валерия", "Ващенко", 35, Gender.Female);
            Person third = new Person("Имератор", "Невероятный", 154, Gender.Undefined);
            //_ = new Person("Анастасия", "Подкорытова", 14, Gender.Female);
            //_ = new Person("Иван", "Иванов", 25, Gender.Male);
            //_ = new Person("Екатерина", "Горбачева", 53, Gender.Female);

            PersonList list1 = new PersonList();
            list1.AddPerson(first);
            list1.AddPerson(second);
            list1.AddPerson(third);
        }
    }
}
