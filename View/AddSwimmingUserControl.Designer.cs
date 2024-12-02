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
        /// Освободить все используемые ресурсы
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
            _labelStyleSwimming = new Label();
            _comboBoxStyleSwimming = new ComboBox();
            _labelDistance = new Label();
            _numBoxDistance = new NumBox();
            SuspendLayout();
            // 
            // _labelStyleSwimming
            // 
            _labelStyleSwimming.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _labelStyleSwimming.AutoSize = true;
            _labelStyleSwimming.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _labelStyleSwimming.Location = new Point(12, 23);
            _labelStyleSwimming.Name = "_labelStyleSwimming";
            _labelStyleSwimming.Size = new Size(123, 21);
            _labelStyleSwimming.TabIndex = 2;
            _labelStyleSwimming.Text = "Стиль плавания";
            // 
            // _comboBoxStyleSwimming
            // 
            _comboBoxStyleSwimming.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _comboBoxStyleSwimming.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxStyleSwimming.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _comboBoxStyleSwimming.FormattingEnabled = true;
            _comboBoxStyleSwimming.Location = new Point(141, 20);
            _comboBoxStyleSwimming.Name = "_comboBoxStyleSwimming";
            _comboBoxStyleSwimming.Size = new Size(150, 29);
            _comboBoxStyleSwimming.TabIndex = 1;
            // 
            // _labelDistance
            // 
            _labelDistance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _labelDistance.AutoSize = true;
            _labelDistance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _labelDistance.Location = new Point(12, 77);
            _labelDistance.Name = "_labelDistance";
            _labelDistance.Size = new Size(106, 21);
            _labelDistance.TabIndex = 2;
            _labelDistance.Text = "Дистанция, м";
            // 
            // _numBoxDistance
            // 
            _numBoxDistance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _numBoxDistance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _numBoxDistance.Location = new Point(199, 74);
            _numBoxDistance.Name = "_numBoxDistance";
            _numBoxDistance.Size = new Size(92, 29);
            _numBoxDistance.TabIndex = 2;
            // 
            // AddSwimmingUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(_labelDistance);
            Controls.Add(_numBoxDistance);
            Controls.Add(_labelStyleSwimming);
            Controls.Add(_comboBoxStyleSwimming);
            Name = "AddSwimmingUserControl";
            Size = new Size(315, 117);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        /// <summary>
        /// Надпись для стиля плавания
        /// </summary>
        private Label _labelStyleSwimming;

        /// <summary>
        /// comboBox
        /// </summary>
        private ComboBox _comboBoxStyleSwimming;

        /// <summary>
        /// надпись ", м"
        /// </summary>
        private Label _labelDistance;

        /// <summary>
        /// NumBox дистанция
        /// </summary>
        private NumBox _numBoxDistance;
    }
}
