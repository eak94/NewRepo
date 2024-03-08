
namespace ClassLibrary1
{
    /// <summary>
    /// Класс описывает абстракцию списка
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Массив для хранения перечня людей
        /// </summary>
        private Person[] _people;

        /// <summary>
        /// Наименование массива 
        /// </summary>
        private string _nameArrayPerson;

        /// <summary>
        /// Конструктор класса Массив Персон 1
        /// </summary>
        /// <param name="nameArrayPerson">Название массива</param>
        public PersonList(string nameArrayPerson)
        {
            _nameArrayPerson = nameArrayPerson;
            _people = new Person[3];
        }

        /// <summary>
        /// Конструктор класса Массив Персон 2
        /// </summary>
        /// <param name="arrayPerson">Список Персон</param>
        /// <param name="nameArrayPerson">Название списка</param>
        public PersonList(Person[] arrayPerson, string nameArrayPerson)
        {
            _nameArrayPerson = nameArrayPerson;
            _people = arrayPerson;
        }

        /// <summary>
        /// Определения свойства названия массивов
        /// </summary>
        public string NamelistPerson
        {
            get
            {
                return _nameArrayPerson;
            }
            set
            {
                _nameArrayPerson = value;
            }
        }


        /// <summary>
        /// Метод для отображения списка персон 
        /// </summary>
        public void PrintPeople()
        {
            Console.WriteLine($"Список персон в {_nameArrayPerson}:");
            foreach (var person in _people)
            {
                // Печатаем, если объект не null
                if (person != null)
                {
                    person.PrintPerson();
                }
            }
        }

        /// <summary>
        /// Метод для добавления новых элементов в одномерный массив
        /// </summary>
        /// <param name="person">Данные о персоне</param>
        public void AddPerson(Person person)
        {
            Array.Resize(ref _people, _people.Length + 1);
            _people[_people.Length - 1] = person;
        }

        /// <summary>
        /// Метод для добавления новых элементов в одномерный массив
        /// </summary>
        /// <param name="person">Данные о персоне</param>
        public void AddPerson1(Person person)
        {
            Array.Resize(ref _people, _people.Length + 1);
            int element = 0;
            for (int i = 0; i < _people.Length; i++)
            {
                if (_people[i] == null)
                {
                    element = i;
                    break;
                }
            }
            for (int i = element; i < element + 1; i++)
            {
                _people[i] = person;
            }
        }

        /// <summary>
        /// Метод для удаления элемента по введенному индексу 
        /// </summary>
        /// <param name="index">Индекс персоны, которую надо удалить</param>
        public void DeleteIndexPerson(int index)
        {
            if (index >= 0 && index < _people.Length)
            {
                // Сдвигаем элементы, чтобы заполнить пробел
                for (int i = index; i < _people.Length - 1; i++)
                {
                    _people[i] = _people[i + 1];
                }

                // Изменяем размер массива, чтобы удалить последний элемент
                Array.Resize(ref _people, _people.Length - 1);
            }
        }

        /// <summary>
        /// Метод для поиска персоны по указанному индексу
        /// </summary>
        /// <param name="index">Индекс персоны</param>
        /// <returns>Персона по указанному индексу или null, если индекс некорректен</returns>
        public Person IndexPerson(int index)
        {
            if (index >= 0 && index < _people.Length)
            {
                return _people[index];
            }
            else
            {
                // Можно выбросить исключение или вернуть null в зависимости от логики приложения
                return null;
            }
        }

        /// <summary>
        /// Метод для поиска элемента при его наличии в списке
        /// </summary>
        /// <param name="index">Вовзращает индекс элемента, при наличии в списке</param>
        public Person FindIndexPerson(int index)
        {
            return _people[index];
        }

        /// <summary>
        /// Метод очищает весь список, начиная с 0
        /// </summary>
        public void DeleteArrayPerson()
        {
            Array.Clear(_people, 0, _people.Length);
        }

        /// <summary>
        /// Метод для определения количества персон в списке 
        /// </summary>
        /// <returns>Возвращает количество персон в списке</returns>
        public int CountPerson()
        {
            return _ = _people.Length;
        }
        /// <summary>
        /// Индексатор для доступа к элементам списка по индексу
        /// </summary>
        /// <param name="index">Индекс элемента</param>
        /// <returns>Элемент списка по указанному индексу</returns>
        public Person this[int index]
        {
            get
            {
                if (index >= 0 && index < _people.Length)
                {
                    return _people[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < _people.Length)
                {
                    _people[index] = value;
                }
            }

        }
    }
}
