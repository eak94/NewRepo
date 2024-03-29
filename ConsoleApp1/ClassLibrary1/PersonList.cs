
namespace ClassLibrary1
{
    /// <summary>
    /// Класс описывает абстракцию списка
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Массив для хранения персон
        /// </summary>
        private List<Person> _people = new List<Person>();

        //TODO: remove
        /// <summary>
        /// Метод для отображения списка персон 
        /// </summary>
        public void PrintPeople()
        {
            foreach (var person in _people)
            {
                if (person != null)
                {
                    person.PrintPerson();
                }
            }
        }

        /// <summary>
        /// Метод для добавления новых элементов в одномерный массив
        /// </summary>
        /// <param name="person">Персона</param>
        public void AddPerson(Person person)
        {
            _people.Add(person);
        }

        /// <summary>
        /// Метод для удаления элемента по введенному индексу 
        /// </summary>
        /// <param name="index">Индекс персоны, которую надо удалить</param>
        public void DeleteIndexPerson(int index)
        {
            _people.RemoveAt(index);
        }

        /// <summary>
        /// Метод для поиска персоны по указанному индексу
        /// </summary>
        /// <param name="index">Индекс персоны</param>
        /// <returns></returns>
        public Person IndexPerson(int index)
        {
            if (index >= 0 && index < _people.Count)
            {
                return _people[index];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Метод для поиска элемента при его наличии в списке
        /// </summary>
        /// <param name="index"></param>
        public Person FindIndexPerson(Person person)
        {
            if (_people.Contains(person))
            {
                return person;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Метод очищает весь список, начиная с 0
        /// </summary>
        public void DeleteArrayPerson()
        {
            _people.Clear();
        }

        /// <summary>
        /// Метод для определения количества персон в списке 
        /// </summary>
        /// <returns>Возвращает количество персон в списке</returns>
        public int CountPerson()
        {
            return _people.Count;
        }
    }
}
