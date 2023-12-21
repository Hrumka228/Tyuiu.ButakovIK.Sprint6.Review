using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ButakovIK.Sprint6.Review.V24.Lib;

namespace Tyuiu.ButakovIK.Sprint6.Review.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        public int[,] valueArray;
        public int rows;
        public int columns;
        public int randomStart;
        public int randomStop;
        public int elemStart;
        public int elemEnd;
        public int selectR;

        private void buttonMatrix_BIK_Click_1(object sender, EventArgs e)
        {
            try
            {
                rows = Convert.ToInt32(textBoxRows_BIK.Text);
                columns = Convert.ToInt32(textBoxColumns_BIK.Text);
                randomStart = Convert.ToInt32(textBoxStartRange_BIK.Text);
                randomStop = Convert.ToInt32(textBoxStopRange_BIK.Text);

                Random rnd = new Random();

                valueArray = new int[rows, columns];

                dataGridViewMatrix_BIK.RowCount = valueArray.GetLength(0);
                dataGridViewMatrix_BIK.ColumnCount = valueArray.GetLength(1);


                bool isNegative = rnd.Next(0, 2) == 0;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        valueArray[i, j] = rnd.Next(randomStart, randomStop);

                        if (isNegative)
                        {
                            valueArray[i, j] *= -1;
                        }
                        isNegative = !isNegative;

                        dataGridViewMatrix_BIK.Rows[i].Cells[j].Value = valueArray[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_BIK_Click(object sender, EventArgs e)
        {
            try
            {
                elemStart = Convert.ToInt32(textBoxStartElemColumns_BIK.Text);
                elemEnd = Convert.ToInt32(textBoxStopElemRows_BIK.Text);
                selectR = Convert.ToInt32(textBoxSelectRow_BIK.Text);


                if (valueArray != null && selectR >= 0 && selectR < rows)
                {
                    int res = DataService.GetMatrix(valueArray, selectR, elemStart, elemEnd);
                    textBoxResult_BIK.Text = Convert.ToString(res);
                }
                else
                {
                    MessageBox.Show("Матрица не инициализирована или выбрана неверная строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные для выполнения вычислений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
