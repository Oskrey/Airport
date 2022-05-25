namespace Аэропорт
{
    partial class FormЛичныйКабинет
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
            this.pictureBoxАватар = new System.Windows.Forms.PictureBox();
            this.labelПриветствие = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxАватар)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxАватар
            // 
            this.pictureBoxАватар.Image = global::Аэропорт.Properties.Resources.Glaz;
            this.pictureBoxАватар.Location = new System.Drawing.Point(46, 40);
            this.pictureBoxАватар.Name = "pictureBoxАватар";
            this.pictureBoxАватар.Size = new System.Drawing.Size(222, 203);
            this.pictureBoxАватар.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxАватар.TabIndex = 0;
            this.pictureBoxАватар.TabStop = false;
            // 
            // labelПриветствие
            // 
            this.labelПриветствие.AutoSize = true;
            this.labelПриветствие.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelПриветствие.Location = new System.Drawing.Point(13, 13);
            this.labelПриветствие.Name = "labelПриветствие";
            this.labelПриветствие.Size = new System.Drawing.Size(192, 24);
            this.labelПриветствие.TabIndex = 1;
            this.labelПриветствие.Text = "Добро пожаловать, ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(17, 282);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 156);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "На данный момент задач нет\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nл";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список дел:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormЛичныйКабинет
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelПриветствие);
            this.Controls.Add(this.pictureBoxАватар);
            this.Name = "FormЛичныйКабинет";
            this.Text = "FormЛичныйКабинет";
            this.Load += new System.EventHandler(this.FormЛичныйКабинет_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxАватар)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxАватар;
        private System.Windows.Forms.Label labelПриветствие;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}