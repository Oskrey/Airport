namespace Аэропорт
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCapchaRefresh = new System.Windows.Forms.Button();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxAlert = new System.Windows.Forms.TextBox();
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.timerDeny = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.buttonLook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(89, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 15);
            this.labelName.TabIndex = 35;
            this.labelName.Text = "Аэропорт";
            // 
            // buttonCapchaRefresh
            // 
            this.buttonCapchaRefresh.Location = new System.Drawing.Point(163, 241);
            this.buttonCapchaRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCapchaRefresh.Name = "buttonCapchaRefresh";
            this.buttonCapchaRefresh.Size = new System.Drawing.Size(70, 19);
            this.buttonCapchaRefresh.TabIndex = 34;
            this.buttonCapchaRefresh.TabStop = false;
            this.buttonCapchaRefresh.Text = "Обновить";
            this.buttonCapchaRefresh.UseVisualStyleBackColor = true;
            this.buttonCapchaRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.Location = new System.Drawing.Point(19, 241);
            this.textBoxCaptcha.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(140, 20);
            this.textBoxCaptcha.TabIndex = 27;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.Location = new System.Drawing.Point(11, 11);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(223, 17);
            this.labelWelcome.TabIndex = 31;
            this.labelWelcome.Text = "Д О Б Р О   П О Ж А Л О В А Т Ь";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(16, 104);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(45, 13);
            this.labelPassword.TabIndex = 30;
            this.labelPassword.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(16, 57);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(38, 13);
            this.labelLogin.TabIndex = 29;
            this.labelLogin.Text = "Логин";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(19, 265);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(214, 23);
            this.buttonLogin.TabIndex = 28;
            this.buttonLogin.Text = "ВОЙТИ";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(19, 121);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(178, 20);
            this.textBoxPassword.TabIndex = 26;
            this.textBoxPassword.Text = "Админ";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(19, 74);
            this.textBoxLogin.MaxLength = 30;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(215, 20);
            this.textBoxLogin.TabIndex = 25;
            this.textBoxLogin.Text = "Админ";
            // 
            // textBoxAlert
            // 
            this.textBoxAlert.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAlert.Location = new System.Drawing.Point(14, 9);
            this.textBoxAlert.Multiline = true;
            this.textBoxAlert.Name = "textBoxAlert";
            this.textBoxAlert.Size = new System.Drawing.Size(220, 132);
            this.textBoxAlert.TabIndex = 36;
            this.textBoxAlert.Text = "Вы заблокированы в системе\r\nза неудачные попытки входа";
            this.textBoxAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAlert.Visible = false;
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTimer.Location = new System.Drawing.Point(13, 156);
            this.textBoxTimer.Multiline = true;
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(220, 132);
            this.textBoxTimer.TabIndex = 37;
            this.textBoxTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTimer.Visible = false;
            // 
            // timerDeny
            // 
            this.timerDeny.Interval = 1000;
            this.timerDeny.Tick += new System.EventHandler(this.timerDeny_Tick);
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(19, 148);
            this.pictureBoxCaptcha.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(214, 88);
            this.pictureBoxCaptcha.TabIndex = 33;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // buttonLook
            // 
            this.buttonLook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLook.Location = new System.Drawing.Point(203, 121);
            this.buttonLook.Name = "buttonLook";
            this.buttonLook.Size = new System.Drawing.Size(30, 22);
            this.buttonLook.TabIndex = 32;
            this.buttonLook.TabStop = false;
            this.buttonLook.UseVisualStyleBackColor = true;
            this.buttonLook.Click += new System.EventHandler(this.buttonLook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 297);
            this.Controls.Add(this.buttonLook);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCapchaRefresh);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxAlert);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.pictureBoxCaptcha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCapchaRefresh;
        private System.Windows.Forms.TextBox textBoxCaptcha;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxAlert;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.Timer timerDeny;
        private System.Windows.Forms.PictureBox pictureBoxCaptcha;
        private System.Windows.Forms.Button buttonLook;
    }
}

