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

            _buttonAgree.Click += new EventHandler(AgreeButtonClick);

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

                if (_checkBoxWeightLifting.Checked)
                {
                    FilteredTypeExercise(_calloriesList,
                        _filteredСalloriesList,
                        typeof(WeightLifting));
                }

                if (_checkBoxSwimming.Checked)
                {
                    FilteredTypeExercise(_calloriesList,
                        _filteredСalloriesList,
                        typeof(Swimming));
                }

                if (_checkBoxRunning.Checked)
                {
                    FilteredTypeExercise(_calloriesList,
                        _filteredСalloriesList,
                        typeof(Running));
                }

                CheckedData();
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
        /// Метод фильтрации данных по типу упражнения
        /// </summary>
        /// <typeparam name="ExerciseBase">Тип списка</typeparam>
        /// <param name="exerciseList">Исходный список</param>
        /// <param name="filteredExerciseList">Отфильтрованный список</param>
        /// <param name="typeExercise">Тип упражнения</param>
        private static void FilteredTypeExercise<ExerciseBase>(
          BindingList<ExerciseBase> exerciseList,
           BindingList<ExerciseBase> filteredExerciseList,
           Type typeExercise)
        {
            foreach (var exercise in exerciseList)
            {
                if (typeExercise == exercise.GetType())
                {
                    filteredExerciseList.Add(exercise);
                }
            }
        }

        /// <summary>
        /// Метод фильтрации по данным типа упражнения
        /// </summary>
        private void CheckedData()
        {
            BindingList<ExerciseBase> exerciseList =
                new BindingList<ExerciseBase>();
        
            bool statusCheckBox = _checkBoxSwimming.Checked
                || _checkBoxRunning.Checked
                || _checkBoxWeightLifting.Checked;

            exerciseList = statusCheckBox
                ? new BindingList<ExerciseBase>(_filteredСalloriesList)
                : new BindingList<ExerciseBase>(exerciseList);

            if (_checkBoxTime.Checked)
            {
                if (!string.IsNullOrEmpty(_textBoxTime.Text))
                {
                    double time = Convert.ToDouble(_textBoxTime.Text);
                    Filtered(exerciseList, time, exercise => exercise.Time);
                    _filteredСalloriesList = exerciseList;
                }
                else
                {
                    MessageBox.Show("Введите время тренировки.", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (_checkBoxWeightPerson.Checked)
            {
                if (!string.IsNullOrEmpty(_textBoxWeightPerson.Text))
                {
                    double weightPerson = Convert.ToDouble(_textBoxWeightPerson.Text);
                    Filtered(exerciseList, weightPerson, exercise => exercise.WeightPerson);
                    _filteredСalloriesList = exerciseList;
                }
                else
                {
                    MessageBox.Show("Введите массу.", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="exerciseList"></param>
        /// <param name="filterValue"></param>
        /// <param name="filterFunc"></param>
        private static void Filtered<T>(BindingList<ExerciseBase> exerciseList, 
            T filterValue, Func<ExerciseBase, T> filterFunc)
        {
            for (int i = exerciseList.Count - 1; i >= 0; i--)
            {
                if (!EqualityComparer<T>.Default.Equals(filterFunc(exerciseList[i]), filterValue))
                {
                    exerciseList.RemoveAt(i);
                }
            }
        }

    }
}
