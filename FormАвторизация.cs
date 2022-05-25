using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Аэропорт
{
    public partial class Form1 : Form
    {
        private string text = String.Empty;

        public Form1()
        {
            InitializeComponent();
        }
        
        private Bitmap CreateImage(int Width, int Height) //генерация изображения со случайным текстом
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);


            //Добавим различные цвета
            Brush[] colors =
            {
                 Brushes.Black,
                 Brushes.Red,
                 Brushes.RoyalBlue,
                 Brushes.Green
            };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);
            textBoxCaptcha.Text = text;
            return result;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
        }

        int tsec, tmin;
        int w = 2;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (w > 0)
            {
                if (textBoxCaptcha.Text == text)
                {

                    string почта = textBoxLogin.Text;
                    string телефон = textBoxLogin.Text;
                    string пароль = textBoxPassword.Text;
                    SqlCommand command = ClassTotal.connection.CreateCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select * from [Сотрудники] Where [Почта] = @Почта or [Телефон]  = @Телефон and [Пароль] = @Пароль";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Почта", почта);
                    command.Parameters.AddWithValue("@Телефон", телефон);
                    command.Parameters.AddWithValue("@Пароль", пароль);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if ((bool)reader["Статус"])
                        {
                            ClassTotal.id = (int)reader["ID сотрудника"];
                            ClassTotal.idRole = (int)reader["ID должности"];
                            reader.Close();
                            switch (ClassTotal.idRole)
                            {
                                case (1)://Пилот
                                    
                                    break;
                                case (2)://техник
                                    FormЛичныйКабинет flt = new FormЛичныйКабинет(ClassTotal.id);
                                    Hide();
                                    flt.ShowDialog();
                                    Show();
                                    break;
                                case (3)://Кассир
                                    
                                    break;
                                case (6)://Обслуга
                                    
                                    break;
                                case (7)://Администратор
                                    
                                    break;
                                case (9):
                                    FormТабло ft = new FormТабло();
                                    Hide();
                                    ft.ShowDialog();
                                    Show();
                                    break;
                            }

                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Вы заблокированы в системе");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Логин и/или пароль введены неверно. Осталось попыток:" + w);
                        reader.Close();
                        w--;
                    }
                }
                else
                {
                    MessageBox.Show("Капча введена неверно");
                    pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
                    textBoxCaptcha.Clear();
                }
            }
            else
            {
                //tmin = 5;
                tsec = 5;
                labelLogin.Visible = false;
                labelPassword.Visible = false;
                labelWelcome.Visible = false;
                labelName.Visible = false;

                textBoxLogin.Visible = false;
                textBoxPassword.Visible = false;
                textBoxCaptcha.Visible = false;

                pictureBoxCaptcha.Visible = false;

                buttonCapchaRefresh.Visible = false;
                buttonLogin.Visible = false;
                buttonLook.Visible = false;

                textBoxTimer.Visible = true;
                textBoxAlert.Visible = true;
                textBoxTimer.Text = "01:00";
                timerDeny.Start();
                ActiveForm.ControlBox = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
        }


        private void buttonLook_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == true)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void timerDeny_Tick(object sender, EventArgs e)
        {
            if (tmin == 0 && tsec == 0)
            {
                timerDeny.Stop();
                w = 2;
                labelLogin.Visible = true;
                labelPassword.Visible = true;
                labelWelcome.Visible = true;
                labelName.Visible = true;

                textBoxLogin.Visible = true;
                textBoxPassword.Visible = true;
                textBoxCaptcha.Visible = true;

                pictureBoxCaptcha.Visible = true;
                pictureBoxCaptcha.Image = CreateImage(pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);

                buttonCapchaRefresh.Visible = true;
                buttonLogin.Visible = true;
                buttonLook.Visible = true;
                ActiveForm.ControlBox = true;


                textBoxAlert.Visible = false;
                textBoxTimer.Visible = false;
            }
            if (tsec > 0)
            {
                tsec--;
            }
            if (tsec == 0)
            {
                if (tmin > 0)
                {
                    tmin--;
                    if (tmin == 0)
                    { tsec = 59; }
                }
                if (tmin > 0)
                { tsec = 59; }
            }
            textBoxTimer.Text = printNumber(tmin) + ':' + printNumber(tsec);
        }

        private static string printNumber(int num)
        {
            string str;
            if (num < 10)
                str = "0" + num;
            else
                str = "" + num;
            return str;
        }
    }
}
