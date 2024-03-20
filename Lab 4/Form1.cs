using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        private double[,] array = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
            // Отримання введених даних користувачем
            string input = txtArray.Text;
            string[] elements = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Конвертація рядка в масив чисел
            List<double> array = new List<double>();
            foreach (string element in elements)
            {
                if (!double.TryParse(element, out double number))
                {
                    MessageBox.Show("Помилка при введенні даних. Переконайтеся, що всі елементи масиву є числами.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                array.Add(number);
            }
            // Сортування масиву
            array.Sort((a, b) =>
            {
                if (Math.Abs(a) <= 1 && Math.Abs(b) <= 1)
                {
                    return a.CompareTo(b);
                }
                else if (Math.Abs(a) <= 1)
                {
                    return -1;
                }
                else if (Math.Abs(b) <= 1)
                {
                    return 1;
                }
                else
                {
                    return a.CompareTo(b);
                }
            });
            // Розрахунок кількості додатних елементів
            int positiveCount = array.Count(x => x > 0);

            // Розрахунок суми елементів після останнього нульового елемента
            double sumAfterLastZero = 0;
            bool foundZero = false;
            for (int i = array.Count - 1; i >= 0; i--)
            {
                if (foundZero)
                {
                    sumAfterLastZero += array[i];
                }
                else if (array[i] == 0)
                {
                    foundZero = true;
                }
            }
            // Виведення результатів на форму
            lblPositiveCount.Text = $"Кількість додатних елементів: {positiveCount}";
            lblSumAfterLastZero.Text = $"Сума елементів після останнього нульового: {sumAfterLastZero}";
            lblTransformedArray.Text = "Масив після перетворення: " + string.Join(", ", array);
        }
        private void InitializeDataGridView()
        {
            // Встановлення кількості рядків та стовпців у DataGridView
            dataGridView1.RowCount = array.GetLength(0);
            dataGridView1.ColumnCount = array.GetLength(1);

            // Заповнення DataGridView даними з двовимірного масиву
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = array[i, j];
                }
            }
        }

        private void btnShowFifthRow_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                dataGridView1.Rows[4].Cells[j].Style.BackColor = System.Drawing.Color.Green; // Позначимо рядок жовтим кольором
            }
        }

        private void btnShowColumn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtColumnIndex.Text, out int columnIndex) && columnIndex >= 0 && columnIndex < array.GetLength(1))
            {
                dataGridView1.Columns[columnIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow; // Позначимо стовпець жовтим кольором
            }
            else
            {
                MessageBox.Show("Неправильно введений індекс стовпця.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
