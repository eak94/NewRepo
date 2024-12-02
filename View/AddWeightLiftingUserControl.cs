using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Пользовательский элемент управления для 
    /// типа упражнения жим штанги
    /// </summary>
    public partial class AddWeightLiftingUserControl : UserControl, IElementAddadble
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public AddWeightLiftingUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляемый элемент тип упражнения - жим штанги
        /// </summary>
        public ExerciseBase Element
        {
            get
            {
                return new WeightLifting()
                {
                    WorkingWeight = Convert.ToDouble(_numBoxWorkingWeight.Text),
                    Repetitions = (int)Convert.ToDouble(_numBoxRepetitions.Text),
                    MaxWeight = Convert.ToDouble(_numBoxMaxWeight.Text),
                };
            }
        }

        /// <summary>
        /// Метод проверки введенных данные
        /// </summary>
        public bool ValidateInput()
        {
            if (string.IsNullOrEmpty(_numBoxWorkingWeight.Text) 
                || !double.TryParse(_numBoxWorkingWeight.Text, out var workingWeight) 
                || workingWeight <= 0)
            {
                MessageBox.Show("Значение в поле Рабочий вес " +
                    "должно быть положительное и больше 0." +
                    " Введите корректные данные.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(_numBoxRepetitions.Text) 
                || !int.TryParse(_numBoxRepetitions.Text, out var repetitions) 
                || repetitions <= 0)
            {
                MessageBox.Show("Значение в поле Количество " +
                    "повторений должно быть положительное и больше 0. " +
                    "Введите корректные данные.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(_numBoxMaxWeight.Text)
                || !double.TryParse(_numBoxMaxWeight.Text, out var maxWeight) 
                || maxWeight <= 0)
            {
                MessageBox.Show("Значение в поле Максимальный " +
                    "вес должно быть положительное и больше 0." +
                    " Введите корректные данные.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
