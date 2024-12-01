using Model;
using System.ComponentModel;
using System.Xml.Serialization;

//заблокировать кнопку сбросить фильтр, когда фильтр применен 
//доработать ошибки
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

            _buttonResetCallories.Click += ResetedFilter;

            _buttonResetCallories.Click += ShowIfFiltered;

            _buttonOpenCallories.Click += OpenFile;

            _buttonSaveCallories.Click += SaveFile;

#if DEBUG
            _buttonAddRandom.Click += ClickRandomButton;
#endif

            DeactivateElements();
        }

        /// <summary>
        /// Метод заполнения таблицы результатов расчета 
        /// </summary>
        /// <param name="calloriesList"></param>
        private void FillingDataGridView(BindingList<ExerciseBase> calloriesList)
        {
            _dataControlCallories.DataSource = calloriesList;

            _dataControlCallories.AllowUserToResizeColumns = false;
            _dataControlCallories.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            _dataControlCallories.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            _dataControlCallories.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            _dataControlCallories.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
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
            CalloriesAddedEventArgs addedEventArgs = exerciseBase as CalloriesAddedEventArgs;
            var newExercise = addedEventArgs?.ExerciseBase;
            _calloriesList.Add(addedEventArgs?.ExerciseBase);
        }

        /// <summary>
        /// Метод деактивации элементов 
        /// </summary>
        private void DeactivateElements()
        {
            _buttonAddCallories.Enabled = !_isFindFormOpen &&
                !_isFiltered && !_isDataFormOpen;
            _buttonFillterCallories.Enabled = !_isDataFormOpen &&
                !_isFindFormOpen;
            _buttonSaveCallories.Enabled = !_isFiltered;
            _buttonOpenCallories.Enabled = !_isFiltered;
            _buttonDelete.Enabled = !_isFiltered;
        }

        /// <summary>
        /// Метод для кнопки "Удалить"
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void ClickDeleteElementButton(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in _dataControlCallories.SelectedRows)
            {
                if (row.DataBoundItem is ExerciseBase element)
                {
                    _calloriesList.Remove(element);
                }
            }
        }

        /// <summary>
		/// Метод нажатия на кнопку "Настроить фильтр"
		/// </summary>
		/// <param name="sender">Событие</param>
		/// <param name="e">Данные о событие</param>
		private void FillterButtonClick(object sender, EventArgs e)
        {
            if (!_isFindFormOpen)
            {
                _isFindFormOpen = true;
                DeactivateElements();
                FilterForm findForm = new FilterForm(_calloriesList);
                findForm.FormClosed += (s, args) =>
                {
                    _isFindFormOpen = false;
                    DeactivateElements();
                };
                findForm.СalloriesFiltered += FilteredExersice;
                findForm.Show();
            }
        }

        /// <summary>
        /// Метод, меняющий состояния кнопок "отфильтровать" и 
        /// "Сбросить фильтр", который позволяет пользователю 
        /// понять отфильтрован ли список.
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событии</param>
        private void ShowIfFiltered(object sender, EventArgs e)
        {
            if (_isFiltered == true)
            {
                _buttonResetCallories.Enabled = true;
                _buttonDelete.Enabled = false;
            }
            else
            {
                _buttonFillterCallories.Enabled = true;
                _buttonResetCallories.Enabled = true;
                _buttonDelete.Enabled = true;
            }
        }

        /// <summary>
		/// Обработчик фильтрации данных.
		/// </summary>
		/// <param name="sender">Событие.</param>
		/// <param name="transportList">Данные о событие.</param>
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
        /// Метод нажатия на кнопку "Сбросить".
        /// </summary>
        /// <param name="sender">Событие</param>
        /// <param name="e">Данные о событие</param>
        private void ResetedFilter(object sender, EventArgs e)
        {
            FillingDataGridView(_calloriesList);
            _isFiltered = false;
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
                Filter = "Файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
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
                Filter = "Файлы (*txt.)|*.txt|Все файлы (*.*)|*.*"
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