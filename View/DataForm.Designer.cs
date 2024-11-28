namespace View
{
    /// <summary>
    /// Класс для добавление элементов
    /// </summary>
    partial class DataForm
    {
        /// <summary>
        /// Необходимая переменная дизайнера
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Метод для явного освобождения ресурсов
        /// </summary>
        /// <param name="disposing">true если ресурсы необходимо
        /// oудалить,иначе false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _groupBoxDataExercise = new GroupBox();
            _comboBoxExercise = new ComboBox();
            _buttonDataAgree = new Button();
            _buttonDataCancel = new Button();
            _textBoxWeightPerson = new TextBox();
            _labelWeightPerson = new Label();
            _textBoxTime = new TextBox();
            _labelTime = new Label();
            _groupBoxParametrExerciseBase = new GroupBox();
            _groupBoxParametrExercise = new GroupBox();
            label2 = new Label();
            _groupBoxDataExercise.SuspendLayout();
            _groupBoxParametrExerciseBase.SuspendLayout();
            _groupBoxParametrExercise.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBoxDataExercise
            // 
            _groupBoxDataExercise.Controls.Add(_comboBoxExercise);
            _groupBoxDataExercise.Location = new Point(61, 31);
            _groupBoxDataExercise.Name = "_groupBoxDataExercise";
            _groupBoxDataExercise.Size = new Size(322, 85);
            _groupBoxDataExercise.TabIndex = 0;
            _groupBoxDataExercise.TabStop = false;
            _groupBoxDataExercise.Text = "Тип упражнения";
            // 
            // _comboBoxExercise
            // 
            _comboBoxExercise.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxExercise.FormattingEnabled = true;
            _comboBoxExercise.Location = new Point(16, 37);
            _comboBoxExercise.Name = "_comboBoxExercise";
            _comboBoxExercise.Size = new Size(280, 29);
            _comboBoxExercise.TabIndex = 0;
            // 
            // _buttonDataAgree
            // 
            _buttonDataAgree.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _buttonDataAgree.Location = new Point(582, 296);
            _buttonDataAgree.Name = "_buttonDataAgree";
            _buttonDataAgree.Size = new Size(162, 33);
            _buttonDataAgree.TabIndex = 2;
            _buttonDataAgree.Text = "Рассчитать";
            _buttonDataAgree.UseVisualStyleBackColor = true;
            // 
            // _buttonDataCancel
            // 
            _buttonDataCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _buttonDataCancel.Location = new Point(460, 296);
            _buttonDataCancel.Name = "_buttonDataCancel";
            _buttonDataCancel.Size = new Size(99, 33);
            _buttonDataCancel.TabIndex = 3;
            _buttonDataCancel.Text = "Отмена";
            _buttonDataCancel.UseVisualStyleBackColor = true;
            // 
            // _textBoxWeightPerson
            // 
            _textBoxWeightPerson.Location = new Point(204, 89);
            _textBoxWeightPerson.Name = "_textBoxWeightPerson";
            _textBoxWeightPerson.Size = new Size(92, 29);
            _textBoxWeightPerson.TabIndex = 1;
            // 
            // _labelWeightPerson
            // 
            _labelWeightPerson.AutoSize = true;
            _labelWeightPerson.Location = new Point(16, 89);
            _labelWeightPerson.Name = "_labelWeightPerson";
            _labelWeightPerson.Size = new Size(129, 21);
            _labelWeightPerson.TabIndex = 0;
            _labelWeightPerson.Text = "Вес человека, кг ";
            // 
            // _textBoxTime
            // 
            _textBoxTime.Location = new Point(204, 41);
            _textBoxTime.Name = "_textBoxTime";
            _textBoxTime.Size = new Size(92, 29);
            _textBoxTime.TabIndex = 1;
            // 
            // _labelTime
            // 
            _labelTime.AutoSize = true;
            _labelTime.Location = new Point(16, 41);
            _labelTime.Name = "_labelTime";
            _labelTime.Size = new Size(160, 21);
            _labelTime.TabIndex = 0;
            _labelTime.Text = "Время тренировки, ч";
            // 
            // _groupBoxParametrExerciseBase
            // 
            _groupBoxParametrExerciseBase.BackColor = Color.Transparent;
            _groupBoxParametrExerciseBase.Controls.Add(_textBoxWeightPerson);
            _groupBoxParametrExerciseBase.Controls.Add(_labelWeightPerson);
            _groupBoxParametrExerciseBase.Controls.Add(_textBoxTime);
            _groupBoxParametrExerciseBase.Controls.Add(_labelTime);
            _groupBoxParametrExerciseBase.FlatStyle = FlatStyle.Flat;
            _groupBoxParametrExerciseBase.Location = new Point(61, 135);
            _groupBoxParametrExerciseBase.Name = "_groupBoxParametrExerciseBase";
            _groupBoxParametrExerciseBase.Size = new Size(322, 142);
            _groupBoxParametrExerciseBase.TabIndex = 5;
            _groupBoxParametrExerciseBase.TabStop = false;
            // 
            // _groupBoxParametrExercise
            // 
            _groupBoxParametrExercise.BackColor = Color.Transparent;
            _groupBoxParametrExercise.Controls.Add(label2);
            _groupBoxParametrExercise.FlatStyle = FlatStyle.Flat;
            _groupBoxParametrExercise.Location = new Point(421, 31);
            _groupBoxParametrExercise.Name = "_groupBoxParametrExercise";
            _groupBoxParametrExercise.Size = new Size(322, 246);
            _groupBoxParametrExercise.TabIndex = 6;
            _groupBoxParametrExercise.TabStop = false;
            _groupBoxParametrExercise.Text = "Параметры по типу упражнения";
            _groupBoxParametrExercise.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 41);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 0;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 350);
            Controls.Add(_groupBoxParametrExercise);
            Controls.Add(_groupBoxParametrExerciseBase);
            Controls.Add(_buttonDataCancel);
            Controls.Add(_buttonDataAgree);
            Controls.Add(_groupBoxDataExercise);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DataForm";
            Text = "Добавить расчет каллорий";
            _groupBoxDataExercise.ResumeLayout(false);
            _groupBoxParametrExerciseBase.ResumeLayout(false);
            _groupBoxParametrExerciseBase.PerformLayout();
            _groupBoxParametrExercise.ResumeLayout(false);
            _groupBoxParametrExercise.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        /// <summary>
        /// groupBox тип упражнения
        /// </summary>
        private GroupBox _groupBoxDataExercise;

        /// <summary>
        /// groupBox параметры по типу упражнение 
        /// </summary>
        private GroupBox _groupBoxParametrExerciseBase;

        /// <summary>
        /// comboBox тип упражнения
        /// </summary>
        private ComboBox _comboBoxExercise;

        /// <summary>
        /// Кнопка "Рассчитать"
        /// </summary>
        private Button _buttonDataAgree;

        /// <summary>
        /// Кнопка "Отмена"
        /// </summary>
        private Button _buttonDataCancel;

        /// <summary>
        /// textBox время тренировки
        /// </summary>
        private TextBox _textBoxTime;

        /// <summary>
        /// textBox вес человека
        /// </summary>
        private TextBox _textBoxWeightPerson;

        /// <summary>
        /// подпись около textBox ", кг"
        /// </summary>
        private Label _labelWeightPerson;

        /// <summary>
        /// подпись около textBox ", ч"
        /// </summary>
        private Label _labelTime;

        /// <summary>
        /// Пользовательский элемент управления по типу упражнения бег
        /// </summary>
        private AddRunningUserControl _addRunningUserControl;

        /// <summary>
        /// Пользовательский элемент управления по типу упражнения плавание
        /// </summary>
        private AddSwimmingUserControl _addSwimmingUserControl;

        /// <summary>
        /// Пользовательский элемент управления по типу упражнения жим штанги
        /// </summary>
        private AddWeightLiftingUserControl _addWeightLiftingUserControl;
        private GroupBox _groupBoxParametrExercise;
        private Label label2;
    }
        
}