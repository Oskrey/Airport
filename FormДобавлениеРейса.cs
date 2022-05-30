using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Аэропорт
{
    public partial class FormДобавлениеРейса : Form
    {
        public FormДобавлениеРейса()
        {
            InitializeComponent();
        }
        private void dgv()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select [ID рейса] as 'Номер рейса', Название AS 'Самолёт', Откуда, [Время вылета],Куда, [Время прилёта] from Расписание" +
                " inner join Самолёты on Самолёты.[ID самолёта] = Расписание.[ID самолёта]", ClassTotal.connection);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int iDСамолёта = Convert.ToInt32(textBoxIDСамолёта.Text);
            if (String.IsNullOrEmpty(textBoxIDСамолёта.Text))
            {
                MessageBox.Show("Вы не ввели ID cамолёта");
                return;
            }

            string откуда = textBoxОткуда.Text;
            if (String.IsNullOrEmpty(откуда))
            {
                MessageBox.Show("Вы не ввели место вылета");
                return;
            }

            string куда = textBoxКуда.Text;
            if (String.IsNullOrEmpty(куда))
            {
                MessageBox.Show("Вы не ввели место прилёта");
                return;
            }
            DateTime времяВылета = dateTimePickerВремяВылета.Value;
           // времяВылета += dateTimePickerВремяВылета.Value.TimeOfDay;
            DateTime времяПрилёта = dateTimePickerВремяПрилёта.Value;
           // времяПрилёта = dateTimePickerВремяПрилёта.Value.TimeOfDay;
            SqlCommand command = ClassTotal.connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from [Расписание] Where [Время прилёта] = @время and [iD самолёта] = @самолёт";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@время", времяПрилёта);
            command.Parameters.AddWithValue("@самолёт", iDСамолёта);

            SqlDataReader reader = command.ExecuteReader();

            
            if (reader.HasRows)
            {
                reader.Close();
                MessageBox.Show("Пользователь с таким аккаунтом зарегистрирован в системе");
                return;
            }
            else
            {
                reader.Close();
            }


            // Из битового образа перенсти с массив бит
            int temp;
            command.CommandText = "INSERT INTO [Расписание] VALUES ( @id,@вылет, @прилёт,@откуда, @куда, 'true')";

            command.Parameters.AddWithValue("@id", iDСамолёта);
            command.Parameters.AddWithValue("@вылет", времяВылета);
            command.Parameters.AddWithValue("@прилёт", времяПрилёта);
            command.Parameters.AddWithValue("@откуда", откуда);
            command.Parameters.AddWithValue("@куда", куда);



            int countResult = (int)command.ExecuteNonQuery();
            if (countResult != 0)
            {
                MessageBox.Show("Информация в БД обновлена успешно");
                dgv();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }

        }

        private void FormДобавлениеРейса_Load(object sender, EventArgs e)
        {
            dgv();
        }
    }
}
