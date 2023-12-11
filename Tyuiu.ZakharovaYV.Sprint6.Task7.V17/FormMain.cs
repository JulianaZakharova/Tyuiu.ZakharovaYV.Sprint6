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
using Tyuiu.ZakharovaYV.Sprint6.Task7.V17.Lib;

namespace Tyuiu.ZakharovaYV.Sprint6.Task7.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_ZYV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialog_ZYV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
     
        static int rows;
        static int columns;
        string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            //разделяем на строки
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            //определяем колличество строк и столбцов
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            // выделяем массив данных
            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)//заполняем массив данными
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpenFile_ZYV_Click(object sender, EventArgs e)
        {
            openFileDialog_ZYV.ShowDialog();
            openFilePath = openFileDialog_ZYV.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);
            dataGridViewInp_ZYV.ColumnCount = columns;
            dataGridViewInp_ZYV.RowCount = rows;
            dataGridViewOutPut_ZYV.ColumnCount = columns;
            dataGridViewOutPut_ZYV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInp_ZYV.Columns[i].Width = 25;
                dataGridViewOutPut_ZYV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInp_ZYV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonSafeFile_ZYV.Enabled = true;
        }

        private void buttonDone_ZYV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_ZYV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSafeFile_ZYV.Enabled = true;
        }

        private void buttonSafeFile_ZYV_Click(object sender, EventArgs e)
        {
            saveFileDialog_ZYV.FileName = "OutPutFileTask7.csv";
            saveFileDialog_ZYV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_ZYV.ShowDialog();

            string path = openFileDialog_ZYV.FileName;
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutPut_ZYV.RowCount;
            int columns = dataGridViewOutPut_ZYV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_ZYV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_ZYV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_ZYV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
