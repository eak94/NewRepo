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
        /// Конструктор
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

        }

        /// <summary>
        /// Метод изменения состояния текстовых полей.
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void ChangeTextBoxState(object sender, EventArgs e)
        {
            _numBoxTime.Enabled = _checkBoxTime.Checked;
            _numBoxWeightPerson.Enabled = _checkBoxWeightPerson.Checked;
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
        /// Метод чтения значения из поля ввода данных.
        /// </summary>
        /// <param name="numBox"></param>
        /// <returns></returns>
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
