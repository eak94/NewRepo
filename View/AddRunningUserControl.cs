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
    /// Пользовательский элемент управления типа упражнения бег
    /// </summary>
    public partial class AddRunningUserControl : UserControl, IElementAddedble
    {
        /// <summary>
        /// Конструктор класса 
        /// </summary>
        public AddRunningUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для проверки числа
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns>Проверенное число</returns>
        public static double CheckNumber(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Введенное число должно быть " +
                    "положительным или не равным нулю");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Добавляемый элемент тип упражнения - бег
        /// </summary>
        public ExerciseBase Element
        {
            get
            {
                double distance = 0;
                double intensity = 0;

                if (!string.IsNullOrWhiteSpace(_textBoxDistance.Text) &&
                    double.TryParse(_textBoxDistance.Text, out distance))
                {
                    distance = CheckNumber(distance);
                }
                else
                {
                    MessageBox.Show("Введите корректное значение для дистанции.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                if (!string.IsNullOrWhiteSpace(_textBoxIntensity.Text) &&
                    double.TryParse(_textBoxIntensity.Text, out intensity))
                {

                    intensity = CheckNumber(intensity);
                }
                else
                {
                    MessageBox.Show("Введите корректное значение для интенсивности.", 
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                return new Running()
                {
                    Intensity = intensity,
                    Distance = distance
                };
            }
        }


        private void _textBoxMetRunning_TextChanged(object sender, EventArgs e)
        {

        }

        private void _textBoxDistance_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRunningUserControl_Load(object sender, EventArgs e)
        {

        }

        private void AddRunningUserControl_Load_1(object sender, EventArgs e)
        {

        }
    }
}
