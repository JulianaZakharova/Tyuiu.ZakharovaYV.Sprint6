
namespace Tyuiu.ZakharovaYV.Sprint6.Task6.V9
{
    partial class FormAbout
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxAbout_ZYV = new System.Windows.Forms.PictureBox();
            this.textBoxAbiut_ZYV = new System.Windows.Forms.TextBox();
            this.buttonAbout_ZYV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_ZYV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAbout_ZYV);
            this.groupBox1.Controls.Add(this.textBoxAbiut_ZYV);
            this.groupBox1.Controls.Add(this.pictureBoxAbout_ZYV);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBoxAbout_ZYV
            // 
            this.pictureBoxAbout_ZYV.Image = global::Tyuiu.ZakharovaYV.Sprint6.Task6.V9.Properties.Resources.юлиана;
            this.pictureBoxAbout_ZYV.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxAbout_ZYV.Name = "pictureBoxAbout_ZYV";
            this.pictureBoxAbout_ZYV.Size = new System.Drawing.Size(135, 152);
            this.pictureBoxAbout_ZYV.TabIndex = 0;
            this.pictureBoxAbout_ZYV.TabStop = false;
            // 
            // textBoxAbiut_ZYV
            // 
            this.textBoxAbiut_ZYV.Location = new System.Drawing.Point(176, 19);
            this.textBoxAbiut_ZYV.Multiline = true;
            this.textBoxAbiut_ZYV.Name = "textBoxAbiut_ZYV";
            this.textBoxAbiut_ZYV.ReadOnly = true;
            this.textBoxAbiut_ZYV.Size = new System.Drawing.Size(328, 165);
            this.textBoxAbiut_ZYV.TabIndex = 1;
            this.textBoxAbiut_ZYV.Text = "Разработчик : Захарова Ю.В.\r\nГруппа ПКТБ-23-2\r\n\r\nПрограмма разработана в рамках и" +
    "зучения языка С#\r\nТИУ ВШЦТ (с) 2023";
            // 
            // buttonAbout_ZYV
            // 
            this.buttonAbout_ZYV.Location = new System.Drawing.Point(429, 207);
            this.buttonAbout_ZYV.Name = "buttonAbout_ZYV";
            this.buttonAbout_ZYV.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout_ZYV.TabIndex = 2;
            this.buttonAbout_ZYV.Text = "ок";
            this.buttonAbout_ZYV.UseVisualStyleBackColor = true;
            this.buttonAbout_ZYV.Click += new System.EventHandler(this.buttonAbout_ZYV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 255);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_ZYV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAbiut_ZYV;
        private System.Windows.Forms.PictureBox pictureBoxAbout_ZYV;
        private System.Windows.Forms.Button buttonAbout_ZYV;
    }
}