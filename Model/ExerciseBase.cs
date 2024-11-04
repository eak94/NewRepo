namespace Model
{
    /// <summary>
    /// Базовый класс упражнения 
    /// </summary>
    public abstract class ExerciseBase
    {
        /// <summary>
        /// Свойство Вес 
        /// </summary>
        public double Weight { get; }

        /// <summary>
        /// Свойство Время
        /// </summary>
        public double Time { get; }
    }
}
