
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
        public static PersonBase GetRandomPerson()
        {
            PersonBase randomPerson = new Random();

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

            randomPerson.Age = random.Next(PersonBase.MinAge, PersonBase.MaxAge);

            return randomPerson;
        }


        /// <summary>
        /// Возвращает случайного взрослого с случайными параметрами.
        /// </summary>
        /// <param name="adult">Взрослый, для которого устанавливаются параметры.</param>
        public static void SetRandomAdult(Adult adult)
        {
            Random random = new Random();

            List<string> job = new List<string>()
            {
                "ABC", "Пятерочка", "Красное-Белое", "Чиним двери", "ИА СО ЕЭС ОСВР",
                "РОССЕТИ", "Скат", "S7", "Aston"
            };

            adult.Age = random.Next(adult.MinAge, adult.MaxAge);
            if (random.Next(0, 2) == 0)
            {
                adult.Job = job[random.Next(0, job.Count)];
            }
            adult.PassportSeries = random.Next(1111, 9999);
            adult.PassportNumber = random.Next(111111, 999999);
        }
    }
}
