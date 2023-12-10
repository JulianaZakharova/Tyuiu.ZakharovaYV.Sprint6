
namespace Tyuiu.ZakharovaYV.Sprint6.Task2.V28
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
            this.groupBoxTask_ZYV = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTask_ZYV = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBoxInPut_ZYV = new System.Windows.Forms.GroupBox();
            this.labelFinish_ZYV = new System.Windows.Forms.Label();
            this.labelStart_ZYV = new System.Windows.Forms.Label();
            this.textBoxFinish_ZYV = new System.Windows.Forms.TextBox();
            this.textBoxStart_ZYV = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_ZYV = new System.Windows.Forms.GroupBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_ZYV = new System.Windows.Forms.Button();
            this.buttonHelp_ZYV = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBoxTask_ZYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInPut_ZYV.SuspendLayout();
            this.groupBoxOutPut_ZYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZYV
            // 
            this.groupBoxTask_ZYV.Controls.Add(this.pictureBox1);
            this.groupBoxTask_ZYV.Controls.Add(this.textBoxTask_ZYV);
            this.groupBoxTask_ZYV.Controls.Add(this.groupBox4);
            this.groupBoxTask_ZYV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ZYV.Name = "groupBoxTask_ZYV";
            this.groupBoxTask_ZYV.Size = new System.Drawing.Size(545, 267);
            this.groupBoxTask_ZYV.TabIndex = 0;
            this.groupBoxTask_ZYV.TabStop = false;
            this.groupBoxTask_ZYV.Text = "Условие";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.ZakharovaYV.Sprint6.Task2.V28.Properties.Resources.Снимок1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 38);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTask_ZYV
            // 
            this.textBoxTask_ZYV.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_ZYV.Multiline = true;
            this.textBoxTask_ZYV.Name = "textBoxTask_ZYV";
            this.textBoxTask_ZYV.Size = new System.Drawing.Size(358, 38);
            this.textBoxTask_ZYV.TabIndex = 1;
            this.textBoxTask_ZYV.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести ввиде таблицы.";
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
            this.groupBoxInPut_ZYV.Location = new System.Drawing.Point(12, 296);
            this.groupBoxInPut_ZYV.Name = "groupBoxInPut_ZYV";
            this.groupBoxInPut_ZYV.Size = new System.Drawing.Size(312, 128);
            this.groupBoxInPut_ZYV.TabIndex = 0;
            this.groupBoxInPut_ZYV.TabStop = false;
            this.groupBoxInPut_ZYV.Text = "Ввод данных";
            // 
            // labelFinish_ZYV
            // 
            this.labelFinish_ZYV.AutoSize = true;
            this.labelFinish_ZYV.Location = new System.Drawing.Point(157, 39);
            this.labelFinish_ZYV.Name = "labelFinish_ZYV";
            this.labelFinish_ZYV.Size = new System.Drawing.Size(66, 13);
            this.labelFinish_ZYV.TabIndex = 1;
            this.labelFinish_ZYV.Text = "Конец шага";
            // 
            // labelStart_ZYV
            // 
            this.labelStart_ZYV.AutoSize = true;
            this.labelStart_ZYV.Location = new System.Drawing.Point(7, 39);
            this.labelStart_ZYV.Name = "labelStart_ZYV";
            this.labelStart_ZYV.Size = new System.Drawing.Size(64, 13);
            this.labelStart_ZYV.TabIndex = 1;
            this.labelStart_ZYV.Text = "Старт шага";
            // 
            // textBoxFinish_ZYV
            // 
            this.textBoxFinish_ZYV.Location = new System.Drawing.Point(160, 65);
            this.textBoxFinish_ZYV.Name = "textBoxFinish_ZYV";
            this.textBoxFinish_ZYV.Size = new System.Drawing.Size(146, 20);
            this.textBoxFinish_ZYV.TabIndex = 0;
            // 
            // textBoxStart_ZYV
            // 
            this.textBoxStart_ZYV.Location = new System.Drawing.Point(6, 65);
            this.textBoxStart_ZYV.Name = "textBoxStart_ZYV";
            this.textBoxStart_ZYV.Size = new System.Drawing.Size(139, 20);
            this.textBoxStart_ZYV.TabIndex = 0;
            // 
            // groupBoxOutPut_ZYV
            // 
            this.groupBoxOutPut_ZYV.Controls.Add(this.chartFunction);
            this.groupBoxOutPut_ZYV.Controls.Add(this.dataGridViewFunction);
            this.groupBoxOutPut_ZYV.Location = new System.Drawing.Point(576, 12);
            this.groupBoxOutPut_ZYV.Name = "groupBoxOutPut_ZYV";
            this.groupBoxOutPut_ZYV.Size = new System.Drawing.Size(658, 412);
            this.groupBoxOutPut_ZYV.TabIndex = 0;
            this.groupBoxOutPut_ZYV.TabStop = false;
            this.groupBoxOutPut_ZYV.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction.Legends.Add(legend3);
            this.chartFunction.Location = new System.Drawing.Point(143, 69);
            this.chartFunction.Name = "chartFunction";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction.Series.Add(series3);
            this.chartFunction.Size = new System.Drawing.Size(509, 300);
            this.chartFunction.TabIndex = 1;
            this.chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnF});
            this.dataGridViewFunction.Location = new System.Drawing.Point(16, 33);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.Size = new System.Drawing.Size(121, 361);
            this.dataGridViewFunction.TabIndex = 0;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.Width = 50;
            // 
            // ColumnF
            // 
            this.ColumnF.HeaderText = "F(x)";
            this.ColumnF.Name = "ColumnF";
            this.ColumnF.Width = 50;
            // 
            // buttonDone_ZYV
            // 
            this.buttonDone_ZYV.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_ZYV.Location = new System.Drawing.Point(413, 335);
            this.buttonDone_ZYV.Name = "buttonDone_ZYV";
            this.buttonDone_ZYV.Size = new System.Drawing.Size(157, 71);
            this.buttonDone_ZYV.TabIndex = 1;
            this.buttonDone_ZYV.Text = "Выполнить";
            this.buttonDone_ZYV.UseVisualStyleBackColor = false;
            this.buttonDone_ZYV.Click += new System.EventHandler(this.buttonDone_ZYV_Click);
            this.buttonDone_ZYV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_ZYV_MouseDown);
            this.buttonDone_ZYV.MouseEnter += new System.EventHandler(this.buttonDone_ZYV_MouseEnter);
            this.buttonDone_ZYV.MouseLeave += new System.EventHandler(this.buttonDone_ZYV_MouseLeave);
            // 
            // buttonHelp_ZYV
            // 
            this.buttonHelp_ZYV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonHelp_ZYV.Location = new System.Drawing.Point(330, 335);
            this.buttonHelp_ZYV.Name = "buttonHelp_ZYV";
            this.buttonHelp_ZYV.Size = new System.Drawing.Size(77, 71);
            this.buttonHelp_ZYV.TabIndex = 1;
            this.buttonHelp_ZYV.Text = "Справка";
            this.buttonHelp_ZYV.UseVisualStyleBackColor = false;
            this.buttonHelp_ZYV.Click += new System.EventHandler(this.buttonHelp_ZYV_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 450);
            this.Controls.Add(this.buttonHelp_ZYV);
            this.Controls.Add(this.buttonDone_ZYV);
            this.Controls.Add(this.groupBoxInPut_ZYV);
            this.Controls.Add(this.groupBoxOutPut_ZYV);
            this.Controls.Add(this.groupBoxTask_ZYV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 28  | Захарова Ю. В";
            this.groupBoxTask_ZYV.ResumeLayout(false);
            this.groupBoxTask_ZYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInPut_ZYV.ResumeLayout(false);
            this.groupBoxInPut_ZYV.PerformLayout();
            this.groupBoxOutPut_ZYV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZYV;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBoxInPut_ZYV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_ZYV;
        private System.Windows.Forms.Button buttonDone_ZYV;
        private System.Windows.Forms.Button buttonHelp_ZYV;
        private System.Windows.Forms.TextBox textBoxTask_ZYV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxFinish_ZYV;
        private System.Windows.Forms.TextBox textBoxStart_ZYV;
        private System.Windows.Forms.Label labelFinish_ZYV;
        private System.Windows.Forms.Label labelStart_ZYV;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

