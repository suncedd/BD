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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection sqlcon = new SqlConnection(@"Data Source=PK306NEW-10;Initial Catalog=Фейерверк;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фейерверкDataSet8.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter1.Fill(this.фейерверкDataSet8.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фейерверкDataSet7.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter2.Fill(this.фейерверкDataSet7.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фейерверкDataSet6.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter1.Fill(this.фейерверкDataSet6.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фейерверкDataSet5.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.фейерверкDataSet5.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фейерверкDataSet4.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.фейерверкDataSet4.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "фейерверкDataSet3.Товар". При необходимости она может быть перемещена или удалена.
    

            sqlcon.Open();
            SqlDataAdapter a = new SqlDataAdapter("select dbo.Поставщик.Название as Поставщик , dbo.Товар.Название,[Кол-во], Цена From(Поставщик left join Приход ON Приход.КодПоставщика= Поставщик.КодПоставщика) left join Товар on Приход.КодТовара=Товар.КодТовара", sqlcon);
            DataSet ds = new DataSet();
            a.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlcon.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            int kolvo = Convert.ToInt32(textBox1.Text);
            int money = Convert.ToInt32(textBox2.Text);
            int kodtov = Convert.ToInt32(comboBox1.SelectedValue);
            int kodpos = Convert.ToInt32(comboBox1.SelectedValue);
            DataSet ds = new DataSet();
            SqlDataAdapter b = new SqlDataAdapter("USE [Фейерверк] INSERT INTO [dbo].[приход] ([КодПоставщика], [Кол-во], [Цена], [КодТовара])VALUES("+ kodpos +", " + kolvo +", "+ money +","+ kodtov +")", sqlcon);
            b.Fill(ds);
            SqlDataAdapter a = new SqlDataAdapter("select dbo.Поставщик.Название as Поставщик , dbo.Товар.Название,[Кол-во], Цена From(Поставщик left join Приход ON Приход.КодПоставщика= Поставщик.КодПоставщика) left join Товар on Приход.КодТовара=Товар.КодТовара", sqlcon);
            
            a.Fill(ds);
            
            dataGridView1.DataSource = ds.Tables[0];
            sqlcon.Close();
            dataGridView1.Update();
        }
    }

}

