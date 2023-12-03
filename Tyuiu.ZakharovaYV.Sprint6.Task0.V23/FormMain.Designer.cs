
namespace Tyuiu.ZakharovaYV.Sprint6.Task0.V23
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
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_ZYV = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_ZYV = new System.Windows.Forms.GroupBox();
            this.labelX_ZYV = new System.Windows.Forms.Label();
            this.textBoxInput_ZYV = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_ZYV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_ZYV = new System.Windows.Forms.TextBox();
            this.labelRes_ZYV = new System.Windows.Forms.Label();
            this.buttonDone_ZYV = new System.Windows.Forms.Button();
            this.buttonHelp_ZYV = new System.Windows.Forms.Button();
            this.groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ZYV)).BeginInit();
            this.groupBoxInput_ZYV.SuspendLayout();
            this.groupBoxOutPut_ZYV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Controls.Add(this.textBox1);
            this.groupBoxTask.Controls.Add(this.pictureBoxFormula_ZYV);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 29);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(760, 218);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 149);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Вычислить выражение по формуле :";
            // 
            // pictureBoxFormula_ZYV
            // 
            this.pictureBoxFormula_ZYV.Image = global::Tyuiu.ZakharovaYV.Sprint6.Task0.V23.Properties.Resources.formula;
            this.pictureBoxFormula_ZYV.Location = new System.Drawing.Point(516, 26);
            this.pictureBoxFormula_ZYV.Name = "pictureBoxFormula_ZYV";
            this.pictureBoxFormula_ZYV.Size = new System.Drawing.Size(128, 60);
            this.pictureBoxFormula_ZYV.TabIndex = 0;
            this.pictureBoxFormula_ZYV.TabStop = false;
            // 
            // groupBoxInput_ZYV
            // 
            this.groupBoxInput_ZYV.Controls.Add(this.labelX_ZYV);
            this.groupBoxInput_ZYV.Controls.Add(this.textBoxInput_ZYV);
            this.groupBoxInput_ZYV.Location = new System.Drawing.Point(12, 265);
            this.groupBoxInput_ZYV.Name = "groupBoxInput_ZYV";
            this.groupBoxInput_ZYV.Size = new System.Drawing.Size(325, 103);
            this.groupBoxInput_ZYV.TabIndex = 1;
            this.groupBoxInput_ZYV.TabStop = false;
            this.groupBoxInput_ZYV.Text = "Ввод данных :";
            // 
            // labelX_ZYV
            // 
            this.labelX_ZYV.AutoSize = true;
            this.labelX_ZYV.Location = new System.Drawing.Point(16, 35);
            this.labelX_ZYV.Name = "labelX_ZYV";
            this.labelX_ZYV.Size = new System.Drawing.Size(87, 13);
            this.labelX_ZYV.TabIndex = 1;
            this.labelX_ZYV.Text = "Переменная X :";
            // 
            // textBoxInput_ZYV
            // 
            this.textBoxInput_ZYV.Location = new System.Drawing.Point(19, 61);
            this.textBoxInput_ZYV.Name = "textBoxInput_ZYV";
            this.textBoxInput_ZYV.Size = new System.Drawing.Size(112, 20);
            this.textBoxInput_ZYV.TabIndex = 0;
            this.textBoxInput_ZYV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_ZYV_KeyPress);
            // 
            // groupBoxOutPut_ZYV
            // 
            this.groupBoxOutPut_ZYV.Controls.Add(this.textBoxResult_ZYV);
            this.groupBoxOutPut_ZYV.Controls.Add(this.labelRes_ZYV);
            this.groupBoxOutPut_ZYV.Location = new System.Drawing.Point(392, 265);
            this.groupBoxOutPut_ZYV.Name = "groupBoxOutPut_ZYV";
            this.groupBoxOutPut_ZYV.Size = new System.Drawing.Size(345, 103);
            this.groupBoxOutPut_ZYV.TabIndex = 2;
            this.groupBoxOutPut_ZYV.TabStop = false;
            this.groupBoxOutPut_ZYV.Text = "Вывод данных :";
            // 
            // textBoxResult_ZYV
            // 
            this.textBoxResult_ZYV.Location = new System.Drawing.Point(42, 61);
            this.textBoxResult_ZYV.Name = "textBoxResult_ZYV";
            this.textBoxResult_ZYV.ReadOnly = true;
            this.textBoxResult_ZYV.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult_ZYV.TabIndex = 1;
            // 
            // labelRes_ZYV
            // 
            this.labelRes_ZYV.AutoSize = true;
            this.labelRes_ZYV.Location = new System.Drawing.Point(39, 35);
            this.labelRes_ZYV.Name = "labelRes_ZYV";
            this.labelRes_ZYV.Size = new System.Drawing.Size(65, 13);
            this.labelRes_ZYV.TabIndex = 0;
            this.labelRes_ZYV.Text = "Результат :";
            // 
            // buttonDone_ZYV
            // 
            this.buttonDone_ZYV.Location = new System.Drawing.Point(636, 394);
            this.buttonDone_ZYV.Name = "buttonDone_ZYV";
            this.buttonDone_ZYV.Size = new System.Drawing.Size(105, 35);
            this.buttonDone_ZYV.TabIndex = 3;
            this.buttonDone_ZYV.Text = "Выполнить";
            this.buttonDone_ZYV.UseVisualStyleBackColor = true;
            this.buttonDone_ZYV.Click += new System.EventHandler(this.buttonDone_ZYV_Click);
            // 
            // buttonHelp_ZYV
            // 
            this.buttonHelp_ZYV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_ZYV.Location = new System.Drawing.Point(564, 394);
            this.buttonHelp_ZYV.Name = "buttonHelp_ZYV";
            this.buttonHelp_ZYV.Size = new System.Drawing.Size(38, 35);
            this.buttonHelp_ZYV.TabIndex = 4;
            this.buttonHelp_ZYV.Text = "?";
            this.buttonHelp_ZYV.UseVisualStyleBackColor = true;
            this.buttonHelp_ZYV.Click += new System.EventHandler(this.buttonHelp_ZYV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_ZYV);
            this.Controls.Add(this.buttonDone_ZYV);
            this.Controls.Add(this.groupBoxOutPut_ZYV);
            this.Controls.Add(this.groupBoxInput_ZYV);
            this.Controls.Add(this.groupBoxTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 23 | Захарова Ю. В.";
            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_ZYV)).EndInit();
            this.groupBoxInput_ZYV.ResumeLayout(false);
            this.groupBoxInput_ZYV.PerformLayout();
            this.groupBoxOutPut_ZYV.ResumeLayout(false);
            this.groupBoxOutPut_ZYV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInput_ZYV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_ZYV;
        private System.Windows.Forms.TextBox textBoxInput_ZYV;
        private System.Windows.Forms.Label labelX_ZYV;
        private System.Windows.Forms.TextBox textBoxResult_ZYV;
        private System.Windows.Forms.Label labelRes_ZYV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_ZYV;
        private System.Windows.Forms.Button buttonDone_ZYV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonHelp_ZYV;
    }
}

