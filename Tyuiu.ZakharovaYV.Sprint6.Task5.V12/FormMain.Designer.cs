
namespace Tyuiu.ZakharovaYV.Sprint6.Task5.V12
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1_ZYV = new System.Windows.Forms.Panel();
            this.buttonHelp_ZYV = new System.Windows.Forms.Button();
            this.buttonOpenFile_ZYV = new System.Windows.Forms.Button();
            this.buttonDone_ZYV = new System.Windows.Forms.Button();
            this.groupBoxTask_ZYV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZYV = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2_ZYV = new System.Windows.Forms.Panel();
            this.groupBoxResult_ZYV = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_ZYV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartFunction_ZYV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1_ZYV.SuspendLayout();
            this.groupBoxTask_ZYV.SuspendLayout();
            this.panel2_ZYV.SuspendLayout();
            this.groupBoxResult_ZYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ZYV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZYV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_ZYV
            // 
            this.panel1_ZYV.Controls.Add(this.buttonHelp_ZYV);
            this.panel1_ZYV.Controls.Add(this.buttonOpenFile_ZYV);
            this.panel1_ZYV.Controls.Add(this.buttonDone_ZYV);
            this.panel1_ZYV.Controls.Add(this.groupBoxTask_ZYV);
            this.panel1_ZYV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_ZYV.Location = new System.Drawing.Point(0, 0);
            this.panel1_ZYV.Name = "panel1_ZYV";
            this.panel1_ZYV.Size = new System.Drawing.Size(800, 119);
            this.panel1_ZYV.TabIndex = 0;
            // 
            // buttonHelp_ZYV
            // 
            this.buttonHelp_ZYV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZYV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_ZYV.Location = new System.Drawing.Point(711, 12);
            this.buttonHelp_ZYV.Name = "buttonHelp_ZYV";
            this.buttonHelp_ZYV.Size = new System.Drawing.Size(77, 71);
            this.buttonHelp_ZYV.TabIndex = 7;
            this.buttonHelp_ZYV.Text = "Справка";
            this.buttonHelp_ZYV.UseVisualStyleBackColor = false;
            this.buttonHelp_ZYV.Click += new System.EventHandler(this.buttonHelp_ZYV_Click);
            // 
            // buttonOpenFile_ZYV
            // 
            this.buttonOpenFile_ZYV.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonOpenFile_ZYV.Location = new System.Drawing.Point(573, 12);
            this.buttonOpenFile_ZYV.Name = "buttonOpenFile_ZYV";
            this.buttonOpenFile_ZYV.Size = new System.Drawing.Size(94, 71);
            this.buttonOpenFile_ZYV.TabIndex = 6;
            this.buttonOpenFile_ZYV.Text = "Открыть файл";
            this.buttonOpenFile_ZYV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_ZYV.Click += new System.EventHandler(this.buttonOpenFile_ZYV_Click);
            // 
            // buttonDone_ZYV
            // 
            this.buttonDone_ZYV.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_ZYV.Location = new System.Drawing.Point(450, 12);
            this.buttonDone_ZYV.Name = "buttonDone_ZYV";
            this.buttonDone_ZYV.Size = new System.Drawing.Size(117, 71);
            this.buttonDone_ZYV.TabIndex = 5;
            this.buttonDone_ZYV.Text = "Выполнить";
            this.buttonDone_ZYV.UseVisualStyleBackColor = false;
            this.buttonDone_ZYV.Click += new System.EventHandler(this.buttonDone_ZYV_Click);
            // 
            // groupBoxTask_ZYV
            // 
            this.groupBoxTask_ZYV.Controls.Add(this.textBoxTask_ZYV);
            this.groupBoxTask_ZYV.Controls.Add(this.groupBox4);
            this.groupBoxTask_ZYV.Location = new System.Drawing.Point(12, 3);
            this.groupBoxTask_ZYV.Name = "groupBoxTask_ZYV";
            this.groupBoxTask_ZYV.Size = new System.Drawing.Size(432, 91);
            this.groupBoxTask_ZYV.TabIndex = 2;
            this.groupBoxTask_ZYV.TabStop = false;
            this.groupBoxTask_ZYV.Text = "Условие";
            // 
            // textBoxTask_ZYV
            // 
            this.textBoxTask_ZYV.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_ZYV.Multiline = true;
            this.textBoxTask_ZYV.Name = "textBoxTask_ZYV";
            this.textBoxTask_ZYV.ReadOnly = true;
            this.textBoxTask_ZYV.Size = new System.Drawing.Size(420, 50);
            this.textBoxTask_ZYV.TabIndex = 1;
            this.textBoxTask_ZYV.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в DataGridView\r\n все числа " +
    "кратные 5 и построить диаграмму по этим значениям.";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(0, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(445, 144);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox1";
            // 
            // panel2_ZYV
            // 
            this.panel2_ZYV.Controls.Add(this.groupBoxResult_ZYV);
            this.panel2_ZYV.Controls.Add(this.panel1);
            this.panel2_ZYV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2_ZYV.Location = new System.Drawing.Point(0, 119);
            this.panel2_ZYV.Name = "panel2_ZYV";
            this.panel2_ZYV.Size = new System.Drawing.Size(200, 331);
            this.panel2_ZYV.TabIndex = 1;
            // 
            // groupBoxResult_ZYV
            // 
            this.groupBoxResult_ZYV.Controls.Add(this.dataGridViewResult_ZYV);
            this.groupBoxResult_ZYV.Location = new System.Drawing.Point(3, 6);
            this.groupBoxResult_ZYV.Name = "groupBoxResult_ZYV";
            this.groupBoxResult_ZYV.Size = new System.Drawing.Size(194, 313);
            this.groupBoxResult_ZYV.TabIndex = 3;
            this.groupBoxResult_ZYV.TabStop = false;
            this.groupBoxResult_ZYV.Text = "Вывод данных";
            // 
            // dataGridViewResult_ZYV
            // 
            this.dataGridViewResult_ZYV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_ZYV.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewResult_ZYV.Name = "dataGridViewResult_ZYV";
            this.dataGridViewResult_ZYV.Size = new System.Drawing.Size(182, 279);
            this.dataGridViewResult_ZYV.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(206, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 331);
            this.panel1.TabIndex = 2;
            // 
            // chartFunction_ZYV
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction_ZYV.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction_ZYV.Legends.Add(legend3);
            this.chartFunction_ZYV.Location = new System.Drawing.Point(219, 129);
            this.chartFunction_ZYV.Name = "chartFunction_ZYV";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction_ZYV.Series.Add(series3);
            this.chartFunction_ZYV.Size = new System.Drawing.Size(569, 318);
            this.chartFunction_ZYV.TabIndex = 2;
            this.chartFunction_ZYV.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartFunction_ZYV);
            this.Controls.Add(this.panel2_ZYV);
            this.Controls.Add(this.panel1_ZYV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 12  | Захарова Ю. В";
            this.panel1_ZYV.ResumeLayout(false);
            this.groupBoxTask_ZYV.ResumeLayout(false);
            this.groupBoxTask_ZYV.PerformLayout();
            this.panel2_ZYV.ResumeLayout(false);
            this.groupBoxResult_ZYV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_ZYV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZYV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_ZYV;
        private System.Windows.Forms.GroupBox groupBoxTask_ZYV;
        private System.Windows.Forms.TextBox textBoxTask_ZYV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDone_ZYV;
        private System.Windows.Forms.Button buttonOpenFile_ZYV;
        private System.Windows.Forms.Button buttonHelp_ZYV;
        private System.Windows.Forms.Panel panel2_ZYV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxResult_ZYV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZYV;
        private System.Windows.Forms.DataGridView dataGridViewResult_ZYV;
    }
}

