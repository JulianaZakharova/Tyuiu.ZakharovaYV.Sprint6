
namespace WindowsFormsMyApp1
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
            this.buttonPushMe = new System.Windows.Forms.Button();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.radioButtonDiv = new System.Windows.Forms.RadioButton();
            this.radioButtonMult = new System.Windows.Forms.RadioButton();
            this.radioButtonMinus = new System.Windows.Forms.RadioButton();
            this.radioButtonPlus = new System.Windows.Forms.RadioButton();
            this.labelVarB = new System.Windows.Forms.Label();
            this.labelVarA = new System.Windows.Forms.Label();
            this.textBoxVarB = new System.Windows.Forms.TextBox();
            this.textBoxVarA = new System.Windows.Forms.TextBox();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPushMe
            // 
            this.buttonPushMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPushMe.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.buttonPushMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPushMe.Location = new System.Drawing.Point(335, 30);
            this.buttonPushMe.Name = "buttonPushMe";
            this.buttonPushMe.Size = new System.Drawing.Size(132, 33);
            this.buttonPushMe.TabIndex = 0;
            this.buttonPushMe.Text = "Нажми на меня ";
            this.buttonPushMe.UseVisualStyleBackColor = true;
            this.buttonPushMe.Click += new System.EventHandler(this.buttonPushMe_Click);
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.radioButtonDiv);
            this.groupBoxInputData.Controls.Add(this.radioButtonMult);
            this.groupBoxInputData.Controls.Add(this.radioButtonMinus);
            this.groupBoxInputData.Controls.Add(this.radioButtonPlus);
            this.groupBoxInputData.Controls.Add(this.labelVarB);
            this.groupBoxInputData.Controls.Add(this.labelVarA);
            this.groupBoxInputData.Controls.Add(this.textBoxVarB);
            this.groupBoxInputData.Controls.Add(this.textBoxVarA);
            this.groupBoxInputData.Location = new System.Drawing.Point(24, 30);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(248, 158);
            this.groupBoxInputData.TabIndex = 1;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод Данных";
            this.groupBoxInputData.Enter += new System.EventHandler(this.groupBoxInputData_Enter);
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.Location = new System.Drawing.Point(192, 78);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(30, 17);
            this.radioButtonDiv.TabIndex = 2;
            this.radioButtonDiv.TabStop = true;
            this.radioButtonDiv.Text = "/";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            // 
            // radioButtonMult
            // 
            this.radioButtonMult.AutoSize = true;
            this.radioButtonMult.Location = new System.Drawing.Point(192, 41);
            this.radioButtonMult.Name = "radioButtonMult";
            this.radioButtonMult.Size = new System.Drawing.Size(29, 17);
            this.radioButtonMult.TabIndex = 2;
            this.radioButtonMult.TabStop = true;
            this.radioButtonMult.Text = "*";
            this.radioButtonMult.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinus
            // 
            this.radioButtonMinus.AutoSize = true;
            this.radioButtonMinus.Location = new System.Drawing.Point(139, 78);
            this.radioButtonMinus.Name = "radioButtonMinus";
            this.radioButtonMinus.Size = new System.Drawing.Size(28, 17);
            this.radioButtonMinus.TabIndex = 2;
            this.radioButtonMinus.TabStop = true;
            this.radioButtonMinus.Text = "-";
            this.radioButtonMinus.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlus
            // 
            this.radioButtonPlus.AutoSize = true;
            this.radioButtonPlus.Location = new System.Drawing.Point(139, 41);
            this.radioButtonPlus.Name = "radioButtonPlus";
            this.radioButtonPlus.Size = new System.Drawing.Size(31, 17);
            this.radioButtonPlus.TabIndex = 2;
            this.radioButtonPlus.TabStop = true;
            this.radioButtonPlus.Text = "+";
            this.radioButtonPlus.UseVisualStyleBackColor = true;
            // 
            // labelVarB
            // 
            this.labelVarB.AutoSize = true;
            this.labelVarB.Location = new System.Drawing.Point(6, 93);
            this.labelVarB.Name = "labelVarB";
            this.labelVarB.Size = new System.Drawing.Size(20, 13);
            this.labelVarB.TabIndex = 1;
            this.labelVarB.Text = "B :";
            // 
            // labelVarA
            // 
            this.labelVarA.AutoSize = true;
            this.labelVarA.Location = new System.Drawing.Point(7, 20);
            this.labelVarA.Name = "labelVarA";
            this.labelVarA.Size = new System.Drawing.Size(20, 13);
            this.labelVarA.TabIndex = 1;
            this.labelVarA.Text = "A :";
            // 
            // textBoxVarB
            // 
            this.textBoxVarB.Location = new System.Drawing.Point(6, 109);
            this.textBoxVarB.Name = "textBoxVarB";
            this.textBoxVarB.Size = new System.Drawing.Size(98, 20);
            this.textBoxVarB.TabIndex = 0;
            // 
            // textBoxVarA
            // 
            this.textBoxVarA.Location = new System.Drawing.Point(6, 38);
            this.textBoxVarA.Name = "textBoxVarA";
            this.textBoxVarA.Size = new System.Drawing.Size(98, 20);
            this.textBoxVarA.TabIndex = 0;
            // 
            // groupBoxOut
            // 
            this.groupBoxOut.Controls.Add(this.labelResult);
            this.groupBoxOut.Controls.Add(this.textBoxResult);
            this.groupBoxOut.Location = new System.Drawing.Point(24, 216);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(152, 73);
            this.groupBoxOut.TabIndex = 2;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Вывод :";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(7, 16);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(68, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = " Результат :";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 32);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(127, 20);
            this.textBoxResult.TabIndex = 0;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(197, 266);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить ";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxOut);
            this.Controls.Add(this.groupBoxInputData);
            this.Controls.Add(this.buttonPushMe);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мое первое приложение под Windows ";
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxOut.ResumeLayout(false);
            this.groupBoxOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPushMe;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.Label labelVarB;
        private System.Windows.Forms.Label labelVarA;
        private System.Windows.Forms.TextBox textBoxVarB;
        private System.Windows.Forms.TextBox textBoxVarA;
        private System.Windows.Forms.GroupBox groupBoxOut;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.RadioButton radioButtonPlus;
        private System.Windows.Forms.RadioButton radioButtonDiv;
        private System.Windows.Forms.RadioButton radioButtonMult;
        private System.Windows.Forms.RadioButton radioButtonMinus;
    }
}

