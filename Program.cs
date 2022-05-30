﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Аэропорт
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ClassTotal.connection = new SqlConnection(); //Создание объекта подключения
            ClassTotal.connection.ConnectionString = ClassTotal.connectionString;
            try
            {
                ClassTotal.connection.Open();      //Опасная команда
                Application.Run(new Form1());

            }
            catch (SqlException ex)     //Обработка сбоя при подключении
            {
                switch (ex.Number)      //Номер ошибки
                {
                    case 17: MessageBox.Show("Неверное имя сервера"); break;
                    case 4060: MessageBox.Show("Неверное имя БД"); break;
                    case 18456: MessageBox.Show("Неверное имя пользователя или пароль"); break;
                }
                MessageBox.Show(ex.Message + Environment.NewLine + "Уровень ошибки " + ex.Class); return;
            }
            catch (Exception ex)            //Общий сбой при подключении
            {
                MessageBox.Show("Ошибка подключения " + ex.Message); return;
            }
            finally
            {
                if (ClassTotal.connection.State == ConnectionState.Open) ClassTotal.connection.Close();
            }

        }

    }
}
