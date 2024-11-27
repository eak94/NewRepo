using System.ComponentModel;
using Model;

namespace View
{
    /// <summary>
    /// класс передает данные события при фильтрации
    /// </summary>
    internal class CalloriesFilterEventArgs : EventArgs
    {
        /// <summary>
        /// Свойство для получения отфильтрованного списка 
        /// </summary>
        public BindingList<ExerciseBase> FilteredCalloriesList { get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="filteredCalloriesList">Отфильтрованный список
        /// расчетов каллорий</param>
        /// <exception cref="ArgumentNullException">Проверка списка на null</exception>
        public CalloriesFilterEventArgs(BindingList<ExerciseBase> filteredCalloriesList)
        {
            if (filteredCalloriesList == null)
            {
                throw new ArgumentNullException();
            }

            FilteredCalloriesList = filteredCalloriesList;
        }
    }
}
