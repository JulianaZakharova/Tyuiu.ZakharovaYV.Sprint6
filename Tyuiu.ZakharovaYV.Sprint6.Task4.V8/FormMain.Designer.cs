
namespace Tyuiu.ZakharovaYV.Sprint6.Task4.V8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxTask_ZYV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZYV = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_ZYV = new System.Windows.Forms.GroupBox();
            this.labelFinish_ZYV = new System.Windows.Forms.Label();
            this.labelStart_ZYV = new System.Windows.Forms.Label();
            this.textBoxFinish_ZYV = new System.Windows.Forms.TextBox();
            this.textBoxStart_ZYV = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_ZYV = new System.Windows.Forms.GroupBox();
            this.chartFunction_ZYV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxRezult_ZYV = new System.Windows.Forms.TextBox();
            this.buttonDone_ZYV = new System.Windows.Forms.Button();
            this.buttonHelp_ZYV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxTask_ZYV.SuspendLayout();
            this.groupBoxInPut_ZYV.SuspendLayout();
            this.groupBoxOutPut_ZYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZYV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZYV
            // 
            this.groupBoxTask_ZYV.Controls.Add(this.textBoxTask_ZYV);
            this.groupBoxTask_ZYV.Controls.Add(this.groupBox4);
            this.groupBoxTask_ZYV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ZYV.Name = "groupBoxTask_ZYV";
            this.groupBoxTask_ZYV.Size = new System.Drawing.Size(432, 91);
            this.groupBoxTask_ZYV.TabIndex = 1;
            this.groupBoxTask_ZYV.TabStop = false;
            this.groupBoxTask_ZYV.Text = "Условие";
            // 
            // textBoxTask_ZYV
            // 
            this.textBoxTask_ZYV.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_ZYV.Multiline = true;
            this.textBoxTask_ZYV.Name = "textBoxTask_ZYV";
            this.textBoxTask_ZYV.ReadOnly = true;
            this.textBoxTask_ZYV.Size = new System.Drawing.Size(413, 59);
            this.textBoxTask_ZYV.TabIndex = 1;
            this.textBoxTask_ZYV.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox. Построить график фуенкций  и сохранить в фаил\r\nOut PutFileTask. txt по на" +
    "жатии кнопки.";
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
            // groupBoxInPut_ZYV
            // 
            this.groupBoxInPut_ZYV.Controls.Add(this.labelFinish_ZYV);
            this.groupBoxInPut_ZYV.Controls.Add(this.labelStart_ZYV);
            this.groupBoxInPut_ZYV.Controls.Add(this.textBoxFinish_ZYV);
            this.groupBoxInPut_ZYV.Controls.Add(this.textBoxStart_ZYV);
            this.groupBoxInPut_ZYV.Location = new System.Drawing.Point(459, 12);
            this.groupBoxInPut_ZYV.Name = "groupBoxInPut_ZYV";
            this.groupBoxInPut_ZYV.Size = new System.Drawing.Size(312, 91);
            this.groupBoxInPut_ZYV.TabIndex = 2;
            this.groupBoxInPut_ZYV.TabStop = false;
            this.groupBoxInPut_ZYV.Text = "Ввод данных";
            // 
            // labelFinish_ZYV
            // 
            this.labelFinish_ZYV.AutoSize = true;
            this.labelFinish_ZYV.Location = new System.Drawing.Point(157, 22);
            this.labelFinish_ZYV.Name = "labelFinish_ZYV";
            this.labelFinish_ZYV.Size = new System.Drawing.Size(66, 13);
            this.labelFinish_ZYV.TabIndex = 1;
            this.labelFinish_ZYV.Text = "Конец шага";
            // 
            // labelStart_ZYV
            // 
            this.labelStart_ZYV.AutoSize = true;
            this.labelStart_ZYV.Location = new System.Drawing.Point(6, 22);
            this.labelStart_ZYV.Name = "labelStart_ZYV";
            this.labelStart_ZYV.Size = new System.Drawing.Size(64, 13);
            this.labelStart_ZYV.TabIndex = 1;
            this.labelStart_ZYV.Text = "Старт шага";
            // 
            // textBoxFinish_ZYV
            // 
            this.textBoxFinish_ZYV.Location = new System.Drawing.Point(160, 38);
            this.textBoxFinish_ZYV.Name = "textBoxFinish_ZYV";
            this.textBoxFinish_ZYV.Size = new System.Drawing.Size(146, 20);
            this.textBoxFinish_ZYV.TabIndex = 0;
            this.textBoxFinish_ZYV.Text = "5";
            // 
            // textBoxStart_ZYV
            // 
            this.textBoxStart_ZYV.Location = new System.Drawing.Point(6, 38);
            this.textBoxStart_ZYV.Name = "textBoxStart_ZYV";
            this.textBoxStart_ZYV.Size = new System.Drawing.Size(139, 20);
            this.textBoxStart_ZYV.TabIndex = 0;
            this.textBoxStart_ZYV.Text = "-5";
            // 
            // groupBoxOutPut_ZYV
            // 
            this.groupBoxOutPut_ZYV.Controls.Add(this.chartFunction_ZYV);
            this.groupBoxOutPut_ZYV.Controls.Add(this.textBoxRezult_ZYV);
            this.groupBoxOutPut_ZYV.Location = new System.Drawing.Point(18, 109);
            this.groupBoxOutPut_ZYV.Name = "groupBoxOutPut_ZYV";
            this.groupBoxOutPut_ZYV.Size = new System.Drawing.Size(1054, 436);
            this.groupBoxOutPut_ZYV.TabIndex = 3;
            this.groupBoxOutPut_ZYV.TabStop = false;
            this.groupBoxOutPut_ZYV.Text = "Вывод данных";
            // 
            // chartFunction_ZYV
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_ZYV.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_ZYV.Legends.Add(legend2);
            this.chartFunction_ZYV.Location = new System.Drawing.Point(234, 26);
            this.chartFunction_ZYV.Name = "chartFunction_ZYV";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_ZYV.Series.Add(series2);
            this.chartFunction_ZYV.Size = new System.Drawing.Size(742, 386);
            this.chartFunction_ZYV.TabIndex = 3;
            this.chartFunction_ZYV.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "График функций sin(x)";
            this.chartFunction_ZYV.Titles.Add(title2);
            // 
            // textBoxRezult_ZYV
            // 
            this.textBoxRezult_ZYV.Location = new System.Drawing.Point(6, 26);
            this.textBoxRezult_ZYV.Multiline = true;
            this.textBoxRezult_ZYV.Name = "textBoxRezult_ZYV";
            this.textBoxRezult_ZYV.Size = new System.Drawing.Size(205, 401);
            this.textBoxRezult_ZYV.TabIndex = 2;
            // 
            // buttonDone_ZYV
            // 
            this.buttonDone_ZYV.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_ZYV.Location = new System.Drawing.Point(777, 12);
            this.buttonDone_ZYV.Name = "buttonDone_ZYV";
            this.buttonDone_ZYV.Size = new System.Drawing.Size(117, 71);
            this.buttonDone_ZYV.TabIndex = 4;
            this.buttonDone_ZYV.Text = "Выполнить";
            this.buttonDone_ZYV.UseVisualStyleBackColor = false;
            this.buttonDone_ZYV.Click += new System.EventHandler(this.buttonDone_ZYV_Click);
            // 
            // buttonHelp_ZYV
            // 
            this.buttonHelp_ZYV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_ZYV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_ZYV.Location = new System.Drawing.Point(1018, 12);
            this.buttonHelp_ZYV.Name = "buttonHelp_ZYV";
            this.buttonHelp_ZYV.Size = new System.Drawing.Size(77, 71);
            this.buttonHelp_ZYV.TabIndex = 4;
            this.buttonHelp_ZYV.Text = "Справка";
            this.buttonHelp_ZYV.UseVisualStyleBackColor = false;
            this.buttonHelp_ZYV.Click += new System.EventHandler(this.buttonHelp_ZYV_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(900, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 557);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonHelp_ZYV);
            this.Controls.Add(this.buttonDone_ZYV);
            this.Controls.Add(this.groupBoxOutPut_ZYV);
            this.Controls.Add(this.groupBoxInPut_ZYV);
            this.Controls.Add(this.groupBoxTask_ZYV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 8  | Захарова Ю. В";
            this.groupBoxTask_ZYV.ResumeLayout(false);
            this.groupBoxTask_ZYV.PerformLayout();
            this.groupBoxInPut_ZYV.ResumeLayout(false);
            this.groupBoxInPut_ZYV.PerformLayout();
            this.groupBoxOutPut_ZYV.ResumeLayout(false);
            this.groupBoxOutPut_ZYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZYV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZYV;
        private System.Windows.Forms.TextBox textBoxTask_ZYV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBoxInPut_ZYV;
        private System.Windows.Forms.Label labelFinish_ZYV;
        private System.Windows.Forms.Label labelStart_ZYV;
        private System.Windows.Forms.TextBox textBoxFinish_ZYV;
        private System.Windows.Forms.TextBox textBoxStart_ZYV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_ZYV;
        private System.Windows.Forms.TextBox textBoxRezult_ZYV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZYV;
        private System.Windows.Forms.Button buttonDone_ZYV;
        private System.Windows.Forms.Button buttonHelp_ZYV;
        private System.Windows.Forms.Button button1;
    }
}

