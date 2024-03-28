
namespace ClassLibrary1
{
    public class RandomPerson
    {

        /// <summary>
        /// Метод для генерации случайных персон
        /// </summary>
        /// <returns>Возвращает персону, которая сгенерирована случайным образом</returns>
        public static Person GetRandomPerson()
        {
            Person randomPerson = new Person();
            var nameFemale = new string[] {"Катя", "Алена", "Анна", "Екатерина",
        "Алина", "Кира", "Валентина"};
            var nameMale = new string[] {"Антон", "Виктор", "Андрей", "Михаил",
        "Борис", "Роман", "Петр"};
            var secondnameMale = new string[] {"Стенов", "Любимов", "Стулов", "Попов",
        "Андреев", "Иванов", "Пушкин"};
            var secondnameFemale = new string[] {"Любимова", "Ващенко", "Подкорытова", "Мешанкина",
        "Сечина", "Ручкина", "Спицина"};

            Random rnd = new Random();
            int minAge = 0;
            int maxAge = 100;
            randomPerson.Gender = (Gender)rnd.Next(2);

            switch (randomPerson.Gender)
            {
                case Gender.Female:
                    var rndPersonNameFemale = rnd.Next(0, nameFemale.Length);
                    var rndPersonSecondnameFemale = rnd.Next(0, secondnameFemale.Length);
                    randomPerson.Name = nameFemale[rndPersonNameFemale];
                    randomPerson.SecondName = secondnameFemale[rndPersonSecondnameFemale];
                    break;
                case Gender.Male:
                    var rndPersonNameMale = rnd.Next(0, nameMale.Length);
                    var rndPersonSecondnameMale = rnd.Next(0, secondnameMale.Length);
                    randomPerson.Name = nameMale[rndPersonNameMale];
                    randomPerson.SecondName = secondnameMale[rndPersonSecondnameMale];
                    break;
                default:
                    break;
            }

            randomPerson.Age = rnd.Next(minAge, maxAge);

            return randomPerson;
        }
    }
}
