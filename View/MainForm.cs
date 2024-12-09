using Model;
using System.ComponentModel;
using System.Xml.Serialization;


namespace View
{
    /// <summary>
    /// Главная форма расчета каллорий 
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Лист для заполнения таблицы
        /// результатами расчета каллорий
        /// </summary>
        private BindingList<ExerciseBase> _calloriesList =
            new BindingList<ExerciseBase>();

        /// <summary>
		/// Отфильтрованный лист для заполнения таблицы.
		/// </summary>
		private BindingList<ExerciseBase> _filteredExerciseList;

        /// <summary>
		///  Поле для хранения состояния формы DataForm.
		/// </summary>
		private bool _isDataFormOpen = false;

        /// <summary>
        ///  Поле для хранения состояния формы FindForm.
        /// </summary>
        private bool _isFindFormOpen = false;

        /// <summary>
        /// Поле для хранения состояния фильтра.
        /// </summary>
        private bool _isFiltered = false;

        /// <summary>
		/// Поле для сохранения и открытия файла.
		/// </summary>
		private readonly XmlSerializer _serializerXml =
            new XmlSerializer(typeof(BindingList<ExerciseBase>));

        /// <summary>
        /// Событие, срабатывающее при обновлении данных
        /// </summary>
        public event EventHandler DataUpdated;

        /// <summary>
        /// Конструктор Главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            FillingDataGridView(_calloriesList);

            _buttonAddCallories.Click += AddCalloriesButtonClick;

            _buttonDelete.Click += ClickDeleteElementButton;

            _buttonFillterCallories.Click += FillterButtonClick;

            _buttonFillterCallories.Click += ShowIfFiltered;

            _buttonOpenCallories.Click += OpenFile;

            _buttonSaveCallories.Click += SaveFile;

#if DEBUG
            _buttonAddRandom.Click += ClickRandomButton;

#endif
        }

        /// <summary>
        /// Метод заполнения таблицы результатов расчета 
        /// </summary>
        /// <param name="calloriesList">Список объектов ExerciseBase,
        /// содержащих данные для отображения в таблице</param>
        private void FillingDataGridView(BindingList<ExerciseBase> calloriesList)
        {
            _dataControlCallories.DataSource = null; 
            _dataControlCallories.DataSource = calloriesList;

            _dataControlCallories.AllowUserToResizeColumns = false;
            _dataControlCallories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dataControlCallories.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _dataControlCallories.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _dataControlCallories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Обработчик отмены добавления
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="exerciseBase">Жанные о событии</param>
        private void CancelCallories(object sender, EventArgs exerciseBase)
        {
            CalloriesAddedEventArgs addedEventArgs =
               exerciseBase as CalloriesAddedEventArgs;

            _calloriesList.Remove(addedEventArgs?.ExerciseBase);
        }

        /// <summary>
        /// Метода нажатия на кнопку "Добавить рандомный расчет".
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void ClickRandomButton(object sender, EventArgs e)
        {
            _calloriesList.Add(RandomCallories.GetRandomExercise());
        }

        /// <summary>
        /// Метод нажатия на кнопку "Добавить"
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void AddCalloriesButtonClick(object sender, EventArgs e)
        {
            if (!_isDataFormOpen)
            {
                _isDataFormOpen = true;
                DeactivateElements();

                DataForm DataForm = new DataForm();
                DataForm.FormClosed += (s, args) =>
                {
                    _isDataFormOpen = false;
                    DeactivateElements();
                };
                DataForm.CalloriesAdded += AddedCallories;
                DataForm.CalloriesCancel += CancelCallories;
                DataForm.Show();
            }
        }

        /// <summary>
        /// Обработчик добавления данных в список calloriesList
        /// </summary>
        /// <param name="sender">объект, который вызвал событие</param>
        /// <param name="exerciseBase">аргументы события, которые содержат 
        /// данные, передаваемые при вызове события</param>
        private void AddedCallories(object sender, EventArgs exerciseBase)
        {
            CalloriesAddedEventArgs addedEventArgs = exerciseBase
                as CalloriesAddedEventArgs;
            _calloriesList.Add(addedEventArgs?.ExerciseBase);
        }

        /// <summary>
        /// Метод деактивации элементов 
        /// </summary>
        private void DeactivateElements()
        {
            _buttonAddCallories.Enabled = !_isFiltered && !_isDataFormOpen;
            _buttonFillterCallories.Enabled = !_isFindFormOpen && !_isDataFormOpen;
            _buttonSaveCallories.Enabled = !_isFiltered;
            _buttonOpenCallories.Enabled = !_isFiltered;
#if DEBUG
            _buttonAddRandom.Enabled = !_isFiltered;
#endif
        }


        /// <summary>
        /// Метод для кнопки "Удалить"
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void ClickDeleteElementButton(object sender, EventArgs e)
        {
            var currentList = _isFiltered ? _filteredExerciseList : _calloriesList;
            var itemsToRemove = new List<ExerciseBase>();
            foreach (DataGridViewRow row in _dataControlCallories.SelectedRows)
            {
                if (row.DataBoundItem is ExerciseBase element)
                {
                    itemsToRemove.Add(element);
                }
            }

            foreach (var item in itemsToRemove)
            {
                currentList.Remove(item);
                if (_isFiltered)
                {
                    _calloriesList.Remove(item);
                }
            }
            DataUpdated?.Invoke(this, EventArgs.Empty);
        }


        /// <summary>
		/// Метод нажатия на кнопку "Настроить фильтр"
		/// </summary>
		/// <param name="sender">Событие</param>
		/// <param name="e">Данные о событие</param>
		private void FillterButtonClick(object sender, EventArgs e)
        {
            if (_isFindFormOpen) return;

            _isFindFormOpen = true;
            FilterForm filterForm = new FilterForm(_calloriesList);

            filterForm.ApplyFilter += (filteredItems) =>
            {
                if (filteredItems == _calloriesList) 
                {
                    _isFiltered = false;
                    FillingDataGridView(_calloriesList);
                }
                else
                {
                    _filteredExerciseList = filteredItems;
                    _isFiltered = true;
                    FillingDataGridView(_filteredExerciseList);
                }

                DeactivateElements(); 
            };

            filterForm.FormClosed += (s, e) =>
            {
                _isFindFormOpen = false;
                DeactivateElements(); 
            };

            filterForm.Show();
        }


        /// <summary>
        /// Метод, меняющий состояния кнопок при фильтрации
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void ShowIfFiltered(object sender, EventArgs e)
        {
            _buttonFillterCallories.Enabled = !_isFiltered;
        }

        /// <summary>
		/// Обработчик фильтрации данных
		/// </summary>
		/// <param name="sender">Событие</param>
		/// <param name="transportList">Данные о событие</param>
		private void FilteredExersice(object sender, EventArgs exerciseList)
        {
            CalloriesFilterEventArgs filterEventArgs =
                 exerciseList as CalloriesFilterEventArgs;

            _filteredExerciseList = filterEventArgs?.FilteredCalloriesList;
            _isFiltered = true;
            DeactivateElements();
            FillingDataGridView(_filteredExerciseList);
        }

        /// <summary>
        /// Метод обработки нажатия на кнопку "Сбросить фильтр" на фильтр форме
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событие</param>
        private void ResetFilter(object sender, EventArgs e)
        {
            _isFiltered = false;
            FillingDataGridView(_calloriesList);
            DeactivateElements();
        }

        /// <summary>
		/// Метод для открытия данных из файла
		/// </summary>
		/// <param name="sender">Событие</param>
		/// <param name="e">Данные о событие</param>
		private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.tran)|*.tran|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            string filePath = openFileDialog.FileName.ToString();

            try
            {
                using (var file = new StreamReader(filePath))
                {
                    _calloriesList =
                        (BindingList<ExerciseBase>)_serializerXml.Deserialize(file);
                }

                _dataControlCallories.DataSource = _calloriesList;
                MessageBox.Show("Файл успешно загружен.",
                    "Загрузка завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить файл.\n" +
                   "Файл повреждён или не соответствует формату.",
                   "Ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
		/// Метод для сохранения данных в файл
		/// </summary>
		/// <param name="sender">Событие</param>
		/// <param name="e">Данные о событие</param>
		private void SaveFile(object sender, EventArgs e)
        {
            if (!_calloriesList.Any() || _calloriesList is null)
            {
                MessageBox.Show("Отсутствуют данные для сохранения.",
                    "Данные не сохранены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*tran.)|*.tran|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName.ToString();

                using (var file = File.Create(filePath))
                {
                    _serializerXml.Serialize(file, _calloriesList);
                }

                MessageBox.Show("Файл успешно сохранён.",
                    "Сохранение завершено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}