namespace View
{
    /// <summary>
    /// Пользовательский элемент управления для 
    /// типа упражнения плавание
    /// </summary>
    partial class AddSwimmingUserControl
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
            _groupBoxSwimming = new GroupBox();
            _textBoxMetSwimming = new TextBox();
            _labelMetSwimming = new Label();
            _textBoxDistance = new TextBox();
            _labelDistance = new Label();
            _comboBoxStyleSwimming = new ComboBox();
            _labelStyleSwimming = new Label();
            _groupBoxSwimming.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBoxSwimming
            // 
            _groupBoxSwimming.Controls.Add(_textBoxMetSwimming);
            _groupBoxSwimming.Controls.Add(_labelMetSwimming);
            _groupBoxSwimming.Controls.Add(_textBoxDistance);
            _groupBoxSwimming.Controls.Add(_labelDistance);
            _groupBoxSwimming.Controls.Add(_comboBoxStyleSwimming);
            _groupBoxSwimming.Controls.Add(_labelStyleSwimming);
            _groupBoxSwimming.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _groupBoxSwimming.Location = new Point(3, 3);
            _groupBoxSwimming.Name = "_groupBoxSwimming";
            _groupBoxSwimming.Size = new Size(335, 244);
            _groupBoxSwimming.TabIndex = 2;
            _groupBoxSwimming.TabStop = false;
            _groupBoxSwimming.Text = "Параметры плавания";
            _groupBoxSwimming.Enter += _groupBoxRunning_Enter;
            // 
            // _textBoxMetSwimming
            // 
            _textBoxMetSwimming.Location = new Point(18, 124);
            _textBoxMetSwimming.Name = "_textBoxMetSwimming";
            _textBoxMetSwimming.Size = new Size(292, 29);
            _textBoxMetSwimming.TabIndex = 5;
            // 
            // _labelMetSwimming
            // 
            _labelMetSwimming.AutoSize = true;
            _labelMetSwimming.Location = new Point(21, 100);
            _labelMetSwimming.Name = "_labelMetSwimming";
            _labelMetSwimming.Size = new Size(40, 21);
            _labelMetSwimming.TabIndex = 4;
            _labelMetSwimming.Text = "MET";
            // 
            // _textBoxDistance
            // 
            _textBoxDistance.Location = new Point(18, 189);
            _textBoxDistance.Name = "_textBoxDistance";
            _textBoxDistance.Size = new Size(292, 29);
            _textBoxDistance.TabIndex = 2;
            // 
            // _labelDistance
            // 
            _labelDistance.AutoSize = true;
            _labelDistance.Location = new Point(18, 165);
            _labelDistance.Name = "_labelDistance";
            _labelDistance.Size = new Size(106, 21);
            _labelDistance.TabIndex = 2;
            _labelDistance.Text = "Дистанция, м";
            // 
            // _comboBoxStyleSwimming
            // 
            _comboBoxStyleSwimming.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxStyleSwimming.FormattingEnabled = true;
            _comboBoxStyleSwimming.Location = new Point(18, 65);
            _comboBoxStyleSwimming.Name = "_comboBoxStyleSwimming";
            _comboBoxStyleSwimming.Size = new Size(292, 29);
            _comboBoxStyleSwimming.TabIndex = 1;
            _comboBoxStyleSwimming.SelectedIndexChanged += _comboBoxStyleSwimming_SelectedIndexChanged;
            // 
            // _labelStyleSwimming
            // 
            _labelStyleSwimming.AutoSize = true;
            _labelStyleSwimming.Location = new Point(18, 41);
            _labelStyleSwimming.Name = "_labelStyleSwimming";
            _labelStyleSwimming.Size = new Size(123, 21);
            _labelStyleSwimming.TabIndex = 2;
            _labelStyleSwimming.Text = "Стиль плавания";
            // 
            // AddSwimmingUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(_groupBoxSwimming);
            Name = "AddSwimmingUserControl";
            Size = new Size(346, 253);
            _groupBoxSwimming.ResumeLayout(false);
            _groupBoxSwimming.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        /// <summary>
        /// groupBox для типа упражнения плавание
        /// </summary>
        private GroupBox _groupBoxSwimming;

        /// <summary>
        /// textBox для Met для типа упражнения плавание
        /// </summary>
        private TextBox _textBoxMetSwimming;

        /// <summary>
        /// надпись для Met для типа упражнения плавание
        /// </summary>
        private Label _labelMetSwimming;

        /// <summary>
        /// textBox дистанция
        /// </summary>
        private TextBox _textBoxDistance;

        /// <summary>
        /// надпись для дистанции для типа упражнения плавание
        /// </summary>
        private Label _labelDistance;

        /// <summary>
        /// comboBox для стиля плавания
        /// </summary>
        private ComboBox _comboBoxStyleSwimming;

        /// <summary>
        /// надпись для стиля плавания для типа упражнения плавание
        /// </summary>
        private Label _labelStyleSwimming;
    }
}
