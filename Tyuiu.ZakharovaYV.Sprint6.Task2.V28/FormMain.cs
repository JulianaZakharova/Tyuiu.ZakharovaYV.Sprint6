using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZakharovaYV.Sprint6.Task2.V28.Lib;

namespace Tyuiu.ZakharovaYV.Sprint6.Task2.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_ZYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task2.V28. Выполнила студентка группы ПКТБ 23-2, Захарова Юлиана", "Сообщение");
        }

        DataService ds = new DataService();
        private void buttonDone_ZYV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_ZYV.Text);
                int stopStep = Convert.ToInt32(textBoxFinish_ZYV.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.Titles.Add("График функций sin(x)");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
           
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_ZYV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_ZYV.BackColor = Color.Red;
        }

        private void buttonDone_ZYV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_ZYV.BackColor = Color.Green;
        }

        private void buttonDone_ZYV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_ZYV.BackColor = Color.Blue;
        }
    }
}
