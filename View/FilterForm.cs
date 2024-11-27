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
        /// Метод нажатия на кнопку "ОК"
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событие</param>
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
                    FilteredTypeExersice(_calloriesList,
                        _filteredСalloriesList,
                        typeof(WeightLifting));
                }

                if (_checkBoxSwimming.Checked)
                {
                    FilteredTypeExersice(_calloriesList,
                        _filteredСalloriesList,
                        typeof(Swimming));
                }

                if (_checkBoxRunning.Checked)
                {
                    FilteredTypeExersice(_calloriesList,
                        _filteredСalloriesList,
                        typeof(Running));
                }

               //CheckedData();
               //if (_filteredСalloriesList.Count == 0
               //    || _filteredСalloriesList is null)
               //{
               //    MessageBox.Show("Совпадений не найдено.", "Информация",
               //        MessageBoxButtons.OK, MessageBoxIcon.Information);
               //    return;
               //}

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
        /// <param name="ExersiceList">Исходный список</param>
        /// <param name="filteredExersiceList">Отфильтрованный список</param>
        /// <param name="typeExersice">Тип упражнения</param>
        private static void FilteredTypeExersice<ExerciseBase>(
            BindingList<ExerciseBase> exersiceList,
            BindingList<ExerciseBase> filteredExersiceList,
            Type typeExersice)
        {
            foreach (var exersice in exersiceList)
            {
                if (typeExersice == exersice.GetType())
                {
                    filteredExersiceList.Add(exersice);
                }
            }
        }

        ///// <summary>
        ///// Метод фильтрации по данным человека(весу) и времени тренировки
        ///// </summary>
        //private void CheckedData()
        //{
        //    BindingList<ExerciseBase> exersiceList =
        //        new BindingList<ExerciseBase>();
        //
        //    bool statusCheckBox = _checkBoxFindCar.Checked
        //        || _checkBoxFindHybridCar.Checked
        //        || _checkBoxFindHelicopter.Checked;
        //
        //    exersiceList = statusCheckBox
        //        ? [.. _filteredTransportList]
        //        : [.. _transportList];
        //
        //    if (_checkBoxMass.Checked)
        //    {
        //        if (!string.IsNullOrEmpty(_textBoxMass.Text))
        //        {
        //            FilteredWeight(exersiceList,
        //            Convert.ToDouble(_textBoxMass.Text));
        //            _filteredTransportList = transportList;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Введите вес.", "Предупреждение",
        //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //
        //    if (_checkBoxCapacity.Checked)
        //    {
        //        if (!string.IsNullOrEmpty(_textBoxCapacity.Text))
        //        {
        //            FilteredTime(exersiceList,
        //            Convert.ToDouble(_textBoxCapacity.Text));
        //            _filteredTransportList = transportList;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Введите время тренировки.", "Предупреждение",
        //                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //}

        /// <summary>
        /// Метод фильтрации данных по массе.
        /// </summary>
        /// <param name="transportList">Отфильтрованный список.</param>
        /// <param name="Mass">Масса.</param>
       //private static void FilteredTime(
       //    BindingList<TransportBase> transportList, double Mass)
       //{
       //    for (int i = transportList.Count - 1; i >= 0; i--)
       //    {
       //        if (transportList[i].Mass != Mass)
       //        {
       //            transportList.RemoveAt(i);
       //        }
       //    }
       //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
