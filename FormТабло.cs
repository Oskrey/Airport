using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Аэропорт
{
    public partial class FormТабло : Form
    {
        public FormТабло()
        {
            InitializeComponent();
        }

        private void FormТабло_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select [ID рейса] as 'Номер рейса', Название AS 'Самолёт', Откуда, [Время вылета],Куда, [Время прилёта] from Расписание" +
                " inner join Самолёты on Самолёты.[ID самолёта] = Расписание.[ID самолёта]", ClassTotal.connection);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
