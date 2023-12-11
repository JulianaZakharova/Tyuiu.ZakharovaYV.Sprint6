using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZakharovaYV.Sprint6.Task6.V9.Lib;
using System.IO;

namespace Tyuiu.ZakharovaYV.Sprint6.Task6.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath = @"C:\DataSprint6\InPutFileTask6V9.txt";
        DataService DataService = new DataService();

        private void buttonOpenFile_ZYV_Click(object sender, EventArgs e)
        {
            openFileDialog_ZYV.ShowDialog();
            openFilePath = openFileDialog_ZYV.FileName;
            textBoxUslovie_ZYV.Text = File.ReadAllText(openFilePath);
            groupBoxResult_ZYV.Text = groupBoxResult_ZYV.Text + " " + openFileDialog_ZYV.FileName;
            buttonDone_ZYV.Enabled = true;

        }

        private void buttonDone_ZYV_Click(object sender, EventArgs e)
        {
           
            try
            {
                string str = " ";
                textBoxResult_ZYV.Text = DataService.CollectTextFromFile(str, openFilePath);
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZYV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
