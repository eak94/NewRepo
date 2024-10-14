
namespace LibraryPerson
{
    /// <summary>
    ///  Класс рандомного создания персон
    /// </summary>
    public class RandomPerson
    {
        /// <summary>
        /// Метод для генерации случайных взрослых
        /// </summary>
        /// <returns>Возвращает персону, которая сгенерирована случайным образом</returns>
        public static void GetRandomPerson(PersonBase person)
        {
            PersonBase randomPerson = new Random();

            List<string> nameFemale = new List<string>()
            {
                "Валерия", "Алена", "Анна",
                "Екатерина", "Алина", "Кира",
                "Валентина"
            };

            List<string> nameMale = new List<string>()
            {
                "Антон", "Виктор", "Андрей",
                "Михаил","Борис", "Роман",
                "Петр"
            };

            List<string> secondnameMale = new List<string>()
            {
                "Стенов", "Любимов", "Стулов",
                "Попов","Андреев", "Иванов", "Пушкин"
            };

            List<string> secondnameFemale = new List<string>()
            {
                "Любимова", "Ващенко", "Подкорытова",
                "Мешанкина", "Сечина", "Ручкина", "Доскова"
            };

            Random random = new Random();
            randomPerson.Gender = (Gender)random.Next(2);

            switch (randomPerson.Gender)
            {
                case Gender.Female:
                    var randomPersonNameFemale = random.Next(0, nameFemale.Count);
                    var randomPersonSecondnameFemale = random.Next(0, secondnameFemale.Count);
                    randomPerson.Name = nameFemale[randomPersonNameFemale];
                    randomPerson.SecondName = secondnameFemale[randomPersonSecondnameFemale];
                    break;

                case Gender.Male:
                    var randomPersonNameMale = random.Next(0, nameMale.Count);
                    var randomPersonSecondnameMale = random.Next(0, secondnameMale.Count);
                    randomPerson.Name = nameMale[randomPersonNameMale];
                    randomPerson.SecondName = secondnameMale[randomPersonSecondnameMale];
                    break;

                default:
                    break;
            }
            randomPerson.Age = random.Next(person.MinAge, person.MaxAge);
        }


        /// <summary>
        /// Возвращает случайного взрослого с случайными параметрами.
        /// </summary>
        /// <param name="adult">Взрослый, для которого устанавливаются параметры.</param>
        public static void SetRandomAdult(Adult adult)
        {
            Random random = new Random();
            string[] jobs = new string[];

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
