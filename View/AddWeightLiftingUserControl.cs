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
    public partial class AddWeightLiftingUserControl : UserControl, IElementAddedble
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public AddWeightLiftingUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляемый элемент тип упражнения - бег
        /// </summary>
        public ExerciseBase Element
        {
            get
            {
                return new WeightLifting()
                {
                    WorkingWeight = Convert.ToDouble(
                            _textBoxWorkingWeight.Text),
                    Repetitions = (int)Convert.ToDouble
                    (_textBoxRepetitions.Text),
                    MaxWeight = Convert.ToDouble(
                            _textBoxMaxWeight.Text),
                };
            }
        }

        private void _textBoxMaxWeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
