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

using Tyuiu.ZakharovaYV.Sprint6.Task5.V12.Lib;

namespace Tyuiu.ZakharovaYV.Sprint6.Task5.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\Users\USER\source\repos\Tyuiu.ZakharovaYV.Sprint6\Tyuiu.ZakharovaYV.Sprint6.Task5.V12\bin\Debug\InPutFileTask5V12.txt";

        private void buttonDone_ZYV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_ZYV.ColumnCount = 2;
            dataGridViewResult_ZYV.Columns[0].Width = 20;
            dataGridViewResult_ZYV.Columns[1].Width = 50;

            this.chartFunction_ZYV.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunction_ZYV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_ZYV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for(int i = 0; i<numsMass.Length; i++)
            {
                dataGridViewResult_ZYV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_ZYV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonHelp_ZYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task5.V12. Выполнила студентка группы ПКТБ 23-2, Захарова Юлиана", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_ZYV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
