using System.ComponentModel;

namespace Model
{
    /// <summary>
    /// Перечисление типов упражнения
    /// </summary>
    public enum ExerciseType
    {
        /// <summary>
        /// Бег
        /// </summary>
        [Description("Бег")]
        Running,

        /// <summary>
        /// Плавание
        /// </summary>
        [Description("Плавание")]
        Swimming,

        /// <summary>
        /// Тяжелая атлетика
        /// </summary>
        [Description("Тяжелая атлетика")]
        WeightLifting,
    }
}
