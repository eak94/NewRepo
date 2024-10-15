
using System.Threading;

namespace LibraryPerson
{
    /// <summary>
    ///  Класс рандомного создания персон
    /// </summary>
    public class RandomPerson
    {
        /// <summary>
        /// Метод для генерации случайного мужчины
        /// </summary>
        /// <returns>Возвращает мужчину, которая сгенерирована случайным образом</returns>
        public static void MaleRandomPerson(PersonBase person)
        {
            Random randomMalePerson = new Random();

            List<string> nameMale = new List<string>()
            {
                "Антон", "Виктор", "Андрей",
                "Михаил","Борис", "Роман","Петр"
            };

            List<string> secondnameMale = new List<string>()
            {
                "Стенов", "Любимов", "Стулов",
                "Попов","Андреев", "Иванов", "Пушкин", "Подкорытов"
            };

            person.Gender = (Gender)randomMalePerson.Next(2);

            var randomPersonNameMale = randomMalePerson.Next(0, nameMale.Count);
            var randomPersonSecondnameMale = randomMalePerson.Next(0, secondnameMale.Count);
            person.Name = nameMale[randomPersonNameMale];
            person.SecondName = secondnameMale[randomPersonSecondnameMale];

            person.Age = randomMalePerson.Next(person.MinAge, person.MaxAge);
        }
        /// <summary>
        /// Метод для генерации случайной женщины
        /// </summary>
        /// <returns>Возвращает женщину, которая сгенерирована случайным образом</returns>
        public static void FemaleRandomPerson(PersonBase person)
        {
            Random randomFemalePerson = new Random();

            List<string> nameFemale = new List<string>()
            {
                "Валерия", "Алена", "Анна",
                "Екатерина", "Алина", "Кира","Валентина"
            };

            List<string> secondnameFemale = new List<string>()
            {
                "Любимова", "Ващенко", "Подкорытова",
                "Мешанкина", "Сечина", "Ручкина", "Доскова"
            };

            person.Gender = (Gender)randomFemalePerson.Next(2);

            var randomPersonNameFemale = randomFemalePerson.Next(0, nameFemale.Count);
            var randomPersonSecondnameFemale = randomFemalePerson.Next(0, secondnameFemale.Count);
            person.Name = nameFemale[randomPersonNameFemale];
            person.SecondName = secondnameFemale[randomPersonSecondnameFemale];

            person.Age = randomFemalePerson.Next(person.MinAge, person.MaxAge);
        }

        /// <summary>
        /// Метод для генерации супружеской пары 
        /// </summary>
        /// <param name="secondName"></param>
        /// <returns></returns>
        public static (PersonBase husband, PersonBase wife) GetRandoMarriedCouple (string secondName)
        {
            var husband = MaleRandomPerson();
            husband.SecondName = secondName;

            var husband = FemaleRandomPerson();
            husband.SecondName = secondName;
            return (husband, wife);
        }
    }
}
