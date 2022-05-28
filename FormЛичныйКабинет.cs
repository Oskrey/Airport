using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Аэропорт
{
    public partial class FormЛичныйКабинет : Form
    {
        public FormЛичныйКабинет(int id, int role)
        {
            this.id = id;
            this.role = role;
            InitializeComponent();
        }
        int id, role;
        private void FormЛичныйКабинет_Load(object sender, EventArgs e)
        {
            byte[] imgBytes;        //Обмен между ОП и БД
            Image bit;     //Изображение в видеопамяти
            string name_file;       //Путь к файлу с изображением
            MemoryStream stream;	//Промежуточный поток в памяти
            bit = pictureBoxАватар.Image;
            stream = new MemoryStream();
            bit.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            imgBytes = stream.ToArray();

            SqlCommand cmd = ClassTotal.connection.CreateCommand();
            cmd.CommandText = "select * from [Сотрудники] where [ID сотрудника] = " + id;
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            labelПриветствие.Text +=" "+ reader["Фамилия сотрудника"].ToString() + " "+reader["Имя сотрудника"].ToString();
            //Почему
            if (!reader.IsDBNull(reader.GetOrdinal("Фото")))  //Пусто
            {
                imgBytes = (byte[])reader["Фото"];   //Взять фото из БД
                stream = new MemoryStream(imgBytes);    //Преобразования
                pictureBoxАватар.Image = Image.FromStream(stream);
            }
            reader.Close();

           

            switch (role)
            {
                case (1)://Пилот
                    textBox1.Text = "На данный момент задач нет";
                    break;
                case (2)://техник
                    cmd.CommandText = "select * from [Самолёты] inner join Расписание on Самолёты.[ID самолёта] = Расписание.[ID самолёта]";
                    reader = cmd.ExecuteReader();
                    
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if ((DateTime)reader["Время вылета"] >= DateTime.Today)
                        {
                            textBox1.Text += "Необходимо заправить: " + (string)reader["Название"] + Environment.NewLine;
                        }
                    }
                    reader.Close();

                    cmd.CommandText = "select * from [Самолёты]";
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if ((DateTime)reader["Дата последнего ТО"] <= DateTime.Today)
                        {
                            textBox1.Text += "Необходимо провести ТО: " + (string)reader["Название"] + Environment.NewLine;
                        }
                    }
                    reader.Close();

                    break;
                case (6)://Обслуга
                    textBox1.Text = "На данный момент задач нет";

                    break;
            }


            //comboBoxРоль.Items.Clear();
            //SqlCommand command = ClassTotal.connection.CreateCommand();
            //command.CommandText = " select [ID роли], [Название роли] from Роли";
            //SqlDataReader r = command.ExecuteReader();
            //if (r.HasRows)
            //{
            //    while (r.Read())
            //    {
            //        comboBoxРоль.Items.Add(r[0] + ", " + r[1]);
            //    }
            //}
            //r.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
