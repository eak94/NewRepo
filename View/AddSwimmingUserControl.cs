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
    /// Пользовательский элемент типа упражнения плавание
    /// </summary>
    public partial class AddSwimmingUserControl : UserControl, IElementAddedble
    {
        /// <summary>
        /// Словарь стилей плавания
        /// </summary>
        private static readonly Dictionary<string, SwimmingStyle> _typesSwimmingStyle = new()
        {
            { "Брасс", SwimmingStyle.Brass},
            { "Кроль-умеренный", SwimmingStyle.CrawlModerate},
            { "Кроль-быстрый", SwimmingStyle.CrawlFast },
            { "На спине", SwimmingStyle.Backstroke },
            { "Дельфин", SwimmingStyle.Dolphin }
        };

        /// <summary>
        /// Конструктор пользовательского элемента типа плавание
        /// </summary>
        public AddSwimmingUserControl()
        {
            InitializeComponent();

            FillComboBox(_typesSwimmingStyle.Keys.ToArray(),
                _comboBoxStyleSwimming);
        }

        /// <summary>
        /// Заполнение comboBox массивом данных comboBox
        /// </summary>
        /// <param name="dataSource">Массив данных.</param>
        /// <param name="comboBox">ComboBox</param>
        private void FillComboBox<T>(T[] dataSource, ComboBox comboBox)
        {
            comboBox.DataSource = dataSource;
            comboBox.SelectedItem = dataSource[0];
        }

        /// <summary>
        /// Добавляемый элемент тип упражнения плавание
        /// </summary>
        public ExerciseBase Element
        {
            get
            {
                return new Swimming()
                {
                    Distance = Convert.ToDouble(_textBoxDistance.Text),
                };
            }
        }

        private void _labelDistance_Click(object sender, EventArgs e)
        {

        }

        private void _textBoxDistance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

