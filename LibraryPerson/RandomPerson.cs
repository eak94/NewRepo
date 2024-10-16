using System;
using System.Reflection;

namespace LibraryPerson
{

    /// <summary>
    ///  Класс рандомного создания персон
    /// </summary>
    public class RandomPerson
    {
        /// <summary>
        /// объект класса Random
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Метод для генерации случайной персоны заданного пола 
        /// </summary>
        /// <param name="person">Случайна персона</param>
        public static void SetRandomPerson(PersonBase person)
        {
            List<string> nameMale = new List<string>()
            {
                "Антон", "Виктор", "Андрей",
                "Михаил", "Борис", "Роман", "Петр"
            };

            List<string> secondnameMale = new List<string>()
            {
                "Стенов", "Любимов", "Стулов", "Досков",
                "Попов", "Андреев", "Ручкин", "Пушкин", "Подкорытов"
            };

            List<string> nameFemale = new List<string>()
            {
                "Валерия", "Алена", "Анна",
                "Екатерина", "Алина", "Кира", "Валентина"
            };

            List<string> secondnameFemale = new List<string>()
            {
                "Любимова", "Ващенко", "Подкорытова",
                "Стулова", "Попова", "Сечина", "Ручкина", "Доскова"
            };

            person.Gender = _random.Next(2) == 0 ? Gender.Male : Gender.Female;

            switch (person.Gender)
            {
                case Gender.Male:
                    person.Name = nameMale[_random.Next(nameMale.Count)];
                    person.SecondName = secondnameMale[_random.Next(secondnameMale.Count)];
                    break;

                case Gender.Female:
                    person.Name = nameFemale[_random.Next(nameFemale.Count)];
                    person.SecondName = secondnameFemale[_random.Next(secondnameFemale.Count)];
                    break;
                default:
                    break;
            }

            person.Age = _random.Next(person.MinAge, person.MaxAge);
        }

        /// <summary>
        /// Метод для генерации случайной персоны заданного пола 
        /// </summary>
        /// <param name="person">Случайна персона</param>
        /// <param name="gender">Пол</param>
        public static void SetRandomPersonGender(PersonBase person, Gender gender)
        {
            List<string> nameMale = new List<string>()
            {
                "Антон", "Виктор", "Андрей",
                "Михаил", "Борис", "Роман", "Петр"
            };

            List<string> secondnameMale = new List<string>()
            {
                "Стенов", "Любимов", "Стулов", "Досков",
                "Попов", "Андреев", "Ручкин", "Пушкин", "Подкорытов"
            };

            List<string> nameFemale = new List<string>()
            {
                "Валерия", "Алена", "Анна",
                "Екатерина", "Алина", "Кира", "Валентина"
            };

            List<string> secondnameFemale = new List<string>()
            {
                "Любимова", "Ващенко", "Подкорытова",
                "Стулова", "Попова", "Сечина", "Ручкина", "Доскова"
            };

            person.Gender = gender;

            if (gender == Gender.Male)
            {
                person.Name = nameMale[_random.Next(nameMale.Count)];
                person.SecondName = secondnameMale[_random.Next(secondnameMale.Count)];
            }
            else
            {
                person.Name = nameFemale[_random.Next(nameFemale.Count)];
                person.SecondName = secondnameFemale[_random.Next(secondnameFemale.Count)];
            }

            person.Age = _random.Next(person.MinAge, person.MaxAge);
        }

        /// <summary>
        /// Метод для генерации параметров случайного взрослого 
        /// </summary>
        /// <param name="adult">взрослый, для которого устанавливаются параметры</param>
        public static void SetRandomAdult(Adult adult)
        {
            Random randomAdult = new Random();

            List<string> jobs = new List<string>()
            {
                "Пятерочка", "Магнит", "S7", "СО ЕЭС", "Aston",
                "Сбертех", "Сбербанк", "Альфабанк", "Минеральные воды"
            };

            adult.Age = randomAdult.Next(adult.MinAge, adult.MaxAge);
            adult.Job = jobs[randomAdult.Next(0, jobs.Count)];
            adult.PassportNumber = randomAdult.Next(111111, 999999);
            adult.PassportSeries = randomAdult.Next(1111, 9999);
        }

        /// <summary>
        /// Метод для генерации случайной персоны
        /// </summary>
        /// <returns>Возвращает случайного взрослого</returns>
        public static PersonBase GetRandomPerson()
        {
            PersonBase person = new Adult();
            SetRandomPerson(person);
            return person;
        }

        /// <summary>
        /// Метод для генерации случайного взрослого со случайными параметрами
        /// </summary>
        /// <returns>Возвращает случайного взрослого</returns>
        public static PersonBase GetRandomAdult()
        {
            Adult adult = new Adult();
            SetRandomPerson(adult);
            SetRandomAdult(adult);
            SetRandomPartner(adult);
            return adult;
        }

        /// <summary>
        /// Метод для создания случайного взрослого заданного пола 
        /// </summary>
        /// <returns>Возвращает случайного взрослого заданного пола</returns>
        public static Adult GetRandomAdultGenger(Gender gender)
        {
            Adult adult = new Adult();
            SetRandomPersonGender(adult, gender);
            SetRandomAdult(adult);
            return adult;
        }

        /// <summary>
        /// Метод для генерации партнера 
        /// </summary>
        /// <param name="adult">Возвращает взрослого для которого
        /// устанавливается партнер по фамилии</param>
        public static void SetRandomPartner(Adult adult)
        {
            Adult partner = new Adult();

            if (_random.Next(0, 2) == 0)
            {
                switch (adult.Gender)
                {
                    case Gender.Male:
                        partner = GetRandomAdultGenger(Gender.Female);
                        break;

                    case Gender.Female:
                        partner = GetRandomAdultGenger(Gender.Male);
                        break;
                    default:
                        break;
                }
                adult.Parther = partner;
            }
        }

        /// <summary>
        /// Метод для генерации ребенка со случайными параметрами
        /// </summary>
        /// <param name="child">ребенок, для которого задаются параметры</param>
        public static void SetRandomChild(Child child)
        {
            Random randomChild = new Random();
            List<string> educations = new List<string>()
            {
                "МБОУ СОШ №1", "Гимназия №2", "Детский сад Солнышко", "Изобразительный колледж"
            };

            child.Education = educations[randomChild.Next(0, educations.Count)];

            child.Father = new Adult();
            SetRandomPersonGender(child.Father, Gender.Male);

            child.Mother = new Adult();
            SetRandomPersonGender(child.Mother, Gender.Female);
        }

        /// <summary>
        /// Метод для генерации ребенка со случайными параметрами 
        /// </summary>
        /// <returns>Возвращает ребенка со случайными параметрами</returns>
        public static Child GetRandomChild()
        {
            Child child = new Child();
            SetRandomPerson(child);
            SetRandomChild(child);
            return child;
        }
    }
}
