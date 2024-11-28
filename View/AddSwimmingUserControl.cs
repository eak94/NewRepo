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
        /// Словарь коэффициентов MET
        /// </summary>
        private static readonly Dictionary<SwimmingStyle, int> _metCoefficients = new()
        {
            { SwimmingStyle.Brass, 5 },
            { SwimmingStyle.CrawlModerate, 6 },
            { SwimmingStyle.CrawlFast, 8 },
            { SwimmingStyle.Backstroke, 4 },
            { SwimmingStyle.Dolphin, 10 }
        };

        /// <summary>
        /// Конструктор пользовательского элемента типа плавание
        /// </summary>
        public AddSwimmingUserControl()
        {
            InitializeComponent();

            FillComboBox(_typesSwimmingStyle.Keys.ToArray(),
                _comboBoxStyleSwimming);

            _comboBoxStyleSwimming.SelectedIndexChanged += 
                ComboBoxStyleSwimming;
        }

        /// <summary>
        /// Заполнение comboBox массивом данных comboBox
        /// </summary>
        /// <param name="dataSource">Массив данных.</param>
        /// <param name="comboBox">ComboBox</param>
        private void FillComboBox<T>(T[] dataSource, ComboBox comboBox)
        {
            comboBox.DataSource = dataSource;
            comboBox.SelectedItem = dataSource.GetValue(0);
        }

        /// <summary>
        /// Обработчик изменения выбора стиля плавания
        /// </summary>
        private void ComboBoxStyleSwimming(object sender, EventArgs e)
        {
            if (_comboBoxStyleSwimming.SelectedItem != null)
            {
                string selectedStyle = 
                    _comboBoxStyleSwimming.SelectedItem.ToString();

                if (_typesSwimmingStyle.TryGetValue
                    (selectedStyle, out SwimmingStyle style))
                {
                    
                    if (_metCoefficients.TryGetValue
                        (style, out int metCoefficient))
                    {
                        _textBoxMetSwimming.Text = metCoefficient.ToString();
                    }
                }
            }
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
    }
}

