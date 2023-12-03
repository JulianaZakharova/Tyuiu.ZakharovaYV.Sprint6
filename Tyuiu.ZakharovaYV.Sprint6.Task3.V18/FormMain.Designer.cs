
namespace Tyuiu.ZakharovaYV.Sprint6.Task3.V18
{
    partial class FormMainTask3_ZYV
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
            this.groupBoxTask_ZYV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZYV = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPut = new System.Windows.Forms.GroupBox();
            this.textBoxResult_ZYV = new System.Windows.Forms.TextBox();
            this.labelRes_ZYV = new System.Windows.Forms.Label();
            this.buttonDone_ZYV = new System.Windows.Forms.Button();
            this.buttonHelp_ZYV = new System.Windows.Forms.Button();
            this.groupBoxTask_ZYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.groupBoxOutPut.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZYV
            // 
            this.groupBoxTask_ZYV.Controls.Add(this.textBoxTask_ZYV);
            this.groupBoxTask_ZYV.Controls.Add(this.dataGridViewMatrix);
            this.groupBoxTask_ZYV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ZYV.Name = "groupBoxTask_ZYV";
            this.groupBoxTask_ZYV.Size = new System.Drawing.Size(667, 402);
            this.groupBoxTask_ZYV.TabIndex = 0;
            this.groupBoxTask_ZYV.TabStop = false;
            this.groupBoxTask_ZYV.Text = "Условие";
            // 
            // textBoxTask_ZYV
            // 
            this.textBoxTask_ZYV.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_ZYV.Multiline = true;
            this.textBoxTask_ZYV.Name = "textBoxTask_ZYV";
            this.textBoxTask_ZYV.Size = new System.Drawing.Size(330, 176);
            this.textBoxTask_ZYV.TabIndex = 1;
            this.textBoxTask_ZYV.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в четвертой строке на 0.\r\n\r" +
    "\n-19 -19   1  18   7\r\n\r\n   5   3  -4  -6 -12\r\n\r\n -15   6   2   2 -14\r\n\r\n  -9 -10" +
    "  15  -5  -6\r\n\r\n -13 -15  -9   7   1";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(375, 19);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(271, 354);
            this.dataGridViewMatrix.TabIndex = 0;
            // 
            // groupBoxOutPut
            // 
            this.groupBoxOutPut.Controls.Add(this.textBoxResult_ZYV);
            this.groupBoxOutPut.Controls.Add(this.labelRes_ZYV);
            this.groupBoxOutPut.Location = new System.Drawing.Point(712, 12);
            this.groupBoxOutPut.Name = "groupBoxOutPut";
            this.groupBoxOutPut.Size = new System.Drawing.Size(227, 216);
            this.groupBoxOutPut.TabIndex = 1;
            this.groupBoxOutPut.TabStop = false;
            this.groupBoxOutPut.Text = "Вывод данных";
            // 
            // textBoxResult_ZYV
            // 
            this.textBoxResult_ZYV.Location = new System.Drawing.Point(10, 46);
            this.textBoxResult_ZYV.Multiline = true;
            this.textBoxResult_ZYV.Name = "textBoxResult_ZYV";
            this.textBoxResult_ZYV.ReadOnly = true;
            this.textBoxResult_ZYV.Size = new System.Drawing.Size(199, 149);
            this.textBoxResult_ZYV.TabIndex = 1;
            // 
            // labelRes_ZYV
            // 
            this.labelRes_ZYV.AutoSize = true;
            this.labelRes_ZYV.Location = new System.Drawing.Point(7, 30);
            this.labelRes_ZYV.Name = "labelRes_ZYV";
            this.labelRes_ZYV.Size = new System.Drawing.Size(65, 13);
            this.labelRes_ZYV.TabIndex = 0;
            this.labelRes_ZYV.Text = "Результат :";
            // 
            // buttonDone_ZYV
            // 
            this.buttonDone_ZYV.Location = new System.Drawing.Point(858, 362);
            this.buttonDone_ZYV.Name = "buttonDone_ZYV";
            this.buttonDone_ZYV.Size = new System.Drawing.Size(81, 23);
            this.buttonDone_ZYV.TabIndex = 2;
            this.buttonDone_ZYV.Text = "Выполнять";
            this.buttonDone_ZYV.UseVisualStyleBackColor = true;
            this.buttonDone_ZYV.Click += new System.EventHandler(this.buttonDone_ZYV_Click);
            // 
            // buttonHelp_ZYV
            // 
            this.buttonHelp_ZYV.Location = new System.Drawing.Point(799, 362);
            this.buttonHelp_ZYV.Name = "buttonHelp_ZYV";
            this.buttonHelp_ZYV.Size = new System.Drawing.Size(37, 23);
            this.buttonHelp_ZYV.TabIndex = 2;
            this.buttonHelp_ZYV.Text = "?";
            this.buttonHelp_ZYV.UseVisualStyleBackColor = true;
            this.buttonHelp_ZYV.Click += new System.EventHandler(this.buttonHelp_ZYV_Click);
            // 
            // FormMainTask3_ZYV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 423);
            this.Controls.Add(this.buttonHelp_ZYV);
            this.Controls.Add(this.buttonDone_ZYV);
            this.Controls.Add(this.groupBoxOutPut);
            this.Controls.Add(this.groupBoxTask_ZYV);
            this.Name = "FormMainTask3_ZYV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 18  | Захарова Ю. В";
            this.Load += new System.EventHandler(this.FormMainTask3_ZYV_Load);
            this.groupBoxTask_ZYV.ResumeLayout(false);
            this.groupBoxTask_ZYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.groupBoxOutPut.ResumeLayout(false);
            this.groupBoxOutPut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZYV;
        private System.Windows.Forms.TextBox textBoxTask_ZYV;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.GroupBox groupBoxOutPut;
        private System.Windows.Forms.TextBox textBoxResult_ZYV;
        private System.Windows.Forms.Label labelRes_ZYV;
        private System.Windows.Forms.Button buttonDone_ZYV;
        private System.Windows.Forms.Button buttonHelp_ZYV;
    }
}

