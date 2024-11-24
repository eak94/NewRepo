using Model;

namespace View
{
    /// <summary>
    /// Класс передает данные событию при добавлении нового расчета каллорий
    /// </summary>
    internal class CalloriesAddedEventArgs : EventArgs
    {
        /// <summary>
        /// Свойство для получения расчета каллорий
        /// </summary>
        public ExerciseBase ExerciseBase { get; }

        /// <summary>
        /// Конструктор 
        /// </summary>
        /// <param name="exerciseBase">Добавленный расчет каллорий</param>
        /// <exception cref="ArgumentNullException">Проверка на null</exception>
        public CalloriesAddedEventArgs(ExerciseBase exerciseBase)
        {
            if (exerciseBase == null)
            {
                throw new ArgumentNullException();
            }

            ExerciseBase = exerciseBase;
        }
    }
}
