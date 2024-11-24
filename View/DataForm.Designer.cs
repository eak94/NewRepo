namespace View
{
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
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(54, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип упражнения";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 29);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(54, 403);
            button1.Name = "button1";
            button1.Size = new Size(319, 33);
            button1.TabIndex = 1;
            button1.Text = "Заполнить рандомными значениями";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(613, 403);
            button2.Name = "button2";
            button2.Size = new Size(77, 33);
            button2.TabIndex = 2;
            button2.Text = "Ок";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(494, 403);
            button3.Name = "button3";
            button3.Size = new Size(99, 33);
            button3.TabIndex = 3;
            button3.Text = "Отмена";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(54, 159);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 98);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Данные о человеке";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 66);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 29);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 0;
            label1.Text = "Вес, кг ";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 159);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(54, 274);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(254, 101);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Данные о тренировке ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 66);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(16, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 29);
            textBox3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 34);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 0;
            label6.Text = "Время, ч";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(339, 44);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(351, 331);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Данные по типу упражнения";
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(723, 458);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "DataForm";
            Text = "Добавить расчет каллорий";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private GroupBox groupBox4;
    }
}