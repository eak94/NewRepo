
namespace LibraryPerson
{
    /// <summary>
    ///  Класс рандомного создания персон
    /// </summary>
    public class RandomPerson
    {
        /// <summary>
        /// Метод для генерации случайных персон
        /// </summary>
        /// <returns>Возвращает персону, которая сгенерирована случайным образом</returns>
        public static Person GetRandomPerson()
        {
            Person randomPerson = new Person();

            string[] nameFemale = new string[]
            {
                "Валерия", "Алена", "Анна",
                "Екатерина", "Алина", "Кира",
                "Валентина"
            };
            string[] nameMale = new string[]
            {
                "Антон", "Виктор", "Андрей",
                "Михаил","Борис", "Роман",
                "Петр"
            };
            string[] secondnameMale = new string[] {"Стенов", "Любимов", "Стулов",
                "Попов","Андреев", "Иванов", "Пушкин"};
            string[] secondnameFemale = new string[] {"Любимова", "Ващенко", "Подкорытова",
                "Мешанкина", "Сечина", "Ручкина", "Доскова"};

            Random random = new Random();
            randomPerson.Gender = (Gender)random.Next(2);

            switch (randomPerson.Gender)
            {
                case Gender.Female:
                    var randomPersonNameFemale = random.Next(0, nameFemale.Length);
                    var randomPersonSecondnameFemale = random.Next(0, secondnameFemale.Length);
                    randomPerson.Name = nameFemale[randomPersonNameFemale];
                    randomPerson.SecondName = secondnameFemale[randomPersonSecondnameFemale];
                    break;

                case Gender.Male:
                    var randomPersonNameMale = random.Next(0, nameMale.Length);
                    var randomPersonSecondnameMale = random.Next(0, secondnameMale.Length);
                    randomPerson.Name = nameMale[randomPersonNameMale];
                    randomPerson.SecondName = secondnameMale[randomPersonSecondnameMale];
                    break;

                default:
                    break;
            }

            randomPerson.Age = random.Next(Person.MinAge, Person.MaxAge);

            return randomPerson;
        }
    }
}
