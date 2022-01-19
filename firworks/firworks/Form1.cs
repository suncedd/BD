using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace firworks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=PK306NEW-10;Initial Catalog=Фейерверк;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            sqlcon.Open();
            SqlDataAdapter a = new SqlDataAdapter("select dbo.Товар.Название , Описание, Цена From Приход left join Товар ON Товар.КодТовара = Приход.КодТовара", sqlcon);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlcon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 z = new Form2();
            z.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
