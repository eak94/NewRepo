namespace LibraryPerson
{
    /// <summary>
    /// Дочерний класс Child
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Поле матери
        /// </summary>
        private Adult _mother;

        /// <summary>
        /// Поле отца
        /// </summary>
        private Adult _father;

        /// <summary>
        /// Поле места обучения (десткий сад/школа)
        /// </summary>
        private string _education;

        /// <summary>
        /// Свойство поля матери
        /// </summary>
        public Adult Mother
        {
            get
            {
                return _mother;
            }
            set
            {
                if (value?.Gender != Gender.Female && value! = null)
                {
                    throw new ArgumentException
                        ("Мать должна быть женского пола");
                }

                if (Mother != null)
                {
                    throw new ArgumentException
                        ("У ребенка уже есть мать");
                }

                else
                {
                    _mother = value;
                }
            }
        }

        /// <summary>
        /// Свойство поля отца
        /// </summary>
        public Adult Father
        {
            get
            {
                return _father;
            }
            set
            {
                if (value?.Gender != Gender.Male && value! = null)
                {
                    throw new ArgumentException
                        ("Отец должен быть мужского пола");
                }

                if (Father != null)
                {
                    throw new ArgumentException
                        ("У ребенка уже есть отец");
                }

                else
                {
                    _father = value;
                }
            }
        }


        /// <summary>
        /// Свойство поля места обучения
        /// </summary>
        public string Education
        {
            get
            {
                return _education;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException
                        ("Поле не может быть пустым.\n " +
                        "Если нет информации, то поставьте минус ");
                }
                else
                {
                    _education = value;
                }
            }
        }

        /// <summary>
        /// Свойство для поля минимального возраста ребенка
        /// </summary>
        public override int MaxAge { get; } = 18;

        /// <summary>
        /// Экземляр класса по умолчанию
        /// </summary>
        public Child() : this("Иван", "Иванов", 0, Gender.Male,
                               null, null, "Школа")
        { }

        /// <summary>
        /// Конструктор класса Child
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="secondName">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="gender">Пол</param>
        /// <param name="father">Отец</param>
        /// <param name="mother">Мать</param>
        /// <param name="education">Образование</param>
        public Child(string name, string secondName, int age,
            Gender gender, Adult father, Adult mother, string education)
            : base(name, secondName, age, gender)
        {
            Father = father;
            Mother = mother;
            Education = education;
        }

        /// <summary>
        /// Переопределяемый метод для получения информации о ребенке 
        /// </summary>
        /// <returns>Информация о ребенке</returns>
        public override string GetInfo()
        {
            string info = $"{base.GetInfo()}" +
                $"Данные о ребенке: Мать: {Mother}, Отец: {Father}, " +
                $"Образование: {Education}";

            if (Father == null)
            {
                info += $"Отец: - ";
            }
            else
            {
                info += $"Отец: {Father}, ";
            }

            if (Mother == null)
            {
                info += $"Мать: - ";
            }
            else
            {
                info += $"Мать: {Mother} ";
            }

            if (Education == null)
            {
                info += $"Образование (детский сад/школа): - ";
            }
            else
            {
                info += $"Образование (детский сад/школа): {Education} ";
            }
            return info;
        }
    }

}
