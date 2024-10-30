using LibraryPerson;
using System;

namespace LB1
{
    /// <summary>
    /// Основная программа
    /// </summary>
    internal class Program
    {
        //TODO: исправить логику с добавлением в список 
        /// <summary>
        /// Основная программа
        /// </summary>
        public static void Main()
        {

            Console.WriteLine("Создаем список из 7 рандомных людей");
            _ = Console.ReadKey();

            PersonList personlist = new PersonList();
            Random random = new Random();

            int numAdults = random.Next(3, 7);
            int numChildren = random.Next(3, 7);

            for (int i = 0; i < numAdults; i++)
            {
                personlist.AddPerson(RandomPerson.GetRandomAdult());
            }

            for (int i = 0; i < numChildren; i++)
            {
                personlist.AddPerson(RandomPerson.GetRandomChild());
            }

            Console.WriteLine(personlist.GetPersonsList());
        }
    }
}
