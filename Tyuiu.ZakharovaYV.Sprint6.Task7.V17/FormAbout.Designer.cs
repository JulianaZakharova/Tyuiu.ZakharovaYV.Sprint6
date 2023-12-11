
namespace Tyuiu.ZakharovaYV.Sprint6.Task7.V17
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
            this.groupBoxAbout_ZYV = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAbout_ZYV = new System.Windows.Forms.Button();
            this.groupBoxAbout_ZYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAbout_ZYV
            // 
            this.groupBoxAbout_ZYV.Controls.Add(this.buttonAbout_ZYV);
            this.groupBoxAbout_ZYV.Controls.Add(this.textBox1);
            this.groupBoxAbout_ZYV.Controls.Add(this.pictureBox1);
            this.groupBoxAbout_ZYV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAbout_ZYV.Name = "groupBoxAbout_ZYV";
            this.groupBoxAbout_ZYV.Size = new System.Drawing.Size(524, 287);
            this.groupBoxAbout_ZYV.TabIndex = 0;
            this.groupBoxAbout_ZYV.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.ZakharovaYV.Sprint6.Task7.V17.Properties.Resources.NewCanvas52;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 203);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(326, 181);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Разработчик : Захарова Ю.В\r\nгруппу ПКТБ 23-2\r\n\r\nПрограмма разработана в рамках из" +
    "учения С#\r\n\r\nТИУ ВШЦТ (с)2023";
            // 
            // buttonAbout_ZYV
            // 
            this.buttonAbout_ZYV.Location = new System.Drawing.Point(443, 206);
            this.buttonAbout_ZYV.Name = "buttonAbout_ZYV";
            this.buttonAbout_ZYV.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout_ZYV.TabIndex = 2;
            this.buttonAbout_ZYV.Text = "ok";
            this.buttonAbout_ZYV.UseVisualStyleBackColor = true;
            this.buttonAbout_ZYV.Click += new System.EventHandler(this.buttonAbout_ZYV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 253);
            this.Controls.Add(this.groupBoxAbout_ZYV);
            this.Name = "FormAbout";
            this.Text = "О программе";
            this.groupBoxAbout_ZYV.ResumeLayout(false);
            this.groupBoxAbout_ZYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAbout_ZYV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAbout_ZYV;
    }
}