namespace LibraryPerson
{

    /// <summary>
    ///  Класс рандомного создания персон
    /// </summary>
    public class RandomPerson
    {
        /// <summary>
        /// Метод для генерации случайной персоны заданного пола 
        /// </summary>
        /// <param name="person">Случайна персона</param>
        public static void SetRandomPerson(PersonBase person)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<string> nameMale = new List<string>()
            {
                "Антон", "Виктор", "Андрей",
                "Михаил", "Борис", "Роман"
            };

            List<string> nameFemale = new List<string>()
            {
                "Валерия", "Алена", "Анна",
                "Екатерина", "Алина", "Кира"
            };

            List<string> secondNames = new List<string>()
            {
                "Короленко", "Ващенко", "Дурново",
                "Челибидахе", "Попова", "Черных"
            };

            person.Age = random.Next(person.MinAge, person.MaxAge);
            person.Gender = (Gender)random.Next(0, 2);

            switch (person.Gender)
            {
                case Gender.Male:
                    person.Name = nameMale[random.Next(0, nameMale.Count)];
                    break;

                case Gender.Female:
                    person.Name = nameFemale[random.Next(0, nameFemale.Count)];
                    break;
                default:
                    break;
            }

            person.SecondName = secondNames[random.Next(0, secondNames.Count)];
        }

        /// <summary>
        /// Метод для генерации случайной персоны заданного пола 
        /// </summary>
        /// <param name="person">Случайна персона</param>
        /// <param name="gender">Пол</param>
        public static void SetRandomPerson(PersonBase person, Gender gender)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<string> nameMale = new List<string>()
            {
                "Антон", "Виктор", "Андрей",
                "Михаил", "Борис", "Роман"
            };

            List<string> nameFemale = new List<string>()
            {
                "Валерия", "Алена", "Анна",
                "Екатерина", "Алина", "Кира"
            };

            List<string> secondNames = new List<string>()
            {
                "Короленко", "Ващенко", "Дурново",
                "Челибидахе", "Попова", "Черных"
            };

            person.Age = random.Next(person.MinAge, person.MaxAge);

            if (gender == Gender.Male)
            {
                person.Gender = Gender.Male;
            }

            else
            {
                person.Gender = Gender.Female;
            }

            switch (person.Gender)
            {
                case Gender.Male:
                    person.Name = nameMale[random.Next(0, nameMale.Count)];
                    break;

                case Gender.Female:
                    person.Name = nameFemale[random.Next(0, nameFemale.Count)];
                    break;
                default:
                    break;
            }

            person.SecondName = secondNames[random.Next(0, secondNames.Count)];
        }

        /// <summary>
        /// Метод для генерации параметров случайного взрослого 
        /// </summary>
        /// <param name="adult">взрослый, для которого
        /// устанавливаются параметры</param>
        public static void SetRandomAdult(Adult adult)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<string> jobs = new List<string>()
            {
                "Пятерочка", "Магнит", "S7", "СО ЕЭС", "Aston",
                "Сбертех", "Сбербанк", "Альфабанк", "Минеральные воды"
            };

            adult.Age = random.Next(adult.MinAge, adult.MaxAge);

            if (random.Next(0, 2) == 0)
            {
                adult.Job = jobs[random.Next(0, jobs.Count)];
            }
            adult.PassportSeries = random.Next(1111, 9999);
            adult.PassportNumber = random.Next(111111, 999999);
        }

        /// <summary>
        /// Метод для генерации случайной персоны
        /// </summary>
        /// <returns>Возвращает случайного взрослого</returns>
        public static PersonBase GetRandomPerson()
        {
            Random random = new Random();
            PersonBase person = new Adult();
            SetRandomPerson(person);
            return person;
        }

        /// <summary>
        /// Метод для генерации случайного
        /// взрослого со случайными параметрами
        /// </summary>
        /// <returns>Возвращает случайного взрослого</returns>
        public static Adult GetRandomAdult()
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
        public static Adult GetRandomAdult(Gender gender)
        {
            Adult adult = new Adult();
            SetRandomPerson(adult, gender);
            SetRandomAdult(adult);
            return adult;
        }

        /// <summary>
        /// Метод для создания случайного человка
        /// </summary>
        /// <param name="adult">Взрослый,для которого устанавливается партнер</param>
        public static void SetRandomPartner(Adult adult)
        {
            Adult partner = new Adult();
            Random random = new Random(Guid.NewGuid().GetHashCode());

            if (random.Next(0, 2) == 0)
            {
                switch (adult.Gender)
                {
                    case Gender.Male:
                        partner = GetRandomAdult(Gender.Female);
                        break;

                    case Gender.Female:
                        partner = GetRandomAdult(Gender.Male);
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
            Random random = new Random(Guid.NewGuid().GetHashCode());

            List<string> educations = new List<string>()
            {
                "МБОУ СОШ №1", "Гимназия №2",
                "Детский сад Солнышко", "Изобразительный колледж"
            };

            child.Education = educations[random.Next(0, educations.Count)];

            if (random.Next(0, 2) == 0)
            {
                Adult father = GetRandomAdult(Gender.Male);
                child.Father = father;
            }

            if (random.Next(0, 2) == 0)
            {
                Adult mother = GetRandomAdult(Gender.Female);
                child.Mother = mother;
            }
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
