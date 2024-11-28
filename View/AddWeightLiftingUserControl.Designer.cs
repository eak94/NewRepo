namespace View
{
    /// <summary>
    /// Пользовательский элемент управления
    /// для типа упражнения жима штанги
    /// </summary>
    partial class AddWeightLiftingUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            _textBoxWorkingWeight = new TextBox();
            _textBoxMaxWeight = new TextBox();
            _labelMaxWeight = new Label();
            _textBoxRepetitions = new TextBox();
            _labelRepetitions = new Label();
            _labelWorkingWeight = new Label();
            SuspendLayout();
            // 
            // _textBoxWorkingWeight
            // 
            _textBoxWorkingWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _textBoxWorkingWeight.Location = new Point(208, 77);
            _textBoxWorkingWeight.Name = "_textBoxWorkingWeight";
            _textBoxWorkingWeight.Size = new Size(92, 29);
            _textBoxWorkingWeight.TabIndex = 6;
            // 
            // _textBoxMaxWeight
            // 
            _textBoxMaxWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _textBoxMaxWeight.Location = new Point(208, 24);
            _textBoxMaxWeight.Name = "_textBoxMaxWeight";
            _textBoxMaxWeight.Size = new Size(92, 29);
            _textBoxMaxWeight.TabIndex = 5;
            // 
            // _labelMaxWeight
            // 
            _labelMaxWeight.AutoSize = true;
            _labelMaxWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _labelMaxWeight.Location = new Point(19, 27);
            _labelMaxWeight.Name = "_labelMaxWeight";
            _labelMaxWeight.Size = new Size(168, 21);
            _labelMaxWeight.TabIndex = 4;
            _labelMaxWeight.Text = "Максимальный вес, кг";
            _labelMaxWeight.Click += _labelMaxWeight_Click;
            // 
            // _textBoxRepetitions
            // 
            _textBoxRepetitions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _textBoxRepetitions.Location = new Point(208, 131);
            _textBoxRepetitions.Name = "_textBoxRepetitions";
            _textBoxRepetitions.Size = new Size(92, 29);
            _textBoxRepetitions.TabIndex = 2;
            // 
            // _labelRepetitions
            // 
            _labelRepetitions.AutoSize = true;
            _labelRepetitions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _labelRepetitions.Location = new Point(19, 134);
            _labelRepetitions.Name = "_labelRepetitions";
            _labelRepetitions.Size = new Size(183, 21);
            _labelRepetitions.TabIndex = 2;
            _labelRepetitions.Text = "Количество повторений";
            // 
            // _labelWorkingWeight
            // 
            _labelWorkingWeight.AutoSize = true;
            _labelWorkingWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _labelWorkingWeight.Location = new Point(19, 80);
            _labelWorkingWeight.Name = "_labelWorkingWeight";
            _labelWorkingWeight.Size = new Size(120, 21);
            _labelWorkingWeight.TabIndex = 2;
            _labelWorkingWeight.Text = "Рабочий вес, кг";
            // 
            // AddWeightLiftingUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(_textBoxWorkingWeight);
            Controls.Add(_labelWorkingWeight);
            Controls.Add(_textBoxMaxWeight);
            Controls.Add(_labelRepetitions);
            Controls.Add(_labelMaxWeight);
            Controls.Add(_textBoxRepetitions);
            Name = "AddWeightLiftingUserControl";
            Size = new Size(315, 191);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        /// <summary>
        /// textBox для рабочего веса 
        /// </summary>
        private TextBox _textBoxWorkingWeight;

        /// <summary>
        /// textBox для максимального веса
        /// </summary>
        private TextBox _textBoxMaxWeight;

        /// <summary>
        /// textBox для количества повторений
        /// </summary>
        private TextBox _textBoxRepetitions;

        /// <summary>
        /// надпись для максимального веса
        /// </summary>
        private Label _labelMaxWeight;
                
        /// <summary>
        /// надпись для количества повторений
        /// </summary>
        private Label _labelRepetitions;

        /// <summary>
        /// надпись для рабочего веса 
        /// </summary>
        private Label _labelWorkingWeight;
    }
}
