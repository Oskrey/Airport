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
        public FormЛичныйКабинет(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        int id;
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
