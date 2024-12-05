using Model;
using System.ComponentModel;
using System.Data;


namespace View
{
    /// <summary>
    /// Форма фильтрации
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Исходный список результатов расчета каллорий
        /// </summary>
        private BindingList<ExerciseBase> _calloriesList;

        /// <summary>
        /// Отфильтрованный список результатов расчета каллорий
        /// </summary>
        private BindingList<ExerciseBase> _filteredСalloriesList;

        /// <summary>
        /// Событие на фильтрацию списка
        /// </summary>
        public EventHandler СalloriesFiltered;

        /// <summary>
        /// Событие сброса фильтрации списка
        /// </summary>
        public EventHandler CalloriesUnfiltered;

        /// <summary>
        /// Конструктор для фильтрации расчетов 
        /// </summary>
        /// <param name="calloriesList">Исходных список 
        /// результатов расчета каллорий</param>
        public FilterForm(BindingList<ExerciseBase> calloriesList)
        {
            _calloriesList = calloriesList;

            InitializeComponent();
            _numBoxTime.Enabled = false;
            _numBoxWeightPerson.Enabled = false;
            _checkBoxTime.CheckedChanged += ChangeTextBoxState;
            _checkBoxWeightPerson.CheckedChanged += ChangeTextBoxState;
            _buttonAgree.Click += AgreeButtonClick;
            _buttonReset.Click += ResetFilter;
            this.FormClosed += ResetFilter;

        }

        /// <summary>
        /// Метод изменения состояния текстовых полей
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void ChangeTextBoxState(object sender, EventArgs e)
        {
            _numBoxTime.Enabled = _checkBoxTime.Checked;
            _numBoxWeightPerson.Enabled = _checkBoxWeightPerson.Checked;
        }

        /// <summary>
        /// Изменение чекбоксов 
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void ResetCheckBoxes(object sender, EventArgs e)
        {
            _checkBoxWeightPerson.Checked = false;
            _checkBoxTime.Checked = false;
            _checkBoxWeightLifting.Checked = false;
            _checkBoxSwimming.Checked = false;
            _checkBoxRunning.Checked = false;
        }

        /// <summary>
        /// Метод нажатия на кнопку "Применить"
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void AgreeButtonClick(object sender, EventArgs e)
        {
            bool checkClick = _checkBoxWeightPerson.Checked
                || _checkBoxTime.Checked
                || _checkBoxWeightLifting.Checked
                || _checkBoxSwimming.Checked
                || _checkBoxRunning.Checked;

            if (checkClick)
            {
                _filteredСalloriesList = new BindingList<ExerciseBase>();
                List<ExerciseBase> filterdExercises = null;
                List<string> typeFilterCriteria = new List<string>();
                ExerciseBase element = null;
                double? time = GetValueFromNumBox(_numBoxTime);
                double? weight = GetValueFromNumBox(_numBoxWeightPerson);

                if (_checkBoxWeightLifting.Checked)
                {
                    element = new WeightLifting();
                    typeFilterCriteria.Add(element.ExerciseType);
                }

                if (_checkBoxSwimming.Checked)
                {
                    element = new Swimming();
                    typeFilterCriteria.Add(element.ExerciseType);
                }

                if (_checkBoxRunning.Checked)
                {
                    element = new Running();
                    typeFilterCriteria.Add(element.ExerciseType);
                }

                filterdExercises = _calloriesList.Where(obj =>
                   (typeFilterCriteria.Count == 0 ||
                   typeFilterCriteria.Contains(obj.ExerciseType))
                   &&
                   (!time.HasValue ||
                   obj.Time == time)
                   &&
                   (!weight.HasValue ||
                   obj.WeightPerson == weight)
                ).ToList();

                _filteredСalloriesList = new BindingList<ExerciseBase>
                    (filterdExercises);

                if (_filteredСalloriesList.Count == 0
                    || _filteredСalloriesList is null)
                {
                    MessageBox.Show("Совпадений не найдено.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                СalloriesFiltered.Invoke(this,
                new CalloriesFilterEventArgs(_filteredСalloriesList));
            }
            else
            {
                MessageBox.Show("Заполните критерии поиска.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку "Сбросить фильтр".
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событие</param>
        private void ResetFilter(object sender, EventArgs e)
        {
            ResetCheckBoxes(sender, e);
            CalloriesUnfiltered.Invoke(this,
               new CalloriesFilterEventArgs(_calloriesList));
        }

        /// <summary>
        /// Метод чтения значения из поля ввода данных.
        /// </summary>
        private double? GetValueFromNumBox(TextBox numBox)
        {
            if (!numBox.Enabled)
            {
                return null;
            }
            if (string.IsNullOrWhiteSpace(numBox.Text))
            {
                return null;
            }
            else
            {
                return Convert.ToDouble(numBox.Text);
            }
        }
    }
}
