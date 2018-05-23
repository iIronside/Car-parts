using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarPart2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=ADMIN-ПК\SQLEXPRESS;Initial Catalog=AutoCarPartShop2;Integrated Security=True"); // строка подключения

        private void MainForm_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlDataAdapter sqlDatAdap = new SqlDataAdapter("select pok.Имя, pok.Фамилия, nak.IDПокупателя, zap.Код_запчасти from Покупатели pok inner join Накладная_продаж nak on pok.IDПокупателя = nak.IDПокупателя inner join Список_продаж cek on nak.IDНакладной_продаж = cek.IDНакладной_продаж inner join Запчасть zap on zap.Код_запчасти = cek.Код_запчасти", sqlConnection);
            DataTable dt = new DataTable();
            sqlDatAdap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// Выход из программы через меню файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        /// <summary>
        /// Выход через кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }


        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStringInTable AddStringForm = new AddStringInTable(sqlConnection);
            AddStringForm.Show();
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteString DelStr = new DeleteString(sqlConnection);
            DelStr.Show();
        }

        private void вывестиТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayForm DisForm = new DisplayForm(sqlConnection);
            DisForm.Show();
        }

        private void оформитьПродажуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm(sqlConnection);
            sellingForm.Show();
        }

        private void заказатьПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplyForm supForm = new SupplyForm(sqlConnection);
            supForm.Show();
        }

        private void изменитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateString upStr = new UpdateString(sqlConnection);
            upStr.Show();
        }
    }
}
