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
            _labelStyleSwimming = new Label();
            _comboBoxStyleSwimming = new ComboBox();
            _labelDistance = new Label();
            _textBoxDistance = new TextBox();
            _labelMetSwimming = new Label();
            _textBoxMetSwimming = new TextBox();
            SuspendLayout();
            // 
            // _labelStyleSwimming
            // 
            _labelStyleSwimming.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _labelStyleSwimming.AutoSize = true;
            _labelStyleSwimming.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _labelStyleSwimming.Location = new Point(45, 63);
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
            _comboBoxStyleSwimming.Location = new Point(50, 87);
            _comboBoxStyleSwimming.Name = "_comboBoxStyleSwimming";
            _comboBoxStyleSwimming.Size = new Size(289, 29);
            _comboBoxStyleSwimming.TabIndex = 1;
            _comboBoxStyleSwimming.SelectedIndexChanged += _comboBoxStyleSwimming_SelectedIndexChanged;
            // 
            // _labelDistance
            // 
            _labelDistance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _labelDistance.AutoSize = true;
            _labelDistance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _labelDistance.Location = new Point(45, 197);
            _labelDistance.Name = "_labelDistance";
            _labelDistance.Size = new Size(106, 21);
            _labelDistance.TabIndex = 2;
            _labelDistance.Text = "Дистанция, м";
            // 
            // _textBoxDistance
            // 
            _textBoxDistance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _textBoxDistance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _textBoxDistance.Location = new Point(48, 221);
            _textBoxDistance.Name = "_textBoxDistance";
            _textBoxDistance.Size = new Size(289, 29);
            _textBoxDistance.TabIndex = 2;
            // 
            // _labelMetSwimming
            // 
            _labelMetSwimming.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _labelMetSwimming.AutoSize = true;
            _labelMetSwimming.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _labelMetSwimming.Location = new Point(48, 128);
            _labelMetSwimming.Name = "_labelMetSwimming";
            _labelMetSwimming.Size = new Size(40, 21);
            _labelMetSwimming.TabIndex = 4;
            _labelMetSwimming.Text = "MET";
            // 
            // _textBoxMetSwimming
            // 
            _textBoxMetSwimming.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _textBoxMetSwimming.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _textBoxMetSwimming.Location = new Point(48, 152);
            _textBoxMetSwimming.Name = "_textBoxMetSwimming";
            _textBoxMetSwimming.Size = new Size(289, 29);
            _textBoxMetSwimming.TabIndex = 5;
            // 
            // AddSwimmingUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(_textBoxMetSwimming);
            Controls.Add(_labelMetSwimming);
            Controls.Add(_labelDistance);
            Controls.Add(_textBoxDistance);
            Controls.Add(_labelStyleSwimming);
            Controls.Add(_comboBoxStyleSwimming);
            Name = "AddSwimmingUserControl";
            Size = new Size(387, 321);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _labelStyleSwimming;
        private ComboBox _comboBoxStyleSwimming;
        private Label _labelDistance;
        private TextBox _textBoxDistance;
        private Label _labelMetSwimming;
        private TextBox _textBoxMetSwimming;
    }
}
