using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZakharovaYV.Sprint6.Task3.V18.Lib;

namespace Tyuiu.ZakharovaYV.Sprint6.Task3.V18
{
    public partial class FormMainTask3_ZYV : Form
    {
        public FormMainTask3_ZYV()
        {
            InitializeComponent();
        }

        private void buttonHelp_ZYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task3.V18. Выполнила студентка группы ПКТБ 23-2, Захарова Юлиана", "Сообщение");
        }
        DataService ds = new DataService();

        int[,] mtrx = new int[5, 5] { {-19, -19, 1, 18, 7},
                                      {5, 3, -4, -6, -12},
                                      {-15, 6, 2, 2, -14},
                                      {-9, -10, 15, -5, -6},
                                      {-13, -15, -9, 7, 1} };
        




        private void FormMainTask3_ZYV_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;


            //задаем ширину столбцов 
            for (int i = 0; i< columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 30;
            }

            for (int j = 0; j < columns; j++)
            {
                if (mtrx[3, j] % 2 == 0)
                {
                    mtrx[3, j] = 0;
                }
            }

            //заполняем сетку данными 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j<columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_ZYV_Click(object sender, EventArgs e)
        {
            textBoxResult_ZYV.Text = Convert.ToString(ds.Calculate(mtrx));
            textBoxResult_ZYV.Text = "";

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    textBoxResult_ZYV.Text += mtrx[i, j] + " ";
                }

                textBoxResult_ZYV.Text += "\r\n";
            }
        }
    }
}
