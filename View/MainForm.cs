using Model;
using System.ComponentModel;


namespace View
{
    /// <summary>
    /// ������� ����� ������� �������� 
    /// </summary>
    public partial class MainForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// ���� ��� ���������� �������
        /// </summary>
        private BindingList<ExerciseBase> _calloriesList =
            new BindingList<ExerciseBase>();

        /// <summary>
        /// ���� ��� �������� ��������� ����� DataForm 
        /// (����� ���������� ���������� ��� ������)
        /// </summary>
        private bool _isDataFormOpen = false;

        /// <summary>
        ///  ���� ��� �������� ��������� ����� FindForm.
        /// </summary>
        private bool _isFindFormOpen = false;

        /// <summary>
        /// ���� ��� �������� ��������� �������.
        /// </summary>
        private bool _isFiltered = false;

        /// <summary>
        /// ����������� BasicForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _buttonResetCallories.Click += _buttonResetCallories_Click;

            _buttonSaveCallories.Click += _buttonSaveCallories_Click;

            _buttonOpenCallories.Click -= _buttonOpenCallories_Click;

            _buttonOpenCallories.Click += _buttonOpenCallories_Click;

            FillingDataGridView(_calloriesList);

        }

        /// <summary>
        /// ����� ���������� ������� ����������� ������� 
        /// </summary>
        /// <param name="calloriesList"></param>
        private void FillingDataGridView(BindingList<ExerciseBase> calloriesList)
        {
            _dataControlCallories.DataSource = calloriesList;
        }

        /// <summary>
        /// ����� ������� �� ������ "��������"
        /// </summary>
        /// <param name="sender">�������</param>
        /// <param name="e">������ � �������</param>
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
        /// ���������� ���������� ������ � ������ calloriesList
        /// </summary>
        /// <param name="sender">������, ������� ������ �������</param>
        /// <param name="exerciseBase">��������� �������, ������� �������� 
        /// ������, ������������ ��� ������ �������</param>
        private void AddedCallories(object sender, EventArgs exerciseBase)
        {
            CalloriesAddedEventArgs addedEventArgs =
                 exerciseBase as CalloriesAddedEventArgs;
            _calloriesList.Add(addedEventArgs?.ExerciseBase);
        }

        /// <summary>
        /// ���������� ��� ������ ���������� ������ � ������ calloriesList
        /// </summary>
        /// <param name="sender">������, ������� ������ �������</param>
        /// <param name="exerciseBase">��������� �������, ������� �������� 
        /// ������, ������������ ��� ������ �������</param>
        private void CancelCallories(object sender, EventArgs exerciseBase)
        {
            CalloriesAddedEventArgs addedEventArgs =
                exerciseBase as CalloriesAddedEventArgs;
            _calloriesList.Remove(addedEventArgs?.ExerciseBase);
        }

        /// <summary>
        /// ����� ����������� ��������� 
        /// </summary>
        private void DeactivateElements()
        {
            _buttonAddCallories.Enabled = !_isFindFormOpen && 
                !_isDataFormOpen && !_isFiltered;

            _buttonFindCallories.Enabled = !_isFindFormOpen &&
                !_isDataFormOpen;

            _buttonSaveCallories.Enabled = !_isFiltered;

            _buttonOpenCallories.Enabled = !_isFiltered;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _groupBoxResultCalloties_Enter(object sender, EventArgs e)
        {

        }

        private void _buttonResetCallories_Click(object sender, EventArgs e)
        {

        }

        private void _buttonSaveCallories_Click(object sender, EventArgs e)
        {

        }

        private void _buttonOpenCallories_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewResultCalloties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAddCallories_Click(object sender, EventArgs e)
        {

        }
    }
}