using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ZakharovaYV.Sprint6.Task0.V23.Lib;

namespace Tyuiu.ZakharovaYV.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_ZYV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_ZYV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_ZYV.Text)));
            }
            catch 
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxInput_ZYV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<=47 || e.KeyChar>= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_ZYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 0 выполнила студентка группы ПКТБ 23-2, Захарова Юлиана  ", "Сообщение");
        }
    }
}
