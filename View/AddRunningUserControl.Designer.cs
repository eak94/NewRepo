namespace View
{
    partial class UserControl1
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
            _groupBoxRunning = new GroupBox();
            _textBoxMetRunning = new TextBox();
            _labelMetRunning = new Label();
            _textBoxDistance = new TextBox();
            _labelDistance = new Label();
            _comboBoxIntensity = new ComboBox();
            _labelIntensity = new Label();
            _groupBoxRunning.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBoxRunning
            // 
            _groupBoxRunning.Controls.Add(_textBoxMetRunning);
            _groupBoxRunning.Controls.Add(_labelMetRunning);
            _groupBoxRunning.Controls.Add(_textBoxDistance);
            _groupBoxRunning.Controls.Add(_labelDistance);
            _groupBoxRunning.Controls.Add(_comboBoxIntensity);
            _groupBoxRunning.Controls.Add(_labelIntensity);
            _groupBoxRunning.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _groupBoxRunning.Location = new Point(3, 3);
            _groupBoxRunning.Name = "_groupBoxRunning";
            _groupBoxRunning.Size = new Size(335, 243);
            _groupBoxRunning.TabIndex = 1;
            _groupBoxRunning.TabStop = false;
            _groupBoxRunning.Text = "Параметры бега";
            // 
            // _textBoxMetRunning
            // 
            _textBoxMetRunning.Location = new Point(18, 125);
            _textBoxMetRunning.Name = "_textBoxMetRunning";
            _textBoxMetRunning.Size = new Size(292, 29);
            _textBoxMetRunning.TabIndex = 5;
            // 
            // _labelMetRunning
            // 
            _labelMetRunning.AutoSize = true;
            _labelMetRunning.Location = new Point(21, 101);
            _labelMetRunning.Name = "_labelMetRunning";
            _labelMetRunning.Size = new Size(40, 21);
            _labelMetRunning.TabIndex = 4;
            _labelMetRunning.Text = "MET";
            // 
            // _textBoxDistance
            // 
            _textBoxDistance.Location = new Point(18, 190);
            _textBoxDistance.Name = "_textBoxDistance";
            _textBoxDistance.Size = new Size(292, 29);
            _textBoxDistance.TabIndex = 2;
            // 
            // _labelDistance
            // 
            _labelDistance.AutoSize = true;
            _labelDistance.BackColor = SystemColors.ButtonFace;
            _labelDistance.Location = new Point(18, 166);
            _labelDistance.Name = "_labelDistance";
            _labelDistance.Size = new Size(114, 21);
            _labelDistance.TabIndex = 2;
            _labelDistance.Text = "Дистанция, км";
            // 
            // _comboBoxIntensity
            // 
            _comboBoxIntensity.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxIntensity.FormattingEnabled = true;
            _comboBoxIntensity.Location = new Point(18, 65);
            _comboBoxIntensity.Name = "_comboBoxIntensity";
            _comboBoxIntensity.Size = new Size(292, 29);
            _comboBoxIntensity.TabIndex = 1;
            // 
            // _labelIntensity
            // 
            _labelIntensity.AutoSize = true;
            _labelIntensity.Location = new Point(18, 41);
            _labelIntensity.Name = "_labelIntensity";
            _labelIntensity.Size = new Size(160, 21);
            _labelIntensity.TabIndex = 2;
            _labelIntensity.Text = "Интенсивность, км/ч";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_groupBoxRunning);
            Name = "UserControl1";
            Size = new Size(346, 251);
            _groupBoxRunning.ResumeLayout(false);
            _groupBoxRunning.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        /// <summary>
        /// groupBox для типа упражнения бег
        /// </summary>
        private GroupBox _groupBoxRunning;

        /// <summary>
        /// textBox Met для типа упражнения бег
        /// </summary>
        private TextBox _textBoxMetRunning;

        /// <summary>
        /// надпись для Met для типа упражнения бег
        /// </summary>
        private Label _labelMetRunning;

        /// <summary>
        /// textBox дистанция для типа упражнения бег
        /// </summary>
        private TextBox _textBoxDistance;

        /// <summary>
        /// надпись для дистанции для типа упражнения бег
        /// </summary>
        private Label _labelDistance;

        /// <summary>
        /// comboBox интенсивность
        /// </summary>
        private ComboBox _comboBoxIntensity;

        /// <summary>
        /// надпись для интенсивность для типа упржнения бег
        /// </summary>
        private Label _labelIntensity;
    }
}
