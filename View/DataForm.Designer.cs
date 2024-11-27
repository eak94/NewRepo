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
            _buttonDataAddRandomParametr = new Button();
            _buttonDataAgree = new Button();
            _buttonDataCancel = new Button();
            _groupBoxDataPerson = new GroupBox();
            _textBoxWeightPerson = new TextBox();
            _labelWeightPerson = new Label();
            _groupBoxDataTime = new GroupBox();
            _textBoxTime = new TextBox();
            _labelTime = new Label();
            _groupBoxParametrExercise = new GroupBox();
            _groupBoxDataExercise.SuspendLayout();
            _groupBoxDataPerson.SuspendLayout();
            _groupBoxDataTime.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBoxDataExercise
            // 
            _groupBoxDataExercise.Controls.Add(_comboBoxExercise);
            _groupBoxDataExercise.Location = new Point(53, 44);
            _groupBoxDataExercise.Name = "_groupBoxDataExercise";
            _groupBoxDataExercise.Size = new Size(280, 85);
            _groupBoxDataExercise.TabIndex = 0;
            _groupBoxDataExercise.TabStop = false;
            _groupBoxDataExercise.Text = "Тип упражнения";
            _groupBoxDataExercise.Enter += _groupBoxDataExercise_Enter;
            // 
            // _comboBoxExercise
            // 
            _comboBoxExercise.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxExercise.FormattingEnabled = true;
            _comboBoxExercise.Location = new Point(16, 37);
            _comboBoxExercise.Name = "_comboBoxExercise";
            _comboBoxExercise.Size = new Size(238, 29);
            _comboBoxExercise.TabIndex = 0;
            _comboBoxExercise.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // _buttonDataAddRandomParametr
            // 
            _buttonDataAddRandomParametr.Location = new Point(53, 398);
            _buttonDataAddRandomParametr.Name = "_buttonDataAddRandomParametr";
            _buttonDataAddRandomParametr.Size = new Size(280, 69);
            _buttonDataAddRandomParametr.TabIndex = 1;
            _buttonDataAddRandomParametr.Text = "Заполнить рандомными значениями";
            _buttonDataAddRandomParametr.UseVisualStyleBackColor = true;
            // 
            // _buttonDataAgree
            // 
            _buttonDataAgree.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _buttonDataAgree.Location = new Point(725, 485);
            _buttonDataAgree.Name = "_buttonDataAgree";
            _buttonDataAgree.Size = new Size(77, 33);
            _buttonDataAgree.TabIndex = 2;
            _buttonDataAgree.Text = "Ок";
            _buttonDataAgree.UseVisualStyleBackColor = true;
            _buttonDataAgree.Click += button2_Click;
            // 
            // _buttonDataCancel
            // 
            _buttonDataCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _buttonDataCancel.Location = new Point(606, 485);
            _buttonDataCancel.Name = "_buttonDataCancel";
            _buttonDataCancel.Size = new Size(99, 33);
            _buttonDataCancel.TabIndex = 3;
            _buttonDataCancel.Text = "Отмена";
            _buttonDataCancel.UseVisualStyleBackColor = true;
            _buttonDataCancel.Click += _buttonDataCancel_Click;
            // 
            // _groupBoxDataPerson
            // 
            _groupBoxDataPerson.Controls.Add(_textBoxWeightPerson);
            _groupBoxDataPerson.Controls.Add(_labelWeightPerson);
            _groupBoxDataPerson.Location = new Point(53, 285);
            _groupBoxDataPerson.Name = "_groupBoxDataPerson";
            _groupBoxDataPerson.Size = new Size(280, 98);
            _groupBoxDataPerson.TabIndex = 4;
            _groupBoxDataPerson.TabStop = false;
            _groupBoxDataPerson.Text = "Данные о человеке";
            // 
            // _textBoxWeightPerson
            // 
            _textBoxWeightPerson.Location = new Point(15, 58);
            _textBoxWeightPerson.Name = "_textBoxWeightPerson";
            _textBoxWeightPerson.Size = new Size(239, 29);
            _textBoxWeightPerson.TabIndex = 1;
            // 
            // _labelWeightPerson
            // 
            _labelWeightPerson.AutoSize = true;
            _labelWeightPerson.Location = new Point(16, 34);
            _labelWeightPerson.Name = "_labelWeightPerson";
            _labelWeightPerson.Size = new Size(59, 21);
            _labelWeightPerson.TabIndex = 0;
            _labelWeightPerson.Text = "Вес, кг ";
            _labelWeightPerson.Click += label1_Click;
            // 
            // _groupBoxDataTime
            // 
            _groupBoxDataTime.Controls.Add(_textBoxTime);
            _groupBoxDataTime.Controls.Add(_labelTime);
            _groupBoxDataTime.Location = new Point(53, 174);
            _groupBoxDataTime.Name = "_groupBoxDataTime";
            _groupBoxDataTime.Size = new Size(280, 105);
            _groupBoxDataTime.TabIndex = 5;
            _groupBoxDataTime.TabStop = false;
            _groupBoxDataTime.Text = "Данные о тренировке ";
            // 
            // _textBoxTime
            // 
            _textBoxTime.Location = new Point(16, 58);
            _textBoxTime.Name = "_textBoxTime";
            _textBoxTime.Size = new Size(238, 29);
            _textBoxTime.TabIndex = 1;
            // 
            // _labelTime
            // 
            _labelTime.AutoSize = true;
            _labelTime.Location = new Point(16, 34);
            _labelTime.Name = "_labelTime";
            _labelTime.Size = new Size(71, 21);
            _labelTime.TabIndex = 0;
            _labelTime.Text = "Время, ч";
            // 
            // _groupBoxParametrExercise
            // 
            _groupBoxParametrExercise.BackColor = Color.Transparent;
            _groupBoxParametrExercise.FlatStyle = FlatStyle.Flat;
            _groupBoxParametrExercise.Location = new Point(355, 44);
            _groupBoxParametrExercise.Name = "_groupBoxParametrExercise";
            _groupBoxParametrExercise.Size = new Size(447, 423);
            _groupBoxParametrExercise.TabIndex = 5;
            _groupBoxParametrExercise.TabStop = false;
            _groupBoxParametrExercise.Text = "Данные по типу упражнения";
            _groupBoxParametrExercise.Visible = false;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(866, 548);
            Controls.Add(_groupBoxParametrExercise);
            Controls.Add(_groupBoxDataTime);
            Controls.Add(_groupBoxDataPerson);
            Controls.Add(_buttonDataCancel);
            Controls.Add(_buttonDataAgree);
            Controls.Add(_buttonDataAddRandomParametr);
            Controls.Add(_groupBoxDataExercise);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "DataForm";
            Text = "Добавить расчет каллорий";
            _groupBoxDataExercise.ResumeLayout(false);
            _groupBoxDataPerson.ResumeLayout(false);
            _groupBoxDataPerson.PerformLayout();
            _groupBoxDataTime.ResumeLayout(false);
            _groupBoxDataTime.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        /// <summary>
        /// groupBox тип упражнения
        /// </summary>
        private GroupBox _groupBoxDataExercise;

        /// <summary>
        /// groupBox данные о человеке
        /// </summary>
        private GroupBox _groupBoxDataPerson;

        /// <summary>
        /// groupBox данные о тренировке 
        /// </summary>
        private GroupBox _groupBoxDataTime;

        /// <summary>
        /// groupBox параметры по типу упражнение 
        /// </summary>
        private GroupBox _groupBoxParametrExercise;

        /// <summary>
        /// comboBox тип упражнения
        /// </summary>
        private ComboBox _comboBoxExercise;

        /// <summary>
        /// Кнопка добавить рандрмные параметры
        /// </summary>
        private Button _buttonDataAddRandomParametr;

        /// <summary>
        /// Кнопка "Ок"
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
    }
        
}