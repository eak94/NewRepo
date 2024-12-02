﻿namespace View
{
    /// <summary>
    /// Класс NumericBox.
    /// </summary>
    public class NumBox : TextBox
    {
        /// <summary>
        /// Конструктор класса NumericBox.
        /// </summary>
        public NumBox()
        {
            KeyPress += new KeyPressEventHandler(CheckInput);
        }
        /// <summary>
        /// Корректировка ввода данных
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Объект, содержащий данные о событии</param>
        private void CheckInput(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol == '.' || symbol == ',' || symbol == '-')
                && (Text.IndexOf(',') != -1))
            {
                e.Handled = true;
                return;
            }

            if ((symbol == '-')
                && Text.IndexOf('-') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(symbol) && symbol != (char)Keys.Back
                && symbol != ',' && symbol != '.' && symbol != '-')
            {
                e.Handled = true;
            }

            if (symbol == '.')
            {
                e.KeyChar = ',';
            }
        }
    }
}
