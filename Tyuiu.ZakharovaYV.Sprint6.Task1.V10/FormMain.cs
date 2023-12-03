using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZakharovaYV.Sprint6.Task1.V10.Lib;

namespace Tyuiu.ZakharovaYV.Sprint6.Task1.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService(); // будет доступно всем событиям на форме
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
                textBoxResult_ZYV.Text = "";
                textBoxResult_ZYV.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_ZYV.AppendText(" |    x      |   f(x)    | " + Environment.NewLine);
                textBoxResult_ZYV.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i<= len - 1; i++)
                {
                    strLine = String.Format(" | {0,7:d}  | {1,7 :f2}  | ", startStep, valueArray[i]);
                    textBoxResult_ZYV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_ZYV.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_ZYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 1. V10. Выполнила студентка группы ПКТБ 23-2, Захарова Юлиана  ", "Сообщение");
        }
    }
}
