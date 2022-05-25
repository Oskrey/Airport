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
            da.SelectCommand = new SqlCommand("Select * from [Расписание]", ClassTotal.connection);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
