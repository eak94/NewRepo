
namespace ClassLibrary1
{
    /// <summary>
    /// Класс описывает абстракцию списка
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Одномерный пустой массив, содержащий объекты класса
        /// </summary>
        private Person[] _people = new Person[0];

        /// <summary>
        /// Метод для добавления новых элементов в одномерный массив
        /// </summary>
        /// <param name="person">Данные о персоне</param>
        public void AddPerson(Person person)
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
        /// Метод для удаления элемента по введеному индексу 
        /// </summary>
        /// <param name="index">Индекс персоны,которую надо удалить</param>
        public void DeleteIndexPerson(int index)
        {
            _people[index] = null;
        }

        /// <summary>
        /// Метод для поиска персоны по указанному индексу
        /// </summary>
        /// <param name="index">Вовзращается персоны по
        /// введенному индексу </param>
        public void IndexPerson(int index)
        {
            if (index >= _people.Length || _people[index] == null)
            {
                Console.WriteLine("Элемент с данным индексом не существует");
            }
            else
            {
                _people[index].PrintPerson();
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

    }
}
