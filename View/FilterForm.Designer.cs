namespace View
{
    /// <summary>
    /// Класс для фильтрации
    /// </summary>
    partial class FilterForm
    {
        /// <summary>
        /// Необходимая переменная дизайнера.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Метод для явного освобождения ресурсов.
        /// </summary>
        /// <param name="disposing">true если ресурсы необходимо
        /// удалить,иначе false</param>
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
            _groupBoxFilterExercise = new GroupBox();
            _checkBoxWeightLifting = new CheckBox();
            _checkBoxSwimming = new CheckBox();
            _checkBoxRunning = new CheckBox();
            _groupBoxFilterWeightPerson = new GroupBox();
            _textBoxWeightPerson = new TextBox();
            _checkBoxWeightPerson = new CheckBox();
            _buttonAgree = new Button();
            _groupBoxTime = new GroupBox();
            _textBoxTime = new TextBox();
            _checkBoxTime = new CheckBox();
            _groupBoxFilterExercise.SuspendLayout();
            _groupBoxFilterWeightPerson.SuspendLayout();
            _groupBoxTime.SuspendLayout();
            SuspendLayout();
            // 
            // _groupBoxFilterExercise
            // 
            _groupBoxFilterExercise.Controls.Add(_checkBoxWeightLifting);
            _groupBoxFilterExercise.Controls.Add(_checkBoxSwimming);
            _groupBoxFilterExercise.Controls.Add(_checkBoxRunning);
            _groupBoxFilterExercise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _groupBoxFilterExercise.Location = new Point(35, 30);
            _groupBoxFilterExercise.Name = "_groupBoxFilterExercise";
            _groupBoxFilterExercise.Size = new Size(335, 140);
            _groupBoxFilterExercise.TabIndex = 0;
            _groupBoxFilterExercise.TabStop = false;
            _groupBoxFilterExercise.Text = "По типу упражения ";
            // 
            // _checkBoxWeightLifting
            // 
            _checkBoxWeightLifting.AutoSize = true;
            _checkBoxWeightLifting.Location = new Point(15, 100);
            _checkBoxWeightLifting.Name = "_checkBoxWeightLifting";
            _checkBoxWeightLifting.Size = new Size(156, 25);
            _checkBoxWeightLifting.TabIndex = 2;
            _checkBoxWeightLifting.Text = "Тяжелая атлетика";
            _checkBoxWeightLifting.UseVisualStyleBackColor = true;
            // 
            // _checkBoxSwimming
            // 
            _checkBoxSwimming.AutoSize = true;
            _checkBoxSwimming.Location = new Point(15, 65);
            _checkBoxSwimming.Name = "_checkBoxSwimming";
            _checkBoxSwimming.Size = new Size(98, 25);
            _checkBoxSwimming.TabIndex = 1;
            _checkBoxSwimming.Text = "Плавание";
            _checkBoxSwimming.UseVisualStyleBackColor = true;
            // 
            // _checkBoxRunning
            // 
            _checkBoxRunning.AutoSize = true;
            _checkBoxRunning.Location = new Point(15, 31);
            _checkBoxRunning.Name = "_checkBoxRunning";
            _checkBoxRunning.Size = new Size(52, 25);
            _checkBoxRunning.TabIndex = 0;
            _checkBoxRunning.Text = "Бег";
            _checkBoxRunning.UseVisualStyleBackColor = true;
            // 
            // _groupBoxFilterWeightPerson
            // 
            _groupBoxFilterWeightPerson.Controls.Add(_textBoxWeightPerson);
            _groupBoxFilterWeightPerson.Controls.Add(_checkBoxWeightPerson);
            _groupBoxFilterWeightPerson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _groupBoxFilterWeightPerson.Location = new Point(35, 188);
            _groupBoxFilterWeightPerson.Name = "_groupBoxFilterWeightPerson";
            _groupBoxFilterWeightPerson.Size = new Size(335, 79);
            _groupBoxFilterWeightPerson.TabIndex = 1;
            _groupBoxFilterWeightPerson.TabStop = false;
            _groupBoxFilterWeightPerson.Text = "По данным человека";
            // 
            // _textBoxWeightPerson
            // 
            _textBoxWeightPerson.Location = new Point(259, 35);
            _textBoxWeightPerson.Name = "_textBoxWeightPerson";
            _textBoxWeightPerson.Size = new Size(59, 29);
            _textBoxWeightPerson.TabIndex = 4;
            // 
            // _checkBoxWeightPerson
            // 
            _checkBoxWeightPerson.AutoSize = true;
            _checkBoxWeightPerson.Location = new Point(15, 39);
            _checkBoxWeightPerson.Name = "_checkBoxWeightPerson";
            _checkBoxWeightPerson.Size = new Size(74, 25);
            _checkBoxWeightPerson.TabIndex = 3;
            _checkBoxWeightPerson.Text = "Вес, кг";
            _checkBoxWeightPerson.UseVisualStyleBackColor = true;
            // 
            // _buttonAgree
            // 
            _buttonAgree.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _buttonAgree.Location = new Point(230, 379);
            _buttonAgree.Name = "_buttonAgree";
            _buttonAgree.Size = new Size(140, 31);
            _buttonAgree.TabIndex = 2;
            _buttonAgree.Text = "Применить";
            _buttonAgree.UseVisualStyleBackColor = true;
            // 
            // _groupBoxTime
            // 
            _groupBoxTime.Controls.Add(_textBoxTime);
            _groupBoxTime.Controls.Add(_checkBoxTime);
            _groupBoxTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _groupBoxTime.Location = new Point(35, 284);
            _groupBoxTime.Name = "_groupBoxTime";
            _groupBoxTime.Size = new Size(335, 79);
            _groupBoxTime.TabIndex = 5;
            _groupBoxTime.TabStop = false;
            _groupBoxTime.Text = "По времени тренировки";
            // 
            // _textBoxTime
            // 
            _textBoxTime.Location = new Point(259, 35);
            _textBoxTime.Name = "_textBoxTime";
            _textBoxTime.Size = new Size(59, 29);
            _textBoxTime.TabIndex = 4;
            // 
            // _checkBoxTime
            // 
            _checkBoxTime.AutoSize = true;
            _checkBoxTime.Location = new Point(15, 39);
            _checkBoxTime.Name = "_checkBoxTime";
            _checkBoxTime.Size = new Size(179, 25);
            _checkBoxTime.TabIndex = 3;
            _checkBoxTime.Text = "Время тренировки, ч";
            _checkBoxTime.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(408, 436);
            Controls.Add(_groupBoxTime);
            Controls.Add(_buttonAgree);
            Controls.Add(_groupBoxFilterWeightPerson);
            Controls.Add(_groupBoxFilterExercise);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FilterForm";
            Text = "Фильтр";
            _groupBoxFilterExercise.ResumeLayout(false);
            _groupBoxFilterExercise.PerformLayout();
            _groupBoxFilterWeightPerson.ResumeLayout(false);
            _groupBoxFilterWeightPerson.PerformLayout();
            _groupBoxTime.ResumeLayout(false);
            _groupBoxTime.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        /// <summary>
        /// groupBox для фильтрации по весу человека
        /// </summary>
        private CheckBox _checkBoxWeightPerson;

        /// <summary>
        /// checkBox для фильтрации 
        /// по времени тренировки
        /// </summary>
        private CheckBox _checkBoxTime;

        /// <summary>
        /// checkBox для фильтрации по 
        /// типу упражнения жиму штанги
        /// </summary>
        private CheckBox _checkBoxWeightLifting;

        /// <summary>
        /// checkBox для фильтрации по 
        /// типу упраженения плавание
        /// </summary>
        private CheckBox _checkBoxSwimming;

        /// <summary>
        /// checkBox для фильтрации по 
        /// типу упраженения бег
        /// </summary>
        private CheckBox _checkBoxRunning;

        /// <summary>
        /// groupBox для фильтрации по типу упражения
        /// </summary>
        private GroupBox _groupBoxFilterExercise;

        /// <summary>
        /// groupBox для фильтрации 
        /// по времени тренировки
        /// </summary>
        private GroupBox _groupBoxTime;

        /// <summary>
        /// groupBox для фильтрации 
        /// по данным о человеке
        /// </summary>
        private GroupBox _groupBoxFilterWeightPerson;

        /// <summary>
        /// Кнопка "Ок"
        /// </summary>
        private Button _buttonAgree;

        /// <summary>
        /// textBox ", кг"
        /// </summary>
        private TextBox _textBoxWeightPerson;

        /// <summary>
        /// textBox ", ч"
        /// </summary>
        private TextBox _textBoxTime;

    }
}